using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using HslCommunication;
using HslCommunication.ModBus;
using HslCommunicationModbus.Lib;

namespace HslCommunicationModbus.Units
{
    public partial class testNetRs232 : UserControl
    {
        private ModbusRtu busRtuClient = null;
        public event LeafEvent.DataReceivedHandler DataReceived;
        public testNetRs232()
        {
            InitializeComponent();
            drpComList.Items.AddRange(SerialPort.GetPortNames());
            if (drpComList.Items.Count > 0)
            {
                drpComList.SelectedIndex = 0;
                btnCom.Enabled = true;
            }
            drpBaudRate.SelectedIndex = 6;
            drpParity.SelectedIndex = 2;
            drpDataBits.SelectedIndex = 0;
            drpStopBits.SelectedIndex = 0;
        }


        private bool IsOpen = false;
        private void btnCom_Click(object sender, EventArgs e)
        {
            if (IsOpen)
            {
                try
                {
                    busRtuClient.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                btnCom.Text = "打开串口";
                picComStatus.BackgroundImage = Properties.Resources.redlight;
                IsOpen = false;
            }
            else
            {
                busRtuClient?.Close();
                busRtuClient = new ModbusRtu();


                busRtuClient.AddressStartWithZero = checkBox1.Checked;


                ComboBox2_SelectedIndexChanged(null, new EventArgs());
                busRtuClient.IsStringReverse = checkBox3.Checked;


                try
                {
                    busRtuClient.SerialPortInni(sp =>
                    {
                        sp.PortName = drpComList.SelectedItem.ToString(); ;
                        sp.BaudRate = Convert.ToInt32(drpBaudRate.SelectedItem.ToString());
                        sp.DataBits = Convert.ToInt32(drpDataBits.SelectedItem.ToString());
                        sp.StopBits = (StopBits)Convert.ToInt32(drpStopBits.SelectedItem.ToString());
                        sp.Parity = (Parity)Convert.ToInt32(drpParity.SelectedIndex.ToString());
                    });
                    busRtuClient.Open();
                    btnCom.Text = "关闭串口";
                    picComStatus.BackgroundImage = Properties.Resources.greenlight;

                }
                catch (Exception ex)
                {
                    btnCom.Text = "打开串口";
                    picComStatus.BackgroundImage = Properties.Resources.redlight;
                    MessageBox.Show(ex.Message);
                }

                IsOpen = true;

            }





            // busRtuClient?.Close();

        }

        private void ComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (busRtuClient != null)
            {
                switch (comboBox2.SelectedIndex)
                {
                    case 0: busRtuClient.DataFormat = HslCommunication.Core.DataFormat.ABCD; break;
                    case 1: busRtuClient.DataFormat = HslCommunication.Core.DataFormat.BADC; break;
                    case 2: busRtuClient.DataFormat = HslCommunication.Core.DataFormat.CDAB; break;
                    case 3: busRtuClient.DataFormat = HslCommunication.Core.DataFormat.DCBA; break;
                    default: break;
                }
            }
        }
        private Thread thread = null;              // 后台读取的线程
        private int timeSleep = 1000;               // 读取的间隔
        private bool isThreadRun = false;          // 用来标记线程的运行状态

        private void button27_Click(object sender, EventArgs e)
        {
            if (!isThreadRun)
            {
                if (!int.TryParse(textBox14.Text, out timeSleep))
                {
                    MessageBox.Show("间隔时间格式输入错误！");
                    return;
                }
                button27.Text = "停止";
                isThreadRun = true;
                thread = new Thread(ThreadReadServer);
                thread.IsBackground = true;
                thread.Start();
            }
            else
            {
                button27.Text = "启动";
                isThreadRun = false;
            }
        }

