using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using HslCommunicationModbus.Lib;
using System.Threading;
/*---------------作者：Maximus Ye----------------------*/
/*---------------时间：2013年8月16日---------------*/
/*---------------邮箱：yq@yyzq.net---------*/
/*---------------QQ：275623749---------*/
/*本软件也耗费了我不少的时间和精力，希望各位同行们尊重个人劳动成果，
 * 如果在此版本的基础上修改发布新的版本，请包含原作者信息（包括代码和UI界面相关信息)，为中国的
 * 开源事业做出一点贡献。*/
namespace HslCommunicationModbus.Units
{
    public partial class DataSend : UserControl
    {
       

        public event LeafEvent.DataSendHandler EventDataSend;

        /// <summary>
        /// 是否在自动循环发送状态
        /// </summary>
        bool AutoSend = false;

        public DataSend()
        {
            InitializeComponent();
          
        }

       

      

        /// <summary>
        /// 自动发送
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAutoSend_Click(object sender, EventArgs e)
        {
            if (AutoSend == false)
            {
                btnAutoSend.Text = "停止循环";
               
                nmDelay.Enabled = false;
                AutoSend = true;
                Thread ThTestL = new Thread(new ParameterizedThreadStart(TAutoSend));
                ThTestL.IsBackground = true;
                ThTestL.Start(nmDelay.Value);
            }
            else
            {
                StopAutoSend();
            }
        }

        /// <summary>
        /// 自动发送命令线程
        /// </summary>
        private void TAutoSend(object Interval)
        {
            try
            {
                object sendlock = new object();
                int SendInterval = Convert.ToInt32(Interval);
                while (AutoSend)
                {

                    if (AutoSend)
                    {
                        this.Invoke(new MethodInvoker(delegate
                        {
                           if (EventDataSend != null)
                                {
                                    //if (EventDataSend(lstCMD[i].Bytes) == false)
                                    //{
                                    //    StopAutoSend();
                                    //}
                                   
                                }
                            
                        }));
                        Thread.Sleep(SendInterval);
                    }
                    else
                    {
                        break;
                    }

                }
            }
            catch
            {


            };
        }

        /// <summary>
        /// 停止循环发送
        /// </summary>
        private void StopAutoSend()
        {
            AutoSend = false;
            btnAutoSend.Text = "循环发送";
            nmDelay.Enabled = true;
        }
    }
}
