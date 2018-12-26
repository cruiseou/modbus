namespace HslCommunicationModbus
{
    partial class Form1
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

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.dataReceive1 = new HslCommunicationModbus.Units.DataReceive();
            this.netRs2321 = new HslCommunicationModbus.Units.testNetRs232();
            this.SuspendLayout();
            // 
            // dataReceive1
            // 
            this.dataReceive1.Location = new System.Drawing.Point(26, 244);
            this.dataReceive1.Margin = new System.Windows.Forms.Padding(4);
            this.dataReceive1.Name = "dataReceive1";
            this.dataReceive1.Size = new System.Drawing.Size(738, 302);
            this.dataReceive1.TabIndex = 1;
            // 
            // netRs2321
            // 
            this.netRs2321.Location = new System.Drawing.Point(0, 0);
            this.netRs2321.Name = "netRs2321";
            this.netRs2321.Size = new System.Drawing.Size(845, 274);
            this.netRs2321.TabIndex = 0;
            this.netRs2321.DataReceived += new HslCommunicationModbus.Lib.LeafEvent.DataReceivedHandler(this.netRs2321_DataReceived);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(888, 559);
            this.Controls.Add(this.dataReceive1);
            this.Controls.Add(this.netRs2321);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private Units. testNetRs232 netRs2321;
        private Units.DataReceive dataReceive1;
    }
}

