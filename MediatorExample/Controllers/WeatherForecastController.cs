using MediatorExample.Requests;
using MediatorExample.Responses;
using MediatorExample.Services;
using Microsoft.AspNetCore.Mvc;
using RowebMediator;

namespace MediatorExample.Controllers;

[ApiController]
[Route("[controller]")]
public class WeatherForecastController : ControllerBase
{
    private readonly ILogger<WeatherForecastController> _logger;
    private readonly AppMediator _mediator;

    public WeatherForecastController(ILogger<WeatherForecastController> logger, AppMediator mediator)
    {
        _logger = logger;
        _mediator = mediator;
    }

    [HttpGet(Name = "GetWeatherForecast")]
    public async Task<IActionResult> Get(bool isValid)
    {
        var request = new GetWeatherForecastRequest()
        {
            IsValid = isValid
        };

        var res = await _mediator.Send(request);
        return new JsonResult(res);
    }
}