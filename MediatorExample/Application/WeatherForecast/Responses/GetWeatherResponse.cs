using System;
namespace MediatorExample.Responses
{
	public class GetWeatherForecastResponse: BaseResponse
	{
        public List<WeatherForecast> WeatherForecasts { get; init; }
    }
}

