using Microsoft.AspNetCore.Mvc;

namespace FirstRestAPI.Controllers
{
    [ApiController]
    [Route("prod")]
    public class ProductController : ControllerBase
    {
        [HttpGet("Navruz")]
        public ActionResult Get()
        {
            return Ok();
        }

        [HttpGet]
        public ActionResult Get2()
        {
            return Ok();
        }
    }
}
