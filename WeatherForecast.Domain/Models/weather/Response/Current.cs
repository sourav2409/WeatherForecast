using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherForecast.Domain.Models.weather.Response
{
    public class Current
    {
        // These fields hold the values for the public properties.
        private int? lastUpdatedEpoch;
        private string lastUpdated;
        private double? tempC;
        private double? tempF;
        private int? isDay;
        private Condition condition;
        private double? windMph;
        private double? windKph;
        private int? windDegree;
        private string windDir;
        private double? pressureMb;
        private double? pressureIn;
        private double? precipMm;
        private double? precipIn;
        private int? humidity;
        private int? cloud;
        private double? feelslikeC;
        private double? feelslikeF;
        private double? visKm;
        private double? visMiles;
        private double? uv;
        private double? gustMph;
        private double? gustKph;

        /// <summary>
        /// Local time when the real time data was updated in unix time.
        /// </summary>  
        [JsonProperty("last_updated_epoch")]
        public int? LastUpdatedEpoch
        {
            get
            {
                return lastUpdatedEpoch;
            }
            set
            {
                lastUpdatedEpoch = value;
            }
        }

        /// <summary>
        /// Local time when the real time data was updated.
        /// </summary>        
        [JsonProperty("last_updated")]
        public string LastUpdated
        {
            get
            {
                return lastUpdated;
            }
            set
            {
                lastUpdated = value;
            }
        }

        /// <summary>
        /// Temperature in celsius
        /// </summary>
        [JsonProperty("temp_c")]
        public double? TempC
        {
            get
            {
                return tempC;
            }
            set
            {
                tempC = value;
            }
        }

        /// <summary>
        /// Temperature in fahrenheit
        /// </summary>
        [JsonProperty("temp_f")]
        public double? TempF
        {
            get
            {
                return tempF;
            }
            set
            {
                tempF = value;
            }
        }

        /// <summary>
        /// 1 = Yes 0 = No <br />Whether to show day condition icon or night icon
        /// </summary>
        [JsonProperty("is_day")]
        public int? IsDay
        {
            get
            {
                return isDay;
            }
            set
            {
                isDay = value;
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
                return condition;
            }
            set
            {
                condition = value;
            }
        }

        /// <summary>
        /// Wind speed in miles per hour
        /// </summary>
        [JsonProperty("wind_mph")]
        public double? WindMph
        {
            get
            {
                return windMph;
            }
            set
            {
                windMph = value;
            }
        }

        /// <summary>
        /// Wind speed in kilometer per hour
        /// </summary>
        [JsonProperty("wind_kph")]
        public double? WindKph
        {
            get
            {
                return windKph;
            }
            set
            {
                windKph = value;
            }
        }

        /// <summary>
        /// Wind direction in degrees
        /// </summary>
        [JsonProperty("wind_degree")]
        public int? WindDegree
        {
            get
            {
                return windDegree;
            }
            set
            {
                windDegree = value;
            }
        }

        /// <summary>
        /// Wind direction as 16 point compass. e.g.: NSW
        /// </summary>
        [JsonProperty("wind_dir")]
        public string WindDir
        {
            get
            {
                return windDir;
            }
            set
            {
                windDir = value;
            }
        }

        /// <summary>
        /// Pressure in millibars
        /// </summary>
        [JsonProperty("pressure_mb")]
        public double? PressureMb
        {
            get
            {
                return pressureMb;
            }
            set
            {
                pressureMb = value;
            }
        }

        /// <summary>
        /// Pressure in inches
        /// </summary>
        [JsonProperty("pressure_in")]
        public double? PressureIn
        {
            get
            {
                return pressureIn;
            }
            set
            {
                pressureIn = value;
            }
        }

        /// <summary>
        /// Precipitation amount in millimeters
        /// </summary>
        [JsonProperty("precip_mm")]
        public double? PrecipMm
        {
            get
            {
                return precipMm;
            }
            set
            {
                precipMm = value;
            }
        }

        /// <summary>
        /// Precipitation amount in inches
        /// </summary>
        [JsonProperty("precip_in")]
        public double? PrecipIn
        {
            get
            {
                return precipIn;
            }
            set
            {
                precipIn = value;
            }
        }

        /// <summary>
        /// Humidity as percentage
        /// </summary>
        [JsonProperty("humidity")]
        public int? Humidity
        {
            get
            {
                return humidity;
            }
            set
            {
                humidity = value;
            }
        }

        /// <summary>
        /// Cloud cover as percentage
        /// </summary>
        [JsonProperty("cloud")]
        public int? Cloud
        {
            get
            {
                return cloud;
            }
            set
            {
                cloud = value;
            }
        }

        /// <summary>
        /// Feels like temperature as celcius
        /// </summary>
        [JsonProperty("feelslike_c")]
        public double? FeelslikeC
        {
            get
            {
                return feelslikeC;
            }
            set
            {
                feelslikeC = value;
            }
        }

        /// <summary>
        /// Feels like temperature as fahrenheit
        /// </summary>
        [JsonProperty("feelslike_f")]
        public double? FeelslikeF
        {
            get
            {
                return feelslikeF;
            }
            set
            {
                feelslikeF = value;
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("vis_km")]
        public double? VisKm
        {
            get
            {
                return visKm;
            }
            set
            {
                visKm = value;
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("vis_miles")]
        public double? VisMiles
        {
            get
            {
                return visMiles;
            }
            set
            {
                visMiles = value;
            }
        }

        /// <summary>
        /// UV Index
        /// </summary>
        [JsonProperty("uv")]
        public double? Uv
        {
            get
            {
                return uv;
            }
            set
            {
                uv = value;
            }
        }

        /// <summary>
        /// Wind gust in miles per hour
        /// </summary>
        [JsonProperty("gust_mph")]
        public double? GustMph
        {
            get
            {
                return gustMph;
            }
            set
            {
                gustMph = value;
            }
        }

        /// <summary>
        /// Wind gust in kilometer per hour
        /// </summary>
        [JsonProperty("gust_kph")]
        public double? GustKph
        {
            get
            {
                return gustKph;
            }
            set
            {
                gustKph = value;
            }
        }
    }
}
