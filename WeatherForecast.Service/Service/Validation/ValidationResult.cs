using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeatherAPI.Standard.Http.Response;
using WeatherForecast.Domain.Models.Service;

namespace WeatherForecast.Service.Service.Validation
{
    public class ValidationResult
    {
        public bool Success { get; set; }
        public IList<ServiceError> Errors { get; set; }

        public HttpStringResponse ResponseMessage { get; set; }  
    }
}
