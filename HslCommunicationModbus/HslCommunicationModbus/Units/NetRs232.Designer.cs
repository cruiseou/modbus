namespace HslCommunicationModbus.Units
{
    partial class NetRs232
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.drpComList = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.drpBaudRate = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.drpParity = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.drpDataBits = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.drpStopBits = new System.Windows.Forms.ComboBox();
            this.picComStatus = new System.Windows.Forms.PictureBox();
            this.btnCom = new System.Windows.Forms.Button();
            this.label21 = new System.Windows.Forms.Label();
            this.textBox15 = new System.Windows.Forms.TextBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.button27 = new System.Windows.Forms.Button();
            this.textBox14 = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_D0Clear = new System.Windows.Forms.Button();
            this.txt_D0Count = new System.Windows.Forms.TextBox();
            this.txt_D0ClearAddress = new System.Windows.Forms.TextBox();
            this.txt_S0Address = new System.Windows.Forms.TextBox();
            this.txt_ReadS0Time = new System.Windows.Forms.TextBox();
            this.btn_ReadS0 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_S0 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_S10 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btn_ReadS10 = new System.Windows.Forms.Button();
            this.txt_ReadS10Time = new System.Windows.Forms.TextBox();
            this.txt_S10Address = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picComStatus)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 15);
            this.label1.TabIndex = 36;
            this.label1.Text = "串口";
            // 
            // drpComList
            // 
            this.drpComList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.drpComList.FormattingEnabled = true;
            this.drpComList.Location = new System.Drawing.Point(83, 11);
            this.drpComList.Margin = new System.Windows.Forms.Padding(4);
            this.drpComList.Name = "drpComList";
            this.drpComList.Size = new System.Drawing.Size(117, 23);
            this.drpComList.TabIndex = 37;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 45);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 15);
            this.label2.TabIndex = 38;
            this.label2.Text = "波特率";
            // 
            // drpBaudRate
            // 
            this.drpBaudRate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.drpBaudRate.FormattingEnabled = true;
            this.drpBaudRate.Items.AddRange(new object[] {
            "300",
            "600",
            "1200",
            "2400",
            "4800",
            "9600",
            "19200",
            "38400",
            "43000",
            "56000",
            "57600",
            "115200"});
            this.drpBaudRate.Location = new System.Drawing.Point(83, 41);
            this.drpBaudRate.Margin = new System.Windows.Forms.Padding(4);
            this.drpBaudRate.Name = "drpBaudRate";
            this.drpBaudRate.Size = new System.Drawing.Size(117, 23);
            this.drpBaudRate.TabIndex = 39;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 77);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 15);
            this.label3.TabIndex = 40;
            this.label3.Text = "校验位";
            // 
            // drpParity
            // 
            this.drpParity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.drpParity.FormattingEnabled = true;
            this.drpParity.Items.AddRange(new object[] {
            "None",
            "Odd",
            "Even",
            "Mark",
            "Space"});
            this.drpParity.Location = new System.Drawing.Point(83, 73);
            this.drpParity.Margin = new System.Windows.Forms.Padding(4);
            this.drpParity.Name = "drpParity";
            this.drpParity.Size = new System.Drawing.Size(117, 23);
            this.drpParity.TabIndex = 41;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 109);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 15);
            this.label4.TabIndex = 42;
            this.label4.Text = "数据位";
            // 
            // drpDataBits
            // 
            this.drpDataBits.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.drpDataBits.FormattingEnabled = true;
            this.drpDataBits.Items.AddRange(new object[] {
            "8",
            "7",
            "6"});
            this.drpDataBits.Location = new System.Drawing.Point(83, 106);
            this.drpDataBits.Margin = new System.Windows.Forms.Padding(4);
            this.drpDataBits.Name = "drpDataBits";
            this.drpDataBits.Size = new System.Drawing.Size(117, 23);
            this.drpDataBits.TabIndex = 43;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 142);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 15);
            this.label5.TabIndex = 44;
            this.label5.Text = "停止位";
            // 
            // drpStopBits
            // 
            this.drpStopBits.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.drpStopBits.FormattingEnabled = true;
            this.drpStopBits.Items.AddRange(new object[] {
            "1",
            "2"});
            this.drpStopBits.Location = new System.Drawing.Point(83, 138);
            this.drpStopBits.Margin = new System.Windows.Forms.Padding(4);
            this.drpStopBits.Name = "drpStopBits";
            this.drpStopBits.Size = new System.Drawing.Size(117, 23);
            this.drpStopBits.TabIndex = 45;
            // 
            // picComStatus
            // 
            this.picComStatus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.picComStatus.Location = new System.Drawing.Point(23, 171);
            this.picComStatus.Margin = new System.Windows.Forms.Padding(4);
            this.picComStatus.Name = "picComStatus";
            this.picComStatus.Size = new System.Drawing.Size(50, 46);
            this.picComStatus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picComStatus.TabIndex = 47;
            this.picComStatus.TabStop = false;
            // 
            // btnCom
            // 
            this.btnCom.Enabled = false;
            this.btnCom.Location = new System.Drawing.Point(83, 171);
            this.btnCom.Margin = new System.Windows.Forms.Padding(4);
            this.btnCom.Name = "btnCom";
            this.btnCom.Size = new System.Drawing.Size(119, 46);
            this.btnCom.TabIndex = 46;
            this.btnCom.Tag = "0";
            this.btnCom.Text = "打开串口";
            this.btnCom.UseVisualStyleBackColor = true;
            this.btnCom.Click += new System.EventHandler(this.btnCom_Click);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(223, 13);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(52, 15);
            this.label21.TabIndex = 48;
            this.label21.Text = "站号：";
            // 
            // textBox15
            // 
            this.textBox15.Location = new System.Drawing.Point(281, 3);
            this.textBox15.Name = "textBox15";
            this.textBox15.Size = new System.Drawing.Size(37, 25);
            this.textBox15.TabIndex = 49;
            this.textBox15.Text = "1";
            // 
            // comboBox2
            // 
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "ABCD",
            "BADC",
            "CDAB",
            "DCBA"});
            this.comboBox2.Location = new System.Drawing.Point(359, 74);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(111, 23);
            this.comboBox2.TabIndex = 50;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(226, 41);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(104, 19);
            this.checkBox3.TabIndex = 51;
            this.checkBox3.Text = "字符串颠倒";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Location = new System.Drawing.Point(226, 77);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(127, 19);
            this.checkBox1.TabIndex = 52;
            this.checkBox1.Text = "首地址从0开始";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // button27
            // 
            this.button27.Location = new System.Drawing.Point(691, 7);
            this.button27.Name = "button27";
            this.button27.Size = new System.Drawing.Size(70, 28);
            this.button27.TabIndex = 58;
            this.button27.Text = "启动";
            this.button27.UseVisualStyleBackColor = true;
            this.button27.Click += new System.EventHandler(this.button27_Click);
            // 
            // textBox14
            // 
            this.textBox14.Location = new System.Drawing.Point(587, 7);
            this.textBox14.Name = "textBox14";
            this.textBox14.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox14.Size = new System.Drawing.Size(82, 25);
            this.textBox14.TabIndex = 57;
            this.textBox14.Text = "1000";
            this.textBox14.TextChanged += new System.EventHandler(this.textBox14_TextChanged);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(617, 112);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(52, 15);
            this.label18.TabIndex = 56;
            this.label18.Text = "间隔：";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label17.Location = new System.Drawing.Point(397, 45);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(272, 15);
            this.label17.TabIndex = 55;
            this.label17.Text = "此处假设确定了数据的类型，为short：";
            // 
            // textBox12
            // 
            this.textBox12.Location = new System.Drawing.Point(400, 5);
            this.textBox12.Name = "textBox12";
            this.textBox12.Size = new System.Drawing.Size(132, 25);
            this.textBox12.TabIndex = 54;
            this.textBox12.Text = "100";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(342, 15);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(52, 15);
            this.label15.TabIndex = 53;
            this.label15.Text = "地址：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(217, 215);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 15);
            this.label6.TabIndex = 59;
            this.label6.Text = "D0计数";
            // 
            // btn_D0Clear
            // 
            this.btn_D0Clear.Location = new System.Drawing.Point(457, 211);
            this.btn_D0Clear.Name = "btn_D0Clear";
            this.btn_D0Clear.Size = new System.Drawing.Size(75, 23);
            this.btn_D0Clear.TabIndex = 60;
            this.btn_D0Clear.Text = "D0置零";
            this.btn_D0Clear.UseVisualStyleBackColor = true;
            this.btn_D0Clear.Click += new System.EventHandler(this.btn_D0Clear_Click);
            // 
            // txt_D0Count
            // 
            this.txt_D0Count.Location = new System.Drawing.Point(276, 209);
            this.txt_D0Count.Name = "txt_D0Count";
            this.txt_D0Count.Size = new System.Drawing.Size(132, 25);
            this.txt_D0Count.TabIndex = 61;
            // 
            // txt_D0ClearAddress
            // 
            this.txt_D0ClearAddress.Location = new System.Drawing.Point(553, 209);
            this.txt_D0ClearAddress.Name = "txt_D0ClearAddress";
            this.txt_D0ClearAddress.Size = new System.Drawing.Size(132, 25);
            this.txt_D0ClearAddress.TabIndex = 62;
            this.txt_D0ClearAddress.Text = "100";
            // 
            // txt_S0Address
            // 
            this.txt_S0Address.Location = new System.Drawing.Point(479, 109);
            this.txt_S0Address.Name = "txt_S0Address";
            this.txt_S0Address.Size = new System.Drawing.Size(132, 25);
            this.txt_S0Address.TabIndex = 63;
            this.txt_S0Address.Text = "20480";
            // 
            // txt_ReadS0Time
            // 
            this.txt_ReadS0Time.Location = new System.Drawing.Point(679, 106);
            this.txt_ReadS0Time.Name = "txt_ReadS0Time";
            this.txt_ReadS0Time.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_ReadS0Time.Size = new System.Drawing.Size(82, 25);
            this.txt_ReadS0Time.TabIndex = 64;
            this.txt_ReadS0Time.Text = "100";
            // 
            // btn_ReadS0
            // 
            this.btn_ReadS0.Location = new System.Drawing.Point(782, 102);
            this.btn_ReadS0.Name = "btn_ReadS0";
            this.btn_ReadS0.Size = new System.Drawing.Size(70, 28);
            this.btn_ReadS0.TabIndex = 65;
            this.btn_ReadS0.Text = "启动";
            this.btn_ReadS0.UseVisualStyleBackColor = true;
            this.btn_ReadS0.Click += new System.EventHandler(this.btn_ReadS0_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(232, 112);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 15);
            this.label7.TabIndex = 66;
            this.label7.Text = "S0：";
            // 
            // txt_S0
            // 
            this.txt_S0.Location = new System.Drawing.Point(276, 109);
            this.txt_S0.Name = "txt_S0";
            this.txt_S0.Size = new System.Drawing.Size(132, 25);
            this.txt_S0.TabIndex = 67;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(421, 114);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 15);
            this.label8.TabIndex = 68;
            this.label8.Text = "地址：";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(421, 164);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 15);
            this.label9.TabIndex = 75;
            this.label9.Text = "地址：";
            // 
            // txt_S10
            // 
            this.txt_S10.Location = new System.Drawing.Point(276, 159);
            this.txt_S10.Name = "txt_S10";
            this.txt_S10.Size = new System.Drawing.Size(132, 25);
            this.txt_S10.TabIndex = 74;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(232, 162);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(46, 15);
            this.label10.TabIndex = 73;
            this.label10.Text = "S10：";
            // 
            // btn_ReadS10
            // 
            this.btn_ReadS10.Location = new System.Drawing.Point(782, 152);
            this.btn_ReadS10.Name = "btn_ReadS10";
            this.btn_ReadS10.Size = new System.Drawing.Size(70, 28);
            this.btn_ReadS10.TabIndex = 72;
            this.btn_ReadS10.Text = "启动";
            this.btn_ReadS10.UseVisualStyleBackColor = true;
            this.btn_ReadS10.Click += new System.EventHandler(this.btn_ReadS10_Click);
            // 
            // txt_ReadS10Time
            // 
            this.txt_ReadS10Time.Location = new System.Drawing.Point(679, 156);
            this.txt_ReadS10Time.Name = "txt_ReadS10Time";
            this.txt_ReadS10Time.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_ReadS10Time.Size = new System.Drawing.Size(82, 25);
            this.txt_ReadS10Time.TabIndex = 71;
            this.txt_ReadS10Time.Text = "100";
            // 
            // txt_S10Address
            // 
            this.txt_S10Address.Location = new System.Drawing.Point(479, 159);
            this.txt_S10Address.Name = "txt_S10Address";
            this.txt_S10Address.Size = new System.Drawing.Size(132, 25);
            this.txt_S10Address.TabIndex = 70;
            this.txt_S10Address.Text = "20489";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(617, 162);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(52, 15);
            this.label11.TabIndex = 69;
            this.label11.Text = "间隔：";
            // 
            // NetRs232
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txt_S10);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btn_ReadS10);
            this.Controls.Add(this.txt_ReadS10Time);
            this.Controls.Add(this.txt_S10Address);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txt_S0);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btn_ReadS0);
            this.Controls.Add(this.txt_ReadS0Time);
            this.Controls.Add(this.txt_S0Address);
            this.Controls.Add(this.txt_D0ClearAddress);
            this.Controls.Add(this.txt_D0Count);
            this.Controls.Add(this.btn_D0Clear);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button27);
            this.Controls.Add(this.textBox14);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.textBox12);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.checkBox3);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.textBox15);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.drpComList);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.drpBaudRate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.drpParity);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.drpDataBits);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.drpStopBits);
            this.Controls.Add(this.picComStatus);
            this.Controls.Add(this.btnCom);
            this.Name = "NetRs232";
            this.Size = new System.Drawing.Size(976, 367);
            ((System.ComponentModel.ISupportInitialize)(this.picComStatus)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox drpComList;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox drpBaudRate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox drpParity;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox drpDataBits;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox drpStopBits;
        private System.Windows.Forms.PictureBox picComStatus;
        private System.Windows.Forms.Button btnCom;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox textBox15;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button button27;
        private System.Windows.Forms.TextBox textBox14;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox textBox12;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_D0Clear;
        private System.Windows.Forms.TextBox txt_D0Count;
        private System.Windows.Forms.TextBox txt_D0ClearAddress;
        private System.Windows.Forms.TextBox txt_S0Address;
        private System.Windows.Forms.TextBox txt_ReadS0Time;
        private System.Windows.Forms.Button btn_ReadS0;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_S0;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_S10;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btn_ReadS10;
        private System.Windows.Forms.TextBox txt_ReadS10Time;
        private System.Windows.Forms.TextBox txt_S10Address;
        private System.Windows.Forms.Label label11;
    }
}
