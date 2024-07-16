using System;
using System.Globalization;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace WeatherApp
{
    public partial class Form1 : Form
    {
        private Point initialClick;
        private static readonly HttpClient client = new HttpClient();
        private List<ForecastItem> forecastItems = new List<ForecastItem>();
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        public class ForecastItem
        {
            public string Date { get; set; }
            public string Temperature { get; set; }
            public string Description { get; set; }
        }

        private async Task GetWeatherDataAsync(string location)
        {
            string apiKey = "d625546d2435755dece371038daac30a";
            string currentWeatherUrl = $"http://api.openweathermap.org/data/2.5/weather?q={location}&appid={apiKey}&units=metric";
            string forecastUrl = $"http://api.openweathermap.org/data/2.5/forecast?q={location}&appid={apiKey}&units=metric";

            try
            {
                var currentWeatherResponse = await client.GetStringAsync(currentWeatherUrl);
                var currentWeatherData = JObject.Parse(currentWeatherResponse);

                string temperature = currentWeatherData["main"]["temp"].ToString();
                string description = currentWeatherData["weather"][0]["description"].ToString();
                string humidity = currentWeatherData["main"]["humidity"].ToString();
                long sunriseTimestamp = long.Parse(currentWeatherData["sys"]["sunrise"].ToString());
                long sunsetTimestamp = long.Parse(currentWeatherData["sys"]["sunset"].ToString());

                DateTime sunriseTime = DateTimeOffset.FromUnixTimeSeconds(sunriseTimestamp).LocalDateTime;
                DateTime sunsetTime = DateTimeOffset.FromUnixTimeSeconds(sunsetTimestamp).LocalDateTime;

                UpdateCurrentWeatherUI(DateTime.Now, sunriseTime, sunsetTime, temperature, description, location, humidity);

                var forecastResponse = await client.GetStringAsync(forecastUrl);
                var forecastData = JObject.Parse(forecastResponse);

                UpdateForecastUI(forecastData);
            }
            catch (HttpRequestException)
            {
                MessageBox.Show("Error fetching data from the API. Please check the location and try again.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An unexpected error occurred: {ex.Message}");
            }
        }

        private void UpdateCurrentWeatherUI(DateTime now, DateTime sunrise, DateTime sunset, string temperature, string description, string location, string humidity)
        {
            todayLabel.Text = now.ToString("MMM dd, yy");
            sunriseLabel.Text = sunrise.ToString("hh:mm tt");
            sunsetLabel.Text = sunset.ToString("hh:mm tt");
            temperatureLabel.Text = $"{temperature}°C";
            descriptionLabel.Text = description;
            locationLabel.Text = location;
            humidityLabel.Text = $"{humidity}%";
        }

        private void UpdateForecastUI(JObject forecastData)
        {
            forecastList.Controls.Clear();
            int cardX = 15;
            int cardY = 15;
            HashSet<string> uniqueDays = new HashSet<string>();

            foreach (var item in forecastData["list"])
            {
                string dateString = item["dt_txt"].ToString();
                DateTime date = DateTime.ParseExact(dateString, "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture);
                string dayName = date.ToString("ddd");

                if (!uniqueDays.Contains(dayName))
                {
                    uniqueDays.Add(dayName);
                    string temp = item["main"]["temp"].ToString();
                    string desc = item["weather"][0]["description"].ToString();

                    WeatherForecastCard card = new WeatherForecastCard();
                    card.SetData(dayName, $"{temp}°C", desc);

                    card.Size = new Size(166, 150);
                    card.Location = new Point(cardX, cardY);
                    forecastList.Controls.Add(card);

                    cardX += card.Width + 15;
                    if (cardX + card.Width > forecastList.Width)
                    {
                        cardX = 10;
                        cardY += card.Height + 10;
                    }
                }
            }
        }

        private async void search(object sender, EventArgs e)
        {
            string location = textLocation.Text;
            await GetWeatherDataAsync(location);
        }

        private async void refreshWeatherData(object sender, EventArgs e)
        {
            string location = textLocation.Text;
            await GetWeatherDataAsync(location);
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                initialClick = this.PointToClient(Cursor.Position);
                this.Capture = true;
                this.Cursor = Cursors.SizeAll;
            }
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point currentMousePos = this.PointToClient(Cursor.Position);
                Point offset = new Point(currentMousePos.X - initialClick.X, currentMousePos.Y - initialClick.Y);
                this.Location = new Point(this.Location.X + offset.X, this.Location.Y + offset.Y);
            }
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            this.Capture = false;
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void maximize_Click(object sender, EventArgs e)
        {
            //    if (this.WindowState == FormWindowState.Normal)
            //    {
            //        this.WindowState = FormWindowState.Maximized;
            //    }
            //    else
            //    {
            //        this.WindowState = FormWindowState.Normal;
            //    }
        }
    }
}
