using Microsoft.AspNetCore.Mvc;

namespace BeeFacts.Controllers
{
    [ApiController]
    [Route("[controller]/v1")]
    public class BeeFactsController : ControllerBase
    {

        private readonly ILogger<BeeFactsController> _logger;

        public BeeFactsController(ILogger<BeeFactsController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "BeeFact/Random")]
        public IActionResult GetRandomBeeFact()
        {
            return Ok("");
        }
    }
}
