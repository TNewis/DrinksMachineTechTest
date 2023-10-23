namespace DrinkMachineTechTestWebAPI.Models
{
    public class Recipe
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public required List<OrderedStep> Steps { get; set; }

    }
}