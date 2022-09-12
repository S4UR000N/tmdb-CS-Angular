using Common.API.Controllers;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace TMDB.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MoviesController : BaseController
    {
        //[HttpGet]
        //public async Task<ActionResult<dynamic>> Get([FromQuery] GetMoviesQuery model = null)
        //{
        //    return Ok(await Mediator.Send(model));
        //}
    }
}
