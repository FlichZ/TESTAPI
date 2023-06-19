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
            Console.WriteLine(weatherData.CurrentWeather.Temperature); //Текущая темпиратура
            Console.WriteLine(client.WeathercodeToString((int)weatherData.CurrentWeather.Weathercode)); //Код погоды с переводом на по типу ясно и тд.
            Console.WriteLine(weatherData.CurrentWeather.Windspeed); // Скорость ветра
            Console.WriteLine(weatherData.CurrentWeather.WindDirection); // Направление ветра
            Console.WriteLine(weatherData.CurrentWeather.Time); // Время
            Console.WriteLine(weatherData.Hourly.Surface_pressure[0] * 0.750064); // Давление мм рт столба
            Console.WriteLine(weatherData.Hourly.Pressure_msl); // Давление воды
            Console.WriteLine(weatherData.Hourly.Apparent_temperature[0]); // Темпиратура ощущается
            Console.WriteLine(weatherData.Hourly.Precipitation); //  Осадки
            Console.WriteLine(weatherData.Hourly.Precipitation_probability); // Ещё осадки
            Console.WriteLine(weatherData.Hourly.Rain); // Дождь
            Console.WriteLine(weatherData.Hourly.Showers); // Ливни
            Console.WriteLine(weatherData.Hourly.Snowfall); // Снег
            Console.WriteLine(weatherData.Hourly.Snow_depth); // Метель
            Console.WriteLine(weatherData.Hourly.Cloudcover); // Облачность
            Console.WriteLine(weatherData.Hourly.Visibility); // Видимость
            Console.WriteLine(weatherData.Hourly.Temperature_2m[0]); // Темпиратура над 2 метрами земли в списке на часы 
            Console.WriteLine(weatherData.Latitude); // Координаты
            Console.WriteLine(weatherData.Longitude); // Координаты
            //Запрос на весь день
            Console.WriteLine("Запрос на весь день");
            Console.WriteLine(weatherData.Daily.Weathercode[0]); // Код погоды на неделю
            Console.WriteLine(weatherData.Daily.Temperature_2m_max[0]); // максимальная Темпиратура макс над 2 метрами земли в списке на неделю 
            Console.WriteLine(weatherData.Daily.Temperature_2m_min[0]); // минимальная Темпиратура макс над 2 метрами земли в списке на неделю
            Console.WriteLine(weatherData.Daily.Apparent_temperature_max[0]); // примерная максимальная Темпиратура макс над 2 метрами земли в списке на неделю
            Console.WriteLine(weatherData.Daily.Apparent_temperature_min[0]); // примерная минимальная Темпиратура макс над 2 метрами земли в списке на неделю
            Console.WriteLine(weatherData.Daily.Sunrise); // Восход солнца
            Console.WriteLine(weatherData.Daily.Sunset); // Закат
            Console.WriteLine(weatherData.Daily.Precipitation_sum); // Сумма осадков
            Console.WriteLine(weatherData.Daily.Precipitation_hours); // Осадки часы на неделю
            Console.WriteLine(weatherData.Daily.Rain_sum); // Сумма дождей
            Console.WriteLine(weatherData.Daily.Showers_sum); // Ливни
            Console.WriteLine(weatherData.Daily.Snowfall_sum); // Снег
            Console.WriteLine(weatherData.Daily.Windspeed_10m_max); //  Скорость ветра
            Console.WriteLine(weatherData.Daily.Windgusts_10m_max); // Порывы ветра
            Console.WriteLine(weatherData.Daily.Winddirection_10m_dominant); // Направление ветра
            Console.WriteLine(weatherData.Hourly.Relativehumidity_2m); // Влажность

            Console.ReadKey();
        }
    }
}