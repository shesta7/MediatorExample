using System;
using FluentValidation;
using MediatorExample.Requests;

namespace MediatorExample.Application.WeatherForecast.Validators
{
	public class GetWeatherRequestValidator : AbstractValidator<GetWeatherForecastRequest>
    {
		public GetWeatherRequestValidator()
		{
			RuleFor(x => x.IsValid).Equal(true);
		}
	}
}