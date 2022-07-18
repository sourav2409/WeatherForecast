using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeatherForecast.Domain.Models.Service;
using WeatherForecast.Domain.Models.weather.Request;
using WeatherForecast.Domain.Models.weather.Response;

namespace WeatherForecast.Application.Contracts.Service
{
    public interface IWeatherServiceRepository
    {
        Task<ServiceResponse<RealTimeWeatherResponse>> GetRealTimeWeatherDetailsAsync(RealTimeWeatherRequest realTimeWeatherRequest);

        Task<ServiceResponse<WeatherForecastResponse>> GetWeatherForeCastDetailsAsync(WeatherForecastRequest request);
    }
}