        private void ThreadReadServer()
        {
            while (isThreadRun)
            {
                Thread.Sleep(timeSleep);

                try
                {
                    OperateResult<short> read = busRtuClient.ReadInt16(textBox12.Text);
                    if (read.IsSuccess)
                    {
                        // 显示曲线
                        if (isThreadRun) Invoke(new Action<short>(AddDataCurve), read.Content);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("读取失败：" + ex.Message);
                }

            }
        }

        private void AddDataCurve(short data)
        {
            DataReceived(this, BitConverter.GetBytes(data));//输出数据
            // userCurve1.AddCurveData("A", data);

            this.BeginInvoke(new MethodInvoker(delegate
            {
                txt_D0Count.Text=data.ToString();
               
            }));
        }


        /// <summary>
        /// D0置零
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_D0Clear_Click(object sender, EventArgs e)
        {
            try
            {
                writeResultRender(busRtuClient.WriteCoil(txt_D0ClearAddress.Text, true), txt_D0ClearAddress.Text);

                writeResultRender(busRtuClient.WriteCoil(txt_D0ClearAddress.Text, false), txt_D0ClearAddress.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void writeResultRender(OperateResult result, string address)
        {
            if (result.IsSuccess)
            {
              //  MessageBox.Show(DateTime.Now.ToString("[HH:mm:ss] ") + $"[{address}] 写入成功");
            }
            else
            {
               // MessageBox.Show(DateTime.Now.ToString("[HH:mm:ss] ") + $"[{address}] 写入失败{Environment.NewLine}原因：{result.ToMessageShowString()}");
            }
        }

        private void textBox14_TextChanged(object sender, EventArgs e)
        {

        }
        private Thread threadReadS0 = null;              // 后台读取的线程
        private int timeSleepReadS0 = 100;               // 读取的间隔
        private bool isThreadRunReadS0 = false;          // 用来标记线程的运行状态

        /// <summary>
        /// 读取S0状态
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_ReadS0_Click(object sender, EventArgs e)
        {
            if (!isThreadRunReadS0)
            {
                if (!int.TryParse(txt_ReadS0Time.Text, out timeSleepReadS0))
                {
                    MessageBox.Show("间隔时间格式输入错误！");
                    return;
                }
                btn_ReadS0.Text = "停止";
                isThreadRunReadS0 = true;
                threadReadS0 = new Thread(ThreadReadS0Server);
                threadReadS0.IsBackground = true;
                threadReadS0.Start();
            }
            else
            {
                btn_ReadS0.Text = "启动";
                isThreadRunReadS0 = false;
            }
        }

        /// <summary>
        ///  读取S0状态线程
        /// </summary>
        private void ThreadReadS0Server()
        {
            while (isThreadRunReadS0)
            {
                Thread.Sleep(timeSleepReadS0);

                try
                {
                    OperateResult<short> read = busRtuClient.ReadInt16(txt_S0Address.Text);
                    if (read.IsSuccess)
                    {
                        // 显示曲线
                        if (isThreadRunReadS0) Invoke(new Action<short>(AddS0DataCurve), read.Content);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("读取失败：" + ex.Message);
                }

            }
        }


        /// <summary>
        ///  读取S0状态数据接收
        /// </summary>
        /// <param name="data"></param>
        private void AddS0DataCurve(short data)
        {
            DataReceived(this, BitConverter.GetBytes(data));//输出数据
            // userCurve1.AddCurveData("A", data);

            this.BeginInvoke(new MethodInvoker(delegate
            {
                txt_S0.Text = data.ToString();

            }));
        }


        // 后台读取的线程
        private Thread threadReadS10 = null;
        // 读取的间隔
        private int timeSleepReadS10 = 100;
        // 用来标记线程的运行状态

        private bool isThreadRunReadS10 = false;  
                

        /// <summary>
        ///  读取S10状态
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_ReadS10_Click(object sender, EventArgs e)
        {
            if (!isThreadRunReadS10)
            {
                if (!int.TryParse(txt_ReadS10Time.Text, out timeSleepReadS10))
                {
                    MessageBox.Show("间隔时间格式输入错误！");
                    return;
                }
                btn_ReadS10.Text = "停止";
                isThreadRunReadS10 = true;
                threadReadS10 = new Thread(ThreadReadS10Server);
                threadReadS10.IsBackground = true;
                threadReadS10.Start();
            }
            else
            {
                btn_ReadS10.Text = "启动";
                isThreadRunReadS10 = false;
            }
        }

        /// <summary>
        ///  读取S0状态线程
        /// </summary>
        private void ThreadReadS10Server()
        {
            while (isThreadRunReadS10)
            {
                Thread.Sleep(timeSleepReadS10);

                try
                {
                    OperateResult<short> read = busRtuClient.ReadInt16(txt_S10Address.Text);
                    if (read.IsSuccess)
                    {
                        // 显示曲线
                        if (isThreadRunReadS10) Invoke(new Action<short>(AddS10DataCurve), read.Content);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("读取失败：" + ex.Message);
                }

            }
        }

        /// <summary>
        ///  读取S0状态数据接收
        /// </summary>
        /// <param name="data"></param>
        private void AddS10DataCurve(short data)
        {
            DataReceived(this, BitConverter.GetBytes(data));//输出数据
            // userCurve1.AddCurveData("A", data);

            this.BeginInvoke(new MethodInvoker(delegate
            {
                txt_S10.Text = data.ToString();

            }));
        }
    }
}
