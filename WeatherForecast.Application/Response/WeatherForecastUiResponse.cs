using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherForecast.Application.Response
{
    public class WeatherForecastUiResponse : BaseWeatherResponse
    {
        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("forecast")]
        public ForecastVm Forecast { get; set; }
    }
}
