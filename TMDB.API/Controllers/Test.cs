using Common.API.Controllers;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TMDB.Application.Test;

namespace TMDB.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestController : BaseController
    {
        [HttpGet]
        public async Task<ActionResult<dynamic>> Get([FromQuery] TestQuery model = null)
        {
            return Ok(await Mediator.Send(model));
        }

        //[HttpPost]
        ////[Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme, Policy = "CMSUpsertArticle")]
        //public async Task<ActionResult<Result>> Upsert([FromBody] UpsertEmailTemplateCommand model)
        //{
        //    return Ok(await Mediator.Send(model ?? new UpsertEmailTemplateCommand()));
        //}



        //[HttpDelete]
        //public async Task<ActionResult<Result>> Delete([FromQuery][Bind(include: "Id")] DeleteEmailTemplateCommand model)
        //{
        //    return Ok(await Mediator.Send(model));
        //}
    }
}