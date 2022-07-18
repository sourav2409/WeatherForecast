using Microsoft.Extensions.Configuration;
using System.Collections.Generic;
using WeatherAPI.Standard.Http.Client;
using WeatherAPI.Standard.Http.Response;
using WeatherAPI.Standard.Utilities;
using WeatherForecast.Domain.Models.Service;
using WeatherForecast.Service.Service.Validation;

namespace WeatherForecast.Service.Service.Implementation
{
    public class BaseService
    {
        private readonly IConfiguration _configuration;

        public BaseService(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        #region shared http client instance
        private static object syncObject = new object();
        private static IHttpClient clientInstance = null;

        public static IHttpClient ClientInstance
        {
            get
            {
                lock (syncObject)
                {
                    if (null == clientInstance)
                    {
                        clientInstance = new HTTPClient()
;
                    }
                    return clientInstance;
                }
            }
            set
            {
                lock (syncObject)
                {
                    if (value is IHttpClient)
                    {
                        clientInstance = value;
                    }
                }
            }
        }
        #endregion shared http client instance

        internal ArrayDeserialization ArrayDeserializationFormat = ArrayDeserialization.Indexed;
        internal static char ParameterSeparator = '&';

        internal string BaseWeatherAPIUrl { get { return _configuration.GetValue<string>("WeatherApiSettings:BaseUrl"); } }

        internal string BaseWeatherApiKey { get { return _configuration.GetValue<string>("WeatherApiSettings:Key"); } }

        /// <summary>
        /// Validates the response against HTTP errors defined at the API level
        /// </summary>
        /// <param name="_response">The response recieved</param>       
        internal List<ServiceError> ValidateResponse(HttpResponse _response)
        {
            var validationResult = new List<ServiceError>();
            //Error handling using HTTP status codes
            if (_response.StatusCode == 400)
                validationResult.Add(new ServiceError() { ErrorCode = _response.StatusCode, Message = @"Error code 1003: Parameter 'q' not provided.Error code 1005: API request url is invalid.Error code 1006: No location found matching parameter 'q'Error code 9999: Internal application error." });
                
            if (_response.StatusCode == 401)
                validationResult.Add(new ServiceError() { ErrorCode = _response.StatusCode, Message = @"Error code 1002: API key not provided.Error code 2006: API key provided is invalid." });
            
            if (_response.StatusCode == 403)
                validationResult.Add(new ServiceError() { ErrorCode = _response.StatusCode, Message = @"Error code 2007: API key has exceeded calls per month quota.<br />Error code 2008: API key has been disabled." });            


            if ((_response.StatusCode < 200) || (_response.StatusCode > 208)) //[200,208] = HTTP OK
                validationResult.Add(new ServiceError() { ErrorCode = _response.StatusCode, Message = @"HTTP Response Not OK" });

            return validationResult;
        }

        internal ValidationResult ValidateResponseNew(HttpStringResponse _response)
        {
            var validationResult = new List<ServiceError>();
            //Error handling using HTTP status codes
            if (_response.StatusCode == 400)
                validationResult.Add(new ServiceError() { ErrorCode = _response.StatusCode, Message = @"Error code 1003: Parameter 'q' not provided.Error code 1005: API request url is invalid.Error code 1006: No location found matching parameter 'q'Error code 9999: Internal application error." });

            if (_response.StatusCode == 401)
                validationResult.Add(new ServiceError() { ErrorCode = _response.StatusCode, Message = @"Error code 1002: API key not provided.Error code 2006: API key provided is invalid." });

            if (_response.StatusCode == 403)
                validationResult.Add(new ServiceError() { ErrorCode = _response.StatusCode, Message = @"Error code 2007: API key has exceeded calls per month quota.<br />Error code 2008: API key has been disabled." });


            if ((_response.StatusCode < 200) || (_response.StatusCode > 208)) //[200,208] = HTTP OK
                validationResult.Add(new ServiceError() { ErrorCode = _response.StatusCode, Message = @"HTTP Response Not OK" });

            return new ValidationResult() { ResponseMessage = _response, Errors = validationResult, Success = validationResult.Count == 0 };           
           
        }
    }
}
