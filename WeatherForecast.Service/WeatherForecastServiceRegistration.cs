using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeatherForecast.Application.Contracts.Service;
using WeatherForecast.Service.Repositories;
using WeatherForecast.Service.Service.Contracts;
using WeatherForecast.Service.Service.Implementation;

namespace WeatherForecast.Service
{
    public static class WeatherForecastServiceRegistration
    {
        public static IServiceCollection AddPersistenceServices(this IServiceCollection services)
        {            

            services.AddScoped(typeof(IWeatherServiceRepository), typeof(WeatherServiceRepository));
            services.AddScoped(typeof(IWeatherService), typeof(WeatherService));

            return services;
        }
    }
}
