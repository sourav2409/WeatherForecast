using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherForecast.Domain.Models.weather.Response
{
    public class Location
    {
        // These fields hold the values for the public properties.
        private string name;
        private string region;
        private string country;
        private double? lat;
        private double? lon;
        private string tzId;
        private int? localtimeEpoch;
        private string localtime;

        /// <summary>
        /// Local area name.
        /// </summary>
        [JsonProperty("name")]
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        /// <summary>
        /// Local area region.
        /// </summary>
        [JsonProperty("region")]
        public string Region
        {
            get
            {
                return region;
            }
            set
            {
                region = value;
            }
        }

        /// <summary>
        /// Country
        /// </summary>
        [JsonProperty("country")]
        public string Country
        {
            get
            {
                return country;
            }
            set
            {
                country = value;
            }
        }

        /// <summary>
        /// Area latitude
        /// </summary>
        [JsonProperty("lat")]
        public double? Lat
        {
            get
            {
                return lat;
            }
            set
            {
                lat = value;
            }
        }

        /// <summary>
        /// Area longitude
        /// </summary>
        [JsonProperty("lon")]
        public double? Lon
        {
            get
            {
                return lon;
            }
            set
            {
                lon = value;
            }
        }

        /// <summary>
        /// Time zone
        /// </summary>
        [JsonProperty("tz_id")]
        public string TzId
        {
            get
            {
                return tzId;
            }
            set
            {
                tzId = value;
            }
        }

        /// <summary>
        /// Local date and time in unix time
        /// </summary>
        [JsonProperty("localtime_epoch")]
        public int? LocaltimeEpoch
        {
            get
            {
                return localtimeEpoch;
            }
            set
            {
                localtimeEpoch = value;
            }
        }

        /// <summary>
        /// Local date and time
        /// </summary>
        [JsonProperty("localtime")]
        public string Localtime
        {
            get
            {
                return localtime;
            }
            set
            {
                localtime = value;
            }
        }
    }
}
