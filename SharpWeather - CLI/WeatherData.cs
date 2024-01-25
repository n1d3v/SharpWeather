public class WeatherData
{
    public string Name { get; set; }
    public Main Main { get; set; }
    public Weather[] Weather { get; set; }
    public Wind Wind { get; set; }
}

public class Main
{
    public double Temp { get; set; }
}

public class Weather
{
    public string Description { get; set; }
}

public class Wind
{
    public double Speed { get; set; }
}
