namespace Tekne1._8_Uygulama
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.gMap_dumen = new GMap.NET.WindowsForms.GMapControl();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.FullScreen = new System.Windows.Forms.Button();
            this.FormClose = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.timer_data = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.unlem_isk1 = new System.Windows.Forms.PictureBox();
            this.unlem_sck1 = new System.Windows.Forms.PictureBox();
            this.unlem_isk0 = new System.Windows.Forms.PictureBox();
            this.unlem_sck0 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.button4 = new System.Windows.Forms.Button();
            this.chart_iskele = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart_sancak = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.textBox_voltage = new System.Windows.Forms.TextBox();
            this.chart_voltage = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.button5 = new System.Windows.Forms.Button();
            this.timer_gps = new System.Windows.Forms.Timer(this.components);
            this.label7 = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.aGauge_compass = new System.Windows.Forms.AGauge();
            this.aGauge_yon = new System.Windows.Forms.AGauge();
            this.aGauge_sck_a = new System.Windows.Forms.AGauge();
            this.aGauge_isk_a = new System.Windows.Forms.AGauge();
            this.aGauge_isk = new System.Windows.Forms.AGauge();
            this.aGauge1 = new System.Windows.Forms.AGauge();
            this.aGauge_sck = new System.Windows.Forms.AGauge();
            this.aGauge_dumen = new System.Windows.Forms.AGauge();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.unlem_isk1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.unlem_sck1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.unlem_isk0)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.unlem_sck0)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_iskele)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_sancak)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_voltage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.SuspendLayout();
            // 
            // gMap_dumen
            // 
            this.gMap_dumen.Bearing = 0F;
            this.gMap_dumen.CanDragMap = true;
            this.gMap_dumen.EmptyTileColor = System.Drawing.Color.Navy;
            this.gMap_dumen.GrayScaleMode = false;
            this.gMap_dumen.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.gMap_dumen.LevelsKeepInMemory = 5;
            this.gMap_dumen.Location = new System.Drawing.Point(412, -4);
            this.gMap_dumen.MarkersEnabled = true;
            this.gMap_dumen.MaxZoom = 2;
            this.gMap_dumen.MinZoom = 2;
            this.gMap_dumen.MouseWheelZoomEnabled = true;
            this.gMap_dumen.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.gMap_dumen.Name = "gMap_dumen";
            this.gMap_dumen.NegativeMode = false;
            this.gMap_dumen.PolygonsEnabled = true;
            this.gMap_dumen.RetryLoadTile = 0;
            this.gMap_dumen.RoutesEnabled = true;
            this.gMap_dumen.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.gMap_dumen.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.gMap_dumen.ShowTileGridLines = false;
            this.gMap_dumen.Size = new System.Drawing.Size(1081, 573);
            this.gMap_dumen.TabIndex = 0;
            this.gMap_dumen.Zoom = 0D;
            this.gMap_dumen.MouseClick += new System.Windows.Forms.MouseEventHandler(this.gMap_dumen_MouseClick);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(121, 931);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(84, 21);
            this.comboBox1.TabIndex = 1;
            // 
            // FullScreen
            // 
            this.FullScreen.BackColor = System.Drawing.Color.Gray;
            this.FullScreen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FullScreen.Location = new System.Drawing.Point(121, 902);
            this.FullScreen.Name = "FullScreen";
            this.FullScreen.Size = new System.Drawing.Size(84, 23);
            this.FullScreen.TabIndex = 3;
            this.FullScreen.Text = "FullScreen";
            this.FullScreen.UseVisualStyleBackColor = false;
            this.FullScreen.Click += new System.EventHandler(this.FullScreen_Click);
            // 
            // FormClose
            // 
            this.FormClose.BackColor = System.Drawing.Color.Gray;
            this.FormClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FormClose.Location = new System.Drawing.Point(211, 902);
            this.FormClose.Name = "FormClose";
            this.FormClose.Size = new System.Drawing.Size(84, 23);
            this.FormClose.TabIndex = 4;
            this.FormClose.Text = "Close";
            this.FormClose.UseVisualStyleBackColor = false;
            this.FormClose.Click += new System.EventHandler(this.FormClose_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.Gray;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Location = new System.Drawing.Point(1023, 635);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 13);
            this.textBox1.TabIndex = 5;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // timer_data
            // 
            this.timer_data.Interval = 1;
            this.timer_data.Tick += new System.EventHandler(this.timer_data_Tick_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(957, 635);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Latitude";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(40, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(230, 41);
            this.label4.TabIndex = 16;
            this.label4.Text = "ISKELE MOTOR";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(1598, 63);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(258, 41);
            this.label5.TabIndex = 17;
            this.label5.Text = "SANCAK MOTOR";
            // 
            // unlem_isk1
            // 
            this.unlem_isk1.Image = ((System.Drawing.Image)(resources.GetObject("unlem_isk1.Image")));
            this.unlem_isk1.Location = new System.Drawing.Point(154, 286);
            this.unlem_isk1.Name = "unlem_isk1";
            this.unlem_isk1.Size = new System.Drawing.Size(42, 39);
            this.unlem_isk1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.unlem_isk1.TabIndex = 20;
            this.unlem_isk1.TabStop = false;
            // 
            // unlem_sck1
            // 
            this.unlem_sck1.Image = ((System.Drawing.Image)(resources.GetObject("unlem_sck1.Image")));
            this.unlem_sck1.Location = new System.Drawing.Point(1711, 286);
            this.unlem_sck1.Name = "unlem_sck1";
            this.unlem_sck1.Size = new System.Drawing.Size(42, 39);
            this.unlem_sck1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.unlem_sck1.TabIndex = 21;
            this.unlem_sck1.TabStop = false;
            // 
            // unlem_isk0
            // 
            this.unlem_isk0.Image = ((System.Drawing.Image)(resources.GetObject("unlem_isk0.Image")));
            this.unlem_isk0.Location = new System.Drawing.Point(154, 286);
            this.unlem_isk0.Name = "unlem_isk0";
            this.unlem_isk0.Size = new System.Drawing.Size(42, 39);
            this.unlem_isk0.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.unlem_isk0.TabIndex = 22;
            this.unlem_isk0.TabStop = false;
            // 
            // unlem_sck0
            // 
            this.unlem_sck0.Image = ((System.Drawing.Image)(resources.GetObject("unlem_sck0.Image")));
            this.unlem_sck0.Location = new System.Drawing.Point(1711, 286);
            this.unlem_sck0.Name = "unlem_sck0";
            this.unlem_sck0.Size = new System.Drawing.Size(42, 39);
            this.unlem_sck0.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.unlem_sck0.TabIndex = 23;
            this.unlem_sck0.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(460, 835);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(64, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 26;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(694, 835);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(64, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 27;
            this.pictureBox2.TabStop = false;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.Gray;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Location = new System.Drawing.Point(1023, 667);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 13);
            this.textBox2.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Gray;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(834, 660);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(117, 26);
            this.button1.TabIndex = 7;
            this.button1.Text = "Set Waypoint";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Gray;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(834, 628);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(117, 26);
            this.button2.TabIndex = 8;
            this.button2.Text = "Clear";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(957, 667);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Lontitude";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Gray;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(211, 929);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(84, 23);
            this.button3.TabIndex = 29;
            this.button3.Text = "Connect";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "9600\t",
            "115200"});
            this.comboBox2.Location = new System.Drawing.Point(121, 958);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(84, 21);
            this.comboBox2.TabIndex = 30;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Gray;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Location = new System.Drawing.Point(211, 956);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(84, 23);
            this.button4.TabIndex = 31;
            this.button4.Text = "Disconnect";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // chart_iskele
            // 
            this.chart_iskele.BackColor = System.Drawing.Color.DimGray;
            this.chart_iskele.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.chart_iskele.BackImageAlignment = System.Windows.Forms.DataVisualization.Charting.ChartImageAlignmentStyle.Top;
            this.chart_iskele.BorderlineColor = System.Drawing.Color.Black;
            chartArea1.AlignmentStyle = System.Windows.Forms.DataVisualization.Charting.AreaAlignmentStyles.None;
            chartArea1.BackColor = System.Drawing.Color.DimGray;
            chartArea1.BackImageTransparentColor = System.Drawing.Color.White;
            chartArea1.BackSecondaryColor = System.Drawing.Color.Green;
            chartArea1.Name = "ChartArea1";
            this.chart_iskele.ChartAreas.Add(chartArea1);
            this.chart_iskele.Cursor = System.Windows.Forms.Cursors.Default;
            legend1.Name = "Legend1";
            this.chart_iskele.Legends.Add(legend1);
            this.chart_iskele.Location = new System.Drawing.Point(-3, 354);
            this.chart_iskele.Name = "chart_iskele";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series1.Color = System.Drawing.Color.Red;
            series1.Legend = "Legend1";
            series1.Name = "Power";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series2.LabelBorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.DashDot;
            series2.Legend = "Legend1";
            series2.MarkerBorderWidth = 2;
            series2.Name = "Current";
            this.chart_iskele.Series.Add(series1);
            this.chart_iskele.Series.Add(series2);
            this.chart_iskele.Size = new System.Drawing.Size(476, 253);
            this.chart_iskele.TabIndex = 32;
            this.chart_iskele.Text = "chart1";
            // 
            // chart_sancak
            // 
            this.chart_sancak.BackColor = System.Drawing.Color.DimGray;
            this.chart_sancak.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.chart_sancak.BackImageAlignment = System.Windows.Forms.DataVisualization.Charting.ChartImageAlignmentStyle.Top;
            this.chart_sancak.BorderlineColor = System.Drawing.Color.Black;
            chartArea2.AlignmentStyle = System.Windows.Forms.DataVisualization.Charting.AreaAlignmentStyles.None;
            chartArea2.BackColor = System.Drawing.Color.DimGray;
            chartArea2.BackImageTransparentColor = System.Drawing.Color.White;
            chartArea2.BackSecondaryColor = System.Drawing.Color.Green;
            chartArea2.Name = "ChartArea1";
            this.chart_sancak.ChartAreas.Add(chartArea2);
            this.chart_sancak.Cursor = System.Windows.Forms.Cursors.Default;
            legend2.Name = "Legend1";
            this.chart_sancak.Legends.Add(legend2);
            this.chart_sancak.Location = new System.Drawing.Point(1535, 365);
            this.chart_sancak.Name = "chart_sancak";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series3.Color = System.Drawing.Color.Red;
            series3.Legend = "Legend1";
            series3.Name = "Power";
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series4.LabelBorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.DashDot;
            series4.Legend = "Legend1";
            series4.MarkerBorderWidth = 2;
            series4.Name = "Current";
            this.chart_sancak.Series.Add(series3);
            this.chart_sancak.Series.Add(series4);
            this.chart_sancak.Size = new System.Drawing.Size(476, 253);
            this.chart_sancak.TabIndex = 33;
            this.chart_sancak.Text = "chart1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(138, 853);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 32);
            this.label3.TabIndex = 36;
            this.label3.Text = "COM PORT";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(102, 888);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(212, 106);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 37;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(746, 612);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(408, 93);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 38;
            this.pictureBox4.TabStop = false;
            // 
            // textBox_voltage
            // 
            this.textBox_voltage.BackColor = System.Drawing.Color.Gray;
            this.textBox_voltage.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_voltage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox_voltage.Location = new System.Drawing.Point(1622, 681);
            this.textBox_voltage.Name = "textBox_voltage";
            this.textBox_voltage.Size = new System.Drawing.Size(73, 19);
            this.textBox_voltage.TabIndex = 39;
            // 
            // chart_voltage
            // 
            this.chart_voltage.BackColor = System.Drawing.Color.DimGray;
            this.chart_voltage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.chart_voltage.BackImageAlignment = System.Windows.Forms.DataVisualization.Charting.ChartImageAlignmentStyle.Top;
            this.chart_voltage.BorderlineColor = System.Drawing.Color.Black;
            chartArea3.AlignmentStyle = System.Windows.Forms.DataVisualization.Charting.AreaAlignmentStyles.None;
            chartArea3.BackColor = System.Drawing.Color.DimGray;
            chartArea3.BackImageTransparentColor = System.Drawing.Color.White;
            chartArea3.BackSecondaryColor = System.Drawing.Color.Green;
            chartArea3.Name = "ChartArea1";
            this.chart_voltage.ChartAreas.Add(chartArea3);
            this.chart_voltage.Cursor = System.Windows.Forms.Cursors.Default;
            legend3.Name = "Legend1";
            this.chart_voltage.Legends.Add(legend3);
            this.chart_voltage.Location = new System.Drawing.Point(1406, 706);
            this.chart_voltage.Name = "chart_voltage";
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series5.Color = System.Drawing.Color.LawnGreen;
            series5.Legend = "Legend1";
            series5.Name = "voltage";
            series6.ChartArea = "ChartArea1";
            series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series6.Color = System.Drawing.Color.Firebrick;
            series6.Legend = "Legend1";
            series6.Name = "min";
            series7.ChartArea = "ChartArea1";
            series7.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series7.Color = System.Drawing.Color.Blue;
            series7.Legend = "Legend1";
            series7.Name = "max";
            this.chart_voltage.Series.Add(series5);
            this.chart_voltage.Series.Add(series6);
            this.chart_voltage.Series.Add(series7);
            this.chart_voltage.Size = new System.Drawing.Size(614, 253);
            this.chart_voltage.TabIndex = 40;
            this.chart_voltage.Text = "chart1";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(1498, 671);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(118, 32);
            this.label6.TabIndex = 36;
            this.label6.Text = "VOLTAGE";
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(83, 695);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(255, 132);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 41;
            this.pictureBox5.TabStop = false;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Gray;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Location = new System.Drawing.Point(101, 706);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(113, 23);
            this.button5.TabIndex = 43;
            this.button5.Text = "Yön Bulma";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // timer_gps
            // 
            this.timer_gps.Interval = 10;
            this.timer_gps.Tick += new System.EventHandler(this.timer_gps_Tick);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Silver;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(132, 793);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 13);
            this.label7.TabIndex = 44;
            this.label7.Text = "Durum";
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.Gray;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Location = new System.Drawing.Point(101, 735);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(113, 23);
            this.button6.TabIndex = 45;
            this.button6.Text = "Kontolü Al";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(114, 660);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(209, 32);
            this.label8.TabIndex = 46;
            this.label8.Text = "TEKNE KONTROL";
            // 
            // aGauge_compass
            // 
            this.aGauge_compass.BackColor = System.Drawing.Color.Silver;
            this.aGauge_compass.BaseArcColor = System.Drawing.Color.Black;
            this.aGauge_compass.BaseArcRadius = 80;
            this.aGauge_compass.BaseArcStart = 0;
            this.aGauge_compass.BaseArcSweep = 360;
            this.aGauge_compass.BaseArcWidth = 2;
            this.aGauge_compass.GaugeAutoSize = true;
            this.aGauge_compass.Location = new System.Drawing.Point(220, 706);
            this.aGauge_compass.MaxValue = 360F;
            this.aGauge_compass.MinValue = 0F;
            this.aGauge_compass.Name = "aGauge_compass";
            this.aGauge_compass.NeedleColor1 = System.Windows.Forms.AGaugeNeedleColor.Gray;
            this.aGauge_compass.NeedleColor2 = System.Drawing.Color.Gray;
            this.aGauge_compass.NeedleRadius = 80;
            this.aGauge_compass.NeedleType = System.Windows.Forms.NeedleType.Simple;
            this.aGauge_compass.NeedleWidth = 4;
            this.aGauge_compass.ScaleLinesInterColor = System.Drawing.Color.DarkRed;
            this.aGauge_compass.ScaleLinesInterInnerRadius = 73;
            this.aGauge_compass.ScaleLinesInterOuterRadius = 80;
            this.aGauge_compass.ScaleLinesInterWidth = 1;
            this.aGauge_compass.ScaleLinesMajorColor = System.Drawing.Color.DarkRed;
            this.aGauge_compass.ScaleLinesMajorInnerRadius = 70;
            this.aGauge_compass.ScaleLinesMajorOuterRadius = 90;
            this.aGauge_compass.ScaleLinesMajorStepValue = 90F;
            this.aGauge_compass.ScaleLinesMajorWidth = 3;
            this.aGauge_compass.ScaleLinesMinorColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.aGauge_compass.ScaleLinesMinorInnerRadius = 75;
            this.aGauge_compass.ScaleLinesMinorOuterRadius = 80;
            this.aGauge_compass.ScaleLinesMinorTicks = 9;
            this.aGauge_compass.ScaleLinesMinorWidth = 1;
            this.aGauge_compass.ScaleNumbersColor = System.Drawing.Color.Black;
            this.aGauge_compass.ScaleNumbersFormat = null;
            this.aGauge_compass.ScaleNumbersRadius = 200;
            this.aGauge_compass.ScaleNumbersRotation = 0;
            this.aGauge_compass.ScaleNumbersStartScaleLine = 0;
            this.aGauge_compass.ScaleNumbersStepScaleLines = 1;
            this.aGauge_compass.Size = new System.Drawing.Size(104, 110);
            this.aGauge_compass.TabIndex = 42;
            this.aGauge_compass.Text = "aGauge3";
            this.aGauge_compass.Value = 0F;
            // 
            // aGauge_yon
            // 
            this.aGauge_yon.BaseArcColor = System.Drawing.Color.Black;
            this.aGauge_yon.BaseArcRadius = 80;
            this.aGauge_yon.BaseArcStart = 0;
            this.aGauge_yon.BaseArcSweep = 360;
            this.aGauge_yon.BaseArcWidth = 2;
            this.aGauge_yon.GaugeAutoSize = false;
            this.aGauge_yon.Location = new System.Drawing.Point(1050, 740);
            this.aGauge_yon.MaxValue = 360F;
            this.aGauge_yon.MinValue = 0F;
            this.aGauge_yon.Name = "aGauge_yon";
            this.aGauge_yon.NeedleColor1 = System.Windows.Forms.AGaugeNeedleColor.Gray;
            this.aGauge_yon.NeedleColor2 = System.Drawing.Color.Gray;
            this.aGauge_yon.NeedleRadius = 80;
            this.aGauge_yon.NeedleType = System.Windows.Forms.NeedleType.Simple;
            this.aGauge_yon.NeedleWidth = 4;
            this.aGauge_yon.ScaleLinesInterColor = System.Drawing.Color.DarkRed;
            this.aGauge_yon.ScaleLinesInterInnerRadius = 73;
            this.aGauge_yon.ScaleLinesInterOuterRadius = 80;
            this.aGauge_yon.ScaleLinesInterWidth = 1;
            this.aGauge_yon.ScaleLinesMajorColor = System.Drawing.Color.DarkRed;
            this.aGauge_yon.ScaleLinesMajorInnerRadius = 70;
            this.aGauge_yon.ScaleLinesMajorOuterRadius = 90;
            this.aGauge_yon.ScaleLinesMajorStepValue = 90F;
            this.aGauge_yon.ScaleLinesMajorWidth = 3;
            this.aGauge_yon.ScaleLinesMinorColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.aGauge_yon.ScaleLinesMinorInnerRadius = 75;
            this.aGauge_yon.ScaleLinesMinorOuterRadius = 80;
            this.aGauge_yon.ScaleLinesMinorTicks = 9;
            this.aGauge_yon.ScaleLinesMinorWidth = 1;
            this.aGauge_yon.ScaleNumbersColor = System.Drawing.Color.Black;
            this.aGauge_yon.ScaleNumbersFormat = null;
            this.aGauge_yon.ScaleNumbersRadius = 200;
            this.aGauge_yon.ScaleNumbersRotation = 0;
            this.aGauge_yon.ScaleNumbersStartScaleLine = 0;
            this.aGauge_yon.ScaleNumbersStepScaleLines = 1;
            this.aGauge_yon.Size = new System.Drawing.Size(210, 198);
            this.aGauge_yon.TabIndex = 28;
            this.aGauge_yon.Text = "aGauge3";
            this.aGauge_yon.Value = 0F;
            // 
            // aGauge_sck_a
            // 
            this.aGauge_sck_a.BaseArcColor = System.Drawing.Color.Black;
            this.aGauge_sck_a.BaseArcRadius = 80;
            this.aGauge_sck_a.BaseArcStart = 180;
            this.aGauge_sck_a.BaseArcSweep = 250;
            this.aGauge_sck_a.BaseArcWidth = 2;
            this.aGauge_sck_a.GaugeAutoSize = true;
            this.aGauge_sck_a.Location = new System.Drawing.Point(1759, 204);
            this.aGauge_sck_a.MaxValue = 100F;
            this.aGauge_sck_a.MinValue = 0F;
            this.aGauge_sck_a.Name = "aGauge_sck_a";
            this.aGauge_sck_a.NeedleColor1 = System.Windows.Forms.AGaugeNeedleColor.Gray;
            this.aGauge_sck_a.NeedleColor2 = System.Drawing.Color.Gray;
            this.aGauge_sck_a.NeedleRadius = 80;
            this.aGauge_sck_a.NeedleType = System.Windows.Forms.NeedleType.Advance;
            this.aGauge_sck_a.NeedleWidth = 2;
            this.aGauge_sck_a.ScaleLinesInterColor = System.Drawing.Color.Black;
            this.aGauge_sck_a.ScaleLinesInterInnerRadius = 73;
            this.aGauge_sck_a.ScaleLinesInterOuterRadius = 80;
            this.aGauge_sck_a.ScaleLinesInterWidth = 1;
            this.aGauge_sck_a.ScaleLinesMajorColor = System.Drawing.Color.DarkRed;
            this.aGauge_sck_a.ScaleLinesMajorInnerRadius = 70;
            this.aGauge_sck_a.ScaleLinesMajorOuterRadius = 80;
            this.aGauge_sck_a.ScaleLinesMajorStepValue = 20F;
            this.aGauge_sck_a.ScaleLinesMajorWidth = 2;
            this.aGauge_sck_a.ScaleLinesMinorColor = System.Drawing.Color.Gray;
            this.aGauge_sck_a.ScaleLinesMinorInnerRadius = 75;
            this.aGauge_sck_a.ScaleLinesMinorOuterRadius = 80;
            this.aGauge_sck_a.ScaleLinesMinorTicks = 9;
            this.aGauge_sck_a.ScaleLinesMinorWidth = 1;
            this.aGauge_sck_a.ScaleNumbersColor = System.Drawing.Color.Black;
            this.aGauge_sck_a.ScaleNumbersFormat = null;
            this.aGauge_sck_a.ScaleNumbersRadius = 95;
            this.aGauge_sck_a.ScaleNumbersRotation = 0;
            this.aGauge_sck_a.ScaleNumbersStartScaleLine = 0;
            this.aGauge_sck_a.ScaleNumbersStepScaleLines = 1;
            this.aGauge_sck_a.Size = new System.Drawing.Size(133, 145);
            this.aGauge_sck_a.TabIndex = 19;
            this.aGauge_sck_a.Text = "aGauge2";
            this.aGauge_sck_a.Value = 0F;
            // 
            // aGauge_isk_a
            // 
            this.aGauge_isk_a.BaseArcColor = System.Drawing.Color.Black;
            this.aGauge_isk_a.BaseArcRadius = 80;
            this.aGauge_isk_a.BaseArcStart = 180;
            this.aGauge_isk_a.BaseArcSweep = 250;
            this.aGauge_isk_a.BaseArcWidth = 2;
            this.aGauge_isk_a.GaugeAutoSize = true;
            this.aGauge_isk_a.Location = new System.Drawing.Point(204, 204);
            this.aGauge_isk_a.MaxValue = 100F;
            this.aGauge_isk_a.MinValue = 0F;
            this.aGauge_isk_a.Name = "aGauge_isk_a";
            this.aGauge_isk_a.NeedleColor1 = System.Windows.Forms.AGaugeNeedleColor.Gray;
            this.aGauge_isk_a.NeedleColor2 = System.Drawing.Color.Gray;
            this.aGauge_isk_a.NeedleRadius = 80;
            this.aGauge_isk_a.NeedleType = System.Windows.Forms.NeedleType.Advance;
            this.aGauge_isk_a.NeedleWidth = 2;
            this.aGauge_isk_a.ScaleLinesInterColor = System.Drawing.Color.Black;
            this.aGauge_isk_a.ScaleLinesInterInnerRadius = 73;
            this.aGauge_isk_a.ScaleLinesInterOuterRadius = 80;
            this.aGauge_isk_a.ScaleLinesInterWidth = 1;
            this.aGauge_isk_a.ScaleLinesMajorColor = System.Drawing.Color.DarkRed;
            this.aGauge_isk_a.ScaleLinesMajorInnerRadius = 70;
            this.aGauge_isk_a.ScaleLinesMajorOuterRadius = 80;
            this.aGauge_isk_a.ScaleLinesMajorStepValue = 20F;
            this.aGauge_isk_a.ScaleLinesMajorWidth = 2;
            this.aGauge_isk_a.ScaleLinesMinorColor = System.Drawing.Color.Gray;
            this.aGauge_isk_a.ScaleLinesMinorInnerRadius = 75;
            this.aGauge_isk_a.ScaleLinesMinorOuterRadius = 80;
            this.aGauge_isk_a.ScaleLinesMinorTicks = 9;
            this.aGauge_isk_a.ScaleLinesMinorWidth = 1;
            this.aGauge_isk_a.ScaleNumbersColor = System.Drawing.Color.Black;
            this.aGauge_isk_a.ScaleNumbersFormat = null;
            this.aGauge_isk_a.ScaleNumbersRadius = 95;
            this.aGauge_isk_a.ScaleNumbersRotation = 0;
            this.aGauge_isk_a.ScaleNumbersStartScaleLine = 0;
            this.aGauge_isk_a.ScaleNumbersStepScaleLines = 1;
            this.aGauge_isk_a.Size = new System.Drawing.Size(133, 145);
            this.aGauge_isk_a.TabIndex = 18;
            this.aGauge_isk_a.Text = "aGauge2";
            this.aGauge_isk_a.Value = 0F;
            this.aGauge_isk_a.ValueInRangeChanged += new System.EventHandler<System.Windows.Forms.ValueInRangeChangedEventArgs>(this.aGauge_isk_a_ValueInRangeChanged);
            // 
            // aGauge_isk
            // 
            this.aGauge_isk.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.aGauge_isk.BaseArcColor = System.Drawing.Color.Black;
            this.aGauge_isk.BaseArcRadius = 80;
            this.aGauge_isk.BaseArcStart = 90;
            this.aGauge_isk.BaseArcSweep = 250;
            this.aGauge_isk.BaseArcWidth = 2;
            this.aGauge_isk.GaugeAutoSize = true;
            this.aGauge_isk.Location = new System.Drawing.Point(-3, 119);
            this.aGauge_isk.MaxValue = 250F;
            this.aGauge_isk.MinValue = 0F;
            this.aGauge_isk.Name = "aGauge_isk";
            this.aGauge_isk.NeedleColor1 = System.Windows.Forms.AGaugeNeedleColor.Gray;
            this.aGauge_isk.NeedleColor2 = System.Drawing.Color.Gray;
            this.aGauge_isk.NeedleRadius = 80;
            this.aGauge_isk.NeedleType = System.Windows.Forms.NeedleType.Advance;
            this.aGauge_isk.NeedleWidth = 2;
            this.aGauge_isk.ScaleLinesInterColor = System.Drawing.Color.Black;
            this.aGauge_isk.ScaleLinesInterInnerRadius = 73;
            this.aGauge_isk.ScaleLinesInterOuterRadius = 80;
            this.aGauge_isk.ScaleLinesInterWidth = 1;
            this.aGauge_isk.ScaleLinesMajorColor = System.Drawing.Color.DarkRed;
            this.aGauge_isk.ScaleLinesMajorInnerRadius = 70;
            this.aGauge_isk.ScaleLinesMajorOuterRadius = 80;
            this.aGauge_isk.ScaleLinesMajorStepValue = 50F;
            this.aGauge_isk.ScaleLinesMajorWidth = 2;
            this.aGauge_isk.ScaleLinesMinorColor = System.Drawing.Color.Gray;
            this.aGauge_isk.ScaleLinesMinorInnerRadius = 75;
            this.aGauge_isk.ScaleLinesMinorOuterRadius = 80;
            this.aGauge_isk.ScaleLinesMinorTicks = 9;
            this.aGauge_isk.ScaleLinesMinorWidth = 1;
            this.aGauge_isk.ScaleNumbersColor = System.Drawing.Color.Black;
            this.aGauge_isk.ScaleNumbersFormat = null;
            this.aGauge_isk.ScaleNumbersRadius = 95;
            this.aGauge_isk.ScaleNumbersRotation = 0;
            this.aGauge_isk.ScaleNumbersStartScaleLine = 0;
            this.aGauge_isk.ScaleNumbersStepScaleLines = 1;
            this.aGauge_isk.Size = new System.Drawing.Size(259, 230);
            this.aGauge_isk.TabIndex = 12;
            this.aGauge_isk.Text = "aGauge2";
            this.aGauge_isk.Value = 0F;
            // 
            // aGauge1
            // 
            this.aGauge1.BackColor = System.Drawing.Color.DimGray;
            this.aGauge1.BaseArcColor = System.Drawing.Color.Black;
            this.aGauge1.BaseArcRadius = 80;
            this.aGauge1.BaseArcStart = 0;
            this.aGauge1.BaseArcSweep = 360;
            this.aGauge1.BaseArcWidth = 2;
            this.aGauge1.GaugeAutoSize = true;
            this.aGauge1.Location = new System.Drawing.Point(767, 631);
            this.aGauge1.MaxValue = 360F;
            this.aGauge1.MinValue = 0F;
            this.aGauge1.Name = "aGauge1";
            this.aGauge1.NeedleColor1 = System.Windows.Forms.AGaugeNeedleColor.Red;
            this.aGauge1.NeedleColor2 = System.Drawing.Color.Black;
            this.aGauge1.NeedleRadius = 80;
            this.aGauge1.NeedleType = System.Windows.Forms.NeedleType.Simple;
            this.aGauge1.NeedleWidth = 2;
            this.aGauge1.ScaleLinesInterColor = System.Drawing.Color.Black;
            this.aGauge1.ScaleLinesInterInnerRadius = 73;
            this.aGauge1.ScaleLinesInterOuterRadius = 80;
            this.aGauge1.ScaleLinesInterWidth = 1;
            this.aGauge1.ScaleLinesMajorColor = System.Drawing.Color.Black;
            this.aGauge1.ScaleLinesMajorInnerRadius = 70;
            this.aGauge1.ScaleLinesMajorOuterRadius = 80;
            this.aGauge1.ScaleLinesMajorStepValue = 90F;
            this.aGauge1.ScaleLinesMajorWidth = 2;
            this.aGauge1.ScaleLinesMinorColor = System.Drawing.Color.Gray;
            this.aGauge1.ScaleLinesMinorInnerRadius = 75;
            this.aGauge1.ScaleLinesMinorOuterRadius = 80;
            this.aGauge1.ScaleLinesMinorTicks = 9;
            this.aGauge1.ScaleLinesMinorWidth = 1;
            this.aGauge1.ScaleNumbersColor = System.Drawing.Color.Black;
            this.aGauge1.ScaleNumbersFormat = null;
            this.aGauge1.ScaleNumbersRadius = 200;
            this.aGauge1.ScaleNumbersRotation = 0;
            this.aGauge1.ScaleNumbersStartScaleLine = 0;
            this.aGauge1.ScaleNumbersStepScaleLines = 1;
            this.aGauge1.Size = new System.Drawing.Size(61, 55);
            this.aGauge1.TabIndex = 9;
            this.aGauge1.Text = "aGauge1";
            this.aGauge1.Value = 0F;
            // 
            // aGauge_sck
            // 
            this.aGauge_sck.BaseArcColor = System.Drawing.Color.Black;
            this.aGauge_sck.BaseArcRadius = 80;
            this.aGauge_sck.BaseArcStart = 90;
            this.aGauge_sck.BaseArcSweep = 250;
            this.aGauge_sck.BaseArcWidth = 2;
            this.aGauge_sck.GaugeAutoSize = true;
            this.aGauge_sck.Location = new System.Drawing.Point(1543, 119);
            this.aGauge_sck.MaxValue = 250F;
            this.aGauge_sck.MinValue = 0F;
            this.aGauge_sck.Name = "aGauge_sck";
            this.aGauge_sck.NeedleColor1 = System.Windows.Forms.AGaugeNeedleColor.Gray;
            this.aGauge_sck.NeedleColor2 = System.Drawing.Color.Gray;
            this.aGauge_sck.NeedleRadius = 80;
            this.aGauge_sck.NeedleType = System.Windows.Forms.NeedleType.Advance;
            this.aGauge_sck.NeedleWidth = 2;
            this.aGauge_sck.ScaleLinesInterColor = System.Drawing.Color.Black;
            this.aGauge_sck.ScaleLinesInterInnerRadius = 73;
            this.aGauge_sck.ScaleLinesInterOuterRadius = 80;
            this.aGauge_sck.ScaleLinesInterWidth = 1;
            this.aGauge_sck.ScaleLinesMajorColor = System.Drawing.Color.DarkRed;
            this.aGauge_sck.ScaleLinesMajorInnerRadius = 70;
            this.aGauge_sck.ScaleLinesMajorOuterRadius = 80;
            this.aGauge_sck.ScaleLinesMajorStepValue = 50F;
            this.aGauge_sck.ScaleLinesMajorWidth = 2;
            this.aGauge_sck.ScaleLinesMinorColor = System.Drawing.Color.Gray;
            this.aGauge_sck.ScaleLinesMinorInnerRadius = 75;
            this.aGauge_sck.ScaleLinesMinorOuterRadius = 80;
            this.aGauge_sck.ScaleLinesMinorTicks = 9;
            this.aGauge_sck.ScaleLinesMinorWidth = 1;
            this.aGauge_sck.ScaleNumbersColor = System.Drawing.Color.Black;
            this.aGauge_sck.ScaleNumbersFormat = null;
            this.aGauge_sck.ScaleNumbersRadius = 95;
            this.aGauge_sck.ScaleNumbersRotation = 0;
            this.aGauge_sck.ScaleNumbersStartScaleLine = 0;
            this.aGauge_sck.ScaleNumbersStepScaleLines = 1;
            this.aGauge_sck.Size = new System.Drawing.Size(259, 230);
            this.aGauge_sck.TabIndex = 14;
            this.aGauge_sck.Text = "aGauge2";
            this.aGauge_sck.Value = 0F;
            // 
            // aGauge_dumen
            // 
            this.aGauge_dumen.BaseArcColor = System.Drawing.Color.Black;
            this.aGauge_dumen.BaseArcRadius = 80;
            this.aGauge_dumen.BaseArcStart = 20;
            this.aGauge_dumen.BaseArcSweep = 140;
            this.aGauge_dumen.BaseArcWidth = 2;
            this.aGauge_dumen.GaugeAutoSize = false;
            this.aGauge_dumen.Location = new System.Drawing.Point(805, 719);
            this.aGauge_dumen.MaxValue = 60F;
            this.aGauge_dumen.MinValue = 0F;
            this.aGauge_dumen.Name = "aGauge_dumen";
            this.aGauge_dumen.NeedleColor1 = System.Windows.Forms.AGaugeNeedleColor.Gray;
            this.aGauge_dumen.NeedleColor2 = System.Drawing.Color.Gray;
            this.aGauge_dumen.NeedleRadius = 80;
            this.aGauge_dumen.NeedleType = System.Windows.Forms.NeedleType.Advance;
            this.aGauge_dumen.NeedleWidth = 2;
            this.aGauge_dumen.ScaleLinesInterColor = System.Drawing.Color.DarkRed;
            this.aGauge_dumen.ScaleLinesInterInnerRadius = 73;
            this.aGauge_dumen.ScaleLinesInterOuterRadius = 80;
            this.aGauge_dumen.ScaleLinesInterWidth = 1;
            this.aGauge_dumen.ScaleLinesMajorColor = System.Drawing.Color.DarkRed;
            this.aGauge_dumen.ScaleLinesMajorInnerRadius = 70;
            this.aGauge_dumen.ScaleLinesMajorOuterRadius = 80;
            this.aGauge_dumen.ScaleLinesMajorStepValue = 60F;
            this.aGauge_dumen.ScaleLinesMajorWidth = 2;
            this.aGauge_dumen.ScaleLinesMinorColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.aGauge_dumen.ScaleLinesMinorInnerRadius = 75;
            this.aGauge_dumen.ScaleLinesMinorOuterRadius = 80;
            this.aGauge_dumen.ScaleLinesMinorTicks = 9;
            this.aGauge_dumen.ScaleLinesMinorWidth = 1;
            this.aGauge_dumen.ScaleNumbersColor = System.Drawing.Color.Black;
            this.aGauge_dumen.ScaleNumbersFormat = null;
            this.aGauge_dumen.ScaleNumbersRadius = 200;
            this.aGauge_dumen.ScaleNumbersRotation = 0;
            this.aGauge_dumen.ScaleNumbersStartScaleLine = 0;
            this.aGauge_dumen.ScaleNumbersStepScaleLines = 1;
            this.aGauge_dumen.Size = new System.Drawing.Size(205, 204);
            this.aGauge_dumen.TabIndex = 25;
            this.aGauge_dumen.Text = "aGauge3";
            this.aGauge_dumen.Value = 0F;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(357, -30);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(1204, 637);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 47;
            this.pictureBox6.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.aGauge_compass);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.chart_voltage);
            this.Controls.Add(this.textBox_voltage);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.aGauge_yon);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.unlem_sck0);
            this.Controls.Add(this.unlem_isk0);
            this.Controls.Add(this.unlem_sck1);
            this.Controls.Add(this.unlem_isk1);
            this.Controls.Add(this.aGauge_sck_a);
            this.Controls.Add(this.aGauge_isk_a);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.aGauge_isk);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.aGauge1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.FormClose);
            this.Controls.Add(this.FullScreen);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.gMap_dumen);
            this.Controls.Add(this.aGauge_sck);
            this.Controls.Add(this.chart_sancak);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.aGauge_dumen);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.chart_iskele);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Tekne1.8";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint_1);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.unlem_isk1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.unlem_sck1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.unlem_isk0)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.unlem_sck0)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_iskele)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_sancak)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_voltage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GMap.NET.WindowsForms.GMapControl gMap_dumen;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button FullScreen;
        private System.Windows.Forms.Button FormClose;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Timer timer1;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Timer timer_data;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.AGauge aGauge_isk;
        internal System.Windows.Forms.AGauge aGauge_sck;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.AGauge aGauge_isk_a;
        private System.Windows.Forms.AGauge aGauge_sck_a;
        private System.Windows.Forms.PictureBox unlem_isk1;
        private System.Windows.Forms.PictureBox unlem_sck1;
        private System.Windows.Forms.PictureBox unlem_isk0;
        private System.Windows.Forms.PictureBox unlem_sck0;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.AGauge aGauge_dumen;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.AGauge aGauge1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.AGauge aGauge_yon;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_iskele;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_sancak;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.TextBox textBox_voltage;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_voltage;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.AGauge aGauge_compass;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Timer timer_gps;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox pictureBox6;
    }
}

