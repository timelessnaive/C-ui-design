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
using ZedGraph;
/*
 * English  中文      单位
 * 
 * altitude 海拔高度    m
 * speed    速度       m/s
 * yaw      偏转       deg
 * yoll     ????      deg
*/

//1.没有添加新的函数
//2.有编号的函数的都是原先就有但未完成的
//3.没有编号的函数都已经完成

namespace AUV_Monitor
{
    public partial class FrmMain : Form
    { 
        public DeviceX4 Device { get; set; }

        public float x_value, y_value, z_value;

        //public List<double> list_x,list_y;

        PointPairList plist = new PointPairList();//建一个空的坐标点列表

        Random random = new Random();

        public int count = 0;
        // float[]rec_data=new float[4];

        public FrmMain()
        {
            Device = new DeviceX4();
            InitializeComponent();
        }

        // 测试用，点击测试按钮可以看到数字在变化，数据显示标签页中有图形被绘制出来。
        private void  button1_Click(object sender, EventArgs e)
        {
            
            //quickView2.number ++;
            count += 1;

            int x = count;
            int y = count * random.Next(0, 10);
            plist.Add(x, y);//将新的点加入列表
            GraphPane mypane = zedGraphControl1.GraphPane; //创建图形对象
            mypane.CurveList.Clear();//清空图中原有的线
            LineItem mycurve = mypane.AddCurve("11", plist, Color.Black, SymbolType.None);//绘制图形

            //zedGraphControl1.Invalidate();


            pitchAndBank1.Bank = 10 + count; //控制水平仪方向
            pitchAndBank1.Pitch = 20 + count; //控制水平仪蓝色绿色占比

            // quickview1    3
            //          2    4

            quickView1.number = 50 + count;   //水平仪下方数据1
            quickView2.number = 50 + count;
            quickView3.number = 50 + count;
            quickView4.number = 50 + count;

            //仪表盘 数值大小
            //aGauge3   4   1   2

            aGauge3.Value0 = 10 + count;
            aGauge4.Value0 = 20 + count;
            aGauge1.Value0 = 30 + count;
            aGauge2.Value0 = 40 + count;

            //指南针朝向
            hsi1.Heading = 40 + count;
        }

        //整个窗体加载时检查是否有串口
        private void FrmMain_Load(object sender, EventArgs e)
        {
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

        //打开串口按钮绑定的函数
        private void BtnOpenCom_Click(object sender, EventArgs e)
        {
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

        //控制水平仪，其中还有从接口获取数据代码段
        private void SerialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            try
            {
                int count = serialPort1.BytesToRead;
                string str_receice_data;
                byte[] receivedData = new byte[count];
                serialPort1.Read(receivedData, 0, receivedData.Length);
                serialPort1.DiscardInBuffer();

                //x_value,y_value,z_value是从接口中得到的三个值
                this.Invoke((EventHandler)(delegate
                {
                    str_receice_data = Encoding.Default.GetString(receivedData);
                    textBox1.Text = str_receice_data;
                    /*
                    str_receice_data = Encoding.Default.GetString(receivedData);
                    x_value = Convert.ToSingle(str_receice_data.Split(',')[0]);
                    y_value = Convert.ToSingle(str_receice_data.Split(',')[1]);
                    z_value = Convert.ToSingle(str_receice_data.Split(',')[2]);
                    textBox1.Text = "x:" + x_value.ToString() + "y:" + y_value.ToString() + "z:" + z_value.ToString();
                    userControl12.slider.Value = -x_value;
                    userControl12.slider_Copy.Value = z_value;
                    userControl12.slider_Copy1.Value = y_value;

                    pitchAndBank1.Bank = x_value; //控制水平仪方向
                    pitchAndBank1.Pitch = y_value; //控制水平仪蓝色绿色占比

                    // quickview1    3
                    //          2    4

                    //quickView1.number = 50;   //水平仪下方数据1
                    //quickView2.number = 50;
                    //quickView3.number = 50;
                    //quickView4.number = 50;

                    //仪表盘 数值大小
                    //aGauge3   4   1   2
                    /*
                    aGauge1.Value0 = 10;
                    aGauge1.Value0 = 10;
                    aGauge1.Value0 = 10;
                    aGauge1.Value0 = 10;
                    */
                    //指南针朝向
                    //hsi1.Heading= 40;
                }));
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message, "Error");
            }
        }
        
        //001 选中的标签属性值更改时发生的事件
        private void TabMain_SelectedIndexChanged(object sender, EventArgs e)
        {
            //
        }

        //002 右下角指南针控件加载时的事件
        private void Hsi1_Load(object sender, EventArgs e)
        {
            //
        }
        

        //003 单击实时监测-状态标签页的事件
        //行为：刷新界面
        private void TabPage2_Click(object sender, EventArgs e)
        {
            //SerialPort1_DataReceived(sender,);
        }

        //004 选择不同波特率时的事件
        private void CbxBaudRate_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        //下面这个按键没有实例化，应该是原先测试用的，和TabControl1_Click的目的类似
        /*
        private void button1_Click(object sender, EventArgs e)
        {
            userControl12.slider.Value = 50;
            userControl12.slider_Copy.Value = 50;
            userControl12.slider_Copy1.Value = 50;
        }
        */
    }
}
