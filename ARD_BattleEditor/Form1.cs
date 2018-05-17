using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Reflection;

namespace ARD_BattleEditor
{
    public partial class Form1 : Form
    {
        List<UInt32> FilePositions;

        public Form1()
        {
            InitializeComponent();
        }

        private Image GetImageByPreview(string filename)
        {
            string CleanFileName = Path.GetFileName(filename);

            LoadedFileLabel.Text = CleanFileName;

            switch (CleanFileName)
            {
                case "al00.ard":
                    return (Image)new Bitmap(Properties.Resources.al00);
                case "al01.ard":
                    return (Image)new Bitmap(Properties.Resources.al01);
                case "al02.ard":
                    return (Image)new Bitmap(Properties.Resources.al00);
                case "al03.ard":
                    return (Image)new Bitmap(Properties.Resources.al00);
                case "al04.ard":
                    return (Image)new Bitmap(Properties.Resources.al00);
                case "al05.ard":
                    return (Image)new Bitmap(Properties.Resources.al00);
            }

            return null;
        }

        private string[] GetAllStringsFromResource()
        {
            return Properties.Resources.UCMText.Split(Environment.NewLine.ToCharArray());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog diag = new OpenFileDialog();

            if(diag.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                //Clear tabs.
                EventTabControl.TabPages.Clear();

                FileStream f = new FileStream(diag.FileName, FileMode.Open);
                BinaryReader r = new BinaryReader(f);

                string[] UCMStrings = GetAllStringsFromResource();
                FilePositions = new List<UInt32>();
                FilePositions.Clear();

                if (r.ReadUInt32() == 0x01524142)
                {
                    UInt32 FileCount = r.ReadUInt32();

                    for (UInt32 i = 0; i < FileCount; i++)
                    {
                        // Get file format ID.
                        r.BaseStream.Seek(0x10 + i * 0x10, SeekOrigin.Begin);
                        UInt32 FileFormatID = r.ReadUInt32();

                        r.BaseStream.Seek(0x18 + i * 0x10, SeekOrigin.Begin);
                        UInt32 FilePosition = r.ReadUInt32();

                        MapPreview.Image = GetImageByPreview(diag.FileName);

                        if (FileFormatID == 0xC)
                        {
                            FilePositions.Add(i);

                            r.BaseStream.Seek(FilePosition + 0xC, SeekOrigin.Begin);
                            UInt16 NumberOfEntities = r.ReadUInt16();

                            r.BaseStream.Seek(0x14 + i * 0x10, SeekOrigin.Begin);
                            TabPage tab = new TabPage(new string(r.ReadChars(4)));

                            // Read appear data and add combo boxes to each tab.
                            for(int j = 0; j < NumberOfEntities; j++)
                            {
                                r.BaseStream.Seek(FilePosition + 0x34 + 0x40*j, SeekOrigin.Begin);
                                UInt32 UCM = r.ReadUInt32();
                                
                                ComboBox nBox = new ComboBox();
                                nBox.Items.AddRange(UCMStrings);
                                nBox.Width = 250;
                                nBox.SelectedIndex = (int)UCM;
                                nBox.Location = new Point(0, j * 50);

                                tab.Controls.Add(nBox);
                            }

                            EventTabControl.TabPages.Add(tab);
                        }
                    }

                    // Enable the save button if there is any compatible file.
                    SaveARD.Enabled = FilePositions.Count > 0;
                }
                else
                {
                    MessageBox.Show("Not a BAR file.");
                }
            }
        }

        private void MapPreview_Click(object sender, EventArgs e)
        {

        }

        private void SaveARD_Click(object sender, EventArgs e)
        {
            if(FilePositions.Count > 0)
            {
                for(UInt32 i = 0; i < EventTabControl.Controls.Count; i++)
                {
                    TabPage tabPage = (TabPage)EventTabControl.GetControl((int)i);

                    foreach (Control control in tabPage.Controls)
                    {
                        MessageBox.Show(control.GetType().ToString());
                    }
                }
            }
            else
            {
                MessageBox.Show("There is no ARD loaded.");
            }
        }

        private void MapScaleTracker_Scroll(object sender, EventArgs e)
        {

        }
    }
}
