using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherForecast.Domain.Models.weather.Response
{
    public class Condition
    {
        // These fields hold the values for the public properties.
        private string text;
        private string icon;
        private int? code;

        /// <summary>
        /// Weather condition text
        /// </summary>       
        [JsonProperty("text")]
        public string Text
        {
            get
            {
                return text;
            }
            set
            {
                text = value;
            }
        }

        /// <summary>
        /// Weather icon url
        /// </summary>
        [JsonProperty("icon")]
        public string Icon
        {
            get
            {
                return icon;
            }
            set
            {
                icon = value;
            }
        }

        /// <summary>
        /// Weather condition unique code.
        /// </summary>
        [JsonProperty("code")]
        public int? Code
        {
            get
            {
                return code;
            }
            set
            {
                code = value;
            }
        }
    }
}
