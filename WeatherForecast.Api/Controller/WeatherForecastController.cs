using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using WeatherForecast.Application.Features.Weather.Queries.GetCurrentWeatherDetails;
using WeatherForecast.Application.Features.Weather.Queries.GetWeatherForecast;
using WeatherForecast.Application.Response;

namespace WeatherForecast.Api.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class WeatherForecastController : ControllerBase
    {
        private readonly IMediator _mediator;

        public WeatherForecastController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet("currentWeather",Name = "GetRealTimeWeather")]
        [ProducesDefaultResponseType]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<RealTimeWeatherResponseMessage>> GetRealTimeWeather(string city)
        {
            var getCurrentWeatherQuery = new GetCurrentweatherQuery() { query = city, lang = string.Empty };

            var dtos = await _mediator.Send(getCurrentWeatherQuery);
            return Ok(dtos);
        }

        [HttpGet("forecast", Name = "GetWeatherForecast")]
        [ProducesDefaultResponseType]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<RealTimeWeatherResponseMessage>> GetWeatherForecast(string city, int days)
        {
            var getweatherForecastQuery = new GetWeatherForecastQuery() { query = city, lang = string.Empty, days=days };

            var dtos = await _mediator.Send(getweatherForecastQuery);
            return Ok(dtos);
        }

    }
}
