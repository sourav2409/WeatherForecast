using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherForecast.Application.Response
{
    public class CurrentWeatherVm
    {
        /// <summary>
        /// Temperature in celsius
        /// </summary>
        [JsonProperty("tempC")]
        public double? TempC { get; set; }


        /// <summary>
        /// 1 = Yes 0 = No <br />Whether to show day condition icon or night icon
        /// </summary>
        [JsonProperty("isDay")]
        public int? IsDay { get; set; }

        /// <summary>
        /// Feels like temperature as celcius
        /// </summary>
        [JsonProperty("feelsLikeC")]
        public double? FeelslikeC { get; set; }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("condition")]
        public ConditionVm Condition { get; set; }

    }
}

