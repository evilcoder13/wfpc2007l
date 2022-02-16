using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace demoT4WebAPIClient
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnViewWeather_Click(object sender, EventArgs e)
        {
            string url = string.Format("http://api.openweathermap.org/data/2.5/weather?q={0}&appid=8e1908235b6bf2bdd4bfdb4af649a714", txtArea.Text);
            HttpClient client = new HttpClient();
            txtWeather.Text = client.GetStringAsync(url).Result;
            clsWeather w = Newtonsoft.Json.JsonConvert.DeserializeObject<clsWeather>(txtWeather.Text);
            txtWeather.Text = string.Format("Name: {0} ({1})\r\nWeather: {2} - {3}\r\nTemp: {4}\r\nHumidity: {5}\r\nPressure: {6}\r\nWind: {7}", w.name,w.sys.country, w.weather[0].main, w.weather[0].description,Math.Round((w.main.temp-32)*5/9,1),w.main.humidity,w.main.pressure,w.wind.speed+"("+w.wind.deg+")") ;

            //WebRequest
            //WebResponse
            //WebClient
            //WebBrowser
            //System.Net.sock
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string url = string.Format("https://www.omdbapi.com/?s={0}&apikey=5b3098a8", txtSearch.Text);
            HttpClient client = new HttpClient();
            string dulieu = client.GetStringAsync(url).Result;
            SearchMovie ketquatimkiem = Newtonsoft.Json.JsonConvert.DeserializeObject<SearchMovie>(dulieu);
            MessageBox.Show(string.Format("Tim thay {0} phim thoa man tu khoa {1}", ketquatimkiem.totalResults, txtSearch.Text));
            //foreach (Search movie in ketquatimkiem.Search) {
            //    lbMovies.Items.Add(movie);
            //}
            lbMovies.DataSource = ketquatimkiem.Search;
            dgvMovies.DataSource = ketquatimkiem.Search;
        }
    }
}
