using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeatherForecast.Application.Contracts.Service;
using WeatherForecast.Domain.Models.Service;
using WeatherForecast.Domain.Models.weather.Request;
using WeatherForecast.Domain.Models.weather.Response;
using WeatherForecast.Service.Service.Contracts;

namespace WeatherForecast.Service.Repositories
{
    public class WeatherServiceRepository : IWeatherServiceRepository
    {
        private readonly IWeatherService _weatherService;

        public WeatherServiceRepository(IWeatherService weatherService)
        {
           _weatherService = weatherService;
        }
        public async Task<ServiceResponse<RealTimeWeatherResponse>> GetRealTimeWeatherDetailsAsync(RealTimeWeatherRequest realTimeWeatherRequest)
        {
            return await _weatherService.GetRealTimeWeatherDetailsAsync(realTimeWeatherRequest);
        }

        public async Task<ServiceResponse<WeatherForecastResponse>> GetWeatherForeCastDetailsAsync(WeatherForecastRequest request)
        {
            return await _weatherService.GetWeatherForeCastDetails(request);
        }
    }
}
