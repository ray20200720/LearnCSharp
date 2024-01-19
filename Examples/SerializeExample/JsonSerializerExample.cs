using System;
using System.Text.Json;

namespace SerializeExample
{
    public class WeatherForecast
    {
        public DateTimeOffset Date { get; set; }
        public int TemperatureCelsius { get; set; }
        public string Summary { get; set; }
    }

    public class JsonSerializerExample
    {
        public static void ShowExample()
        {
            var weatherForecast = new WeatherForecast
            {
                Date = DateTimeOffset.UtcNow,
                TemperatureCelsius = 25,
                Summary = "Hot"
            };

            string jsonString = JsonSerializer.Serialize(weatherForecast);

            Console.WriteLine(jsonString);
        }
    }
}
