using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherForecast.Application.Response
{
    public class LocationVm
    {
        /// <summary>
        /// Local area name.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// Country
        /// </summary>
        [JsonProperty("country")]
        public string Country { get; set; }
    }
}
