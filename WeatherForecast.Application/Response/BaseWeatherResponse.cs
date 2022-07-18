using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherForecast.Application.Response
{
    public class BaseWeatherResponse : BaseResponse
    {
        /// <summary>
        /// Current weather deatils
        /// </summary>
        [JsonProperty("current")]
        public CurrentWeatherVm CurrentWeather { get; set; }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("weatherLocation")]
        public LocationVm weatherLocation { get; set; }
    }
}
