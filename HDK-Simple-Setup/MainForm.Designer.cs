namespace HDK_Simple_Setup
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSetConfig = new System.Windows.Forms.Button();
            this.lstHMD = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnTrackCalib = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnServer = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.btn3DSample = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Menu;
            this.panel1.Controls.Add(this.btnSetConfig);
            this.panel1.Controls.Add(this.lstHMD);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(280, 71);
            this.panel1.TabIndex = 0;
            // 
            // btnSetConfig
            // 
            this.btnSetConfig.Location = new System.Drawing.Point(169, 34);
            this.btnSetConfig.Name = "btnSetConfig";
            this.btnSetConfig.Size = new System.Drawing.Size(97, 23);
            this.btnSetConfig.TabIndex = 2;
            this.btnSetConfig.Text = "Use Selected";
            this.btnSetConfig.UseVisualStyleBackColor = true;
            this.btnSetConfig.Click += new System.EventHandler(this.button1_Click);
            // 
            // lstHMD
            // 
            this.lstHMD.AllowDrop = true;
            this.lstHMD.FormattingEnabled = true;
            this.lstHMD.Items.AddRange(new object[] {
            "HDK 1.3/1.4",
            "HDK 2.0",
            "CV1",
            "HTC Vive",
            "Vuzix"});
            this.lstHMD.Location = new System.Drawing.Point(15, 35);
            this.lstHMD.Name = "lstHMD";
            this.lstHMD.Size = new System.Drawing.Size(137, 21);
            this.lstHMD.TabIndex = 1;
            this.lstHMD.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "1: Select your hardware";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Menu;
            this.panel2.Controls.Add(this.btnTrackCalib);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(12, 89);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(280, 71);
            this.panel2.TabIndex = 1;
            // 
            // btnTrackCalib
            // 
            this.btnTrackCalib.Location = new System.Drawing.Point(15, 35);
            this.btnTrackCalib.Name = "btnTrackCalib";
            this.btnTrackCalib.Size = new System.Drawing.Size(251, 23);
            this.btnTrackCalib.TabIndex = 1;
            this.btnTrackCalib.Text = "Run Camera Utility";
            this.btnTrackCalib.UseVisualStyleBackColor = true;
            this.btnTrackCalib.Click += new System.EventHandler(this.button2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "2: Calibrate tracking beacons";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.Menu;
            this.panel3.Controls.Add(this.btnServer);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Location = new System.Drawing.Point(12, 166);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(280, 71);
            this.panel3.TabIndex = 2;
            // 
            // btnServer
            // 
            this.btnServer.Location = new System.Drawing.Point(15, 37);
            this.btnServer.Name = "btnServer";
            this.btnServer.Size = new System.Drawing.Size(251, 23);
            this.btnServer.TabIndex = 1;
            this.btnServer.Text = "Run OSVR Server";
            this.btnServer.UseVisualStyleBackColor = true;
            this.btnServer.Click += new System.EventHandler(this.button3_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "3: Run the OSVR server";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.Menu;
            this.panel4.Controls.Add(this.btn3DSample);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Location = new System.Drawing.Point(12, 244);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(280, 82);
            this.panel4.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(160, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "4: Test Direct Mode functionality";
            // 
            // btn3DSample
            // 
            this.btn3DSample.Location = new System.Drawing.Point(15, 45);
            this.btn3DSample.Name = "btn3DSample";
            this.btn3DSample.Size = new System.Drawing.Size(251, 23);
            this.btn3DSample.TabIndex = 1;
            this.btn3DSample.Text = "Direct3D Example";
            this.btn3DSample.UseVisualStyleBackColor = true;
            this.btn3DSample.Click += new System.EventHandler(this.button4_Click);
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(304, 338);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HDK Setup Utility";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnSetConfig;
        private System.Windows.Forms.ComboBox lstHMD;
        private System.Windows.Forms.Button btnTrackCalib;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnServer;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btn3DSample;
        private System.Windows.Forms.Label label4;
    }
}

