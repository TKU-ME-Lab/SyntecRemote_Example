using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Sockets;


using Syntec.Remote;

public enum BitType
{
    O,
    I,
    R
}

public enum BitMode
{
    Read,
    Write
}

namespace SyntecRemote
{
    


    public partial class Form1 : Form
    {
        private SyntecRemoteCNC CNC = null;
        private ConnectionState State = ConnectionState.Closed;
        private BitType m_bittype = BitType.O;
        private BitMode m_bitmode = BitMode.Read;

        static private System.Net.IPAddress m_hostAddress = System.Net.IPAddress.Parse("127.0.0.1");
        static TcpListener m_TcpServer = new TcpListener(m_hostAddress, 4568);
        //static TcpClient m_Tcpclient = null;

        static private System.Threading.Thread m_threadTcp;

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

            m_threadTcp = new System.Threading.Thread(new System.Threading.ThreadStart(socketCB));


            m_TcpServer.Start();
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

                    m_timerReadRbit.Enabled = true;
                    m_timerReadRbit.Start();

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
            int Rstart = 721;
            int Rend = 726;
            int[] data;

            short result = CNC.READ_plc_register(Rstart, Rend,out data);

            if (result != (short)SyntecRemoteCNC.ErrorCode.NormalTermination)
            {
                ShowLog("Fail Read Position");
            }
            else
            {
                //float[] fdata = { };

                //for(int index = 0; index < 6; index++)
                //{
                //    fdata[index] = (float)data[index];
                //}

                m_labelJoint1Val.Text = string.Concat(data[0]);
                m_labelJoint2Val.Text = string.Concat(data[1]);
                m_labelJoint3Val.Text = string.Concat(data[2]);
                m_labelJoint4Val.Text = string.Concat(data[3]);
                m_labelJoint5Val.Text = string.Concat(data[4]);
                m_labelJoint6Val.Text = string.Concat(data[5]);
            }
        }

        private void m_comboBoxModebit_SelectedIndexChanged(object sender, EventArgs e)
        {
            int mode = m_comboBoxModebit.SelectedIndex;    
            
            if (mode == 0)
            {
                ShowLog("Mode Change to Read");
                m_textBoxBitVal.ReadOnly = true;
                m_bitmode = BitMode.Read;
            }
            else if (mode == 1)
            {
                ShowLog("Mode Change to Write");
                m_textBoxBitVal.ReadOnly = false;
                m_bitmode = BitMode.Write;
            }     
        }

        private void m_comboBoxTypeBit_SelectedIndexChanged(object sender, EventArgs e)
        {
            int type = m_comboBoxTypeBit.SelectedIndex;

            switch (type)
            {
                case 0:
                    ShowLog("Bit Change to O bit");
                    m_bittype = global::BitType.O;
                    break;
                case 1:
                    ShowLog("Bit Change to I bit");
                    m_bittype = global::BitType.I;
                    break;
                case 2:
                    ShowLog("Bit Change to R bit");
                    m_bittype = global::BitType.R;
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
                    int plc_bit = int.Parse(m_textBoxBitNo.Text);                    
                    short result = -1;

                    switch (m_bittype)
                    {
                        case BitType.I:
                            byte[] Idata = { byte.Parse(m_textBoxBitVal.Text) };
                            //result = CNC.WRITE_plc_ibit(plc_bit, plc_bit, data);
                            break;
                        case BitType.O:
                            byte[] Odata = { byte.Parse(m_textBoxBitVal.Text) };
                            //result = CNC.WRtie
                            break;
                        case BitType.R:
                            int[] Rdata = { int.Parse(m_textBoxBitVal.Text) };
                            result = CNC.WRITE_plc_register(plc_bit, plc_bit, Rdata);
                            break;
                        default:
                            break;
                    }

                    if (result != (short)SyntecRemoteCNC.ErrorCode.NormalTermination)
                    {
                        ShowLog("Fail Wrtie Register " + m_textBoxBitVal.Text + " Error Code: " +  result);
                    }
                }
            }
        }

        private void m_textBoxBitNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                if (m_bitmode == BitMode.Read && CNC != null)
                {
                    short result = -1;
                    int no = int.Parse(m_textBoxBitNo.Text);
                    byte[] val = null;
                    int[] valR = null;

                    switch (m_bittype)
                    {
                        case BitType.O:
                            result = CNC.READ_plc_obit(no, no, out val);
                            break;
                        case BitType.I:
                            result = CNC.READ_plc_ibit(no, no, out val);
                            break;
                        case BitType.R:
                            result = CNC.READ_plc_register(no, no, out valR);
                            break;
                        default:
                            break;
                    }

                    if (result != (short)SyntecRemoteCNC.ErrorCode.NormalTermination)
                    {
                        switch (m_bittype)
                        {
                            case BitType.O:
                                ShowLog("Fail to read " + string.Concat(no) + " O bit");
                                break;
                            case BitType.I:
                                ShowLog("Fail to read " + string.Concat(no) + " I bit");
                                break;
                            case BitType.R:
                                ShowLog("Fail to read " + string.Concat(no) + " Register");
                                break;
                            default:
                                break;
                        }
                    }
                    else
                    {
                        if (m_bittype == BitType.R)
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

        private void m_timerReadRbit_Tick(object sender, EventArgs e)
        {
            int PoseStart = 50000;
            int PoseEnd = 50004;

            int[] data;

            short result = CNC.READ_plc_register(PoseStart, PoseEnd, out data);

            if (result != (short)SyntecRemoteCNC.ErrorCode.NormalTermination)
            {
                ShowLog("Fail Read Position");
            }
            else
            {
                m_labelR50000Val.Text = string.Concat(data[0]);
                m_labelR50001Val.Text = string.Concat(data[1]);
                m_labelR50002Val.Text = string.Concat(data[2]);
                m_labelR50003Val.Text = string.Concat(data[3]);
                m_labelR50004Val.Text = string.Concat(data[4]);
            }

            result = CNC.READ_plc_register(50010, 50010, out data);

            if (result != (short)SyntecRemoteCNC.ErrorCode.NormalTermination)
            {
                ShowLog("Fail Read Position");
            }
            else
            {
               m_labelR50010Val.Text = string.Concat(data[0]);
            }
        }

        private void m_buttonStart_Click(object sender, EventArgs e)
        {
            int[] data = { 990000, 0, 599000, 0, 0, 0 };
            int R50000 = 50000;
            int R50004 = 50004;


            short result = CNC.WRITE_plc_register(R50000, R50004, data);

            if (result != (short)SyntecRemoteCNC.ErrorCode.NormalTermination)
            {
                ShowLog("Fail Write Pose");
            }
            else
            {
                int RStart = 50010;
                int[] data_Start = { 3 };

                result = CNC.WRITE_plc_register(RStart, RStart, data_Start);

                if (result != (short)SyntecRemoteCNC.ErrorCode.NormalTermination)
                {
                    ShowLog("Fail to Start");
                }
                else
                {
                    ShowLog("Start Drill!!");
                }
            }
        }

        private void socketCB()
        {
            
            //
        }
    }
}
