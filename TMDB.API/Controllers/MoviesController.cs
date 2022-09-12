using Common.API.Controllers;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TMDB.Application.Movie.Movie.Queries;
using TMDB.Models.Movie;

namespace TMDB.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MoviesController : BaseController
    {
        [HttpGet]
        public async Task<ActionResult<List<MovieModel>>> Get([FromQuery] GetMoviesQuery model = null)
        {
            return Ok(await Mediator.Send(model));
        }
    }
}
