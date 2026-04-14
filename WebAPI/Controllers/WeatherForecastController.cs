using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<WeatherForecast> Get()
        {
            var rng = new Random();
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = rng.Next(-20, 55),
                Summary = Summaries[rng.Next(Summaries.Length)]
            })
            .ToArray();
        }


        /// <summary>
        /// EXAMPLE OF USING SPECIFIC NAME WITH IACTION RESULT & CATCHING EXCEPTIONS
        /// 
        /// </summary>
        /// <param name="cityName"></param>
        /// <returns></returns>
        [HttpGet]
        [ProducesResponseType(Microsoft.AspNetCore.Http.StatusCodes.Status400BadRequest)]
        [ProducesResponseType(Microsoft.AspNetCore.Http.StatusCodes.Status404NotFound)]
        [ProducesResponseType(Microsoft.AspNetCore.Http.StatusCodes.Status200OK, Type = typeof(IEnumerable<WeatherForecast>))]
        public IActionResult GetByNameWeatherForecast(string cityName) 
        {
            if (string.IsNullOrEmpty(cityName))
                return BadRequest("CityName must not be null or empty");

            if (cityName == "Invalid")
                return NotFound("City name is not found");

            var rng = new Random();
            return Ok(Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = rng.Next(-20, 55),
                Summary = Summaries[rng.Next(Summaries.Length)]
            })
            .ToArray());
        }

        //  OR

        //[HttpGet("GetByNameWeatherForecast/{id}")]
        //public async Task<ActionResult<WeatherForecast>> GetByNameWeatherForecast(string cityName)
        //{
        //    var countyMasterMain = await Summaries.WeatherForecast.FindAsync(cityName);

        //    if (countyMasterMain == null)
        //    {
        //        return NotFound();
        //    }

        //    return countyMasterMain;
        //}


        /// <summary>
        /// EXAMPLE OF USING SPECIFIC NAME WITH ACTION RESULT OF TYPE <T> & CATCHING EXCEPTIONS
        /// 
        /// </summary>
        /// <param name="cityName"></param>
        /// <returns></returns>
        //[HttpGet]
        //[ProducesResponseType(Microsoft.AspNetCore.Http.StatusCodes.Status400BadRequest)]
        //[ProducesResponseType(Microsoft.AspNetCore.Http.StatusCodes.Status404NotFound)]
        //[ProducesResponseType(Microsoft.AspNetCore.Http.StatusCodes.Status200OK)]
        //public ActionResult<IEnumerable<WeatherForecast>> GetByNameWeatherForecast(string cityName)
        //{
        //    if (string.IsNullOrEmpty(cityName))
        //        return BadRequest("CityName must not be null or empty");

        //    if (cityName == "Invalid")
        //        return NotFound("City name is not found");

        //    var rng = new Random();
        //    return Enumerable.Range(1, 5).Select(index => new WeatherForecast
        //    {
        //        Date = DateTime.Now.AddDays(index),
        //        TemperatureC = rng.Next(-20, 55),
        //        Summary = Summaries[rng.Next(Summaries.Length)]
        //    })
        //    .ToArray();
        //}
    }
}
