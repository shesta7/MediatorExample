using System;
using MediatorExample.Responses;
using RowebMediator;

namespace MediatorExample.Requests
{
    public class GetWeatherForecastRequest : IRequest<GetWeatherForecastResponse >
    {
        public bool IsValid { get; set; }
    }
}

