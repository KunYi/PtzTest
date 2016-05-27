using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PTZTest
{
    public partial class Form1 : Form
    {
        private byte address;
        private Action.CSet action;
        private readonly String[] ProtocolItems = {
            "Pelco-D", 
            "Pelco-P", 
            "Kalatel KTD312",
            "CCR-20G/ADT8020", 
            "YANN"
        };
        private PTZController ptzCnt;

        private void initialForm()
        {
            FormBorderStyle = FormBorderStyle.FixedSingle;

            cmbProtocol.Items.Clear();
            foreach (String p in ProtocolItems)
                cmbProtocol.Items.Add(p);
            cmbProtocol.Text = ProtocolItems[0];

            UpdateStatusLabel();

        }

        public Form1()
        {
            InitializeComponent();
            initialForm();

            address = 0x01;
            comm.Parity = System.IO.Ports.Parity.None;
            comm.DataBits = 8;
            comm.Handshake = System.IO.Ports.Handshake.None;
            comm.PortName = "COM4";
            comm.BaudRate = 9600;

            action = Action.CSet.NONE;
            UpdateStatusLabel();
        }


        private void BtnIn_Click(object sender, EventArgs e)
        {
            SendCmd(ptzCnt.GenerationPacket(new Action(address, Action.CSet.IN)));
        }

        private void BtnOut_Click(object sender, EventArgs e)
        {
            SendCmd(ptzCnt.GenerationPacket(new Action(address, Action.CSet.OUT)));
        }

        private void BtnNear_Click(object sender, EventArgs e)
        {
            SendCmd(ptzCnt.GenerationPacket(new Action(address, Action.CSet.NEAR)));
        }

        private void BtnFar_Click(object sender, EventArgs e)
        {
            SendCmd(ptzCnt.GenerationPacket(new Action(address, Action.CSet.FAR)));
        }

        private void BtnStop_Click(object sender, EventArgs e)
        {
           byte[] packet = ptzCnt.GenerationPacket(new Action(address, Action.CSet.STOP));
           if (comm.IsOpen)
           {
               comm.Write(packet, 0, packet.Length);
           }
        }

        private void Address1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = onlyNumericInput(e.KeyChar);
        }

        private bool onlyNumericInput(char c) {
             
            if (c >= 31 && (c < '0' || c > '9'))
            {
                return true;
            }
            return false;
        }

        private void SpeedPan_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = onlyNumericInput(e.KeyChar);
        }

        private void Setting_Click(object sender, EventArgs e)
        {
            FrmSetting dlgSetting = new FrmSetting();
            
            
            dlgSetting.Baudrate = comm.BaudRate;
            dlgSetting.COMPort = comm.PortName;
            dlgSetting.setComboPort(!comm.IsOpen);

            if (DialogResult.OK == dlgSetting.ShowDialog(this))
            {

                comm.BaudRate = dlgSetting.Baudrate;
                if (!comm.IsOpen)
                {
                    comm.PortName = dlgSetting.COMPort;
                }

                UpdateStatusLabel();
            }
        }

        private void UpdateStatusLabel()
        {
            StringBuilder strB = new StringBuilder();
            strB.Append(comm.PortName);
            strB.Append(":");
            strB.Append(comm.BaudRate.ToString());
            strB.Append(", N, 8, 1");
            StatusLabel1.Text = strB.ToString();
        }

        private void cbOpen_CheckedChanged(object sender, EventArgs e)
        {
            if (cbOpen.Checked)
            {
                cbOpen.Text = "Close";
                
                if (!comm.IsOpen)
                {
                    comm.Open();
                }
            }
            else
            {
                cbOpen.Text = "Open";
                if (comm.IsOpen)
                {
                    comm.Close();
                }
            }
        }

        private void SendCmd(byte[] packet)
        {
            if (comm.IsOpen)
                comm.Write(packet, 0, packet.Length);
        }

        private void BtnUp_Click(object sender, EventArgs e)
        {
            SendCmd(ptzCnt.GenerationPacket(new Action(address, Action.CSet.UP)));
        }

        private void BtnDown_Click(object sender, EventArgs e)
        {
            SendCmd(ptzCnt.GenerationPacket(new Action(address, Action.CSet.DOWN)));
        }

        private void BtnRight_Click(object sender, EventArgs e)
        {
            SendCmd(ptzCnt.GenerationPacket(new Action(address, Action.CSet.RIGHT)));
        }

        private void BtnLeft_Click(object sender, EventArgs e)
        {
            SendCmd(ptzCnt.GenerationPacket(new Action(address, Action.CSet.LEFT)));
        }

        private void cmbProtocol_SelectedValueChanged(object sender, EventArgs e)
        {
            switch (cmbProtocol.SelectedIndex)
            {
                case 0:
                    ptzCnt = new PelcoD();
                    break;
                case 1:
                    ptzCnt = new PelcoP();
                    break;
                case 2:
                    ptzCnt = new KID312();
                    break;
                case 3:
                    ptzCnt = new CCR20G();
                    break;
                case 4:
                    ptzCnt = new YANN();
                    break;
                default:
                    break;

            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (comm.IsOpen)
                comm.Close();
        }

        private void BtnUpR_Click(object sender, EventArgs e)
        {
            SendCmd(ptzCnt.GenerationPacket(new Action(address, Action.CSet.RIGHT | Action.CSet.UP)));
        }

        private void BtnUpL_Click(object sender, EventArgs e)
        {
            SendCmd(ptzCnt.GenerationPacket(new Action(address, Action.CSet.LEFT | Action.CSet.UP)));
        }

        private void BtnDownR_Click(object sender, EventArgs e)
        {
            SendCmd(ptzCnt.GenerationPacket(new Action(address, Action.CSet.RIGHT | Action.CSet.DOWN)));
        }

        private void BtnDownL_Click(object sender, EventArgs e)
        {
            SendCmd(ptzCnt.GenerationPacket(new Action(address, Action.CSet.LEFT | Action.CSet.DOWN)));
        }

        private void TiltSpeed_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = onlyNumericInput(e.KeyChar);
        }

        private int ValidSpeed(string num)
        {
            int speed = int.Parse(num);

            if (speed > 255)
            {
                speed = 255;
                MessageBox.Show("Must enter a number less than 256", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning); 
            }

            return speed;
        }

        private int ValidAddress(string num)
        {
            return ValidSpeed(num);
        }

        private void TiltSpeed_Validating(object sender, CancelEventArgs e)
        {
            int speed = ValidSpeed(TiltSpeed.Text);
            TiltSpeed.Text = speed.ToString();
        }

        private void SpeedPan_Validating(object sender, CancelEventArgs e)
        {
            int speed = ValidSpeed(SpeedPan.Text);
            SpeedPan.Text = speed.ToString();
        }

        private void Address1_Validating(object sender, CancelEventArgs e)
        {
            address = (byte) ValidAddress(Address1.Text);
            Address1.Text = address.ToString();
        }
    }
}