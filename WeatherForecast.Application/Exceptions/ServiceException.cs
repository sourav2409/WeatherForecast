using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeatherForecast.Domain.Models.Service;

namespace WeatherForecast.Application.Exceptions
{
    public class ServiceException : ApplicationException
    {
        public List<string> ValdationErrors { get; set; }

        public ServiceException(IList<ServiceError> errors)
        {            
            foreach (var validationError in errors)
            {
                ValdationErrors.Add(validationError.Message);
            }
        }
    }
}
