using BeeFacts.Behavior;
using BeeFacts.Models;
using Microsoft.AspNetCore.Mvc;

namespace BeeFacts.Controllers
{
    [ApiController]
    [Route("[controller]/v1")]
    public class BeeFactsController : ControllerBase
    {
        private IBeeFactsService beeFactsService { get; set; }
        private readonly ILogger<BeeFactsController> _logger;
        public BeeFactsController(IBeeFactsService beeFactsService, ILogger<BeeFactsController> logger)
        {
            this.beeFactsService = beeFactsService;
            _logger = logger;
        }

        [HttpGet("BeeFact/Random", Name = "GetRandomBeeFact")]
        public IActionResult GetRandomBeeFact()
        {
            BeeFact beeFact = new BeeFact();
            try
            {
                beeFact = beeFactsService.GetRandomBeeFact();
            }
            catch (Exception ex)
            {
                _logger.LogError($"Was not able to retrieve bee fact. Cause: {ex.Message}");
            }
            return Ok(beeFact);
        }
    }
}
