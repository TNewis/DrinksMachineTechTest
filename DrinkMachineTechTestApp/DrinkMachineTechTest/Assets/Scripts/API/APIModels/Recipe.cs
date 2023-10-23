using System.Collections.Generic;

namespace DrinkMachineTechTestWebAPI.Models
{
    public class Recipe
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<OrderedStep> Steps { get; set; }

    }
}