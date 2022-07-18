using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherForecast.Application.Response
{
    public class ForecastVm
    {
        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("forecastday")]
        public List<ForecastDayVm> Forecastday { get; set; }
    }
}
