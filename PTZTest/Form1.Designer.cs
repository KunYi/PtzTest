namespace PTZTest
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
            this.components = new System.ComponentModel.Container();
            this.GrpBox1 = new System.Windows.Forms.GroupBox();
            this.BtnDown = new System.Windows.Forms.Button();
            this.BtnUp = new System.Windows.Forms.Button();
            this.BtnRight = new System.Windows.Forms.Button();
            this.BtnLeft = new System.Windows.Forms.Button();
            this.BtnDownL = new System.Windows.Forms.Button();
            this.BtnUpL = new System.Windows.Forms.Button();
            this.BtnDownR = new System.Windows.Forms.Button();
            this.BtnUpR = new System.Windows.Forms.Button();
            this.BtnStop = new System.Windows.Forms.Button();
            this.cmbProtocol = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnIn = new System.Windows.Forms.Button();
            this.BtnNear = new System.Windows.Forms.Button();
            this.BtnOut = new System.Windows.Forms.Button();
            this.BtnFar = new System.Windows.Forms.Button();
            this.GrpBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Address1 = new System.Windows.Forms.TextBox();
            this.comm = new System.IO.Ports.SerialPort(this.components);
            this.GrpSpeed = new System.Windows.Forms.GroupBox();
            this.TiltSpeed = new System.Windows.Forms.TextBox();
            this.SpeedPan = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.StatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.GrpComm = new System.Windows.Forms.GroupBox();
            this.cbOpen = new System.Windows.Forms.CheckBox();
            this.Setting = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.GrpBox1.SuspendLayout();
            this.GrpBox2.SuspendLayout();
            this.GrpSpeed.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.GrpComm.SuspendLayout();
            this.SuspendLayout();
            // 
            // GrpBox1
            // 
            this.GrpBox1.Controls.Add(this.BtnDown);
            this.GrpBox1.Controls.Add(this.BtnUp);
            this.GrpBox1.Controls.Add(this.BtnRight);
            this.GrpBox1.Controls.Add(this.BtnLeft);
            this.GrpBox1.Controls.Add(this.BtnDownL);
            this.GrpBox1.Controls.Add(this.BtnUpL);
            this.GrpBox1.Controls.Add(this.BtnDownR);
            this.GrpBox1.Controls.Add(this.BtnUpR);
            this.GrpBox1.Controls.Add(this.BtnStop);
            this.GrpBox1.Location = new System.Drawing.Point(8, 12);
            this.GrpBox1.Name = "GrpBox1";
            this.GrpBox1.Size = new System.Drawing.Size(187, 122);
            this.GrpBox1.TabIndex = 0;
            this.GrpBox1.TabStop = false;
            this.GrpBox1.Text = "Pan/Tilt";
            // 
            // BtnDown
            // 
            this.BtnDown.Location = new System.Drawing.Point(64, 85);
            this.BtnDown.Name = "BtnDown";
            this.BtnDown.Size = new System.Drawing.Size(53, 26);
            this.BtnDown.TabIndex = 16;
            this.BtnDown.Text = "↓";
            this.BtnDown.UseVisualStyleBackColor = true;
            this.BtnDown.Click += new System.EventHandler(this.BtnDown_Click);
            // 
            // BtnUp
            // 
            this.BtnUp.Location = new System.Drawing.Point(64, 21);
            this.BtnUp.Name = "BtnUp";
            this.BtnUp.Size = new System.Drawing.Size(53, 26);
            this.BtnUp.TabIndex = 15;
            this.BtnUp.Text = "↑";
            this.BtnUp.UseVisualStyleBackColor = true;
            this.BtnUp.Click += new System.EventHandler(this.BtnUp_Click);
            // 
            // BtnRight
            // 
            this.BtnRight.Location = new System.Drawing.Point(123, 53);
            this.BtnRight.Name = "BtnRight";
            this.BtnRight.Size = new System.Drawing.Size(53, 26);
            this.BtnRight.TabIndex = 14;
            this.BtnRight.Text = "→";
            this.BtnRight.UseVisualStyleBackColor = true;
            this.BtnRight.Click += new System.EventHandler(this.BtnRight_Click);
            // 
            // BtnLeft
            // 
            this.BtnLeft.Location = new System.Drawing.Point(9, 53);
            this.BtnLeft.Name = "BtnLeft";
            this.BtnLeft.Size = new System.Drawing.Size(53, 26);
            this.BtnLeft.TabIndex = 13;
            this.BtnLeft.Text = "←";
            this.BtnLeft.UseVisualStyleBackColor = true;
            this.BtnLeft.Click += new System.EventHandler(this.BtnLeft_Click);
            // 
            // BtnDownL
            // 
            this.BtnDownL.Location = new System.Drawing.Point(9, 85);
            this.BtnDownL.Name = "BtnDownL";
            this.BtnDownL.Size = new System.Drawing.Size(53, 26);
            this.BtnDownL.TabIndex = 12;
            this.BtnDownL.Text = "↙";
            this.BtnDownL.UseVisualStyleBackColor = true;
            this.BtnDownL.Click += new System.EventHandler(this.BtnDownL_Click);
            // 
            // BtnUpL
            // 
            this.BtnUpL.Location = new System.Drawing.Point(9, 21);
            this.BtnUpL.Name = "BtnUpL";
            this.BtnUpL.Size = new System.Drawing.Size(53, 26);
            this.BtnUpL.TabIndex = 11;
            this.BtnUpL.Text = "↖";
            this.BtnUpL.UseVisualStyleBackColor = true;
            this.BtnUpL.Click += new System.EventHandler(this.BtnUpL_Click);
            // 
            // BtnDownR
            // 
            this.BtnDownR.Location = new System.Drawing.Point(123, 85);
            this.BtnDownR.Name = "BtnDownR";
            this.BtnDownR.Size = new System.Drawing.Size(53, 26);
            this.BtnDownR.TabIndex = 10;
            this.BtnDownR.Text = "↘";
            this.BtnDownR.UseVisualStyleBackColor = true;
            this.BtnDownR.Click += new System.EventHandler(this.BtnDownR_Click);
            // 
            // BtnUpR
            // 
            this.BtnUpR.Location = new System.Drawing.Point(123, 21);
            this.BtnUpR.Name = "BtnUpR";
            this.BtnUpR.Size = new System.Drawing.Size(53, 26);
            this.BtnUpR.TabIndex = 9;
            this.BtnUpR.Text = "↗";
            this.BtnUpR.UseVisualStyleBackColor = true;
            this.BtnUpR.Click += new System.EventHandler(this.BtnUpR_Click);
            // 
            // BtnStop
            // 
            this.BtnStop.Location = new System.Drawing.Point(64, 53);
            this.BtnStop.Name = "BtnStop";
            this.BtnStop.Size = new System.Drawing.Size(53, 26);
            this.BtnStop.TabIndex = 8;
            this.BtnStop.Text = "  ▊▊";
            this.BtnStop.UseVisualStyleBackColor = true;
            this.BtnStop.Click += new System.EventHandler(this.BtnStop_Click);
            // 
            // cmbProtocol
            // 
            this.cmbProtocol.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProtocol.FormattingEnabled = true;
            this.cmbProtocol.Location = new System.Drawing.Point(56, 144);
            this.cmbProtocol.Name = "cmbProtocol";
            this.cmbProtocol.Size = new System.Drawing.Size(128, 20);
            this.cmbProtocol.TabIndex = 5;
            this.cmbProtocol.SelectedValueChanged += new System.EventHandler(this.cmbProtocol_SelectedValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 147);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 12);
            this.label1.TabIndex = 6;
            this.label1.Text = "Protocol";
            // 
            // BtnIn
            // 
            this.BtnIn.Location = new System.Drawing.Point(3, 21);
            this.BtnIn.Name = "BtnIn";
            this.BtnIn.Size = new System.Drawing.Size(53, 26);
            this.BtnIn.TabIndex = 0;
            this.BtnIn.Text = "In";
            this.BtnIn.UseVisualStyleBackColor = true;
            this.BtnIn.Click += new System.EventHandler(this.BtnIn_Click);
            // 
            // BtnNear
            // 
            this.BtnNear.Location = new System.Drawing.Point(3, 53);
            this.BtnNear.Name = "BtnNear";
            this.BtnNear.Size = new System.Drawing.Size(53, 26);
            this.BtnNear.TabIndex = 1;
            this.BtnNear.Text = "Near";
            this.BtnNear.UseVisualStyleBackColor = true;
            this.BtnNear.Click += new System.EventHandler(this.BtnNear_Click);
            // 
            // BtnOut
            // 
            this.BtnOut.Location = new System.Drawing.Point(62, 21);
            this.BtnOut.Name = "BtnOut";
            this.BtnOut.Size = new System.Drawing.Size(53, 26);
            this.BtnOut.TabIndex = 2;
            this.BtnOut.Text = "Out";
            this.BtnOut.UseVisualStyleBackColor = true;
            this.BtnOut.Click += new System.EventHandler(this.BtnOut_Click);
            // 
            // BtnFar
            // 
            this.BtnFar.Location = new System.Drawing.Point(62, 53);
            this.BtnFar.Name = "BtnFar";
            this.BtnFar.Size = new System.Drawing.Size(53, 26);
            this.BtnFar.TabIndex = 3;
            this.BtnFar.Text = "Far";
            this.BtnFar.UseVisualStyleBackColor = true;
            this.BtnFar.Click += new System.EventHandler(this.BtnFar_Click);
            // 
            // GrpBox2
            // 
            this.GrpBox2.Controls.Add(this.button1);
            this.GrpBox2.Controls.Add(this.button2);
            this.GrpBox2.Controls.Add(this.BtnFar);
            this.GrpBox2.Controls.Add(this.BtnOut);
            this.GrpBox2.Controls.Add(this.BtnNear);
            this.GrpBox2.Controls.Add(this.BtnIn);
            this.GrpBox2.Location = new System.Drawing.Point(201, 12);
            this.GrpBox2.Name = "GrpBox2";
            this.GrpBox2.Size = new System.Drawing.Size(118, 122);
            this.GrpBox2.TabIndex = 4;
            this.GrpBox2.TabStop = false;
            this.GrpBox2.Text = "Zoom/Focus/Iris";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(190, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 12);
            this.label2.TabIndex = 7;
            this.label2.Text = "Address";
            // 
            // Address1
            // 
            this.Address1.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::PTZTest.Properties.Settings.Default, "Address", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.Address1.Location = new System.Drawing.Point(235, 142);
            this.Address1.MaxLength = 3;
            this.Address1.Name = "Address1";
            this.Address1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Address1.Size = new System.Drawing.Size(32, 22);
            this.Address1.TabIndex = 8;
            this.Address1.Text = global::PTZTest.Properties.Settings.Default.Address;
            this.Address1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Address1_KeyPress);
            this.Address1.Validating += new System.ComponentModel.CancelEventHandler(this.Address1_Validating);
            // 
            // GrpSpeed
            // 
            this.GrpSpeed.Controls.Add(this.TiltSpeed);
            this.GrpSpeed.Controls.Add(this.SpeedPan);
            this.GrpSpeed.Controls.Add(this.label4);
            this.GrpSpeed.Controls.Add(this.label3);
            this.GrpSpeed.Location = new System.Drawing.Point(8, 170);
            this.GrpSpeed.Name = "GrpSpeed";
            this.GrpSpeed.Size = new System.Drawing.Size(131, 41);
            this.GrpSpeed.TabIndex = 11;
            this.GrpSpeed.TabStop = false;
            this.GrpSpeed.Text = "Speed";
            // 
            // TiltSpeed
            // 
            this.TiltSpeed.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::PTZTest.Properties.Settings.Default, "Address", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.TiltSpeed.Location = new System.Drawing.Point(93, 13);
            this.TiltSpeed.MaxLength = 3;
            this.TiltSpeed.Name = "TiltSpeed";
            this.TiltSpeed.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.TiltSpeed.Size = new System.Drawing.Size(32, 22);
            this.TiltSpeed.TabIndex = 13;
            this.TiltSpeed.Text = global::PTZTest.Properties.Settings.Default.Address;
            this.TiltSpeed.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TiltSpeed_KeyPress);
            this.TiltSpeed.Validating += new System.ComponentModel.CancelEventHandler(this.TiltSpeed_Validating);
            // 
            // SpeedPan
            // 
            this.SpeedPan.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::PTZTest.Properties.Settings.Default, "Address", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.SpeedPan.Location = new System.Drawing.Point(30, 13);
            this.SpeedPan.MaxLength = 3;
            this.SpeedPan.Name = "SpeedPan";
            this.SpeedPan.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.SpeedPan.Size = new System.Drawing.Size(32, 22);
            this.SpeedPan.TabIndex = 12;
            this.SpeedPan.Text = global::PTZTest.Properties.Settings.Default.Address;
            this.SpeedPan.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SpeedPan_KeyPress);
            this.SpeedPan.Validating += new System.ComponentModel.CancelEventHandler(this.SpeedPan_Validating);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(68, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(21, 12);
            this.label4.TabIndex = 11;
            this.label4.Text = "Tilt";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(22, 12);
            this.label3.TabIndex = 10;
            this.label3.Text = "Pan";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 218);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(330, 22);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.TabIndex = 13;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // StatusLabel1
            // 
            this.StatusLabel1.Name = "StatusLabel1";
            this.StatusLabel1.Size = new System.Drawing.Size(24, 17);
            this.StatusLabel1.Text = "Test";
            // 
            // GrpComm
            // 
            this.GrpComm.Controls.Add(this.cbOpen);
            this.GrpComm.Controls.Add(this.Setting);
            this.GrpComm.Location = new System.Drawing.Point(179, 170);
            this.GrpComm.Name = "GrpComm";
            this.GrpComm.Size = new System.Drawing.Size(137, 41);
            this.GrpComm.TabIndex = 15;
            this.GrpComm.TabStop = false;
            this.GrpComm.Text = "Communication";
            // 
            // cbOpen
            // 
            this.cbOpen.Appearance = System.Windows.Forms.Appearance.Button;
            this.cbOpen.Location = new System.Drawing.Point(11, 12);
            this.cbOpen.Name = "cbOpen";
            this.cbOpen.Size = new System.Drawing.Size(57, 23);
            this.cbOpen.TabIndex = 15;
            this.cbOpen.Text = "Open";
            this.cbOpen.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cbOpen.UseVisualStyleBackColor = true;
            this.cbOpen.CheckedChanged += new System.EventHandler(this.cbOpen_CheckedChanged);
            // 
            // Setting
            // 
            this.Setting.Location = new System.Drawing.Point(74, 12);
            this.Setting.Name = "Setting";
            this.Setting.Size = new System.Drawing.Size(57, 23);
            this.Setting.TabIndex = 13;
            this.Setting.Text = "Setting";
            this.Setting.UseVisualStyleBackColor = true;
            this.Setting.Click += new System.EventHandler(this.Setting_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(62, 85);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(53, 26);
            this.button1.TabIndex = 5;
            this.button1.Text = "Far";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(3, 85);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(53, 26);
            this.button2.TabIndex = 4;
            this.button2.Text = "Near";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(330, 240);
            this.Controls.Add(this.GrpComm);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.GrpSpeed);
            this.Controls.Add(this.Address1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbProtocol);
            this.Controls.Add(this.GrpBox2);
            this.Controls.Add(this.GrpBox1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "PTZ Tester";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.GrpBox1.ResumeLayout(false);
            this.GrpBox2.ResumeLayout(false);
            this.GrpSpeed.ResumeLayout(false);
            this.GrpSpeed.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.GrpComm.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox GrpBox1;
        private System.Windows.Forms.ComboBox cmbProtocol;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnIn;
        private System.Windows.Forms.Button BtnNear;
        private System.Windows.Forms.Button BtnOut;
        private System.Windows.Forms.Button BtnFar;
        private System.Windows.Forms.GroupBox GrpBox2;
        private System.Windows.Forms.Button BtnStop;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Address1;
        private System.IO.Ports.SerialPort comm;
        private System.Windows.Forms.GroupBox GrpSpeed;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TiltSpeed;
        private System.Windows.Forms.TextBox SpeedPan;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel StatusLabel1;
        private System.Windows.Forms.GroupBox GrpComm;
        private System.Windows.Forms.CheckBox cbOpen;
        private System.Windows.Forms.Button Setting;
        private System.Windows.Forms.Button BtnUpR;
        private System.Windows.Forms.Button BtnDown;
        private System.Windows.Forms.Button BtnUp;
        private System.Windows.Forms.Button BtnRight;
        private System.Windows.Forms.Button BtnLeft;
        private System.Windows.Forms.Button BtnDownL;
        private System.Windows.Forms.Button BtnUpL;
        private System.Windows.Forms.Button BtnDownR;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

