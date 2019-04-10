namespace SyntecRemote
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.m_textBox_IP = new System.Windows.Forms.TextBox();
            this.m_label_IP = new System.Windows.Forms.Label();
            this.m_button_Connect = new System.Windows.Forms.Button();
            this.m_groupBoxInfo = new System.Windows.Forms.GroupBox();
            this.m_tabControlPosition = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.m_labelJoint6Val = new System.Windows.Forms.Label();
            this.m_labelJoint1Name = new System.Windows.Forms.Label();
            this.m_labelJoint5Val = new System.Windows.Forms.Label();
            this.m_labelJoint2Name = new System.Windows.Forms.Label();
            this.m_labelJoint4Val = new System.Windows.Forms.Label();
            this.m_labelJoint3Name = new System.Windows.Forms.Label();
            this.m_labelJoint3Val = new System.Windows.Forms.Label();
            this.m_labelJoint4Name = new System.Windows.Forms.Label();
            this.m_labelJoint2Val = new System.Windows.Forms.Label();
            this.m_labelJoint5Name = new System.Windows.Forms.Label();
            this.m_labelJoint1Val = new System.Windows.Forms.Label();
            this.m_labelJoint6Name = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.m_labelCVal = new System.Windows.Forms.Label();
            this.m_labelBVal = new System.Windows.Forms.Label();
            this.m_labelAVal = new System.Windows.Forms.Label();
            this.m_labelZVal = new System.Windows.Forms.Label();
            this.m_labelYVal = new System.Windows.Forms.Label();
            this.m_labelXVal = new System.Windows.Forms.Label();
            this.m_labelC = new System.Windows.Forms.Label();
            this.m_labelB = new System.Windows.Forms.Label();
            this.m_labelA = new System.Windows.Forms.Label();
            this.m_labelZ = new System.Windows.Forms.Label();
            this.m_labelY = new System.Windows.Forms.Label();
            this.m_labelX = new System.Windows.Forms.Label();
            this.m_groupBoxIP = new System.Windows.Forms.GroupBox();
            this.m_listBoxLog = new System.Windows.Forms.ListBox();
            this.m_timerReadPos = new System.Windows.Forms.Timer(this.components);
            this.m_groupBoxRWbit = new System.Windows.Forms.GroupBox();
            this.m_textBoxBitVal = new System.Windows.Forms.TextBox();
            this.m_labelBitVal = new System.Windows.Forms.Label();
            this.m_labelBitNum = new System.Windows.Forms.Label();
            this.m_textBoxBitNo = new System.Windows.Forms.TextBox();
            this.m_labelBitType = new System.Windows.Forms.Label();
            this.m_labelBitMode = new System.Windows.Forms.Label();
            this.m_comboBoxTypeBit = new System.Windows.Forms.ComboBox();
            this.m_comboBoxModebit = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.m_labelR50010Val = new System.Windows.Forms.Label();
            this.m_labelR50004Val = new System.Windows.Forms.Label();
            this.m_labelR50003Val = new System.Windows.Forms.Label();
            this.m_labelR50002Val = new System.Windows.Forms.Label();
            this.m_labelR50001Val = new System.Windows.Forms.Label();
            this.m_labelR50000Val = new System.Windows.Forms.Label();
            this.m_labelR50010 = new System.Windows.Forms.Label();
            this.m_label50004 = new System.Windows.Forms.Label();
            this.m_labelR50003 = new System.Windows.Forms.Label();
            this.m_label50002 = new System.Windows.Forms.Label();
            this.m_labelR50001 = new System.Windows.Forms.Label();
            this.m_labelR50000 = new System.Windows.Forms.Label();
            this.m_timerReadRbit = new System.Windows.Forms.Timer(this.components);
            this.m_buttonStart = new System.Windows.Forms.Button();
            this.m_timerSendPose = new System.Windows.Forms.Timer(this.components);
            this.m_groupBoxInfo.SuspendLayout();
            this.m_tabControlPosition.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.m_groupBoxIP.SuspendLayout();
            this.m_groupBoxRWbit.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // m_textBox_IP
            // 
            this.m_textBox_IP.BackColor = System.Drawing.SystemColors.Window;
            this.m_textBox_IP.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.m_textBox_IP.Location = new System.Drawing.Point(50, 22);
            this.m_textBox_IP.Name = "m_textBox_IP";
            this.m_textBox_IP.Size = new System.Drawing.Size(100, 27);
            this.m_textBox_IP.TabIndex = 0;
            // 
            // m_label_IP
            // 
            this.m_label_IP.AutoSize = true;
            this.m_label_IP.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.m_label_IP.Location = new System.Drawing.Point(7, 22);
            this.m_label_IP.Name = "m_label_IP";
            this.m_label_IP.Size = new System.Drawing.Size(37, 24);
            this.m_label_IP.TabIndex = 1;
            this.m_label_IP.Text = "IP:";
            // 
            // m_button_Connect
            // 
            this.m_button_Connect.BackColor = System.Drawing.SystemColors.Control;
            this.m_button_Connect.Font = new System.Drawing.Font("新細明體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.m_button_Connect.Location = new System.Drawing.Point(156, 15);
            this.m_button_Connect.Name = "m_button_Connect";
            this.m_button_Connect.Size = new System.Drawing.Size(104, 37);
            this.m_button_Connect.TabIndex = 2;
            this.m_button_Connect.Text = "Connect";
            this.m_button_Connect.UseVisualStyleBackColor = false;
            this.m_button_Connect.Click += new System.EventHandler(this.m_button_Connect_Click);
            // 
            // m_groupBoxInfo
            // 
            this.m_groupBoxInfo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.m_groupBoxInfo.Controls.Add(this.m_tabControlPosition);
            this.m_groupBoxInfo.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.m_groupBoxInfo.Location = new System.Drawing.Point(782, 68);
            this.m_groupBoxInfo.Name = "m_groupBoxInfo";
            this.m_groupBoxInfo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.m_groupBoxInfo.Size = new System.Drawing.Size(266, 288);
            this.m_groupBoxInfo.TabIndex = 3;
            this.m_groupBoxInfo.TabStop = false;
            this.m_groupBoxInfo.Text = "Position";
            // 
            // m_tabControlPosition
            // 
            this.m_tabControlPosition.Controls.Add(this.tabPage1);
            this.m_tabControlPosition.Controls.Add(this.tabPage2);
            this.m_tabControlPosition.Location = new System.Drawing.Point(6, 15);
            this.m_tabControlPosition.Name = "m_tabControlPosition";
            this.m_tabControlPosition.SelectedIndex = 0;
            this.m_tabControlPosition.Size = new System.Drawing.Size(254, 265);
            this.m_tabControlPosition.TabIndex = 7;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.m_labelJoint6Val);
            this.tabPage1.Controls.Add(this.m_labelJoint1Name);
            this.tabPage1.Controls.Add(this.m_labelJoint5Val);
            this.tabPage1.Controls.Add(this.m_labelJoint2Name);
            this.tabPage1.Controls.Add(this.m_labelJoint4Val);
            this.tabPage1.Controls.Add(this.m_labelJoint3Name);
            this.tabPage1.Controls.Add(this.m_labelJoint3Val);
            this.tabPage1.Controls.Add(this.m_labelJoint4Name);
            this.tabPage1.Controls.Add(this.m_labelJoint2Val);
            this.tabPage1.Controls.Add(this.m_labelJoint5Name);
            this.tabPage1.Controls.Add(this.m_labelJoint1Val);
            this.tabPage1.Controls.Add(this.m_labelJoint6Name);
            this.tabPage1.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tabPage1.Location = new System.Drawing.Point(4, 26);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(246, 235);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Joint";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // m_labelJoint6Val
            // 
            this.m_labelJoint6Val.AutoSize = true;
            this.m_labelJoint6Val.Font = new System.Drawing.Font("新細明體", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.m_labelJoint6Val.Location = new System.Drawing.Point(116, 200);
            this.m_labelJoint6Val.Name = "m_labelJoint6Val";
            this.m_labelJoint6Val.Size = new System.Drawing.Size(30, 32);
            this.m_labelJoint6Val.TabIndex = 11;
            this.m_labelJoint6Val.Text = "0";
            this.m_labelJoint6Val.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // m_labelJoint1Name
            // 
            this.m_labelJoint1Name.AutoSize = true;
            this.m_labelJoint1Name.Font = new System.Drawing.Font("新細明體", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.m_labelJoint1Name.Location = new System.Drawing.Point(6, 3);
            this.m_labelJoint1Name.Name = "m_labelJoint1Name";
            this.m_labelJoint1Name.Size = new System.Drawing.Size(104, 32);
            this.m_labelJoint1Name.TabIndex = 0;
            this.m_labelJoint1Name.Text = "Joint 1:";
            // 
            // m_labelJoint5Val
            // 
            this.m_labelJoint5Val.AutoSize = true;
            this.m_labelJoint5Val.Font = new System.Drawing.Font("新細明體", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.m_labelJoint5Val.Location = new System.Drawing.Point(116, 156);
            this.m_labelJoint5Val.Name = "m_labelJoint5Val";
            this.m_labelJoint5Val.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.m_labelJoint5Val.Size = new System.Drawing.Size(30, 32);
            this.m_labelJoint5Val.TabIndex = 10;
            this.m_labelJoint5Val.Text = "0";
            // 
            // m_labelJoint2Name
            // 
            this.m_labelJoint2Name.AutoSize = true;
            this.m_labelJoint2Name.Font = new System.Drawing.Font("新細明體", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.m_labelJoint2Name.Location = new System.Drawing.Point(6, 40);
            this.m_labelJoint2Name.Name = "m_labelJoint2Name";
            this.m_labelJoint2Name.Size = new System.Drawing.Size(104, 32);
            this.m_labelJoint2Name.TabIndex = 1;
            this.m_labelJoint2Name.Text = "Joint 2:";
            // 
            // m_labelJoint4Val
            // 
            this.m_labelJoint4Val.AutoSize = true;
            this.m_labelJoint4Val.Font = new System.Drawing.Font("新細明體", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.m_labelJoint4Val.Location = new System.Drawing.Point(116, 117);
            this.m_labelJoint4Val.Name = "m_labelJoint4Val";
            this.m_labelJoint4Val.Size = new System.Drawing.Size(30, 32);
            this.m_labelJoint4Val.TabIndex = 9;
            this.m_labelJoint4Val.Text = "0";
            // 
            // m_labelJoint3Name
            // 
            this.m_labelJoint3Name.AutoSize = true;
            this.m_labelJoint3Name.Font = new System.Drawing.Font("新細明體", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.m_labelJoint3Name.Location = new System.Drawing.Point(6, 78);
            this.m_labelJoint3Name.Name = "m_labelJoint3Name";
            this.m_labelJoint3Name.Size = new System.Drawing.Size(104, 32);
            this.m_labelJoint3Name.TabIndex = 2;
            this.m_labelJoint3Name.Text = "Joint 3:";
            // 
            // m_labelJoint3Val
            // 
            this.m_labelJoint3Val.AutoSize = true;
            this.m_labelJoint3Val.Font = new System.Drawing.Font("新細明體", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.m_labelJoint3Val.Location = new System.Drawing.Point(116, 78);
            this.m_labelJoint3Val.Name = "m_labelJoint3Val";
            this.m_labelJoint3Val.Size = new System.Drawing.Size(30, 32);
            this.m_labelJoint3Val.TabIndex = 8;
            this.m_labelJoint3Val.Text = "0";
            // 
            // m_labelJoint4Name
            // 
            this.m_labelJoint4Name.AutoSize = true;
            this.m_labelJoint4Name.Font = new System.Drawing.Font("新細明體", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.m_labelJoint4Name.Location = new System.Drawing.Point(6, 117);
            this.m_labelJoint4Name.Name = "m_labelJoint4Name";
            this.m_labelJoint4Name.Size = new System.Drawing.Size(104, 32);
            this.m_labelJoint4Name.TabIndex = 3;
            this.m_labelJoint4Name.Text = "Joint 4:";
            // 
            // m_labelJoint2Val
            // 
            this.m_labelJoint2Val.AutoSize = true;
            this.m_labelJoint2Val.Font = new System.Drawing.Font("新細明體", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.m_labelJoint2Val.Location = new System.Drawing.Point(116, 40);
            this.m_labelJoint2Val.Name = "m_labelJoint2Val";
            this.m_labelJoint2Val.Size = new System.Drawing.Size(30, 32);
            this.m_labelJoint2Val.TabIndex = 7;
            this.m_labelJoint2Val.Text = "0";
            // 
            // m_labelJoint5Name
            // 
            this.m_labelJoint5Name.AutoSize = true;
            this.m_labelJoint5Name.Font = new System.Drawing.Font("新細明體", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.m_labelJoint5Name.Location = new System.Drawing.Point(6, 156);
            this.m_labelJoint5Name.Name = "m_labelJoint5Name";
            this.m_labelJoint5Name.Size = new System.Drawing.Size(104, 32);
            this.m_labelJoint5Name.TabIndex = 4;
            this.m_labelJoint5Name.Text = "Joint 5:";
            // 
            // m_labelJoint1Val
            // 
            this.m_labelJoint1Val.AutoSize = true;
            this.m_labelJoint1Val.Font = new System.Drawing.Font("新細明體", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.m_labelJoint1Val.Location = new System.Drawing.Point(116, 3);
            this.m_labelJoint1Val.Name = "m_labelJoint1Val";
            this.m_labelJoint1Val.Size = new System.Drawing.Size(30, 32);
            this.m_labelJoint1Val.TabIndex = 6;
            this.m_labelJoint1Val.Text = "0";
            // 
            // m_labelJoint6Name
            // 
            this.m_labelJoint6Name.AutoSize = true;
            this.m_labelJoint6Name.Font = new System.Drawing.Font("新細明體", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.m_labelJoint6Name.Location = new System.Drawing.Point(6, 196);
            this.m_labelJoint6Name.Name = "m_labelJoint6Name";
            this.m_labelJoint6Name.Size = new System.Drawing.Size(104, 32);
            this.m_labelJoint6Name.TabIndex = 5;
            this.m_labelJoint6Name.Text = "Joint 6:";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.m_labelCVal);
            this.tabPage2.Controls.Add(this.m_labelBVal);
            this.tabPage2.Controls.Add(this.m_labelAVal);
            this.tabPage2.Controls.Add(this.m_labelZVal);
            this.tabPage2.Controls.Add(this.m_labelYVal);
            this.tabPage2.Controls.Add(this.m_labelXVal);
            this.tabPage2.Controls.Add(this.m_labelC);
            this.tabPage2.Controls.Add(this.m_labelB);
            this.tabPage2.Controls.Add(this.m_labelA);
            this.tabPage2.Controls.Add(this.m_labelZ);
            this.tabPage2.Controls.Add(this.m_labelY);
            this.tabPage2.Controls.Add(this.m_labelX);
            this.tabPage2.Font = new System.Drawing.Font("新細明體", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tabPage2.Location = new System.Drawing.Point(4, 26);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(246, 235);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "World";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // m_labelCVal
            // 
            this.m_labelCVal.AutoSize = true;
            this.m_labelCVal.Font = new System.Drawing.Font("新細明體", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.m_labelCVal.Location = new System.Drawing.Point(118, 195);
            this.m_labelCVal.Name = "m_labelCVal";
            this.m_labelCVal.Size = new System.Drawing.Size(30, 32);
            this.m_labelCVal.TabIndex = 11;
            this.m_labelCVal.Text = "0";
            // 
            // m_labelBVal
            // 
            this.m_labelBVal.AutoSize = true;
            this.m_labelBVal.Font = new System.Drawing.Font("新細明體", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.m_labelBVal.Location = new System.Drawing.Point(118, 156);
            this.m_labelBVal.Name = "m_labelBVal";
            this.m_labelBVal.Size = new System.Drawing.Size(30, 32);
            this.m_labelBVal.TabIndex = 10;
            this.m_labelBVal.Text = "0";
            // 
            // m_labelAVal
            // 
            this.m_labelAVal.AutoSize = true;
            this.m_labelAVal.Font = new System.Drawing.Font("新細明體", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.m_labelAVal.Location = new System.Drawing.Point(118, 118);
            this.m_labelAVal.Name = "m_labelAVal";
            this.m_labelAVal.Size = new System.Drawing.Size(30, 32);
            this.m_labelAVal.TabIndex = 9;
            this.m_labelAVal.Text = "0";
            // 
            // m_labelZVal
            // 
            this.m_labelZVal.AutoSize = true;
            this.m_labelZVal.Font = new System.Drawing.Font("新細明體", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.m_labelZVal.Location = new System.Drawing.Point(118, 81);
            this.m_labelZVal.Name = "m_labelZVal";
            this.m_labelZVal.Size = new System.Drawing.Size(30, 32);
            this.m_labelZVal.TabIndex = 8;
            this.m_labelZVal.Text = "0";
            // 
            // m_labelYVal
            // 
            this.m_labelYVal.AutoSize = true;
            this.m_labelYVal.Font = new System.Drawing.Font("新細明體", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.m_labelYVal.Location = new System.Drawing.Point(118, 44);
            this.m_labelYVal.Name = "m_labelYVal";
            this.m_labelYVal.Size = new System.Drawing.Size(30, 32);
            this.m_labelYVal.TabIndex = 7;
            this.m_labelYVal.Text = "0";
            // 
            // m_labelXVal
            // 
            this.m_labelXVal.AutoSize = true;
            this.m_labelXVal.Font = new System.Drawing.Font("新細明體", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.m_labelXVal.Location = new System.Drawing.Point(118, 7);
            this.m_labelXVal.Name = "m_labelXVal";
            this.m_labelXVal.Size = new System.Drawing.Size(30, 32);
            this.m_labelXVal.TabIndex = 6;
            this.m_labelXVal.Text = "0";
            // 
            // m_labelC
            // 
            this.m_labelC.AutoSize = true;
            this.m_labelC.Font = new System.Drawing.Font("新細明體", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.m_labelC.Location = new System.Drawing.Point(7, 195);
            this.m_labelC.Name = "m_labelC";
            this.m_labelC.Size = new System.Drawing.Size(43, 32);
            this.m_labelC.TabIndex = 5;
            this.m_labelC.Text = "C:";
            // 
            // m_labelB
            // 
            this.m_labelB.AutoSize = true;
            this.m_labelB.Font = new System.Drawing.Font("新細明體", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.m_labelB.Location = new System.Drawing.Point(7, 156);
            this.m_labelB.Name = "m_labelB";
            this.m_labelB.Size = new System.Drawing.Size(43, 32);
            this.m_labelB.TabIndex = 4;
            this.m_labelB.Text = "B:";
            // 
            // m_labelA
            // 
            this.m_labelA.AutoSize = true;
            this.m_labelA.Font = new System.Drawing.Font("新細明體", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.m_labelA.Location = new System.Drawing.Point(7, 118);
            this.m_labelA.Name = "m_labelA";
            this.m_labelA.Size = new System.Drawing.Size(45, 32);
            this.m_labelA.TabIndex = 3;
            this.m_labelA.Text = "A:";
            // 
            // m_labelZ
            // 
            this.m_labelZ.AutoSize = true;
            this.m_labelZ.Font = new System.Drawing.Font("新細明體", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.m_labelZ.Location = new System.Drawing.Point(7, 81);
            this.m_labelZ.Name = "m_labelZ";
            this.m_labelZ.Size = new System.Drawing.Size(41, 32);
            this.m_labelZ.TabIndex = 2;
            this.m_labelZ.Text = "Z:";
            // 
            // m_labelY
            // 
            this.m_labelY.AutoSize = true;
            this.m_labelY.Font = new System.Drawing.Font("新細明體", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.m_labelY.Location = new System.Drawing.Point(7, 44);
            this.m_labelY.Name = "m_labelY";
            this.m_labelY.Size = new System.Drawing.Size(45, 32);
            this.m_labelY.TabIndex = 1;
            this.m_labelY.Text = "Y:";
            // 
            // m_labelX
            // 
            this.m_labelX.AutoSize = true;
            this.m_labelX.Font = new System.Drawing.Font("新細明體", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.m_labelX.Location = new System.Drawing.Point(7, 7);
            this.m_labelX.Name = "m_labelX";
            this.m_labelX.Size = new System.Drawing.Size(45, 32);
            this.m_labelX.TabIndex = 0;
            this.m_labelX.Text = "X:";
            // 
            // m_groupBoxIP
            // 
            this.m_groupBoxIP.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.m_groupBoxIP.Controls.Add(this.m_label_IP);
            this.m_groupBoxIP.Controls.Add(this.m_textBox_IP);
            this.m_groupBoxIP.Controls.Add(this.m_button_Connect);
            this.m_groupBoxIP.Location = new System.Drawing.Point(782, 2);
            this.m_groupBoxIP.Name = "m_groupBoxIP";
            this.m_groupBoxIP.Size = new System.Drawing.Size(266, 60);
            this.m_groupBoxIP.TabIndex = 4;
            this.m_groupBoxIP.TabStop = false;
            // 
            // m_listBoxLog
            // 
            this.m_listBoxLog.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.m_listBoxLog.FormattingEnabled = true;
            this.m_listBoxLog.ItemHeight = 12;
            this.m_listBoxLog.Location = new System.Drawing.Point(18, 362);
            this.m_listBoxLog.Name = "m_listBoxLog";
            this.m_listBoxLog.Size = new System.Drawing.Size(758, 172);
            this.m_listBoxLog.TabIndex = 5;
            // 
            // m_timerReadPos
            // 
            this.m_timerReadPos.Interval = 5;
            this.m_timerReadPos.Tick += new System.EventHandler(this.m_timerReadPos_Tick);
            // 
            // m_groupBoxRWbit
            // 
            this.m_groupBoxRWbit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.m_groupBoxRWbit.Controls.Add(this.m_textBoxBitVal);
            this.m_groupBoxRWbit.Controls.Add(this.m_labelBitVal);
            this.m_groupBoxRWbit.Controls.Add(this.m_labelBitNum);
            this.m_groupBoxRWbit.Controls.Add(this.m_textBoxBitNo);
            this.m_groupBoxRWbit.Controls.Add(this.m_labelBitType);
            this.m_groupBoxRWbit.Controls.Add(this.m_labelBitMode);
            this.m_groupBoxRWbit.Controls.Add(this.m_comboBoxTypeBit);
            this.m_groupBoxRWbit.Controls.Add(this.m_comboBoxModebit);
            this.m_groupBoxRWbit.Location = new System.Drawing.Point(782, 355);
            this.m_groupBoxRWbit.Name = "m_groupBoxRWbit";
            this.m_groupBoxRWbit.Size = new System.Drawing.Size(266, 184);
            this.m_groupBoxRWbit.TabIndex = 6;
            this.m_groupBoxRWbit.TabStop = false;
            // 
            // m_textBoxBitVal
            // 
            this.m_textBoxBitVal.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.m_textBoxBitVal.Location = new System.Drawing.Point(134, 138);
            this.m_textBoxBitVal.Name = "m_textBoxBitVal";
            this.m_textBoxBitVal.Size = new System.Drawing.Size(124, 33);
            this.m_textBoxBitVal.TabIndex = 7;
            this.m_textBoxBitVal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.m_textBoxBitVal_KeyPress);
            // 
            // m_labelBitVal
            // 
            this.m_labelBitVal.AutoSize = true;
            this.m_labelBitVal.Font = new System.Drawing.Font("新細明體", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.m_labelBitVal.Location = new System.Drawing.Point(6, 139);
            this.m_labelBitVal.Name = "m_labelBitVal";
            this.m_labelBitVal.Size = new System.Drawing.Size(94, 32);
            this.m_labelBitVal.TabIndex = 6;
            this.m_labelBitVal.Text = "Value:";
            // 
            // m_labelBitNum
            // 
            this.m_labelBitNum.AutoSize = true;
            this.m_labelBitNum.Font = new System.Drawing.Font("新細明體", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.m_labelBitNum.Location = new System.Drawing.Point(6, 100);
            this.m_labelBitNum.Name = "m_labelBitNum";
            this.m_labelBitNum.Size = new System.Drawing.Size(60, 32);
            this.m_labelBitNum.TabIndex = 5;
            this.m_labelBitNum.Text = "No.";
            // 
            // m_textBoxBitNo
            // 
            this.m_textBoxBitNo.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.m_textBoxBitNo.Location = new System.Drawing.Point(134, 100);
            this.m_textBoxBitNo.Name = "m_textBoxBitNo";
            this.m_textBoxBitNo.Size = new System.Drawing.Size(124, 33);
            this.m_textBoxBitNo.TabIndex = 4;
            this.m_textBoxBitNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.m_textBoxBitNo_KeyPress);
            // 
            // m_labelBitType
            // 
            this.m_labelBitType.AutoSize = true;
            this.m_labelBitType.Font = new System.Drawing.Font("新細明體", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.m_labelBitType.Location = new System.Drawing.Point(6, 60);
            this.m_labelBitType.Name = "m_labelBitType";
            this.m_labelBitType.Size = new System.Drawing.Size(84, 32);
            this.m_labelBitType.TabIndex = 3;
            this.m_labelBitType.Text = "Type:";
            // 
            // m_labelBitMode
            // 
            this.m_labelBitMode.AutoSize = true;
            this.m_labelBitMode.Font = new System.Drawing.Font("新細明體", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.m_labelBitMode.Location = new System.Drawing.Point(6, 18);
            this.m_labelBitMode.Name = "m_labelBitMode";
            this.m_labelBitMode.Size = new System.Drawing.Size(93, 32);
            this.m_labelBitMode.TabIndex = 2;
            this.m_labelBitMode.Text = "Mode:";
            // 
            // m_comboBoxTypeBit
            // 
            this.m_comboBoxTypeBit.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.m_comboBoxTypeBit.FormattingEnabled = true;
            this.m_comboBoxTypeBit.Location = new System.Drawing.Point(190, 60);
            this.m_comboBoxTypeBit.Name = "m_comboBoxTypeBit";
            this.m_comboBoxTypeBit.Size = new System.Drawing.Size(68, 29);
            this.m_comboBoxTypeBit.TabIndex = 1;
            this.m_comboBoxTypeBit.SelectedIndexChanged += new System.EventHandler(this.m_comboBoxTypeBit_SelectedIndexChanged);
            // 
            // m_comboBoxModebit
            // 
            this.m_comboBoxModebit.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.m_comboBoxModebit.FormattingEnabled = true;
            this.m_comboBoxModebit.Location = new System.Drawing.Point(190, 18);
            this.m_comboBoxModebit.Name = "m_comboBoxModebit";
            this.m_comboBoxModebit.Size = new System.Drawing.Size(66, 29);
            this.m_comboBoxModebit.TabIndex = 0;
            this.m_comboBoxModebit.SelectedIndexChanged += new System.EventHandler(this.m_comboBoxModebit_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.m_labelR50010Val);
            this.groupBox1.Controls.Add(this.m_labelR50004Val);
            this.groupBox1.Controls.Add(this.m_labelR50003Val);
            this.groupBox1.Controls.Add(this.m_labelR50002Val);
            this.groupBox1.Controls.Add(this.m_labelR50001Val);
            this.groupBox1.Controls.Add(this.m_labelR50000Val);
            this.groupBox1.Controls.Add(this.m_labelR50010);
            this.groupBox1.Controls.Add(this.m_label50004);
            this.groupBox1.Controls.Add(this.m_labelR50003);
            this.groupBox1.Controls.Add(this.m_label50002);
            this.groupBox1.Controls.Add(this.m_labelR50001);
            this.groupBox1.Controls.Add(this.m_labelR50000);
            this.groupBox1.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox1.Location = new System.Drawing.Point(482, 83);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(288, 273);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "R Bit Table";
            // 
            // m_labelR50010Val
            // 
            this.m_labelR50010Val.AutoSize = true;
            this.m_labelR50010Val.Location = new System.Drawing.Point(167, 222);
            this.m_labelR50010Val.Name = "m_labelR50010Val";
            this.m_labelR50010Val.Size = new System.Drawing.Size(21, 24);
            this.m_labelR50010Val.TabIndex = 11;
            this.m_labelR50010Val.Text = "0";
            // 
            // m_labelR50004Val
            // 
            this.m_labelR50004Val.AutoSize = true;
            this.m_labelR50004Val.Location = new System.Drawing.Point(167, 183);
            this.m_labelR50004Val.Name = "m_labelR50004Val";
            this.m_labelR50004Val.Size = new System.Drawing.Size(21, 24);
            this.m_labelR50004Val.TabIndex = 10;
            this.m_labelR50004Val.Text = "0";
            // 
            // m_labelR50003Val
            // 
            this.m_labelR50003Val.AutoSize = true;
            this.m_labelR50003Val.Location = new System.Drawing.Point(167, 145);
            this.m_labelR50003Val.Name = "m_labelR50003Val";
            this.m_labelR50003Val.Size = new System.Drawing.Size(21, 24);
            this.m_labelR50003Val.TabIndex = 9;
            this.m_labelR50003Val.Text = "0";
            // 
            // m_labelR50002Val
            // 
            this.m_labelR50002Val.AutoSize = true;
            this.m_labelR50002Val.Location = new System.Drawing.Point(167, 108);
            this.m_labelR50002Val.Name = "m_labelR50002Val";
            this.m_labelR50002Val.Size = new System.Drawing.Size(21, 24);
            this.m_labelR50002Val.TabIndex = 8;
            this.m_labelR50002Val.Text = "0";
            // 
            // m_labelR50001Val
            // 
            this.m_labelR50001Val.AutoSize = true;
            this.m_labelR50001Val.Location = new System.Drawing.Point(167, 71);
            this.m_labelR50001Val.Name = "m_labelR50001Val";
            this.m_labelR50001Val.Size = new System.Drawing.Size(21, 24);
            this.m_labelR50001Val.TabIndex = 7;
            this.m_labelR50001Val.Text = "0";
            // 
            // m_labelR50000Val
            // 
            this.m_labelR50000Val.AutoSize = true;
            this.m_labelR50000Val.Location = new System.Drawing.Point(167, 32);
            this.m_labelR50000Val.Name = "m_labelR50000Val";
            this.m_labelR50000Val.Size = new System.Drawing.Size(21, 24);
            this.m_labelR50000Val.TabIndex = 6;
            this.m_labelR50000Val.Text = "0";
            // 
            // m_labelR50010
            // 
            this.m_labelR50010.AutoSize = true;
            this.m_labelR50010.Location = new System.Drawing.Point(7, 222);
            this.m_labelR50010.Name = "m_labelR50010";
            this.m_labelR50010.Size = new System.Drawing.Size(130, 24);
            this.m_labelR50010.TabIndex = 5;
            this.m_labelR50010.Text = "Start(50010):";
            // 
            // m_label50004
            // 
            this.m_label50004.AutoSize = true;
            this.m_label50004.Location = new System.Drawing.Point(35, 183);
            this.m_label50004.Name = "m_label50004";
            this.m_label50004.Size = new System.Drawing.Size(102, 24);
            this.m_label50004.TabIndex = 4;
            this.m_label50004.Text = "B(50004):";
            // 
            // m_labelR50003
            // 
            this.m_labelR50003.AutoSize = true;
            this.m_labelR50003.Location = new System.Drawing.Point(35, 145);
            this.m_labelR50003.Name = "m_labelR50003";
            this.m_labelR50003.Size = new System.Drawing.Size(103, 24);
            this.m_labelR50003.TabIndex = 3;
            this.m_labelR50003.Text = "A(50003):";
            // 
            // m_label50002
            // 
            this.m_label50002.AutoSize = true;
            this.m_label50002.Location = new System.Drawing.Point(37, 108);
            this.m_label50002.Name = "m_label50002";
            this.m_label50002.Size = new System.Drawing.Size(101, 24);
            this.m_label50002.TabIndex = 2;
            this.m_label50002.Text = "Z(50002):";
            // 
            // m_labelR50001
            // 
            this.m_labelR50001.AutoSize = true;
            this.m_labelR50001.Location = new System.Drawing.Point(34, 71);
            this.m_labelR50001.Name = "m_labelR50001";
            this.m_labelR50001.Size = new System.Drawing.Size(103, 24);
            this.m_labelR50001.TabIndex = 1;
            this.m_labelR50001.Text = "Y(50001):";
            // 
            // m_labelR50000
            // 
            this.m_labelR50000.AutoSize = true;
            this.m_labelR50000.Location = new System.Drawing.Point(34, 32);
            this.m_labelR50000.Name = "m_labelR50000";
            this.m_labelR50000.Size = new System.Drawing.Size(103, 24);
            this.m_labelR50000.TabIndex = 0;
            this.m_labelR50000.Text = "X(50000):";
            // 
            // m_timerReadRbit
            // 
            this.m_timerReadRbit.Interval = 5;
            this.m_timerReadRbit.Tick += new System.EventHandler(this.m_timerReadRbit_Tick);
            // 
            // m_buttonStart
            // 
            this.m_buttonStart.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.m_buttonStart.Location = new System.Drawing.Point(39, 84);
            this.m_buttonStart.Name = "m_buttonStart";
            this.m_buttonStart.Size = new System.Drawing.Size(85, 32);
            this.m_buttonStart.TabIndex = 8;
            this.m_buttonStart.Text = "Start";
            this.m_buttonStart.UseVisualStyleBackColor = true;
            this.m_buttonStart.Click += new System.EventHandler(this.m_buttonStart_Click);
            // 
            // m_timerSendPose
            // 
            this.m_timerSendPose.Tick += new System.EventHandler(this.m_timerSendPose_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1066, 551);
            this.Controls.Add(this.m_buttonStart);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.m_groupBoxRWbit);
            this.Controls.Add(this.m_listBoxLog);
            this.Controls.Add(this.m_groupBoxIP);
            this.Controls.Add(this.m_groupBoxInfo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.m_groupBoxInfo.ResumeLayout(false);
            this.m_tabControlPosition.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.m_groupBoxIP.ResumeLayout(false);
            this.m_groupBoxIP.PerformLayout();
            this.m_groupBoxRWbit.ResumeLayout(false);
            this.m_groupBoxRWbit.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox m_textBox_IP;
        private System.Windows.Forms.Label m_label_IP;
        private System.Windows.Forms.Button m_button_Connect;
        private System.Windows.Forms.GroupBox m_groupBoxInfo;
        private System.Windows.Forms.GroupBox m_groupBoxIP;
        private System.Windows.Forms.Label m_labelJoint3Name;
        private System.Windows.Forms.Label m_labelJoint2Name;
        private System.Windows.Forms.Label m_labelJoint1Name;
        private System.Windows.Forms.Label m_labelJoint6Name;
        private System.Windows.Forms.Label m_labelJoint5Name;
        private System.Windows.Forms.Label m_labelJoint4Name;
        private System.Windows.Forms.Label m_labelJoint6Val;
        private System.Windows.Forms.Label m_labelJoint5Val;
        private System.Windows.Forms.Label m_labelJoint4Val;
        private System.Windows.Forms.Label m_labelJoint3Val;
        private System.Windows.Forms.Label m_labelJoint2Val;
        private System.Windows.Forms.Label m_labelJoint1Val;
        private System.Windows.Forms.ListBox m_listBoxLog;
        private System.Windows.Forms.Timer m_timerReadPos;
        private System.Windows.Forms.GroupBox m_groupBoxRWbit;
        private System.Windows.Forms.Label m_labelBitType;
        private System.Windows.Forms.Label m_labelBitMode;
        private System.Windows.Forms.ComboBox m_comboBoxTypeBit;
        private System.Windows.Forms.ComboBox m_comboBoxModebit;
        private System.Windows.Forms.Label m_labelBitVal;
        private System.Windows.Forms.Label m_labelBitNum;
        private System.Windows.Forms.TextBox m_textBoxBitNo;
        private System.Windows.Forms.TextBox m_textBoxBitVal;
        private System.Windows.Forms.TabControl m_tabControlPosition;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label m_labelCVal;
        private System.Windows.Forms.Label m_labelBVal;
        private System.Windows.Forms.Label m_labelAVal;
        private System.Windows.Forms.Label m_labelZVal;
        private System.Windows.Forms.Label m_labelYVal;
        private System.Windows.Forms.Label m_labelXVal;
        private System.Windows.Forms.Label m_labelC;
        private System.Windows.Forms.Label m_labelB;
        private System.Windows.Forms.Label m_labelA;
        private System.Windows.Forms.Label m_labelZ;
        private System.Windows.Forms.Label m_labelY;
        private System.Windows.Forms.Label m_labelX;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label m_labelR50010;
        private System.Windows.Forms.Label m_label50004;
        private System.Windows.Forms.Label m_labelR50003;
        private System.Windows.Forms.Label m_label50002;
        private System.Windows.Forms.Label m_labelR50001;
        private System.Windows.Forms.Label m_labelR50000;
        private System.Windows.Forms.Label m_labelR50010Val;
        private System.Windows.Forms.Label m_labelR50004Val;
        private System.Windows.Forms.Label m_labelR50003Val;
        private System.Windows.Forms.Label m_labelR50002Val;
        private System.Windows.Forms.Label m_labelR50001Val;
        private System.Windows.Forms.Label m_labelR50000Val;
        private System.Windows.Forms.Timer m_timerReadRbit;
        private System.Windows.Forms.Button m_buttonStart;
        private System.Windows.Forms.Timer m_timerSendPose;
    }
}

