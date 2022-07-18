using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherForecast.Domain.Models.weather.Response
{
    public class WeatherForecastResponse : BaseWeatherResponse
    {
        // These fields hold the values for the public properties.
        private Forecast forecast;

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("forecast")]
        public Forecast Forecast
        {
            get
            {
                return this.forecast;
            }
            set
            {
                this.forecast = value;                
            }
        }
    }
}
