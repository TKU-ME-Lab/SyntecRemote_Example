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
using System.Runtime.Serialization.Formatters.Binary;


using Syntec.Remote;
using System.Text.RegularExpressions;

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
        static TcpClient m_TcpClient;
        static NetworkStream m_NetStream;

        private bool m_NewPose = false;
        private String[] m_Pose = { };
        private int m_StartBit = 0;

        static private System.Threading.Thread m_threadTcp;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            m_textBox_IP.Text += "10.0.0.10";

            m_comboBoxModebit.Items.Add("Read");
            m_comboBoxModebit.Items.Add("Write");

            m_comboBoxTypeBit.Items.Add("O");
            m_comboBoxTypeBit.Items.Add("I");
            m_comboBoxTypeBit.Items.Add("R");

            m_threadTcp = new System.Threading.Thread(new System.Threading.ThreadStart(socketCB));

            m_threadTcp.Start();
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

                    m_timerSendPose.Enabled = true;
                    m_timerSendPose.Start();

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

        private void ShowLog(String msg)
        {
            m_listBoxLog.Items.Add(msg);
        }

        private void m_timerReadPos_Tick(object sender, EventArgs e)
        {
            int Rstart;
            int Rend;
            if (m_tabControlPosition.SelectedIndex == 0)
            {
                Rstart = 741;
                Rend = 746;
            }
            else
            {
                Rstart = 721;
                Rend = 726;
            }
            
            int[] data;

            short result = CNC.READ_plc_register(Rstart, Rend,out data);

            if (result != (short)SyntecRemoteCNC.ErrorCode.NormalTermination)
            {
                ShowLog("Fail Read Position");
            }
            else
            {
                if (m_tabControlPosition.SelectedIndex == 0)
                {
                    m_labelJoint1Val.Text = String.Concat((double)data[0] / 1000);
                    m_labelJoint2Val.Text = String.Concat((double)data[1] / 1000);
                    m_labelJoint3Val.Text = String.Concat((double)data[2] / 1000);
                    m_labelJoint4Val.Text = String.Concat((double)data[3] / 1000);
                    m_labelJoint5Val.Text = String.Concat((double)data[4] / 1000);
                    m_labelJoint6Val.Text = String.Concat((double)data[5] / 1000);
                }
                else
                {
                    m_labelXVal.Text = String.Concat((double)data[0] / 1000);
                    m_labelYVal.Text = String.Concat((double)data[1] / 1000);
                    m_labelZVal.Text = String.Concat((double)data[2] / 1000);
                    m_labelAVal.Text = String.Concat((double)data[3] / 1000);
                    m_labelBVal.Text = String.Concat((double)data[4] / 1000);
                    m_labelCVal.Text = String.Concat((double)data[5] / 1000);
                }
                
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
                                ShowLog("Fail to read " + String.Concat(no) + " O bit");
                                break;
                            case BitType.I:
                                ShowLog("Fail to read " + String.Concat(no) + " I bit");
                                break;
                            case BitType.R:
                                ShowLog("Fail to read " + String.Concat(no) + " Register");
                                break;
                            default:
                                break;
                        }
                    }
                    else
                    {
                        if (m_bittype == BitType.R)
                        {
                            m_textBoxBitVal.Text = String.Concat(valR);
                        }
                        else
                        {
                            m_textBoxBitVal.Text = String.Concat(val);
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
                m_labelR50000Val.Text = String.Concat((double)data[0] / 1000);
                m_labelR50001Val.Text = String.Concat((double)data[1] / 1000);
                m_labelR50002Val.Text = String.Concat((double)data[2] / 1000);
                m_labelR50003Val.Text = String.Concat((double)data[3] / 1000);
                m_labelR50004Val.Text = String.Concat((double)data[4] / 1000);
            }

            result = CNC.READ_plc_register(50010, 50010, out data);

            if (result != (short)SyntecRemoteCNC.ErrorCode.NormalTermination)
            {
                ShowLog("Fail Read Position");
            }
            else
            {
               m_labelR50010Val.Text = String.Concat(data[0]);
                m_StartBit = data[0];
            }
        }

        private void m_buttonStart_Click(object sender, EventArgs e)
        {
            if (m_NetStream.CanWrite)
            {
                string msg = "Start";
                byte[] data = Encoding.ASCII.GetBytes(msg);
                m_NetStream.Write(data, 0, data.Length);
               // m_NetStream.
            }
            // 1041453, -38229, 469472, 0, 90000 
            // offset X: +90000, Z: -130000

            //int[] data = { 1068516, -107113, 458469, 27994, 90000 };

            //int R50000 = 50000;
            //int R50004 = 50004;

            //short result = CNC.WRITE_plc_register(R50000, R50004, data);

            //if (result != (short)SyntecRemoteCNC.ErrorCode.NormalTermination)
            //{
            //    ShowLog("Fail Write Pose");
            //}
            //else
            //{
            //    int RStart = 50010;
            //    int[] data_Start = { 1 };

            //    result = CNC.WRITE_plc_register(RStart, RStart, data_Start);

            //    if (result != (short)SyntecRemoteCNC.ErrorCode.NormalTermination)
            //    {
            //        ShowLog("Fail to Start");
            //    }
            //    else
            //    {
            //        ShowLog("Start Drill!!");
            //    }
            //}
        }

        private void socketCB()
        {
            int bufferSize = 0;
            while (true)
            {
                if (m_TcpClient == null || m_NetStream == null)
                {
                    m_TcpClient = m_TcpServer.AcceptTcpClient();
                    bufferSize = m_TcpClient.ReceiveBufferSize;
                    m_NetStream = m_TcpClient.GetStream();
                }
                else
                {
                    if (m_NetStream.CanRead)
                    {
                        byte[] receivePackage = new byte[bufferSize];

                        int Result = m_NetStream.Read(receivePackage, 0, bufferSize);

                        String str = Encoding.ASCII.GetString(receivePackage, 0, bufferSize);
                        str = str.Trim('\0');

                        String pattern = @"\[";

                        m_Pose = Regex.Split(str, pattern);
                        m_NewPose = true;
                    }
                }
            }    
        }

        private void m_timerSendPose_Tick(object sender, EventArgs e)
        {
            if (m_NewPose && m_StartBit == 0)
            {
                ShowLog("X: " + m_Pose[0]);
                ShowLog("Y: " + m_Pose[1]);
                ShowLog("Z: " + m_Pose[2]);
                ShowLog("A: " + m_Pose[3]);

                int X = int.Parse(m_Pose[0]);
                int Y = int.Parse(m_Pose[1]);
                int Z = int.Parse(m_Pose[2]);
                int A = int.Parse(m_Pose[3]);

                int[] data = { X, Y, Z, A, 90000 };

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
                    int[] data_Start = { 1 };

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

                m_NewPose = false;
            }
        }
    }
}
