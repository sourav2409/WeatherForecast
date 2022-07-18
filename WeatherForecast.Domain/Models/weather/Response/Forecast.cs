using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherForecast.Domain.Models.weather.Response
{
    public class Forecast
    {
        // These fields hold the values for the public properties.
        private List<Forecastday> forecastday;

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("forecastday")]
        public List<Forecastday> Forecastday
        {
            get
            {
                return this.forecastday;
            }
            set
            {
                this.forecastday = value;                
            }
        }
    }
}
