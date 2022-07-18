using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeatherForecast.Domain.Models.weather.Response;

namespace WeatherForecast.Application.Response
{
    public class DayVm
    {
        /// <summary>
        /// Maximum temperature in celsius for the day.
        /// </summary>
        [JsonProperty("maxTempC")]
        public double? MaxtempC { get; set; }

        /// <summary>
        /// Maximum temperature in fahrenheit for the day
        /// </summary>
        [JsonProperty("maxTempF")]
        public double? MaxtempF { get; set; }

        /// <summary>
        /// Minimum temperature in celsius for the day
        /// </summary>
        [JsonProperty("minTempC")]
        public double? MintempC { get; set; }

        /// <summary>
        /// Minimum temperature in fahrenheit for the day
        /// </summary>
        [JsonProperty("minTempF")]
        public double? MintempF { get; set; }


        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("condition")]
        public Condition Condition { get; set; }
    }
}
