using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenMeteo;

namespace TestAPI2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            RunAsync().GetAwaiter().GetResult();
        }

        static async Task RunAsync()
        {

            OpenMeteoClient client = new OpenMeteoClient();

            WeatherForecast weatherData = await client.QueryAsync("London");

            Console.WriteLine(weatherData.CurrentWeather.Temperature + "°C");
            Console.ReadKey();
        }
    }
}