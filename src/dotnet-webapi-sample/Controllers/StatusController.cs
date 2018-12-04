using Microsoft.AspNetCore.Mvc;

namespace DotnetWebApiSample.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StatusController : ControllerBase
    {
        public ActionResult<OkResult> Get()
        {
            return Ok();
        }
    }
}
