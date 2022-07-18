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

namespace WeatherForecast.Application.Features.Weather.Queries.GetCurrentWeatherDetails
{
    public class GetCurrentWeatherDetailsQueryHandler : IRequestHandler<GetCurrentweatherQuery, RealTimeWeatherResponseMessage>
    {
        private readonly IMapper _mapper;
        private readonly IWeatherServiceRepository _weatherServiceRepository;

        public GetCurrentWeatherDetailsQueryHandler(IMapper mapper, IWeatherServiceRepository weatherServiceRepository)
        {
            _mapper = mapper;
            _weatherServiceRepository = weatherServiceRepository;
        }

        public async Task<RealTimeWeatherResponseMessage> Handle(GetCurrentweatherQuery request, CancellationToken cancellationToken)
        {
            var requestmodel = new RealTimeWeatherRequest() { q = request.query, lang = request.lang };
            var responseModel = await _weatherServiceRepository.GetRealTimeWeatherDetailsAsync(requestmodel);

            if (responseModel?.Errors?.Count > 0)
            {
                throw new ServiceException(responseModel.Errors);
            }

            RealTimeWeatherResponseMessage realTimeWeatherMessage = _mapper.Map<RealTimeWeatherResponseMessage>(responseModel);
            return realTimeWeatherMessage;
        }
    }
}
