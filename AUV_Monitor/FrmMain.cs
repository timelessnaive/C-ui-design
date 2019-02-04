using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

namespace AUV_Monitor
{
    public partial class FrmMain : Form { 
        public DeviceX4 Device { get; set; }

        public float x_value, y_value, z_value;
       // float[]rec_data=new float[4];
        public FrmMain()
        {
            Device = new DeviceX4();
            InitializeComponent();
        }

        //001
        private void TabMain_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        //002
        private void hsi1_Load(object sender, EventArgs e)
        {

        }
        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            //控制水平仪
            try
            {
                int count = serialPort1.BytesToRead;
                string str_receice_data;
                //ComReceiveCount += count;
                byte[] receivedData = new byte[count];
                serialPort1.Read(receivedData, 0, receivedData.Length);
                serialPort1.DiscardInBuffer();

                this.Invoke((EventHandler)(delegate
                {
                    str_receice_data = Encoding.Default.GetString(receivedData);
                    x_value = Convert.ToSingle(str_receice_data.Split(',')[0]);
                    y_value = Convert.ToSingle(str_receice_data.Split(',')[1]);
                    z_value = Convert.ToSingle(str_receice_data.Split(',')[2]);
                    textBox1.Text = "x:" + x_value.ToString() + "y:" + y_value.ToString() + "z:" + z_value.ToString();
                    userControl12.slider.Value = -x_value;
                    userControl12.slider_Copy.Value = z_value;
                    userControl12.slider_Copy1.Value = y_value;

                    pitchAndBank1.Bank = x_value;
                    pitchAndBank1.Pitch = y_value;

                    

                }));

            }
            catch (System.Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message, "Error");
            }
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            //整个窗体加载时检查是否有串口
            //serialPort1.DataReceived += serialPort1_DataReceived;
            cbxBaudRate.SelectedIndex = 5;
           

            string[] ports = SerialPort.GetPortNames();
            if (ports.Length != 0)
            {
                foreach (string s in System.IO.Ports.SerialPort.GetPortNames())
                {
                    cbxCOMPort.Items.Add(s);
                }
                cbxCOMPort.SelectedIndex = 0;
            }
            else
            {
                MessageBox.Show("未检测到串口！");
            }
           

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //userControl12.slider.Value = 50;
            //userControl12.slider_Copy.Value = 50;
            //userControl12.slider_Copy1.Value = 50;
        }
        //003
        private void tabPage2_Click(object sender, EventArgs e)
        {

        }
        //004
        private void cbxBaudRate_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnOpenCom_Click(object sender, EventArgs e)
        {
            //打开串口按钮绑定的函数
            if (btnOpenCom.Text == "打开串口")
            {
                try
                {
                    string strPortname = cbxCOMPort.SelectedItem.ToString();
                    string strBaudrate = cbxBaudRate.SelectedItem.ToString();
                 
                    
                    Int32 intBaudrate = Convert.ToInt32(strBaudrate);
                   
                    serialPort1.PortName = strPortname;
                    serialPort1.BaudRate = intBaudrate;
                    serialPort1.DataBits = 8;

                    serialPort1.Parity = Parity.None;

                    serialPort1.StopBits = StopBits.One;

                    if (serialPort1.IsOpen == true)
                    {
                        serialPort1.Close();
                    }
                    serialPort1.Open();
                    if (serialPort1.IsOpen == true)
                    {
                        btnOpenCom.Text = "关闭串口";

                        MessageBox.Show("串口已打开！", "Information");
                    }
                }
                catch (System.Exception ex)
                {
                    MessageBox.Show("Error:" + ex.Message, "Error");
                }
            }
            else
            {
                try
                {
                    serialPort1.Close();
                    if (serialPort1.IsOpen == false)
                    {
                        btnOpenCom.Text = "打开串口";

                        MessageBox.Show("串口已关闭！", "Information");
                    }
                }
                catch (System.Exception ex)
                {
                    MessageBox.Show("Error:" + ex.Message, "Error");
                }
            }
        }
    }
}
