using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace WeatherFormUygulamasi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)

        {
            label2.Text = DateTime.Now.ToShortDateString(); //bugünün kısa tarihi

            string api = "88299859bb775490c3fc1e1bd1f730f2";

            string connection = "https://api.openweathermap.org/data/2.5/weather?q=istanbul&mode=xml&lang=en&units=metric&appid=" + api;

            // xml liq ile kullandık ve xdocument sınıfına connectiondan gelen değeri yükledim

            XDocument weather = XDocument.Load(connection);

            // xml liq ile kullandık ve xdocument sınıfına connectiondan gelen değeri yükledim
            // metot içine temperaturedan gelen tagı çek. ElementAt ile temperature dan yakaladığı ilk index değerini yani temperature içindeki value değerini çektim

            var temp = weather.Descendants("temperature").ElementAt(0).Attribute("value").Value;

            var weatherstate = weather.Descendants("weather").ElementAt(0).Attribute("value").Value;

            var wind = weather.Descendants("speed").ElementAt(0).Attribute("value").Value;

            var windstate = weather.Descendants("speed").ElementAt(0).Attribute("name").Value;

            var humidity = weather.Descendants("humidity").ElementAt(0).Attribute("value").Value;

            var precipitation = weather.Descendants("precipitation").ElementAt(0).Attribute("mode").Value;

            label4.Text = temp.ToString();

            label7.Text = weatherstate.ToString();

            label8.Text = wind +" "+ "m/sec";

            label10.Text = humidity + " " + "%";

            label13.Text = precipitation.ToString();

            label14.Text = temp.ToString();

            label17.Text = windstate.ToString();


            if ( weatherstate == "Scattered clouds")
            {
                pictureBox1.ImageLocation = @"C:\Users\NURGÜL\Desktop\www.gazetegercek.com.tr_17580_RD3G72RMEJFJ.jpg";
            }

            if (weatherstate== "broken clouds" || weatherstate == "Partly clouds" || weatherstate == "cloudy" || weatherstate == "scattered clouds")
            {
                pictureBox1.ImageLocation = @"C:\Users\NURGÜL\Desktop\www.gazetegercek.com.tr_17580_RD3G72RMEJFJ.jpg";
            }
        
            if (weatherstate == "Sunny" || weatherstate == "Sun")
            
            {
                pictureBox1.ImageLocation = @"C:\Users\NURGÜL\Desktop\depositphotos_44521433-stock-illustration-cute-sun.jpg";
            }

            if (weatherstate == "Rain" || weatherstate == "Rainy" || weatherstate == "Shower")

            {
                pictureBox1.ImageLocation = @"C:\Users\NURGÜL\Desktop\1620029885_48377.png";
            }

            if (weatherstate == "Breezy" || weatherstate == "Breeze" || weatherstate == "Windy" || weatherstate == "Wind" || weatherstate == "Storm")

            {
                pictureBox1.ImageLocation = @"C:\Users\NURGÜL\Desktop\1620030063_211473.png";
            }

            if (weatherstate == "Winter" || weatherstate == "Snow" || weatherstate == "Snowy" || weatherstate == "Hail" || weatherstate == "Icy")

            {
                pictureBox1.ImageLocation = @"C:\Users\NURGÜL\Desktop\1620029951_68525.jpeg";
            }
            //else
            //{
            //    pictureBox1.ImageLocation = @"C:\Users\NURGÜL\Desktop\turkiyede-bugun-hava-nasil-olacak.webp";
            //}
        }
        

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }
    }
}
