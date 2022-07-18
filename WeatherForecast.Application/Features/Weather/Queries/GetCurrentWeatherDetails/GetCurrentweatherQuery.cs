using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeatherForecast.Application.Response;

namespace WeatherForecast.Application.Features.Weather.Queries.GetCurrentWeatherDetails
{
    public class GetCurrentweatherQuery : IRequest<RealTimeWeatherResponseMessage>
    {
        public string query { get; set; }
        public string lang { get; set; }
    }
}
