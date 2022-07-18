using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherForecast.Domain.Models.weather.Response
{
    public class BaseWeatherResponse
    {
        // These fields hold the values for the public properties.
        private Location location;
        private Current current;

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("location")]
        public Location Location
        {
            get
            {
                return location;
            }
            set
            {
                location = value;
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("current")]
        public Current Current
        {
            get
            {
                return current;
            }
            set
            {
                current = value;
            }
        }
    }
}
