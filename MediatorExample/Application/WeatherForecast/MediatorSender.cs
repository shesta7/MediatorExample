using System;
using System.Threading;
using System.Threading.Tasks;
using MediatorExample;
using MediatorExample.Handlers;
using MediatorExample.Requests;
using MediatorExample.Responses;
using Microsoft.Extensions.DependencyInjection;

namespace MediatorExample.Services;

public partial class AppMediator
{
    public async Task<GetWeatherForecastResponse > Send(GetWeatherForecastRequest request, CancellationToken cancellationToken = default)
    {
        return await (_serviceProvider.GetService(typeof(GetWeatherHandler)) as GetWeatherHandler)?.HandleAsync(request, cancellationToken)
            ?? throw new InvalidOperationException();
    }
}

