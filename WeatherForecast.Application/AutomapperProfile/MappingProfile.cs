using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeatherForecast.Application.Response;
using WeatherForecast.Domain.Models.Service;
using WeatherForecast.Domain.Models.weather.Request;
using WeatherForecast.Domain.Models.weather.Response;

namespace WeatherForecast.Application.AutomapperProfile
{
    internal class MappingProfile: Profile
    {
        public MappingProfile()
        {
            CreateMap<Location, LocationVm>();
            CreateMap<Condition, ConditionVm>();
            CreateMap<Current, CurrentWeatherVm>();
            CreateMap<Day, DayVm>();
            CreateMap<Forecastday, ForecastDayVm>()
                .ForMember(s => s.DayOfTheWeek, d => d.MapFrom(src =>
                    DateTime.Parse(src.Date).Date.Equals(DateTime.Now.Date) ? "Today" : DateTime.Parse(src.Date).Date.DayOfWeek.ToString())
                );
            CreateMap<Forecast, ForecastVm>();
            

            CreateMap<ServiceResponse<RealTimeWeatherResponse>, RealTimeWeatherResponseMessage>()
                .ForMember(d => d.Success, s => s.MapFrom(src => src.Success))
                .ForMember(d => d.ValodationError, s => s.MapFrom(src => src.Errors.Select(e => e.Message)))
                .ForMember(d=> d.weatherLocation, s=> s.MapFrom(src=> src.Data.Location))
                .ForMember(d => d.CurrentWeather, s => s.MapFrom(src => src.Data.Current));

            CreateMap<ServiceResponse<WeatherForecastResponse>, WeatherForecastUiResponse>()
                .ForMember(d => d.Success, s => s.MapFrom(src => src.Success))
                .ForMember(d => d.ValodationError, s => s.MapFrom(src => src.Errors.Select(e => e.Message)))
                .ForMember(d => d.weatherLocation, s => s.MapFrom(src => src.Data.Location))
                .ForMember(d => d.CurrentWeather, s => s.MapFrom(src => src.Data.Current))
                .ForMember(d => d.Forecast, s => s.MapFrom(src => src.Data.Forecast));
        }
    }
}
