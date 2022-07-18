using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherForecast.Domain.Models.weather.Response
{
    public class Forecastday
    {
        // These fields hold the values for the public properties.
        private string date;
        private int? dateEpoch;
        private Day day;       

        /// <summary>
        /// Forecast date
        /// </summary>
        [JsonProperty("date")]
        public string Date
        {
            get
            {
                return this.date;
            }
            set
            {
                this.date = value;
            }
        }

        /// <summary>
        /// Forecast date as unix time.
        /// </summary>
        [JsonProperty("date_epoch")]
        public int? DateEpoch
        {
            get
            {
                return this.dateEpoch;
            }
            set
            {
                this.dateEpoch = value;
            }
        }

        /// <summary>
        /// See day element
        /// </summary>
        [JsonProperty("day")]
        public Day Day
        {
            get
            {
                return this.day;
            }
            set
            {
                this.day = value;
            }
        }       
    }
}
