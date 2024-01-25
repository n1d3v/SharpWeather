using Newtonsoft.Json;

Console.Write("Enter the name of the city: ");
string city = Console.ReadLine();

using (var httpClient = new HttpClient())
{
    using (var response = await httpClient.GetAsync($"https://api.openweathermap.org/data/2.5/weather?q={city}&appid=853c934c10849992f194eb00c697df74&units=metric"))
    {
        string apiResponse = await response.Content.ReadAsStringAsync();
        if (apiResponse.Contains("city not found"))
        {
            Console.WriteLine($"Weather not found for {city}");
        }
        else
        {
            var weatherData = JsonConvert.DeserializeObject<WeatherData>(apiResponse);

            Console.WriteLine($"Temperature in {weatherData.Name}: {weatherData.Main.Temp}°C");
            Console.WriteLine($"Weather: {weatherData.Weather[0].Description}");
            Console.WriteLine($"Wind speed: {weatherData.Wind.Speed} m/s");
        }
    }
}
