namespace DrinkMachineTechTestWebAPI.Models
{
    public class RecipeStep
    {
        public int Id { get; set; }
        public string? Description { get; set; }
        public EnumStepType? StepType { get; set; }
    }
}
