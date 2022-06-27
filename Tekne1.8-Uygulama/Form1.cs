using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
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
using System.Drawing.Drawing2D;

namespace Tekne1._8_Uygulama
{
    public partial class Form1 : Form
    {

        string data;
        decimal veri1;
        decimal veri2;
        decimal veri3;
        decimal veri4;
        decimal veri5;
        decimal veri6;
        decimal veri7;
        decimal veri8;
        int veri9;
        int veri10;
        int veri11;
        decimal lat;
        decimal lng;
        double lng_com;
        double lat_com;
        int dumen = 90;
        int x_axis;
        int z_axis;
        int counter_1;
        int counter_2;
        int counter_3;
        int durum_1;
        int durum_2;
        int durum_3;
        decimal voltage;
        int voltage_min=700;
        int voltage_max=1200;

        int iskele_giden=5;
        int sancak_giden=5;
        int dumen_giden=5;

        int sancak;
        int iskele;

        //double rota;
        double lat1;
        double lng1;
        double lat2;
        double lng2;

        public Form1()
        {
            InitializeComponent();
            Control.CheckForIllegalCrossThreadCalls = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            veri9 = 250;
            veri10 = 250;
            String[] Portlar = SerialPort.GetPortNames();
            foreach (string port in Portlar)
            {
                comboBox1.Items.Add(port);
            }

            comboBox1.SelectedIndex = 0;
            comboBox2.SelectedIndex = 0;

            this.Location = new Point(0,0);
            this.Size = new Size(1920,1080);
            double ist_lat = 41;
            double ist_lng = 29;

            textBox1.Text = Convert.ToString(ist_lat);
            textBox2.Text = Convert.ToString(ist_lng);
            gMap_dumen.DragButton = MouseButtons.Left;
            gMap_dumen.MapProvider = GMapProviders.GoogleMap;
            gMap_dumen.MinZoom = 1;
            gMap_dumen.MaxZoom = 100;
            gMap_dumen.Zoom = 10;
            gMap_dumen.Position = new GMap.NET.PointLatLng(ist_lat, ist_lng);


            chart_iskele.Series["Power"].Points.Clear();



        }

        private void gMapControl1_MouseClick(object sender, MouseEventArgs e)
        {
            var point = gMap_dumen.FromLocalToLatLng(e.X, e.Y);
            double lat = point.Lat;
            double lng = point.Lng;

            textBox1.Text = lat + " ";
            textBox2.Text = lng + " ";

            gMap_dumen.Refresh();
        }

      
        public void display_markers_target(double lat, double lng)
        {
            PointLatLng point = new PointLatLng(lat, lng);
            GMapMarker marker = new GMarkerGoogle(point, GMarkerGoogleType.red_small);
            GMapOverlay markers = new GMapOverlay("markers");
            markers.Markers.Add(marker);
            gMap_dumen.Overlays.Add(markers);
            gMap_dumen.Refresh();
        }
        public void display_markers_loc(double lat, double lng)
        {
            PointLatLng point = new PointLatLng(lat, lng);
            GMapMarker marker = new GMarkerGoogle(point, GMarkerGoogleType.blue_small);
            GMapOverlay markers = new GMapOverlay("markers");
            markers.Markers.Add(marker);
            gMap_dumen.Overlays.Add(markers);
            gMap_dumen.Refresh();
        }
        private void refresh_map()
        {
            gMap_dumen.Zoom++;
            gMap_dumen.Zoom--;
        }
        public static double find_angle(double a, double b, double c, double d)
        {
            double ratio;
            double angle_360;
            double angle;

            double y_eksen_farkı = c - a;
            double x_eksen_farkı = d - b;

            ratio = x_eksen_farkı / y_eksen_farkı;
            angle = Math.Atan(ratio) * (180f / Math.PI);
            angle_360 = (angle + 90);

            if (c < a)
            {
                angle_360 = angle_360 + 180;
                //Console.WriteLine("sol");
            }
            if (c > a)
            {
                // Console.WriteLine("sağ");
            }


            return angle_360;
        }

        

        private void button2_Click(object sender, EventArgs e)
        {
            gMap_dumen.Overlays.Clear();
            gMap_dumen.Refresh();

            lat1 = 0;
            lng1 = 0;
            lat2 = 0;
            lng2 = 0;

        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            display_markers_loc(lng_com, lat_com);
            refresh_map();
        }

  
     




        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                FormBorderStyle = FormBorderStyle.Sizable;
                WindowState = FormWindowState.Normal;
                TopMost = false;
            }

