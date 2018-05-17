namespace ARD_BattleEditor
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.LoadARD = new System.Windows.Forms.Button();
            this.EventTabControl = new System.Windows.Forms.TabControl();
            this.MapPreview = new System.Windows.Forms.PictureBox();
            this.SaveARD = new System.Windows.Forms.Button();
            this.LoadedFileLabel = new System.Windows.Forms.Label();
            this.MapScaleTracker = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.MapPreview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MapScaleTracker)).BeginInit();
            this.SuspendLayout();
            // 
            // LoadARD
            // 
            this.LoadARD.Location = new System.Drawing.Point(13, 13);
            this.LoadARD.Name = "LoadARD";
            this.LoadARD.Size = new System.Drawing.Size(90, 60);
            this.LoadARD.TabIndex = 0;
            this.LoadARD.Text = "Load ARD";
            this.LoadARD.UseVisualStyleBackColor = true;
            this.LoadARD.Click += new System.EventHandler(this.button1_Click);
            // 
            // EventTabControl
            // 
            this.EventTabControl.Location = new System.Drawing.Point(13, 80);
            this.EventTabControl.Name = "EventTabControl";
            this.EventTabControl.SelectedIndex = 0;
            this.EventTabControl.Size = new System.Drawing.Size(1105, 655);
            this.EventTabControl.TabIndex = 1;
            // 
            // MapPreview
            // 
            this.MapPreview.Location = new System.Drawing.Point(1124, 80);
            this.MapPreview.Name = "MapPreview";
            this.MapPreview.Size = new System.Drawing.Size(512, 512);
            this.MapPreview.TabIndex = 2;
            this.MapPreview.TabStop = false;
            this.MapPreview.Click += new System.EventHandler(this.MapPreview_Click);
            // 
            // SaveARD
            // 
            this.SaveARD.Enabled = false;
            this.SaveARD.Location = new System.Drawing.Point(107, 13);
            this.SaveARD.Name = "SaveARD";
            this.SaveARD.Size = new System.Drawing.Size(90, 60);
            this.SaveARD.TabIndex = 5;
            this.SaveARD.Text = "Save ARD";
            this.SaveARD.UseVisualStyleBackColor = true;
            this.SaveARD.Click += new System.EventHandler(this.SaveARD_Click);
            // 
            // LoadedFileLabel
            // 
            this.LoadedFileLabel.AutoSize = true;
            this.LoadedFileLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.LoadedFileLabel.Location = new System.Drawing.Point(216, 60);
            this.LoadedFileLabel.Name = "LoadedFileLabel";
            this.LoadedFileLabel.Size = new System.Drawing.Size(58, 13);
            this.LoadedFileLabel.TabIndex = 6;
            this.LoadedFileLabel.Text = "File loaded";
            this.LoadedFileLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // MapScaleTracker
            // 
            this.MapScaleTracker.LargeChange = 2;
            this.MapScaleTracker.Location = new System.Drawing.Point(1125, 598);
            this.MapScaleTracker.Maximum = 8;
            this.MapScaleTracker.Name = "MapScaleTracker";
            this.MapScaleTracker.Size = new System.Drawing.Size(510, 45);
            this.MapScaleTracker.TabIndex = 7;
            this.MapScaleTracker.Scroll += new System.EventHandler(this.MapScaleTracker_Scroll);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1349, 646);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "MAP SCALE";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1648, 747);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MapScaleTracker);
            this.Controls.Add(this.LoadedFileLabel);
            this.Controls.Add(this.SaveARD);
            this.Controls.Add(this.MapPreview);
            this.Controls.Add(this.EventTabControl);
            this.Controls.Add(this.LoadARD);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "ARD -Battle Editor-";
            ((System.ComponentModel.ISupportInitialize)(this.MapPreview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MapScaleTracker)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button LoadARD;
        private System.Windows.Forms.PictureBox MapPreview;
        private System.Windows.Forms.TabControl EventTabControl;
        private System.Windows.Forms.Button SaveARD;
        private System.Windows.Forms.Label LoadedFileLabel;
        private System.Windows.Forms.TrackBar MapScaleTracker;
        private System.Windows.Forms.Label label1;
    }
}

