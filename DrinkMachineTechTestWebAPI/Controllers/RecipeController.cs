using DrinkMachineTechTestWebAPI.Models;
using DrinkMachineTechTestWebAPI.SampleData;
using Microsoft.AspNetCore.Mvc;

namespace DrinkMachineTechTestWebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class RecipeController : ControllerBase
    {
        private readonly ILogger<RecipeController> _logger;

        public RecipeController(ILogger<RecipeController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetRecipes")]
        public IEnumerable<Recipe> Get()
        {
            return RecipeData.Recipes;
        }
    }
}