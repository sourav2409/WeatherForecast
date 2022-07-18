using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherForecast.Domain.Models.Service
{
    public class ServiceError
    {
        public int ErrorCode { get; set; }
        public string Message { get; set; }
    }
}
