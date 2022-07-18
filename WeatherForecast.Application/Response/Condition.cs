using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherForecast.Application.Response
{
    public class ConditionVm
    {
        /// <summary>
        /// Weather condition text
        /// </summary>       
        [JsonProperty("text")]
        public string Text { get; set; }

        /// <summary>
        /// Weather icon url
        /// </summary>
        [JsonProperty("icon")]
        public string Icon { get; set; }

        /// <summary>
        /// Weather condition unique code.
        /// </summary>
        [JsonProperty("code")]
        public int? Code { get; set; }
    }
}
