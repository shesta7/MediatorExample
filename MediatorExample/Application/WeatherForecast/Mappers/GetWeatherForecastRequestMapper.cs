using System;
using MediatorExample.Requests;
using MediatorExample.Responses;
using RowebMediator;

namespace MediatorExample
{
    public static class MapperExtensions
    {
        public static bool MapToBool(this GetWeatherForecastRequest request)
        {
            return request.IsValid;
        }

        public static string MapToString(this GetWeatherForecastRequest request)
        {
            return request.IsValid.ToString();
        }
    }
}

