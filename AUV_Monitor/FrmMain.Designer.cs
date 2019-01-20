namespace AUV_Monitor
{
    partial class FrmMain
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.TabMain = new CCWin.SkinControl.SkinTabControl();
            this.TabPageIndex = new CCWin.SkinControl.SkinTabPage();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pitchAndBank1 = new metergroup.PitchAndBank();
            this.quickView4 = new MissionPlanner.Controls.QuickView();
            this.quickView1 = new MissionPlanner.Controls.QuickView();
            this.quickView2 = new MissionPlanner.Controls.QuickView();
            this.quickView3 = new MissionPlanner.Controls.QuickView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.aGauge2 = new AGaugeApp.AGauge();
            this.aGauge1 = new AGaugeApp.AGauge();
            this.hsi1 = new MissionPlanner.Controls.HSI();
            this.aGauge3 = new AGaugeApp.AGauge();
            this.aGauge4 = new AGaugeApp.AGauge();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnOpenCom = new System.Windows.Forms.Button();
            this.cbxBaudRate = new System.Windows.Forms.ComboBox();
            this.cbxCOMPort = new System.Windows.Forms.ComboBox();
            this.TabPageData = new CCWin.SkinControl.SkinTabPage();
            this.zedGraphControl1 = new ZedGraph.ZedGraphControl();
            this.TabPageSetting = new CCWin.SkinControl.SkinTabPage();
            this.TabPageInfo = new CCWin.SkinControl.SkinTabPage();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.elementHost2 = new System.Windows.Forms.Integration.ElementHost();
            this.userControl12 = new AUV_Monitor.UserControl1();
            this.TabMain.SuspendLayout();
            this.TabPageIndex.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.TabPageData.SuspendLayout();
            this.SuspendLayout();
            // 
            // TabMain
            // 
            this.TabMain.AnimatorType = CCWin.SkinControl.AnimationType.HorizSlide;
            this.TabMain.CloseRect = new System.Drawing.Rectangle(2, 2, 12, 12);
            this.TabMain.Controls.Add(this.TabPageIndex);
            this.TabMain.Controls.Add(this.TabPageData);
            this.TabMain.Controls.Add(this.TabPageSetting);
            this.TabMain.Controls.Add(this.TabPageInfo);
            this.TabMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabMain.HeadBack = null;
            this.TabMain.ImgSize = new System.Drawing.Size(46, 46);
            this.TabMain.ImgTxtOffset = new System.Drawing.Point(0, 0);
            this.TabMain.ItemSize = new System.Drawing.Size(90, 90);
            this.TabMain.Location = new System.Drawing.Point(0, 0);
            this.TabMain.Margin = new System.Windows.Forms.Padding(2);
            this.TabMain.Name = "TabMain";
            this.TabMain.PageArrowDown = ((System.Drawing.Image)(resources.GetObject("TabMain.PageArrowDown")));
            this.TabMain.PageArrowHover = ((System.Drawing.Image)(resources.GetObject("TabMain.PageArrowHover")));
            this.TabMain.PageBaseColor = System.Drawing.Color.White;
            this.TabMain.PageCloseHover = ((System.Drawing.Image)(resources.GetObject("TabMain.PageCloseHover")));
            this.TabMain.PageCloseNormal = ((System.Drawing.Image)(resources.GetObject("TabMain.PageCloseNormal")));
            this.TabMain.PageDown = ((System.Drawing.Image)(resources.GetObject("TabMain.PageDown")));
            this.TabMain.PageDownTxtColor = System.Drawing.Color.White;
            this.TabMain.PageHover = null;
            this.TabMain.PageHoverTxtColor = System.Drawing.Color.White;
            this.TabMain.PageImagePosition = CCWin.SkinControl.SkinTabControl.ePageImagePosition.Bottom;
            this.TabMain.PageNorml = null;
            this.TabMain.PageNormlTxtColor = System.Drawing.Color.White;
            this.TabMain.SelectedIndex = 0;
            this.TabMain.Size = new System.Drawing.Size(892, 702);
            this.TabMain.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.TabMain.TabIndex = 0;
            this.TabMain.SelectedIndexChanged += new System.EventHandler(this.TabMain_SelectedIndexChanged);
            // 
            // TabPageIndex
            // 
            this.TabPageIndex.BackColor = System.Drawing.Color.Black;
            this.TabPageIndex.BorderColor = System.Drawing.Color.White;
            this.TabPageIndex.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TabPageIndex.Controls.Add(this.panel3);
            this.TabPageIndex.Controls.Add(this.panel2);
            this.TabPageIndex.Controls.Add(this.panel1);
            this.TabPageIndex.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabPageIndex.Font = new System.Drawing.Font("微软雅黑", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TabPageIndex.ForeColor = System.Drawing.Color.White;
            this.TabPageIndex.Location = new System.Drawing.Point(0, 90);
            this.TabPageIndex.Margin = new System.Windows.Forms.Padding(2);
            this.TabPageIndex.Name = "TabPageIndex";
            this.TabPageIndex.Size = new System.Drawing.Size(892, 612);
            this.TabPageIndex.TabIndex = 0;
            this.TabPageIndex.TabItemImage = ((System.Drawing.Image)(resources.GetObject("TabPageIndex.TabItemImage")));
            this.TabPageIndex.Text = "实时监测";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.pitchAndBank1);
            this.panel3.Controls.Add(this.quickView4);
            this.panel3.Controls.Add(this.quickView1);
            this.panel3.Controls.Add(this.quickView2);
            this.panel3.Controls.Add(this.quickView3);
            this.panel3.Location = new System.Drawing.Point(577, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(305, 383);
            this.panel3.TabIndex = 13;
            // 
            // pitchAndBank1
            // 
            this.pitchAndBank1.Bank = 0D;
            this.pitchAndBank1.Location = new System.Drawing.Point(33, -4);
            this.pitchAndBank1.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
            this.pitchAndBank1.Name = "pitchAndBank1";
            this.pitchAndBank1.Pitch = 0D;
            this.pitchAndBank1.Size = new System.Drawing.Size(239, 271);
            this.pitchAndBank1.TabIndex = 0;
            // 
            // quickView4
            // 
            this.quickView4.desc = "Yoll(deg):";
            this.quickView4.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.quickView4.ForeColor = System.Drawing.Color.White;
            this.quickView4.Location = new System.Drawing.Point(150, 330);
            this.quickView4.Margin = new System.Windows.Forms.Padding(2);
            this.quickView4.Name = "quickView4";
            this.quickView4.number = 0D;
            this.quickView4.numberColor = System.Drawing.Color.LawnGreen;
            this.quickView4.numberformat = "0.00";
            this.quickView4.Size = new System.Drawing.Size(122, 52);
            this.quickView4.TabIndex = 7;
            // 
            // quickView1
            // 
            this.quickView1.desc = "Altitude(m):";
            this.quickView1.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.quickView1.ForeColor = System.Drawing.Color.White;
            this.quickView1.Location = new System.Drawing.Point(20, 276);
            this.quickView1.Margin = new System.Windows.Forms.Padding(2);
            this.quickView1.Name = "quickView1";
            this.quickView1.number = 5D;
            this.quickView1.numberColor = System.Drawing.Color.Aqua;
            this.quickView1.numberformat = "0.00";
            this.quickView1.Size = new System.Drawing.Size(117, 50);
            this.quickView1.TabIndex = 4;
            // 
            // quickView2
            // 
            this.quickView2.desc = "Yaw(deg):";
            this.quickView2.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.quickView2.ForeColor = System.Drawing.Color.White;
            this.quickView2.Location = new System.Drawing.Point(20, 330);
            this.quickView2.Margin = new System.Windows.Forms.Padding(2);
            this.quickView2.Name = "quickView2";
            this.quickView2.number = 0D;
            this.quickView2.numberColor = System.Drawing.Color.MediumVioletRed;
            this.quickView2.numberformat = "0.00";
            this.quickView2.Size = new System.Drawing.Size(117, 52);
            this.quickView2.TabIndex = 5;
            // 
            // quickView3
            // 
            this.quickView3.desc = "Speed(m/s):";
            this.quickView3.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.quickView3.ForeColor = System.Drawing.Color.White;
            this.quickView3.Location = new System.Drawing.Point(150, 276);
            this.quickView3.Margin = new System.Windows.Forms.Padding(2);
            this.quickView3.Name = "quickView3";
            this.quickView3.number = 3.2D;
            this.quickView3.numberColor = System.Drawing.Color.BlueViolet;
            this.quickView3.numberformat = "0.00";
            this.quickView3.Size = new System.Drawing.Size(109, 50);
            this.quickView3.TabIndex = 6;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.elementHost2);
            this.panel2.Location = new System.Drawing.Point(3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(568, 384);
            this.panel2.TabIndex = 12;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.tabControl1);
            this.panel1.Location = new System.Drawing.Point(3, 390);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(879, 213);
            this.panel1.TabIndex = 11;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(875, 209);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Black;
            this.tabPage1.Controls.Add(this.aGauge2);
            this.tabPage1.Controls.Add(this.aGauge1);
            this.tabPage1.Controls.Add(this.hsi1);
            this.tabPage1.Controls.Add(this.aGauge3);
            this.tabPage1.Controls.Add(this.aGauge4);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(867, 176);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "仪表";
            // 
            // aGauge2
            // 
            this.aGauge2.BackColor = System.Drawing.Color.Transparent;
            this.aGauge2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.aGauge2.BaseArcColor = System.Drawing.Color.White;
            this.aGauge2.BaseArcRadius = 60;
            this.aGauge2.BaseArcStart = 135;
            this.aGauge2.BaseArcSweep = 270;
            this.aGauge2.BaseArcWidth = 2;
            this.aGauge2.Cap_Idx = ((byte)(1));
            this.aGauge2.CapColor = System.Drawing.Color.White;
            this.aGauge2.CapColors = new System.Drawing.Color[] {
        System.Drawing.Color.Black,
        System.Drawing.Color.White,
        System.Drawing.Color.Black,
        System.Drawing.Color.Black,
        System.Drawing.Color.Black};
            this.aGauge2.CapPosition = new System.Drawing.Point(10, 10);
            this.aGauge2.CapsPosition = new System.Drawing.Point[] {
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(10, 10)};
            this.aGauge2.CapsText = new string[] {
        "",
        "",
        "",
        "",
        ""};
            this.aGauge2.CapText = "";
            this.aGauge2.Center = new System.Drawing.Point(70, 80);
            this.aGauge2.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.aGauge2.Location = new System.Drawing.Point(525, -2);
            this.aGauge2.Margin = new System.Windows.Forms.Padding(2);
            this.aGauge2.MaxValue = 100F;
            this.aGauge2.MinValue = 0F;
            this.aGauge2.Name = "aGauge2";
            this.aGauge2.Need_Idx = ((byte)(3));
            this.aGauge2.NeedleColor1 = AGaugeApp.AGauge.NeedleColorEnum.Gray;
            this.aGauge2.NeedleColor2 = System.Drawing.Color.DimGray;
            this.aGauge2.NeedleEnabled = false;
            this.aGauge2.NeedleRadius = 80;
            this.aGauge2.NeedlesColor1 = new AGaugeApp.AGauge.NeedleColorEnum[] {
        AGaugeApp.AGauge.NeedleColorEnum.Red,
        AGaugeApp.AGauge.NeedleColorEnum.Gray,
        AGaugeApp.AGauge.NeedleColorEnum.Gray,
        AGaugeApp.AGauge.NeedleColorEnum.Gray};
            this.aGauge2.NeedlesColor2 = new System.Drawing.Color[] {
        System.Drawing.Color.DimGray,
        System.Drawing.Color.DimGray,
        System.Drawing.Color.DimGray,
        System.Drawing.Color.DimGray};
            this.aGauge2.NeedlesEnabled = new bool[] {
        true,
        false,
        false,
        false};
            this.aGauge2.NeedlesRadius = new int[] {
        55,
        80,
        80,
        80};
            this.aGauge2.NeedlesType = new int[] {
        0,
        0,
        0,
        0};
            this.aGauge2.NeedlesWidth = new int[] {
        2,
        2,
        2,
        2};
            this.aGauge2.NeedleType = 0;
            this.aGauge2.NeedleWidth = 2;
            this.aGauge2.Range_Idx = ((byte)(1));
            this.aGauge2.RangeColor = System.Drawing.Color.Transparent;
            this.aGauge2.RangeEnabled = true;
            this.aGauge2.RangeEndValue = 400F;
            this.aGauge2.RangeInnerRadius = 70;
            this.aGauge2.RangeOuterRadius = 80;
            this.aGauge2.RangesColor = new System.Drawing.Color[] {
        System.Drawing.Color.Transparent,
        System.Drawing.Color.Transparent,
        System.Drawing.SystemColors.Control,
        System.Drawing.SystemColors.Control,
        System.Drawing.SystemColors.Control};
            this.aGauge2.RangesEnabled = new bool[] {
        true,
        true,
        false,
        false,
        false};
            this.aGauge2.RangesEndValue = new float[] {
        100F,
        400F,
        0F,
        0F,
        0F};
            this.aGauge2.RangesInnerRadius = new int[] {
        50,
        70,
        70,
        70,
        70};
            this.aGauge2.RangesOuterRadius = new int[] {
        60,
        80,
        80,
        80,
        80};
            this.aGauge2.RangesStartValue = new float[] {
        0F,
        300F,
        0F,
        0F,
        0F};
            this.aGauge2.RangeStartValue = 300F;
            this.aGauge2.ScaleLinesInterColor = System.Drawing.Color.White;
            this.aGauge2.ScaleLinesInterInnerRadius = 50;
            this.aGauge2.ScaleLinesInterOuterRadius = 60;
            this.aGauge2.ScaleLinesInterWidth = 1;
            this.aGauge2.ScaleLinesMajorColor = System.Drawing.Color.White;
            this.aGauge2.ScaleLinesMajorInnerRadius = 50;
            this.aGauge2.ScaleLinesMajorOuterRadius = 60;
            this.aGauge2.ScaleLinesMajorStepValue = 20F;
            this.aGauge2.ScaleLinesMajorWidth = 2;
            this.aGauge2.ScaleLinesMinorColor = System.Drawing.Color.White;
            this.aGauge2.ScaleLinesMinorInnerRadius = 55;
            this.aGauge2.ScaleLinesMinorNumOf = 9;
            this.aGauge2.ScaleLinesMinorOuterRadius = 60;
            this.aGauge2.ScaleLinesMinorWidth = 1;
            this.aGauge2.ScaleNumbersColor = System.Drawing.Color.White;
            this.aGauge2.ScaleNumbersFormat = "0";
            this.aGauge2.ScaleNumbersRadius = 40;
            this.aGauge2.ScaleNumbersRotation = 0;
            this.aGauge2.ScaleNumbersStartScaleLine = 0;
            this.aGauge2.ScaleNumbersStepScaleLines = 1;
            this.aGauge2.Size = new System.Drawing.Size(180, 180);
            this.aGauge2.TabIndex = 12;
            this.aGauge2.Value = 0F;
            this.aGauge2.Value0 = 0F;
            this.aGauge2.Value1 = 0F;
            this.aGauge2.Value2 = 0F;
            this.aGauge2.Value3 = 0F;
            // 
            // aGauge1
            // 
            this.aGauge1.BackColor = System.Drawing.Color.Transparent;
            this.aGauge1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.aGauge1.BaseArcColor = System.Drawing.Color.White;
            this.aGauge1.BaseArcRadius = 60;
            this.aGauge1.BaseArcStart = 135;
            this.aGauge1.BaseArcSweep = 270;
            this.aGauge1.BaseArcWidth = 2;
            this.aGauge1.Cap_Idx = ((byte)(1));
            this.aGauge1.CapColor = System.Drawing.Color.White;
            this.aGauge1.CapColors = new System.Drawing.Color[] {
        System.Drawing.Color.Black,
        System.Drawing.Color.White,
        System.Drawing.Color.Black,
        System.Drawing.Color.Black,
        System.Drawing.Color.Black};
            this.aGauge1.CapPosition = new System.Drawing.Point(10, 10);
            this.aGauge1.CapsPosition = new System.Drawing.Point[] {
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(10, 10)};
            this.aGauge1.CapsText = new string[] {
        "",
        "",
        "",
        "",
        ""};
            this.aGauge1.CapText = "";
            this.aGauge1.Center = new System.Drawing.Point(70, 80);
            this.aGauge1.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.aGauge1.Location = new System.Drawing.Point(357, -2);
            this.aGauge1.Margin = new System.Windows.Forms.Padding(2);
            this.aGauge1.MaxValue = 100F;
            this.aGauge1.MinValue = 0F;
            this.aGauge1.Name = "aGauge1";
            this.aGauge1.Need_Idx = ((byte)(3));
            this.aGauge1.NeedleColor1 = AGaugeApp.AGauge.NeedleColorEnum.Gray;
            this.aGauge1.NeedleColor2 = System.Drawing.Color.DimGray;
            this.aGauge1.NeedleEnabled = false;
            this.aGauge1.NeedleRadius = 80;
            this.aGauge1.NeedlesColor1 = new AGaugeApp.AGauge.NeedleColorEnum[] {
        AGaugeApp.AGauge.NeedleColorEnum.Red,
        AGaugeApp.AGauge.NeedleColorEnum.Gray,
        AGaugeApp.AGauge.NeedleColorEnum.Gray,
        AGaugeApp.AGauge.NeedleColorEnum.Gray};
            this.aGauge1.NeedlesColor2 = new System.Drawing.Color[] {
        System.Drawing.Color.DimGray,
        System.Drawing.Color.DimGray,
        System.Drawing.Color.DimGray,
        System.Drawing.Color.DimGray};
            this.aGauge1.NeedlesEnabled = new bool[] {
        true,
        false,
        false,
        false};
            this.aGauge1.NeedlesRadius = new int[] {
        55,
        80,
        80,
        80};
            this.aGauge1.NeedlesType = new int[] {
        0,
        0,
        0,
        0};
            this.aGauge1.NeedlesWidth = new int[] {
        2,
        2,
        2,
        2};
            this.aGauge1.NeedleType = 0;
            this.aGauge1.NeedleWidth = 2;
            this.aGauge1.Range_Idx = ((byte)(1));
            this.aGauge1.RangeColor = System.Drawing.Color.Transparent;
            this.aGauge1.RangeEnabled = true;
            this.aGauge1.RangeEndValue = 400F;
            this.aGauge1.RangeInnerRadius = 70;
            this.aGauge1.RangeOuterRadius = 80;
            this.aGauge1.RangesColor = new System.Drawing.Color[] {
        System.Drawing.Color.Transparent,
        System.Drawing.Color.Transparent,
        System.Drawing.SystemColors.Control,
        System.Drawing.SystemColors.Control,
        System.Drawing.SystemColors.Control};
            this.aGauge1.RangesEnabled = new bool[] {
        true,
        true,
        false,
        false,
        false};
            this.aGauge1.RangesEndValue = new float[] {
        100F,
        400F,
        0F,
        0F,
        0F};
            this.aGauge1.RangesInnerRadius = new int[] {
        50,
        70,
        70,
        70,
        70};
            this.aGauge1.RangesOuterRadius = new int[] {
        60,
        80,
        80,
        80,
        80};
            this.aGauge1.RangesStartValue = new float[] {
        0F,
        300F,
        0F,
        0F,
        0F};
            this.aGauge1.RangeStartValue = 300F;
            this.aGauge1.ScaleLinesInterColor = System.Drawing.Color.White;
            this.aGauge1.ScaleLinesInterInnerRadius = 50;
            this.aGauge1.ScaleLinesInterOuterRadius = 60;
            this.aGauge1.ScaleLinesInterWidth = 1;
            this.aGauge1.ScaleLinesMajorColor = System.Drawing.Color.White;
            this.aGauge1.ScaleLinesMajorInnerRadius = 50;
            this.aGauge1.ScaleLinesMajorOuterRadius = 60;
            this.aGauge1.ScaleLinesMajorStepValue = 20F;
            this.aGauge1.ScaleLinesMajorWidth = 2;
            this.aGauge1.ScaleLinesMinorColor = System.Drawing.Color.White;
            this.aGauge1.ScaleLinesMinorInnerRadius = 55;
            this.aGauge1.ScaleLinesMinorNumOf = 9;
            this.aGauge1.ScaleLinesMinorOuterRadius = 60;
            this.aGauge1.ScaleLinesMinorWidth = 1;
            this.aGauge1.ScaleNumbersColor = System.Drawing.Color.White;
            this.aGauge1.ScaleNumbersFormat = "0";
            this.aGauge1.ScaleNumbersRadius = 40;
            this.aGauge1.ScaleNumbersRotation = 0;
            this.aGauge1.ScaleNumbersStartScaleLine = 0;
            this.aGauge1.ScaleNumbersStepScaleLines = 1;
            this.aGauge1.Size = new System.Drawing.Size(180, 180);
            this.aGauge1.TabIndex = 11;
            this.aGauge1.Value = 0F;
            this.aGauge1.Value0 = 0F;
            this.aGauge1.Value1 = 0F;
            this.aGauge1.Value2 = 0F;
            this.aGauge1.Value3 = 0F;
            // 
            // hsi1
            // 
            this.hsi1.BackColor = System.Drawing.Color.Black;
            this.hsi1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("hsi1.BackgroundImage")));
            this.hsi1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.hsi1.Font = new System.Drawing.Font("微软雅黑", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.hsi1.Heading = 0;
            this.hsi1.Location = new System.Drawing.Point(691, 0);
            this.hsi1.Margin = new System.Windows.Forms.Padding(4);
            this.hsi1.Name = "hsi1";
            this.hsi1.NavHeading = 0;
            this.hsi1.Size = new System.Drawing.Size(180, 180);
            this.hsi1.TabIndex = 3;
            this.hsi1.Load += new System.EventHandler(this.hsi1_Load);
            // 
            // aGauge3
            // 
            this.aGauge3.BackColor = System.Drawing.Color.Transparent;
            this.aGauge3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.aGauge3.BaseArcColor = System.Drawing.Color.White;
            this.aGauge3.BaseArcRadius = 60;
            this.aGauge3.BaseArcStart = 135;
            this.aGauge3.BaseArcSweep = 270;
            this.aGauge3.BaseArcWidth = 2;
            this.aGauge3.Cap_Idx = ((byte)(1));
            this.aGauge3.CapColor = System.Drawing.Color.White;
            this.aGauge3.CapColors = new System.Drawing.Color[] {
        System.Drawing.Color.Black,
        System.Drawing.Color.White,
        System.Drawing.Color.White,
        System.Drawing.Color.Black,
        System.Drawing.Color.Black};
            this.aGauge3.CapPosition = new System.Drawing.Point(50, 88);
            this.aGauge3.CapsPosition = new System.Drawing.Point[] {
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(50, 88),
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(10, 10)};
            this.aGauge3.CapsText = new string[] {
        "",
        "Speed",
        "",
        "",
        ""};
            this.aGauge3.CapText = "Speed";
            this.aGauge3.CausesValidation = false;
            this.aGauge3.Center = new System.Drawing.Point(70, 80);
            this.aGauge3.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.aGauge3.Location = new System.Drawing.Point(-2, 0);
            this.aGauge3.Margin = new System.Windows.Forms.Padding(2);
            this.aGauge3.MaxValue = 60F;
            this.aGauge3.MinValue = 0F;
            this.aGauge3.Name = "aGauge3";
            this.aGauge3.Need_Idx = ((byte)(3));
            this.aGauge3.NeedleColor1 = AGaugeApp.AGauge.NeedleColorEnum.Gray;
            this.aGauge3.NeedleColor2 = System.Drawing.Color.DimGray;
            this.aGauge3.NeedleEnabled = false;
            this.aGauge3.NeedleRadius = 80;
            this.aGauge3.NeedlesColor1 = new AGaugeApp.AGauge.NeedleColorEnum[] {
        AGaugeApp.AGauge.NeedleColorEnum.Red,
        AGaugeApp.AGauge.NeedleColorEnum.Gray,
        AGaugeApp.AGauge.NeedleColorEnum.Gray,
        AGaugeApp.AGauge.NeedleColorEnum.Gray};
            this.aGauge3.NeedlesColor2 = new System.Drawing.Color[] {
        System.Drawing.Color.DimGray,
        System.Drawing.Color.DimGray,
        System.Drawing.Color.DimGray,
        System.Drawing.Color.DimGray};
            this.aGauge3.NeedlesEnabled = new bool[] {
        true,
        false,
        false,
        false};
            this.aGauge3.NeedlesRadius = new int[] {
        50,
        80,
        80,
        80};
            this.aGauge3.NeedlesType = new int[] {
        0,
        0,
        0,
        0};
            this.aGauge3.NeedlesWidth = new int[] {
        2,
        2,
        2,
        2};
            this.aGauge3.NeedleType = 0;
            this.aGauge3.NeedleWidth = 2;
            this.aGauge3.Range_Idx = ((byte)(1));
            this.aGauge3.RangeColor = System.Drawing.Color.Transparent;
            this.aGauge3.RangeEnabled = true;
            this.aGauge3.RangeEndValue = 60F;
            this.aGauge3.RangeInnerRadius = 51;
            this.aGauge3.RangeOuterRadius = 60;
            this.aGauge3.RangesColor = new System.Drawing.Color[] {
        System.Drawing.Color.Transparent,
        System.Drawing.Color.Transparent,
        System.Drawing.SystemColors.Control,
        System.Drawing.SystemColors.Control,
        System.Drawing.SystemColors.Control};
            this.aGauge3.RangesEnabled = new bool[] {
        true,
        true,
        false,
        false,
        false};
            this.aGauge3.RangesEndValue = new float[] {
        60F,
        60F,
        0F,
        0F,
        0F};
            this.aGauge3.RangesInnerRadius = new int[] {
        50,
        51,
        70,
        70,
        70};
            this.aGauge3.RangesOuterRadius = new int[] {
        60,
        60,
        80,
        80,
        80};
            this.aGauge3.RangesStartValue = new float[] {
        0F,
        50F,
        0F,
        0F,
        0F};
            this.aGauge3.RangeStartValue = 50F;
            this.aGauge3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.aGauge3.ScaleLinesInterColor = System.Drawing.Color.White;
            this.aGauge3.ScaleLinesInterInnerRadius = 50;
            this.aGauge3.ScaleLinesInterOuterRadius = 60;
            this.aGauge3.ScaleLinesInterWidth = 1;
            this.aGauge3.ScaleLinesMajorColor = System.Drawing.Color.White;
            this.aGauge3.ScaleLinesMajorInnerRadius = 50;
            this.aGauge3.ScaleLinesMajorOuterRadius = 60;
            this.aGauge3.ScaleLinesMajorStepValue = 10F;
            this.aGauge3.ScaleLinesMajorWidth = 2;
            this.aGauge3.ScaleLinesMinorColor = System.Drawing.Color.White;
            this.aGauge3.ScaleLinesMinorInnerRadius = 55;
            this.aGauge3.ScaleLinesMinorNumOf = 9;
            this.aGauge3.ScaleLinesMinorOuterRadius = 60;
            this.aGauge3.ScaleLinesMinorWidth = 1;
            this.aGauge3.ScaleNumbersColor = System.Drawing.Color.White;
            this.aGauge3.ScaleNumbersFormat = "0";
            this.aGauge3.ScaleNumbersRadius = 40;
            this.aGauge3.ScaleNumbersRotation = 0;
            this.aGauge3.ScaleNumbersStartScaleLine = 0;
            this.aGauge3.ScaleNumbersStepScaleLines = 1;
            this.aGauge3.Size = new System.Drawing.Size(180, 180);
            this.aGauge3.TabIndex = 9;
            this.aGauge3.Value = 0F;
            this.aGauge3.Value0 = 10F;
            this.aGauge3.Value1 = 4F;
            this.aGauge3.Value2 = 0F;
            this.aGauge3.Value3 = 0F;
            // 
            // aGauge4
            // 
            this.aGauge4.BackColor = System.Drawing.Color.Transparent;
            this.aGauge4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.aGauge4.BaseArcColor = System.Drawing.Color.White;
            this.aGauge4.BaseArcRadius = 60;
            this.aGauge4.BaseArcStart = 135;
            this.aGauge4.BaseArcSweep = 270;
            this.aGauge4.BaseArcWidth = 2;
            this.aGauge4.Cap_Idx = ((byte)(1));
            this.aGauge4.CapColor = System.Drawing.Color.White;
            this.aGauge4.CapColors = new System.Drawing.Color[] {
        System.Drawing.Color.Black,
        System.Drawing.Color.White,
        System.Drawing.Color.Black,
        System.Drawing.Color.Black,
        System.Drawing.Color.Black};
            this.aGauge4.CapPosition = new System.Drawing.Point(10, 10);
            this.aGauge4.CapsPosition = new System.Drawing.Point[] {
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(10, 10)};
            this.aGauge4.CapsText = new string[] {
        "",
        "",
        "",
        "",
        ""};
            this.aGauge4.CapText = "";
            this.aGauge4.Center = new System.Drawing.Point(70, 80);
            this.aGauge4.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.aGauge4.Location = new System.Drawing.Point(173, 2);
            this.aGauge4.Margin = new System.Windows.Forms.Padding(2);
            this.aGauge4.MaxValue = 100F;
            this.aGauge4.MinValue = 0F;
            this.aGauge4.Name = "aGauge4";
            this.aGauge4.Need_Idx = ((byte)(3));
            this.aGauge4.NeedleColor1 = AGaugeApp.AGauge.NeedleColorEnum.Gray;
            this.aGauge4.NeedleColor2 = System.Drawing.Color.DimGray;
            this.aGauge4.NeedleEnabled = false;
            this.aGauge4.NeedleRadius = 80;
            this.aGauge4.NeedlesColor1 = new AGaugeApp.AGauge.NeedleColorEnum[] {
        AGaugeApp.AGauge.NeedleColorEnum.Red,
        AGaugeApp.AGauge.NeedleColorEnum.Gray,
        AGaugeApp.AGauge.NeedleColorEnum.Gray,
        AGaugeApp.AGauge.NeedleColorEnum.Gray};
            this.aGauge4.NeedlesColor2 = new System.Drawing.Color[] {
        System.Drawing.Color.DimGray,
        System.Drawing.Color.DimGray,
        System.Drawing.Color.DimGray,
        System.Drawing.Color.DimGray};
            this.aGauge4.NeedlesEnabled = new bool[] {
        true,
        false,
        false,
        false};
            this.aGauge4.NeedlesRadius = new int[] {
        55,
        80,
        80,
        80};
            this.aGauge4.NeedlesType = new int[] {
        0,
        0,
        0,
        0};
            this.aGauge4.NeedlesWidth = new int[] {
        2,
        2,
        2,
        2};
            this.aGauge4.NeedleType = 0;
            this.aGauge4.NeedleWidth = 2;
            this.aGauge4.Range_Idx = ((byte)(1));
            this.aGauge4.RangeColor = System.Drawing.Color.Transparent;
            this.aGauge4.RangeEnabled = true;
            this.aGauge4.RangeEndValue = 400F;
            this.aGauge4.RangeInnerRadius = 70;
            this.aGauge4.RangeOuterRadius = 80;
            this.aGauge4.RangesColor = new System.Drawing.Color[] {
        System.Drawing.Color.Transparent,
        System.Drawing.Color.Transparent,
        System.Drawing.SystemColors.Control,
        System.Drawing.SystemColors.Control,
        System.Drawing.SystemColors.Control};
            this.aGauge4.RangesEnabled = new bool[] {
        true,
        true,
        false,
        false,
        false};
            this.aGauge4.RangesEndValue = new float[] {
        100F,
        400F,
        0F,
        0F,
        0F};
            this.aGauge4.RangesInnerRadius = new int[] {
        50,
        70,
        70,
        70,
        70};
            this.aGauge4.RangesOuterRadius = new int[] {
        60,
        80,
        80,
        80,
        80};
            this.aGauge4.RangesStartValue = new float[] {
        0F,
        300F,
        0F,
        0F,
        0F};
            this.aGauge4.RangeStartValue = 300F;
            this.aGauge4.ScaleLinesInterColor = System.Drawing.Color.White;
            this.aGauge4.ScaleLinesInterInnerRadius = 50;
            this.aGauge4.ScaleLinesInterOuterRadius = 60;
            this.aGauge4.ScaleLinesInterWidth = 1;
            this.aGauge4.ScaleLinesMajorColor = System.Drawing.Color.White;
            this.aGauge4.ScaleLinesMajorInnerRadius = 50;
            this.aGauge4.ScaleLinesMajorOuterRadius = 60;
            this.aGauge4.ScaleLinesMajorStepValue = 20F;
            this.aGauge4.ScaleLinesMajorWidth = 2;
            this.aGauge4.ScaleLinesMinorColor = System.Drawing.Color.White;
            this.aGauge4.ScaleLinesMinorInnerRadius = 55;
            this.aGauge4.ScaleLinesMinorNumOf = 9;
            this.aGauge4.ScaleLinesMinorOuterRadius = 60;
            this.aGauge4.ScaleLinesMinorWidth = 1;
            this.aGauge4.ScaleNumbersColor = System.Drawing.Color.White;
            this.aGauge4.ScaleNumbersFormat = "0";
            this.aGauge4.ScaleNumbersRadius = 40;
            this.aGauge4.ScaleNumbersRotation = 0;
            this.aGauge4.ScaleNumbersStartScaleLine = 0;
            this.aGauge4.ScaleNumbersStepScaleLines = 1;
            this.aGauge4.Size = new System.Drawing.Size(180, 180);
            this.aGauge4.TabIndex = 10;
            this.aGauge4.Value = 0F;
            this.aGauge4.Value0 = 0F;
            this.aGauge4.Value1 = 0F;
            this.aGauge4.Value2 = 0F;
            this.aGauge4.Value3 = 0F;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.Black;
            this.tabPage2.Controls.Add(this.textBox1);
            this.tabPage2.Controls.Add(this.btnOpenCom);
            this.tabPage2.Controls.Add(this.cbxBaudRate);
            this.tabPage2.Controls.Add(this.cbxCOMPort);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(867, 183);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "状态";
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(191, 24);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(537, 131);
            this.textBox1.TabIndex = 3;
            // 
            // btnOpenCom
            // 
            this.btnOpenCom.BackColor = System.Drawing.Color.White;
            this.btnOpenCom.ForeColor = System.Drawing.Color.Black;
            this.btnOpenCom.Location = new System.Drawing.Point(40, 118);
            this.btnOpenCom.Name = "btnOpenCom";
            this.btnOpenCom.Size = new System.Drawing.Size(121, 37);
            this.btnOpenCom.TabIndex = 2;
            this.btnOpenCom.Text = "打开串口";
            this.btnOpenCom.UseVisualStyleBackColor = false;
            this.btnOpenCom.Click += new System.EventHandler(this.btnOpenCom_Click);
            // 
            // cbxBaudRate
            // 
            this.cbxBaudRate.AutoCompleteCustomSource.AddRange(new string[] {
            "1200\t",
            "2400",
            "4800",
            "9600",
            "19200",
            "28400",
            "43000",
            "56000",
            "57600"});
            this.cbxBaudRate.FormattingEnabled = true;
            this.cbxBaudRate.Items.AddRange(new object[] {
            "1200",
            "2400",
            "4800",
            "9600",
            "19200",
            "115200"});
            this.cbxBaudRate.Location = new System.Drawing.Point(40, 69);
            this.cbxBaudRate.Name = "cbxBaudRate";
            this.cbxBaudRate.Size = new System.Drawing.Size(121, 28);
            this.cbxBaudRate.TabIndex = 1;
            this.cbxBaudRate.Text = "115200";
            this.cbxBaudRate.SelectedIndexChanged += new System.EventHandler(this.cbxBaudRate_SelectedIndexChanged);
            // 
            // cbxCOMPort
            // 
            this.cbxCOMPort.FormattingEnabled = true;
            this.cbxCOMPort.Location = new System.Drawing.Point(40, 24);
            this.cbxCOMPort.Name = "cbxCOMPort";
            this.cbxCOMPort.Size = new System.Drawing.Size(121, 28);
            this.cbxCOMPort.TabIndex = 0;
            // 
            // TabPageData
            // 
            this.TabPageData.BackColor = System.Drawing.Color.Black;
            this.TabPageData.BorderColor = System.Drawing.Color.White;
            this.TabPageData.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TabPageData.Controls.Add(this.zedGraphControl1);
            this.TabPageData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabPageData.Font = new System.Drawing.Font("微软雅黑", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TabPageData.ForeColor = System.Drawing.Color.White;
            this.TabPageData.Location = new System.Drawing.Point(0, 90);
            this.TabPageData.Margin = new System.Windows.Forms.Padding(2);
            this.TabPageData.Name = "TabPageData";
            this.TabPageData.Size = new System.Drawing.Size(892, 612);
            this.TabPageData.TabIndex = 3;
            this.TabPageData.TabItemImage = ((System.Drawing.Image)(resources.GetObject("TabPageData.TabItemImage")));
            this.TabPageData.Text = "数据显示";
            // 
            // zedGraphControl1
            // 
            this.zedGraphControl1.BackColor = System.Drawing.Color.Black;
            this.zedGraphControl1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.zedGraphControl1.Location = new System.Drawing.Point(54, 29);
            this.zedGraphControl1.Margin = new System.Windows.Forms.Padding(4);
            this.zedGraphControl1.Name = "zedGraphControl1";
            this.zedGraphControl1.ScrollGrace = 0D;
            this.zedGraphControl1.ScrollMaxX = 0D;
            this.zedGraphControl1.ScrollMaxY = 0D;
            this.zedGraphControl1.ScrollMaxY2 = 0D;
            this.zedGraphControl1.ScrollMinX = 0D;
            this.zedGraphControl1.ScrollMinY = 0D;
            this.zedGraphControl1.ScrollMinY2 = 0D;
            this.zedGraphControl1.Size = new System.Drawing.Size(726, 467);
            this.zedGraphControl1.TabIndex = 0;
            // 
            // TabPageSetting
            // 
            this.TabPageSetting.BackColor = System.Drawing.Color.Black;
            this.TabPageSetting.BorderColor = System.Drawing.Color.White;
            this.TabPageSetting.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TabPageSetting.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabPageSetting.Font = new System.Drawing.Font("微软雅黑", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TabPageSetting.ForeColor = System.Drawing.Color.White;
            this.TabPageSetting.Location = new System.Drawing.Point(0, 90);
            this.TabPageSetting.Margin = new System.Windows.Forms.Padding(2);
            this.TabPageSetting.Name = "TabPageSetting";
            this.TabPageSetting.Size = new System.Drawing.Size(892, 612);
            this.TabPageSetting.TabIndex = 1;
            this.TabPageSetting.TabItemImage = ((System.Drawing.Image)(resources.GetObject("TabPageSetting.TabItemImage")));
            this.TabPageSetting.Text = "参数设置";
            // 
            // TabPageInfo
            // 
            this.TabPageInfo.BackColor = System.Drawing.Color.Black;
            this.TabPageInfo.BorderColor = System.Drawing.Color.White;
            this.TabPageInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TabPageInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabPageInfo.Font = new System.Drawing.Font("微软雅黑", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TabPageInfo.ForeColor = System.Drawing.Color.White;
            this.TabPageInfo.Location = new System.Drawing.Point(0, 90);
            this.TabPageInfo.Margin = new System.Windows.Forms.Padding(2);
            this.TabPageInfo.Name = "TabPageInfo";
            this.TabPageInfo.Size = new System.Drawing.Size(892, 612);
            this.TabPageInfo.TabIndex = 2;
            this.TabPageInfo.TabItemImage = ((System.Drawing.Image)(resources.GetObject("TabPageInfo.TabItemImage")));
            this.TabPageInfo.Text = "软件信息";
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // elementHost2
            // 
            this.elementHost2.Location = new System.Drawing.Point(0, 3);
            this.elementHost2.Name = "elementHost2";
            this.elementHost2.Size = new System.Drawing.Size(561, 377);
            this.elementHost2.TabIndex = 0;
            this.elementHost2.Text = "elementHost2";
            this.elementHost2.Child = this.userControl12;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(892, 702);
            this.Controls.Add(this.TabMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmMain";
            this.Text = "AUV Remote Monitor 1.1.2";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.TabMain.ResumeLayout(false);
            this.TabPageIndex.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.TabPageData.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private CCWin.SkinControl.SkinTabControl TabMain;
        private CCWin.SkinControl.SkinTabPage TabPageInfo;
        private CCWin.SkinControl.SkinTabPage TabPageData;
        private CCWin.SkinControl.SkinTabPage TabPageIndex;
        private metergroup.PitchAndBank pitchAndBank1;
        private MissionPlanner.Controls.HSI hsi1;
        private MissionPlanner.Controls.QuickView quickView4;
        private MissionPlanner.Controls.QuickView quickView3;
        private MissionPlanner.Controls.QuickView quickView2;
        private MissionPlanner.Controls.QuickView quickView1;
        private AGaugeApp.AGauge aGauge3;
        private AGaugeApp.AGauge aGauge4;
        private ZedGraph.ZedGraphControl zedGraphControl1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private AGaugeApp.AGauge aGauge1;
        private AGaugeApp.AGauge aGauge2;
        private CCWin.SkinControl.SkinTabPage TabPageSetting;
        private System.Windows.Forms.Integration.ElementHost elementHost1;
        private UserControl1 userControl11;
        private System.Windows.Forms.Integration.ElementHost elementHost2;
        private UserControl1 userControl12;
        private System.Windows.Forms.Button btnOpenCom;
        private System.Windows.Forms.ComboBox cbxBaudRate;
        private System.Windows.Forms.ComboBox cbxCOMPort;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.TextBox textBox1;
    }
}

