using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Syntec.Remote;

public enum BitType
{
    O,
    I,
    R
}

namespace SyntecRemote
{
    


    public partial class Form1 : Form
    {
        private SyntecRemoteCNC CNC = null;
        private ConnectionState State = ConnectionState.Closed;
        private int Mode = 0;
        private BitType bittype = global::BitType.O;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            m_textBox_IP.Text += "192.168.1.10";

            m_comboBoxModebit.Items.Add("Read");
            m_comboBoxModebit.Items.Add("Write");

            m_comboBoxTypeBit.Items.Add("O");
            m_comboBoxTypeBit.Items.Add("I");
            m_comboBoxTypeBit.Items.Add("R");


            //m_comboBoxModebit.SelectedIndex = 0;
           // m_comboBoxTypeBit.SelectedIndex = 0;
        }

        private void m_button_Connect_Click(object sender, EventArgs e)
        {
            String host = m_textBox_IP.Text;

            
            if (State == ConnectionState.Closed)
            {
                CNC = new SyntecRemoteCNC(host, 10000);

                if (!CNC.isConnected())
                {
                    ShowLog("Fail Connect " + host);
                }
                else
                {
                    Color backcolor = Color.Lime;
                    m_button_Connect.BackColor = backcolor;
                    m_textBox_IP.ReadOnly = true;

                    ShowLog("Connected " + host);

                    m_timerReadPos.Enabled = true;
                    m_timerReadPos.Start();

                    State = ConnectionState.Connecting;
                }
            }
            else
            {
                m_button_Connect.BackColor = SystemColors.Control;
                m_textBox_IP.ReadOnly = false;

                m_timerReadPos.Stop();

                CNC.Close();
                State = ConnectionState.Closed;
            }
            
        }

        private void ShowLog(string msg)
        {
            m_listBoxLog.Items.Add(msg);
        }

        private void m_timerReadPos_Tick(object sender, EventArgs e)
        {
            string[] szAxisName, szUnit;
            short DecPoint;
            float[] Mach, Abs, Rel, Dist;

            short result = CNC.READ_position(out szAxisName, out DecPoint, out szUnit, out Mach, out Abs, out Rel, out Dist);

            if (result != (short)SyntecRemoteCNC.ErrorCode.NormalTermination)
            {
                ShowLog("Fail Read Position");
            }
            else
            {

            }
        }

        private void m_comboBoxModebit_SelectedIndexChanged(object sender, EventArgs e)
        {
            Mode = m_comboBoxModebit.SelectedIndex;    
            
            if (Mode == 0)
            {
                ShowLog("Mode Change to Read");
                m_textBoxBitVal.ReadOnly = true;
            }
            else if (Mode == 1)
            {
                ShowLog("Mode Change to Write");
                m_textBoxBitVal.ReadOnly = false;
            }     
        }

        private void m_comboBoxTypeBit_SelectedIndexChanged(object sender, EventArgs e)
        {
            int type = m_comboBoxTypeBit.SelectedIndex;

            switch (type)
            {
                case 0:
                    ShowLog("Bit Change to O bit");
                    bittype = global::BitType.O;
                    break;
                case 1:
                    ShowLog("Bit Change to I bit");
                    bittype = global::BitType.I;
                    break;
                case 2:
                    ShowLog("Bit Change to R bit");
                    bittype = global::BitType.R;
                    break;
                default:
                    break;
            }
        }

        private void m_textBoxBitVal_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                if (CNC != null)
                {
                    short result = -1;
                    
                }
            }
        }

        private void m_textBoxBitNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                if (Mode == 0 && CNC != null)
                {
                    short result = -1;
                    int no = int.Parse(m_textBoxBitNo.Text);
                    byte[] val = null;
                    int[] valR = null;

                    switch (bittype)
                    {
                        case global::BitType.O:
                            result = CNC.READ_plc_obit(no, no, out val);
                            break;
                        case global::BitType.I:
                            result = CNC.READ_plc_ibit(no, no, out val);
                            break;
                        case global::BitType.R:
                            result = CNC.READ_plc_register(no, no, out valR);
                            break;
                        default:
                            break;
                    }

                    if (result != (short)SyntecRemoteCNC.ErrorCode.NormalTermination)
                    {
                        switch (bittype)
                        {
                            case global::BitType.O:
                                ShowLog("Fail to read " + string.Concat(no) + " O bit");
                                break;
                            case global::BitType.I:
                                ShowLog("Fail to read " + string.Concat(no) + " I bit");
                                break;
                            case global::BitType.R:
                                ShowLog("Fail to read " + string.Concat(no) + " Register");
                                break;
                            default:
                                break;
                        }
                    }
                    else
                    {
                        if (bittype == global::BitType.R)
                        {
                            m_textBoxBitVal.Text = string.Concat(valR);
                        }
                        else
                        {
                            m_textBoxBitVal.Text = string.Concat(val);
                        }
                    }
                }
            }
        }
    }
}
