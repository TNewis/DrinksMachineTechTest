
using DrinkMachineTechTestWebAPI.Requests;
using DrinkMachineTechTestWebAPI.Responses;
using DrinkMachineTechTestWebAPI.Services;
using Microsoft.AspNetCore.Mvc;

namespace DrinkMachineTechTestWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BaristaController : ControllerBase
    {
        private readonly ILogger<BaristaController> _logger;
        private readonly IBaristaService _baristaService;

        public BaristaController(ILogger<BaristaController> logger, IBaristaService baristaService)
        {
            _logger = logger;
            _baristaService = baristaService;
        }

        [HttpPost]
        public async Task<PerformStepResponse> Post(PerformStepRequest request, CancellationToken cancellationToken)
        {
            return await _baristaService.Post(request, cancellationToken);
        }
    }
}
