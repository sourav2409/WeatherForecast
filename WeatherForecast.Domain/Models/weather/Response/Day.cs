using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherForecast.Domain.Models.weather.Response
{
    public class Day
    {
        // These fields hold the values for the public properties.
        private double? maxtempC;
        private double? maxtempF;
        private double? mintempC;
        private double? mintempF;        
        private Condition condition;        

        /// <summary>
        /// Maximum temperature in celsius for the day.
        /// </summary>
        [JsonProperty("maxtemp_c")]
        public double? MaxtempC
        {
            get
            {
                return this.maxtempC;
            }
            set
            {
                this.maxtempC = value;                
            }
        }

        /// <summary>
        /// Maximum temperature in fahrenheit for the day
        /// </summary>
        [JsonProperty("maxtemp_f")]
        public double? MaxtempF
        {
            get
            {
                return this.maxtempF;
            }
            set
            {
                this.maxtempF = value;
            }
        }

        /// <summary>
        /// Minimum temperature in celsius for the day
        /// </summary>
        [JsonProperty("mintemp_c")]
        public double? MintempC
        {
            get
            {
                return this.mintempC;
            }
            set
            {
                this.mintempC = value;
            }
        }

        /// <summary>
        /// Minimum temperature in fahrenheit for the day
        /// </summary>
        [JsonProperty("mintemp_f")]
        public double? MintempF
        {
            get
            {
                return this.mintempF;
            }
            set
            {
                this.mintempF = value;
            }
        }

        
        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("condition")]
        public Condition Condition
        {
            get
            {
                return this.condition;
            }
            set
            {
                this.condition = value;                
            }
        }

    }
}
