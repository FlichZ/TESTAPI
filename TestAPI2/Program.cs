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

            WeatherForecast weatherData = await client.QueryAsync("Moscow");
            //Почасовой запрос на весь день
            Console.WriteLine("Почасовой запрос на весь день");
            Console.WriteLine(weatherData.CurrentWeather.Temperature);
            Console.WriteLine(client.WeathercodeToString((int)weatherData.CurrentWeather.Weathercode));
            Console.WriteLine(weatherData.CurrentWeather.Windspeed);
            Console.WriteLine(weatherData.CurrentWeather.WindDirection);
            Console.WriteLine(weatherData.CurrentWeather.Time);
            Console.WriteLine(weatherData.Hourly.Surface_pressure);
            Console.WriteLine(weatherData.Hourly.Pressure_msl);
            Console.WriteLine(weatherData.Hourly.Apparent_temperature);
            Console.WriteLine(weatherData.Hourly.Precipitation);
            Console.WriteLine(weatherData.Hourly.Precipitation_probability);
            Console.WriteLine(weatherData.Hourly.Rain);
            Console.WriteLine(weatherData.Hourly.Showers);
            Console.WriteLine(weatherData.Hourly.Snowfall);
            Console.WriteLine(weatherData.Hourly.Snow_depth);
            Console.WriteLine(weatherData.Hourly.Cloudcover);
            Console.WriteLine(weatherData.Hourly.Visibility);
            //Запрос на весь день
            Console.WriteLine("Запрос на весь день");
            Console.WriteLine(weatherData.Daily.Weathercode);
            Console.WriteLine(weatherData.Daily.Temperature_2m_max);
            Console.WriteLine(weatherData.Daily.Temperature_2m_min);
            Console.WriteLine(weatherData.Daily.Apparent_temperature_max);
            Console.WriteLine(weatherData.Daily.Apparent_temperature_min);
            Console.WriteLine(weatherData.Daily.Sunrise);
            Console.WriteLine(weatherData.Daily.Sunset);
            Console.WriteLine(weatherData.Daily.Precipitation_sum);
            Console.WriteLine(weatherData.Daily.Precipitation_hours);
            Console.WriteLine(weatherData.Daily.Rain_sum);
            Console.WriteLine(weatherData.Daily.Showers_sum);
            Console.WriteLine(weatherData.Daily.Snowfall_sum);
            Console.WriteLine(weatherData.Daily.Windspeed_10m_max);
            Console.WriteLine(weatherData.Daily.Windgusts_10m_max);
            Console.WriteLine(weatherData.Daily.Winddirection_10m_dominant);

            Console.ReadKey();
        }
    }
}