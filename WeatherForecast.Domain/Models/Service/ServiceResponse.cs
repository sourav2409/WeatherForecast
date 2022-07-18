using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherForecast.Domain.Models.Service
{
    public class ServiceResponse<T> where T : class
    {
        public bool Success { get; set; }
        public IList<ServiceError> Errors{ get; set; }

        public T Data { get; set; }

    }
}
