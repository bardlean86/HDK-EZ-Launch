namespace EZ_Launch
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
            this.btn3DSample = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.container = new System.Windows.Forms.TabControl();
            this.tab1 = new System.Windows.Forms.TabPage();
            this.tab2 = new System.Windows.Forms.TabPage();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnPSMoveConfig = new System.Windows.Forms.Button();
            this.lblPSMoveCheck = new System.Windows.Forms.Label();
            this.btnStartPSMove = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.container.SuspendLayout();
            this.tab1.SuspendLayout();
            this.tab2.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Menu;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnSetConfig);
            this.panel1.Controls.Add(this.lstHMD);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(7, 11);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(280, 70);
            this.panel1.TabIndex = 0;
            // 
            // btnSetConfig
            // 
            this.btnSetConfig.Location = new System.Drawing.Point(167, 32);
            this.btnSetConfig.Name = "btnSetConfig";
            this.btnSetConfig.Size = new System.Drawing.Size(98, 25);
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
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btnTrackCalib);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(7, 91);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(280, 70);
            this.panel2.TabIndex = 1;
            // 
            // btnTrackCalib
            // 
            this.btnTrackCalib.Location = new System.Drawing.Point(15, 35);
            this.btnTrackCalib.Name = "btnTrackCalib";
            this.btnTrackCalib.Size = new System.Drawing.Size(250, 25);
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
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.btnServer);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Location = new System.Drawing.Point(7, 173);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(280, 70);
            this.panel3.TabIndex = 2;
            // 
            // btnServer
            // 
            this.btnServer.Location = new System.Drawing.Point(15, 37);
            this.btnServer.Name = "btnServer";
            this.btnServer.Size = new System.Drawing.Size(250, 25);
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
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.btn3DSample);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Location = new System.Drawing.Point(7, 254);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(280, 70);
            this.panel4.TabIndex = 3;
            // 
            // btn3DSample
            // 
            this.btn3DSample.Location = new System.Drawing.Point(15, 36);
            this.btn3DSample.Name = "btn3DSample";
            this.btn3DSample.Size = new System.Drawing.Size(250, 25);
            this.btn3DSample.TabIndex = 1;
            this.btn3DSample.Text = "Direct3D Example";
            this.btn3DSample.UseVisualStyleBackColor = true;
            this.btn3DSample.Click += new System.EventHandler(this.button4_Click);
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
            // container
            // 
            this.container.Controls.Add(this.tab1);
            this.container.Controls.Add(this.tab2);
            this.container.Location = new System.Drawing.Point(12, 12);
            this.container.Name = "container";
            this.container.SelectedIndex = 0;
            this.container.Size = new System.Drawing.Size(307, 361);
            this.container.TabIndex = 4;
            // 
            // tab1
            // 
            this.tab1.BackColor = System.Drawing.Color.Orange;
            this.tab1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tab1.Controls.Add(this.panel1);
            this.tab1.Controls.Add(this.panel4);
            this.tab1.Controls.Add(this.panel2);
            this.tab1.Controls.Add(this.panel3);
            this.tab1.Location = new System.Drawing.Point(4, 22);
            this.tab1.Name = "tab1";
            this.tab1.Padding = new System.Windows.Forms.Padding(3);
            this.tab1.Size = new System.Drawing.Size(299, 335);
            this.tab1.TabIndex = 0;
            this.tab1.Text = "OSVR";
            this.tab1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // tab2
            // 
            this.tab2.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.tab2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tab2.Controls.Add(this.panel5);
            this.tab2.Location = new System.Drawing.Point(4, 22);
            this.tab2.Name = "tab2";
            this.tab2.Padding = new System.Windows.Forms.Padding(3);
            this.tab2.Size = new System.Drawing.Size(299, 335);
            this.tab2.TabIndex = 1;
            this.tab2.Text = "PS Move";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.Menu;
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.btnPSMoveConfig);
            this.panel5.Controls.Add(this.lblPSMoveCheck);
            this.panel5.Controls.Add(this.btnStartPSMove);
            this.panel5.Location = new System.Drawing.Point(7, 10);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(280, 312);
            this.panel5.TabIndex = 1;
            // 
            // btnPSMoveConfig
            // 
            this.btnPSMoveConfig.Location = new System.Drawing.Point(15, 255);
            this.btnPSMoveConfig.Name = "btnPSMoveConfig";
            this.btnPSMoveConfig.Size = new System.Drawing.Size(250, 25);
            this.btnPSMoveConfig.TabIndex = 1;
            this.btnPSMoveConfig.Text = "PS Move Configuration";
            this.btnPSMoveConfig.UseVisualStyleBackColor = true;
            this.btnPSMoveConfig.Click += new System.EventHandler(this.btnPSMoveConfig_Click);
            // 
            // lblPSMoveCheck
            // 
            this.lblPSMoveCheck.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPSMoveCheck.AutoSize = true;
            this.lblPSMoveCheck.Location = new System.Drawing.Point(32, 20);
            this.lblPSMoveCheck.Name = "lblPSMoveCheck";
            this.lblPSMoveCheck.Size = new System.Drawing.Size(28, 13);
            this.lblPSMoveCheck.TabIndex = 0;
            this.lblPSMoveCheck.Text = "###";
            this.lblPSMoveCheck.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnStartPSMove
            // 
            this.btnStartPSMove.Location = new System.Drawing.Point(15, 211);
            this.btnStartPSMove.Name = "btnStartPSMove";
            this.btnStartPSMove.Size = new System.Drawing.Size(250, 25);
            this.btnStartPSMove.TabIndex = 0;
            this.btnStartPSMove.Text = "Start PS Move Service";
            this.btnStartPSMove.UseVisualStyleBackColor = true;
            this.btnStartPSMove.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(331, 385);
            this.Controls.Add(this.container);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HDK EZ Launch";
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
            this.container.ResumeLayout(false);
            this.tab1.ResumeLayout(false);
            this.tab2.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
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
        private System.Windows.Forms.TabControl container;
        private System.Windows.Forms.TabPage tab1;
        private System.Windows.Forms.TabPage tab2;
        private System.Windows.Forms.Label lblPSMoveCheck;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btnPSMoveConfig;
        private System.Windows.Forms.Button btnStartPSMove;
    }
}

