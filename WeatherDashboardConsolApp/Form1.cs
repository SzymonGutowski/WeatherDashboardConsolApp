using Newtonsoft.Json;
using System.Net;

namespace WeatherDashboardConsolApp
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        string _apiKey = "93c6dcd824f1758b8d0d29ccccafed93";
        private void GenerateWeather_Click(object sender, EventArgs e)
        {
            getWeather();
        }

        private void CalendarButton_Click(object sender, EventArgs e)
        {
            
        }

        private void DateBox_TextChanged(object sender, EventArgs e)
        {
             
        }

        private void dateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            DateBox.Text = dateTimePicker.Value.ToShortDateString();
        }


        void getWeather()
        {
            using (WebClient web = new WebClient())
            {
                string latUser = NorthSouth.Text;
                string lonUser = EastWest.Text;
                string url = string.Format($"https://api.openweathermap.org/data/2.5/weather?lat={latUser}&lon={lonUser}&appid={_apiKey}");
                var jsonLink = web.DownloadString(url);
                WeatherInfo.root Info = JsonConvert.DeserializeObject<WeatherInfo.root>(jsonLink);

                TemperatureJSON.Text = Info.main.temp.ToString();
                PressureJSON.Text = Info.main.pressure.ToString();
                HumidityJSON.Text = Info.main.humidity.ToString();
                WindJSON.Text = Info.wind.speed.ToString();

                
            }
        }

    }
}