            if (durum_3 ==1)
            { 
                
                 if (e.KeyCode == Keys.Left)
                 {
                 for (int i = 0; i < 1; i++)
                 {
                    dumen_giden--;
                 }
                 }
                 if (e.KeyCode == Keys.Right)
                 {
                     for (int i = 0; i < 1; i++)
                 {
                    dumen_giden++;
                 }
                }
                if (e.KeyCode == Keys.Q)
                {
                    for (int i = 0; i < 1; i++)
                    {
                       iskele_giden++;
                    }
                }
                if (e.KeyCode == Keys.A)
                {
                    for (int i = 0; i < 1; i++)
                    {
                        iskele_giden--;
                    }
                }
                if (e.KeyCode == Keys.E)
                {
                    for (int i = 0; i < 1; i++)
                    {
                        sancak_giden++;
                    }
                }
                if (e.KeyCode == Keys.D)
                {
                    for (int i = 0; i < 1; i++)
                    {
                        sancak_giden--;
                    }
                }
                

                if (sancak_giden > 9)
                {
                    sancak_giden = 9;
                }
                if (sancak_giden < 1)
                {
                    sancak_giden = 1;
                } 
                
                if (iskele_giden > 9)
                {
                    iskele_giden = 9;
                }
                if (iskele_giden < 1)
                {
                    iskele_giden = 1;
                }

                if (dumen_giden > 9)
                {
                    dumen_giden = 9;
                }
                if (dumen_giden < 1)
                {
                    dumen_giden = 1;
                }
            }
        }


        private void FullScreen_Click(object sender, EventArgs e)
        {
            FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;
            TopMost = true;
        }

        private void FormClose_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 f1 = new Form1();
            f1.Show();
        }

        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            try
            {
                data = serialPort1.ReadLine();
                serialPort1.WriteLine(Convert.ToString(veri_aktar(iskele_giden, dumen_giden, sancak_giden)));
                string[] veriler = data.Split('*');
                veri1 = Convert.ToDecimal(veriler[0]);
                veri2 = Convert.ToDecimal(veriler[1]);
                veri3 = Convert.ToDecimal(veriler[2]);
                veri4 = Convert.ToDecimal(veriler[3]);
                veri5 = Convert.ToDecimal(veriler[4]);
                veri6 = Convert.ToDecimal(veriler[5]);
                veri7 = Convert.ToDecimal(veriler[6]);
                veri8 = Convert.ToDecimal(veriler[7]);
                veri9 = Convert.ToInt32(veriler[9]);
                veri10 = Convert.ToInt32(veriler[8]);
                veri11 = Convert.ToInt32(veriler[10]);
                lng = veri1 / 1000000;
                lat = veri2 / 1000000;
                lng_com = Convert.ToDouble(lng);
                lat_com = Convert.ToDouble(lat);
            }
            catch (Exception)
            {
                MessageBox.Show("bi sorun çıktı bişiler oldu valla bende anlamaıdm");
                throw;
            }    
        }
       
        private void timer_data_Tick_1(object sender, EventArgs e)
        {
            iskele = yumusatma(veri9, 3, 0, 0);
            sancak = yumusatma(veri10, 3, 0, 1);

            int iskeleg = 250;
            int sancakg = 250; 


           

            if (iskele < 250)
            {
                iskeleg = 250 - iskele;
            }
            if (iskele > 250)
            {
                iskeleg = iskele - 250;
            }
            if (sancak < 250)
            {
                sancakg = 250 - sancak;
            }
            if (sancak > 250)
            {
                sancakg = sancak - 250;
            }
            if (sancak ==250)
            {
                sancakg = 0;
            }

            if (iskele == 250)
            {
                iskeleg = 0;
            }

            Console.WriteLine(sancakg);
            

            chart_iskele.Series["Power"].Points.AddY(iskeleg);
            chart_sancak.Series["Power"].Points.AddY(sancakg);
            chart_iskele.Series["Current"].Points.AddY(yumusatma(Convert.ToInt32(veri6 / 100), 1, 0, 4));
            chart_sancak.Series["Current"].Points.AddY(yumusatma(Convert.ToInt32(veri7 / 100), 1, 0, 7));
            chart_voltage.Series["min"].Points.AddY(voltage_min);
            chart_voltage.Series["max"].Points.AddY(voltage_max);
            chart_voltage.Series["voltage"].Points.AddY(yumusatma(Convert.ToInt32(veri3), 1,1,8));

            if (chart_iskele.Series[0].Points.Count>500)
            {
                chart_iskele.Series[0].Points.RemoveAt(0);
                chart_iskele.Series[1].Points.RemoveAt(0);
            }

            if (chart_sancak.Series[0].Points.Count > 500)
            {
                chart_sancak.Series[0].Points.RemoveAt(0);
                chart_sancak.Series[1].Points.RemoveAt(0);
            }

            if (chart_voltage.Series[0].Points.Count > 1000)
            {
                chart_voltage.Series[0].Points.RemoveAt(0);
                chart_voltage.Series[1].Points.RemoveAt(0);
                chart_voltage.Series[2].Points.RemoveAt(0);
            }
            voltage = veri3 / 100;
            textBox_voltage.Text = Convert.ToString(voltage);
           
            x_axis = yumusatma(Convert.ToInt32(veri4) / 100, 1, 0, 5) - 4;
            z_axis = yumusatma(Convert.ToInt32(veri5) / 100, 1, 0, 6) % 720;
            int gercek_acı = z_axis / 2;
            if (z_axis < 0)
            {
                z_axis = Math.Abs(180 + z_axis);
            }
            if (gercek_acı < 0)
            {
                gercek_acı = gercek_acı + 360;
            }
            Invalidate();

            dumen = veri11 - 60;
            aGauge_isk.Value = iskeleg;
            aGauge_sck.Value = sancakg;
            aGauge_dumen.Value =Math.Abs(yumusatma(dumen,1, 0, 2));
            aGauge_isk_a.Value = yumusatma(Convert.ToInt32(veri6/100), 1, 0,4);
            aGauge_sck_a.Value = yumusatma(Convert.ToInt32(veri7 / 100), 1, 0,7);
            aGauge_yon.Value = gercek_acı;

           

            if (iskeleg > 230)
            {
                unlem_isk1.Visible = true;
                unlem_isk0.Visible = false;
            }

            if (iskeleg < 230)
            {
                unlem_isk1.Visible = false;
                unlem_isk0.Visible = true;
            }
            if (sancakg > 230)
            {
                unlem_sck1.Visible = true;
                unlem_sck0.Visible = false;
            }

            if (sancakg < 230)
            {
                unlem_sck1.Visible = false;
                unlem_sck0.Visible = true;
            }

        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
             display_markers_loc(lng_com, lat_com);
             refresh_map();
            }
           
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            for (int i = 0; i < 1; i++)
            {
                counter_1++;
               // Console.WriteLine(veri3);
               // Console.WriteLine(veri4);
            }

            durum_1 = counter_1 % 2;


            if (durum_1 == 1)
            {
                lat1 = Convert.ToDouble(textBox1.Text);
                lng1 = Convert.ToDouble(textBox2.Text);
                Console.WriteLine(find_angle(lat1, lng1, lat2, lng2));
                aGauge1.Value = Convert.ToInt32(find_angle(lat1, lng1, lat2, lng2));


            }
            if (durum_1 == 0)
            {
                lat2 = Convert.ToDouble(textBox1.Text);
                lng2 = Convert.ToDouble(textBox2.Text);
                Console.WriteLine(find_angle(lat2, lng2, lat1, lng1));
                aGauge1.Value = Convert.ToInt32(find_angle(lat2, lng2, lat1, lng1));

            }

            double lat_new = Convert.ToDouble(textBox1.Text);
            double lng_new = Convert.ToDouble(textBox2.Text);
            display_markers_target(lat_new, lng_new);
            refresh_map();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            gMap_dumen.Overlays.Clear();
            gMap_dumen.Refresh();

            lat1 = 0;
            lng1 = 0;
            lat2 = 0;
            lng2 = 0;

        }

        private void gMap_dumen_MouseClick(object sender, MouseEventArgs e)
        {
            var point = gMap_dumen.FromLocalToLatLng(e.X, e.Y);
            double lat = point.Lat;
            double lng = point.Lng;

            textBox1.Text = lat + " ";
            textBox2.Text = lng + " ";

            gMap_dumen.Refresh();
        }

        Bitmap image = Properties.Resources.tekneyanyun;

        private void Form1_Paint_1(object sender, PaintEventArgs e)
        {
            Graphics g1 = e.Graphics;
            g1.RotateTransform(x_axis, MatrixOrder.Append);
            g1.TranslateTransform(600, 850, MatrixOrder.Append);
            g1.DrawImage(image, -75, -75, 170, 170);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            try
            {
                serialPort1.PortName = comboBox1.Text;
                serialPort1.BaudRate = Convert.ToInt32(comboBox2.Text); 
                serialPort1.Open();
                    timer1.Start();
                    timer_data.Start();
                }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
                throw;
            }
                     
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen == true)
            {
                serialPort1.Close();
               
            }
        
        }
        private int veri_aktar(int iskele, int dumen, int sancak)
        {
            int sondeger;
            sondeger = iskele * 100 + sancak + dumen * 10;

            return sondeger;
        }

      public int[] degisen_deger = new int[20];
        private int yumusatma(int deger, int hassasiyet, int olu_bolge, int yeni_deger)
        {
            int z = yeni_deger;

            if (deger > degisen_deger[z])
            {
                for (int i = 0; i < 1; i++)
                { degisen_deger[z] = degisen_deger[z] + hassasiyet; }
            }

            if (deger < degisen_deger[z])
            {
                for (int i = 0; i < 1; i++)
                { degisen_deger[z] = degisen_deger[z] - hassasiyet; }
            }
            switch (olu_bolge)
            {
                case 0:
                    if (deger == degisen_deger[z])
                    { }
                    break;
                case 1:
                    if (deger == degisen_deger[z] ||
                        deger == degisen_deger[z] + 1 ||
                        deger == degisen_deger[z] - 1)
                    { }
                    break;
                case 2:
                    if (deger == degisen_deger[z] ||
                      deger == degisen_deger[z] + 1 ||
                      deger == degisen_deger[z] - 1 ||
                      deger == degisen_deger[z] + 2 ||
                      deger == degisen_deger[z] - 2)
                    { }
                    break;
                case 3:
                    if (deger == degisen_deger[z] ||
                      deger == degisen_deger[z] + 1 ||
                      deger == degisen_deger[z] - 1 ||
                      deger == degisen_deger[z] + 2 ||
                      deger == degisen_deger[z] - 2 ||
                      deger == degisen_deger[z] + 3 ||
                      deger == degisen_deger[z] - 3)
                    { }
                    break;
                case 4:
                    if (deger == degisen_deger[z] ||
                      deger == degisen_deger[z] + 1 ||
                      deger == degisen_deger[z] - 1 ||
                      deger == degisen_deger[z] + 2 ||
                      deger == degisen_deger[z] - 2 ||
                      deger == degisen_deger[z] + 3 ||
                      deger == degisen_deger[z] - 3 ||
                      deger == degisen_deger[z] + 4 ||
                      deger == degisen_deger[z] - 4)
                    { }
                    break;
            }
            return degisen_deger[z];
        }

        private void button5_Click(object sender, EventArgs e)
        {
            timer_gps.Start();
        }

        //double rota;
        double lat1_gps;
        double lng1_gps;
        double lat2_gps;
        double lng2_gps;

        private void timer_gps_Tick(object sender, EventArgs e)
        {            
                counter_2++;
                durum_2 = counter_2 % 200;

            if (durum_2 ==0)
            {
                lat1_gps = lat_com;
                lng1_gps = lng_com;
            }
            if(durum_2 == 100)
            {
                lat2_gps = lat_com;
                lng2_gps = lng_com;
            }
            if (lat1_gps == lat2_gps &&
                lng1_gps == lng2_gps)
            {
                label7.Text = "Hareket Yok";
                label7.ForeColor = Color.Red;
            }
            if (lat1_gps != lat2_gps &&
                lng1_gps != lng2_gps)
            {
                label7.Text = "Hareket Var";
                label7.ForeColor = Color.Green;
                Console.WriteLine(find_angle(lat1_gps, lng1_gps, lat2_gps, lng2_gps));
                aGauge_compass.Value = Convert.ToInt64(find_angle(lat1_gps, lng1_gps, lat2_gps, lng2_gps)+90 );
            }
            Console.WriteLine(find_angle(lat1_gps, lng1_gps, lat2_gps, lng2_gps) );
            Console.WriteLine(find_angle(lat1_gps, lng1_gps, lat2_gps, lng2_gps) );
            /*
            Console.Write("LAT1_GPS;  ");
            Console.Write(lat1_gps + "  ");
            Console.Write("LAT2_GPS;  ");
            Console.WriteLine(lat2_gps);
            */
        }

        private void aGauge_compass_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            for (int i=0; i<1;  i++)
            {
                counter_3++;
            }
            durum_3 = counter_3 % 2;
            if (durum_3 == 1)
            {
                button6.Text = "Pc Kontrol";
                button6.ForeColor = Color.Green;
            }
            if (durum_3 == 0)
            {
                button6.Text = "Kontrolü Al";
                button6.ForeColor = Color.Black;
            }
        }

        private void aGauge_isk_a_ValueInRangeChanged(object sender, ValueInRangeChangedEventArgs e)
        {

        }
    }
}
