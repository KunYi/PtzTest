using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PTZTest
{
    public partial class FrmSetting : Form
    {
        private String[] Ports;
        private String[] Bauds;

        private void InitialPorts()
        {
            Ports = new String[] { "COM1", "COM2", "COM3", "COM4",
                "COM5", "COM6", "COM7", "COM8",
                "COM9", "COM10", "COM11", "COM12",
                "COM13", "COM14", "COM15", "COM16" };
            
            cmbComPort.Items.Clear();
            foreach (String p in Ports)
                cmbComPort.Items.Add(p);
            
            cmbComPort.Text = Ports[0];
            cmbComPort.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void InitialBauds()
        {
            Bauds = new String[] { "1200", "2400", "4800",
                "9600", "19200" };
            cmbBaudrate.Items.Clear();
            foreach (String b in Bauds)
                cmbBaudrate.Items.Add(b);

            cmbBaudrate.Text = Bauds[2];
            cmbBaudrate.DropDownStyle = ComboBoxStyle.DropDownList;

        }

        private void InitialzeForm()
        {
            InitialBauds();
            InitialPorts();
            FormBorderStyle = FormBorderStyle.FixedDialog;
        }

        public FrmSetting()
        {
            InitializeComponent();
            InitialzeForm();
        }

        public String COMPort
        {
            get { return cmbComPort.Text; }
            set { cmbComPort.Text = value; }
        }

        public int Baudrate
        {
            get { return int.Parse(cmbBaudrate.Text); }

            set { cmbBaudrate.Text = value.ToString(); }
        }

        private void BtnOK_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        public void setComboPort(bool enable)
        {
            cmbComPort.Enabled = enable;
        }
    }
}