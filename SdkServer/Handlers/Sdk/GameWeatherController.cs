using KianaBH.Data.Models.Sdk;
using Microsoft.AspNetCore.Mvc;

namespace KianaBH.SdkServer.Handlers.Sdk;

[ApiController]
public class GameWeatherController : ControllerBase
{
    [HttpGet("/game_weather/weather/get_weather")]
    public IActionResult GetWeather()
    {
        var now = DateTime.Now;
        var dateString = now.ToString("yyyy-MM-dd");

        return Ok(new GetWeatherResponse
        {
            Data = new GetWeatherResponse.GetWeatherResponseData
            {
                Timezone = (int)TimeZoneInfo.Local.GetUtcOffset(now).TotalHours,
                Hourly = Enumerable.Range(1, 24).Select(i =>
                    new GetWeatherResponse.GetWeatherResponseData.HourlyWeatherData
                    {
                        Condition = 3,
                        Date = dateString,
                        Hour = i,
                        Temp = 21
                    }).ToList()
            }
        });
    }
}