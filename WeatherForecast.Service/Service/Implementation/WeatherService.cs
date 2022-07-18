using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeatherAPI.Standard.Http.Request;
using WeatherAPI.Standard.Http.Response;
using WeatherAPI.Standard.Utilities;
using WeatherForecast.Domain.Models.Service;
using WeatherForecast.Domain.Models.weather.Request;
using WeatherForecast.Domain.Models.weather.Response;
using WeatherForecast.Service.Service.Contracts;
using WeatherForecast.Service.Service.Validation;

namespace WeatherForecast.Service.Service.Implementation
{
    public class WeatherService: BaseService , IWeatherService
    {
        private readonly IConfiguration _configuration;
        public WeatherService(IConfiguration configuration) : base(configuration)
        {
            _configuration = configuration;
        }

        public async Task<ServiceResponse<RealTimeWeatherResponse>> GetRealTimeWeatherDetailsAsync(RealTimeWeatherRequest realTimeWeatherRequest)
        {
            var requestParams = new Dictionary<string, object>()
            {
                { "q", realTimeWeatherRequest.q },
                { "lang", realTimeWeatherRequest.lang },
                { "key", BaseWeatherApiKey }
            };

            var response = await GetWeatherDetailsAsync(requestParams, "/current.json");

            var responseMessage = new ServiceResponse<RealTimeWeatherResponse>() { Errors = response.Errors, Success = response.Success};

            if(responseMessage.Success)
            {
                responseMessage.Data = APIHelper.JsonDeserialize<RealTimeWeatherResponse>(response.ResponseMessage.Body);                
            }           

            return responseMessage;
        }

        public async Task<ServiceResponse<WeatherForecastResponse>> GetWeatherForeCastDetails(WeatherForecastRequest request)
        {
            var requestParams = new Dictionary<string, object>()
            {
                { "q", request.q },
                { "days", request.days },                
                { "lang", request.lang },
                { "key", BaseWeatherApiKey }
            };

            var response = await GetWeatherDetailsAsync(requestParams, "/forecast.json");

            var responseMessage = new ServiceResponse<WeatherForecastResponse>() { Errors = response.Errors, Success = response.Success };

            if (responseMessage.Success)
            {
                responseMessage.Data = APIHelper.JsonDeserialize<WeatherForecastResponse>(response.ResponseMessage.Body);
            }

            return responseMessage;

        }



        private async Task<ValidationResult> GetWeatherDetailsAsync(IEnumerable<KeyValuePair<string, object>> parameters, string queryStringForApi)
        {

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(BaseWeatherAPIUrl);
            _queryBuilder.Append(queryStringForApi);

            //process optional query parameters
            APIHelper.AppendUrlWithQueryParameters(_queryBuilder, parameters, ArrayDeserializationFormat, ParameterSeparator);

            //validate and preprocess url
            string _queryUrl = APIHelper.CleanUrl(_queryBuilder);

            //append request with appropriate headers and parameters
            var _headers = new Dictionary<string, string>()
            {
                { "user-agent", "APIMATIC 2.0" },
                { "accept", "application/json" }
            };

            //prepare the API call request to fetch the response
            HttpRequest _request = ClientInstance.Get(_queryUrl, _headers);

            //invoke request and get response
            HttpStringResponse _response = (HttpStringResponse)await ClientInstance.ExecuteAsStringAsync(_request).ConfigureAwait(false);

            //handle errors defined at the weather API level
            var validationResult = ValidateResponseNew(_response);


            return validationResult;
        }
    }
}
