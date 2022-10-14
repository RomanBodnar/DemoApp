namespace DemoApp.Tests;

public class UnitTest1
{
    [Fact]
    public void CelsiumToFahrenheit()
    {
        int c = 10;
        var f = new WeatherForecast { TemperatureC = c }.TemperatureF;
        Assert.Equivalent(49, f);
    }
}