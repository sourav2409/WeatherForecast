using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using WeatherForecast.Application.Contracts.Service;
using WeatherForecast.Application.Exceptions;
using WeatherForecast.Application.Response;
using WeatherForecast.Domain.Models.weather.Request;

namespace WeatherForecast.Application.Features.Weather.Queries.GetWeatherForecast
{
    public class GetWeatherForecastQueryHandler : IRequestHandler<GetWeatherForecastQuery, WeatherForecastUiResponse>
    {
        private readonly IMapper _mapper;
        private readonly IWeatherServiceRepository _weatherServiceRepository;

        public GetWeatherForecastQueryHandler(IMapper mapper, IWeatherServiceRepository weatherServiceRepository)
        {
            _mapper = mapper;
            _weatherServiceRepository = weatherServiceRepository;
        }

        public async Task<WeatherForecastUiResponse> Handle(GetWeatherForecastQuery request, CancellationToken cancellationToken)
        {
            var requestmodel = new WeatherForecastRequest() { q = request.query, lang = request.lang, days = request.days };

            var responseModel = await _weatherServiceRepository.GetWeatherForeCastDetailsAsync(requestmodel);

            if (responseModel?.Errors?.Count > 0)
            {
                throw new ServiceException(responseModel.Errors);
            }

            WeatherForecastUiResponse realTimeWeatherMessage = _mapper.Map<WeatherForecastUiResponse>(responseModel);
            return realTimeWeatherMessage;
        }
    }
}
