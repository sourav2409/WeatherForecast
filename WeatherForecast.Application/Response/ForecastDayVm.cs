using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherForecast.Application.Response
{
    public class ForecastDayVm
    {
        /// <summary>
        /// Forecast date
        /// </summary>
        [JsonProperty("dayOfTheWeek")]
        public string DayOfTheWeek { get; set; }
        

        /// <summary>
        /// See day element
        /// </summary>
        [JsonProperty("day")]
        public DayVm Day { get; set; }
    }
}
