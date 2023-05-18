using Newtonsoft.Json;
using System.Net;

namespace WeatherTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void find_Click_1(object sender, EventArgs e)
        {
            string sity = countryTextBox.Text;
            string url = "https://api.openweathermap.org/data/2.5/weather?q=" +
                         sity + "&appid=19e89a46b9ed01e33acc150becac0a26";//запрашиваем данные по городу

            using var httpclient = new HttpClient();
            var response = await httpclient.GetAsync(url);
            //Обработчик ошибок
            switch (response.StatusCode)
            {
                case HttpStatusCode.NotFound:
                    throw new Exception("Город не найден");

                case HttpStatusCode.InternalServerError:
                    throw new Exception("Ошибка на сервере");
            }

            var resultJson = await response.Content.ReadAsStringAsync();

            var weather = JsonConvert.DeserializeObject<WeatherPes>(resultJson);//преобразуем Json формат

            richTextBox1.Text = ("Температура: " + weather.Main.Temp + "F\n Скорость ветра: " + weather.Wind.Speed + "\n Описание: " + weather.Weather[weather.Weather.Length - 1].Description);//вывод
        }
    }
}
