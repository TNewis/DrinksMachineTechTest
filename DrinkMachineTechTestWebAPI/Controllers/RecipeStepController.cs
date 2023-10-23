using DrinkMachineTechTestWebAPI.Models;
using DrinkMachineTechTestWebAPI.SampleData;
using Microsoft.AspNetCore.Mvc;

namespace DrinkMachineTechTestWebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class RecipeStepController : ControllerBase
    {
        private readonly ILogger<RecipeController> _logger;

        public RecipeStepController(ILogger<RecipeController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetRecipeSteps")]
        public IEnumerable<RecipeStep> Get()
        {
            return RecipeStepData.RecipeSteps;
        }

        [HttpGet("{Id}")]
        public RecipeStep Get(int Id)
        {
            var step= RecipeStepData.RecipeSteps.FirstOrDefault(s => s.Id == Id);

            if (step == null)
            {
                return null;
            }

            return step;
        }
    }
}
