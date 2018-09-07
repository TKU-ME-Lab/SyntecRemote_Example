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
            this.m_labelJoint6Val = new System.Windows.Forms.Label();
            this.m_labelJoint5Val = new System.Windows.Forms.Label();
            this.m_labelJoint4Val = new System.Windows.Forms.Label();
            this.m_labelJoint3Val = new System.Windows.Forms.Label();
            this.m_labelJoint2Val = new System.Windows.Forms.Label();
            this.m_labelJoint1Val = new System.Windows.Forms.Label();
            this.m_labelJoint6Name = new System.Windows.Forms.Label();
            this.m_labelJoint5Name = new System.Windows.Forms.Label();
            this.m_labelJoint4Name = new System.Windows.Forms.Label();
            this.m_labelJoint3Name = new System.Windows.Forms.Label();
            this.m_labelJoint2Name = new System.Windows.Forms.Label();
            this.m_labelJoint1Name = new System.Windows.Forms.Label();
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
            this.m_groupBoxInfo.SuspendLayout();
            this.m_groupBoxIP.SuspendLayout();
            this.m_groupBoxRWbit.SuspendLayout();
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
            this.m_button_Connect.Location = new System.Drawing.Point(156, 13);
            this.m_button_Connect.Name = "m_button_Connect";
            this.m_button_Connect.Size = new System.Drawing.Size(66, 37);
            this.m_button_Connect.TabIndex = 2;
            this.m_button_Connect.Text = "Connect";
            this.m_button_Connect.UseVisualStyleBackColor = false;
            this.m_button_Connect.Click += new System.EventHandler(this.m_button_Connect_Click);
            // 
            // m_groupBoxInfo
            // 
            this.m_groupBoxInfo.Controls.Add(this.m_labelJoint6Val);
            this.m_groupBoxInfo.Controls.Add(this.m_labelJoint5Val);
            this.m_groupBoxInfo.Controls.Add(this.m_labelJoint4Val);
            this.m_groupBoxInfo.Controls.Add(this.m_labelJoint3Val);
            this.m_groupBoxInfo.Controls.Add(this.m_labelJoint2Val);
            this.m_groupBoxInfo.Controls.Add(this.m_labelJoint1Val);
            this.m_groupBoxInfo.Controls.Add(this.m_labelJoint6Name);
            this.m_groupBoxInfo.Controls.Add(this.m_labelJoint5Name);
            this.m_groupBoxInfo.Controls.Add(this.m_labelJoint4Name);
            this.m_groupBoxInfo.Controls.Add(this.m_labelJoint3Name);
            this.m_groupBoxInfo.Controls.Add(this.m_labelJoint2Name);
            this.m_groupBoxInfo.Controls.Add(this.m_labelJoint1Name);
            this.m_groupBoxInfo.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.m_groupBoxInfo.Location = new System.Drawing.Point(814, 68);
            this.m_groupBoxInfo.Name = "m_groupBoxInfo";
            this.m_groupBoxInfo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.m_groupBoxInfo.Size = new System.Drawing.Size(228, 255);
            this.m_groupBoxInfo.TabIndex = 3;
            this.m_groupBoxInfo.TabStop = false;
            this.m_groupBoxInfo.Text = "Position";
            // 
            // m_labelJoint6Val
            // 
            this.m_labelJoint6Val.AutoSize = true;
            this.m_labelJoint6Val.Font = new System.Drawing.Font("新細明體", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.m_labelJoint6Val.Location = new System.Drawing.Point(150, 220);
            this.m_labelJoint6Val.Name = "m_labelJoint6Val";
            this.m_labelJoint6Val.Size = new System.Drawing.Size(30, 32);
            this.m_labelJoint6Val.TabIndex = 11;
            this.m_labelJoint6Val.Text = "0";
            // 
            // m_labelJoint5Val
            // 
            this.m_labelJoint5Val.AutoSize = true;
            this.m_labelJoint5Val.Font = new System.Drawing.Font("新細明體", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.m_labelJoint5Val.Location = new System.Drawing.Point(150, 180);
            this.m_labelJoint5Val.Name = "m_labelJoint5Val";
            this.m_labelJoint5Val.Size = new System.Drawing.Size(30, 32);
            this.m_labelJoint5Val.TabIndex = 10;
            this.m_labelJoint5Val.Text = "0";
            // 
            // m_labelJoint4Val
            // 
            this.m_labelJoint4Val.AutoSize = true;
            this.m_labelJoint4Val.Font = new System.Drawing.Font("新細明體", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.m_labelJoint4Val.Location = new System.Drawing.Point(150, 139);
            this.m_labelJoint4Val.Name = "m_labelJoint4Val";
            this.m_labelJoint4Val.Size = new System.Drawing.Size(30, 32);
            this.m_labelJoint4Val.TabIndex = 9;
            this.m_labelJoint4Val.Text = "0";
            // 
            // m_labelJoint3Val
            // 
            this.m_labelJoint3Val.AutoSize = true;
            this.m_labelJoint3Val.Font = new System.Drawing.Font("新細明體", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.m_labelJoint3Val.Location = new System.Drawing.Point(151, 100);
            this.m_labelJoint3Val.Name = "m_labelJoint3Val";
            this.m_labelJoint3Val.Size = new System.Drawing.Size(30, 32);
            this.m_labelJoint3Val.TabIndex = 8;
            this.m_labelJoint3Val.Text = "0";
            // 
            // m_labelJoint2Val
            // 
            this.m_labelJoint2Val.AutoSize = true;
            this.m_labelJoint2Val.Font = new System.Drawing.Font("新細明體", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.m_labelJoint2Val.Location = new System.Drawing.Point(151, 60);
            this.m_labelJoint2Val.Name = "m_labelJoint2Val";
            this.m_labelJoint2Val.Size = new System.Drawing.Size(30, 32);
            this.m_labelJoint2Val.TabIndex = 7;
            this.m_labelJoint2Val.Text = "0";
            // 
            // m_labelJoint1Val
            // 
            this.m_labelJoint1Val.AutoSize = true;
            this.m_labelJoint1Val.Font = new System.Drawing.Font("新細明體", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.m_labelJoint1Val.Location = new System.Drawing.Point(150, 21);
            this.m_labelJoint1Val.Name = "m_labelJoint1Val";
            this.m_labelJoint1Val.Size = new System.Drawing.Size(30, 32);
            this.m_labelJoint1Val.TabIndex = 6;
            this.m_labelJoint1Val.Text = "0";
            // 
            // m_labelJoint6Name
            // 
            this.m_labelJoint6Name.AutoSize = true;
            this.m_labelJoint6Name.Font = new System.Drawing.Font("新細明體", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.m_labelJoint6Name.Location = new System.Drawing.Point(7, 220);
            this.m_labelJoint6Name.Name = "m_labelJoint6Name";
            this.m_labelJoint6Name.Size = new System.Drawing.Size(104, 32);
            this.m_labelJoint6Name.TabIndex = 5;
            this.m_labelJoint6Name.Text = "Joint 6:";
            // 
            // m_labelJoint5Name
            // 
            this.m_labelJoint5Name.AutoSize = true;
            this.m_labelJoint5Name.Font = new System.Drawing.Font("新細明體", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.m_labelJoint5Name.Location = new System.Drawing.Point(7, 180);
            this.m_labelJoint5Name.Name = "m_labelJoint5Name";
            this.m_labelJoint5Name.Size = new System.Drawing.Size(104, 32);
            this.m_labelJoint5Name.TabIndex = 4;
            this.m_labelJoint5Name.Text = "Joint 5:";
            // 
            // m_labelJoint4Name
            // 
            this.m_labelJoint4Name.AutoSize = true;
            this.m_labelJoint4Name.Font = new System.Drawing.Font("新細明體", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.m_labelJoint4Name.Location = new System.Drawing.Point(7, 139);
            this.m_labelJoint4Name.Name = "m_labelJoint4Name";
            this.m_labelJoint4Name.Size = new System.Drawing.Size(104, 32);
            this.m_labelJoint4Name.TabIndex = 3;
            this.m_labelJoint4Name.Text = "Joint 4:";
            // 
            // m_labelJoint3Name
            // 
            this.m_labelJoint3Name.AutoSize = true;
            this.m_labelJoint3Name.Font = new System.Drawing.Font("新細明體", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.m_labelJoint3Name.Location = new System.Drawing.Point(7, 100);
            this.m_labelJoint3Name.Name = "m_labelJoint3Name";
            this.m_labelJoint3Name.Size = new System.Drawing.Size(104, 32);
            this.m_labelJoint3Name.TabIndex = 2;
            this.m_labelJoint3Name.Text = "Joint 3:";
            // 
            // m_labelJoint2Name
            // 
            this.m_labelJoint2Name.AutoSize = true;
            this.m_labelJoint2Name.Font = new System.Drawing.Font("新細明體", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.m_labelJoint2Name.Location = new System.Drawing.Point(7, 60);
            this.m_labelJoint2Name.Name = "m_labelJoint2Name";
            this.m_labelJoint2Name.Size = new System.Drawing.Size(104, 32);
            this.m_labelJoint2Name.TabIndex = 1;
            this.m_labelJoint2Name.Text = "Joint 2:";
            // 
            // m_labelJoint1Name
            // 
            this.m_labelJoint1Name.AutoSize = true;
            this.m_labelJoint1Name.Font = new System.Drawing.Font("新細明體", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.m_labelJoint1Name.Location = new System.Drawing.Point(7, 18);
            this.m_labelJoint1Name.Name = "m_labelJoint1Name";
            this.m_labelJoint1Name.Size = new System.Drawing.Size(104, 32);
            this.m_labelJoint1Name.TabIndex = 0;
            this.m_labelJoint1Name.Text = "Joint 1:";
            // 
            // m_groupBoxIP
            // 
            this.m_groupBoxIP.Controls.Add(this.m_label_IP);
            this.m_groupBoxIP.Controls.Add(this.m_textBox_IP);
            this.m_groupBoxIP.Controls.Add(this.m_button_Connect);
            this.m_groupBoxIP.Location = new System.Drawing.Point(814, 2);
            this.m_groupBoxIP.Name = "m_groupBoxIP";
            this.m_groupBoxIP.Size = new System.Drawing.Size(228, 60);
            this.m_groupBoxIP.TabIndex = 4;
            this.m_groupBoxIP.TabStop = false;
            // 
            // m_listBoxLog
            // 
            this.m_listBoxLog.FormattingEnabled = true;
            this.m_listBoxLog.ItemHeight = 12;
            this.m_listBoxLog.Location = new System.Drawing.Point(12, 398);
            this.m_listBoxLog.Name = "m_listBoxLog";
            this.m_listBoxLog.Size = new System.Drawing.Size(796, 136);
            this.m_listBoxLog.TabIndex = 5;
            // 
            // m_timerReadPos
            // 
            this.m_timerReadPos.Interval = 1;
            this.m_timerReadPos.Tick += new System.EventHandler(this.m_timerReadPos_Tick);
            // 
            // m_groupBoxRWbit
            // 
            this.m_groupBoxRWbit.Controls.Add(this.m_textBoxBitVal);
            this.m_groupBoxRWbit.Controls.Add(this.m_labelBitVal);
            this.m_groupBoxRWbit.Controls.Add(this.m_labelBitNum);
            this.m_groupBoxRWbit.Controls.Add(this.m_textBoxBitNo);
            this.m_groupBoxRWbit.Controls.Add(this.m_labelBitType);
            this.m_groupBoxRWbit.Controls.Add(this.m_labelBitMode);
            this.m_groupBoxRWbit.Controls.Add(this.m_comboBoxTypeBit);
            this.m_groupBoxRWbit.Controls.Add(this.m_comboBoxModebit);
            this.m_groupBoxRWbit.Location = new System.Drawing.Point(814, 335);
            this.m_groupBoxRWbit.Name = "m_groupBoxRWbit";
            this.m_groupBoxRWbit.Size = new System.Drawing.Size(228, 204);
            this.m_groupBoxRWbit.TabIndex = 6;
            this.m_groupBoxRWbit.TabStop = false;
            // 
            // m_textBoxBitVal
            // 
            this.m_textBoxBitVal.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.m_textBoxBitVal.Location = new System.Drawing.Point(98, 139);
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
            this.m_labelBitVal.Size = new System.Drawing.Size(86, 32);
            this.m_labelBitVal.TabIndex = 6;
            this.m_labelBitVal.Text = "Value";
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
            this.m_textBoxBitNo.Location = new System.Drawing.Point(98, 100);
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
            this.m_labelBitType.Size = new System.Drawing.Size(76, 32);
            this.m_labelBitType.TabIndex = 3;
            this.m_labelBitType.Text = "Type";
            // 
            // m_labelBitMode
            // 
            this.m_labelBitMode.AutoSize = true;
            this.m_labelBitMode.Font = new System.Drawing.Font("新細明體", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.m_labelBitMode.Location = new System.Drawing.Point(6, 18);
            this.m_labelBitMode.Name = "m_labelBitMode";
            this.m_labelBitMode.Size = new System.Drawing.Size(85, 32);
            this.m_labelBitMode.TabIndex = 2;
            this.m_labelBitMode.Text = "Mode";
            // 
            // m_comboBoxTypeBit
            // 
            this.m_comboBoxTypeBit.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.m_comboBoxTypeBit.FormattingEnabled = true;
            this.m_comboBoxTypeBit.Location = new System.Drawing.Point(154, 63);
            this.m_comboBoxTypeBit.Name = "m_comboBoxTypeBit";
            this.m_comboBoxTypeBit.Size = new System.Drawing.Size(68, 29);
            this.m_comboBoxTypeBit.TabIndex = 1;
            this.m_comboBoxTypeBit.SelectedIndexChanged += new System.EventHandler(this.m_comboBoxTypeBit_SelectedIndexChanged);
            // 
            // m_comboBoxModebit
            // 
            this.m_comboBoxModebit.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.m_comboBoxModebit.FormattingEnabled = true;
            this.m_comboBoxModebit.Location = new System.Drawing.Point(156, 18);
            this.m_comboBoxModebit.Name = "m_comboBoxModebit";
            this.m_comboBoxModebit.Size = new System.Drawing.Size(66, 29);
            this.m_comboBoxModebit.TabIndex = 0;
            this.m_comboBoxModebit.SelectedIndexChanged += new System.EventHandler(this.m_comboBoxModebit_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1054, 551);
            this.Controls.Add(this.m_groupBoxRWbit);
            this.Controls.Add(this.m_listBoxLog);
            this.Controls.Add(this.m_groupBoxIP);
            this.Controls.Add(this.m_groupBoxInfo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.m_groupBoxInfo.ResumeLayout(false);
            this.m_groupBoxInfo.PerformLayout();
            this.m_groupBoxIP.ResumeLayout(false);
            this.m_groupBoxIP.PerformLayout();
            this.m_groupBoxRWbit.ResumeLayout(false);
            this.m_groupBoxRWbit.PerformLayout();
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
    }
}

