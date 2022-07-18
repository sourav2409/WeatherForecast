using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherForecast.Domain.Models.weather.Request
{
    public class WeatherForecastRequest : BaseWeatherRequest
    {
        public int days { get; set; }

    }
}
