using System;
using System.Drawing;
using System.Windows.Forms;

namespace WeatherApp
{
    public partial class WeatherForecastCard : UserControl
    {
        public string Date { get; set; }
        public string Temperature { get; set; }
        public string Description { get; set; }

        public WeatherForecastCard()
        {
            InitializeComponent();
        }

        public void SetData(string date, string temperature, string description)
        {
            label1.Text = date;
            label2.Text = temperature;
            label3.Text = description;
        }
        
        private void WeatherForecastCard_Load(object sender, EventArgs e)
        {
            // Load event logic here if needed
        }
    }
}
