namespace HslCommunicationModbus.Units
{
    partial class DataSend
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
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.btnAutoSend = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.nmDelay = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.lblCount = new System.Windows.Forms.LinkLabel();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nmDelay)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAutoSend
            // 
            this.btnAutoSend.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAutoSend.Location = new System.Drawing.Point(0, 191);
            this.btnAutoSend.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAutoSend.Name = "btnAutoSend";
            this.btnAutoSend.Size = new System.Drawing.Size(121, 41);
            this.btnAutoSend.TabIndex = 1;
            this.btnAutoSend.Text = "循环发送";
            this.btnAutoSend.UseVisualStyleBackColor = true;
            this.btnAutoSend.Click += new System.EventHandler(this.btnAutoSend_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(129, 202);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "发送间隔：";
            // 
            // nmDelay
            // 
            this.nmDelay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.nmDelay.Location = new System.Drawing.Point(208, 198);
            this.nmDelay.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nmDelay.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nmDelay.Name = "nmDelay";
            this.nmDelay.Size = new System.Drawing.Size(93, 25);
            this.nmDelay.TabIndex = 3;
            this.nmDelay.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(307, 202);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "毫秒";
            // 
            // lblCount
            // 
            this.lblCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblCount.AutoSize = true;
            this.lblCount.Location = new System.Drawing.Point(451, 201);
            this.lblCount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(15, 15);
            this.lblCount.TabIndex = 8;
            this.lblCount.TabStop = true;
            this.lblCount.Text = "0";
           
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(353, 202);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "发送字节数：";
            // 
            // DataSend
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblCount);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nmDelay);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAutoSend);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "DataSend";
            this.Size = new System.Drawing.Size(628, 235);
            ((System.ComponentModel.ISupportInitialize)(this.nmDelay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnAutoSend;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nmDelay;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.LinkLabel lblCount;
        private System.Windows.Forms.Label label4;
    }
}
