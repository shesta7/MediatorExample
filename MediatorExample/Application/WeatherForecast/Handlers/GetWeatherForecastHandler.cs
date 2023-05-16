using System;
using MediatorExample.Requests;
using Microsoft.Extensions.DependencyInjection;
using RowebMediator;
using MediatorExample;
using MediatorExample.Responses;
using FluentValidation;
using System.ComponentModel.DataAnnotations;

namespace MediatorExample.Handlers;

public class GetWeatherHandler : IHandler<GetWeatherForecastRequest, GetWeatherForecastResponse >
{
    private static readonly string[] Summaries = new[]
    {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

    private readonly IValidator<GetWeatherForecastRequest> _validator;
    private readonly ILogger<GetWeatherHandler> _logger;

    public GetWeatherHandler(IValidator<GetWeatherForecastRequest> validator, ILogger<GetWeatherHandler> logger)
    {
        _validator = validator;
        _logger = logger;
    }

    public async Task<GetWeatherForecastResponse > HandleAsync(GetWeatherForecastRequest request, CancellationToken cancellationToken)
    {
        var testMapping = request.MapToBool(); // just for show possible mapping
        var testMapping2 = request.MapToString(); // just for show possible mapping

        var result = await _validator.ValidateAsync(request);
        if (!result.IsValid)
            return new GetWeatherForecastResponse()
            {
                IsSuccess = false,
                ValidationErrors = result.ToDictionary(),
            };

        var weatherForecasts = Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            })
        .ToList();

        return new GetWeatherForecastResponse()
        {
            IsSuccess = true,
            WeatherForecasts = weatherForecasts
        };
    }
}

