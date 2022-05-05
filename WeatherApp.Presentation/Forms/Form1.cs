using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.Net;
using Domain.Entities;
using Infraestructure.Models;

namespace WeatherApp
{
    public partial class Form1 : Form
    {
        WeatherAppModel weatherAppModel;
      
        public Form1()
        {
            weatherAppModel = new WeatherAppModel();
            InitializeComponent();
        }

        string ClaveAPI = "546f8f4a57c210ec275b69c1314d8bd1";

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            GetWeather();
        }

        void GetWeather()
        {
            try
            {
                using (WebClient client = new WebClient())
                {
                    string url = string.Format("https://api.openweathermap.org/data/2.5/weather?q={0}&appid={1}", txtCity.Text, ClaveAPI);
                    var json = client.DownloadString(url);
                    WeatherInfo.root info = JsonConvert.DeserializeObject<WeatherInfo.root>(json);

                    pictureBox1.ImageLocation = "https://openweathermap.org/img/w/" + info.weather[0].icon + ".png";

                    lblCiudad.Text = txtCity.Text;
                    lblLon.Text = info.coord.lon.ToString();
                    lblLat.Text = info.coord.lat.ToString();
                    lblCondition.Text = info.weather[0].main;
                    lblDetalles.Text = info.weather[0].description;
                    lblAmanecer.Text = weatherAppModel.ConvertDateTime(info.sys.sunrise).ToShortTimeString() + " AM";
                    lblAtardecer.Text = weatherAppModel.ConvertDateTime(info.sys.sunset).ToShortTimeString() + " PM";
                    lblTemp.Text = weatherAppModel.CovertTem(info.main.temp).ToString();
                    lblTemMax.Text = weatherAppModel.CovertTem(info.main.temp_max).ToString();
                    lblTemMin.Text = weatherAppModel.CovertTem(info.main.temp_min).ToString();
                    lblVelocidad.Text = weatherAppModel.ConvertSpeed(info.wind.speed).ToString();
                    lblPresion.Text = info.main.pressure.ToString();
                    lblHumidity.Text = info.main.humidity.ToString();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
