using DrinkMachineTechTestWebAPI.Models;

namespace DrinkMachineTechTestWebAPI.SampleData
{
    public static class RecipeStepData
    {
        private static readonly List<RecipeStep> recipeSteps = new()
        {
            new RecipeStep(){ Id=0, Description="Boil Water", StepType = EnumStepType.BoilWater},
            new RecipeStep(){ Id=1, Description="Pour Into Cup", StepType = EnumStepType.Cup},
            new RecipeStep(){ Id=2, Description="Steep Tea", StepType = EnumStepType.Tea},
            new RecipeStep(){ Id=3, Description="Add Lemon", StepType = EnumStepType.Lemon},
            new RecipeStep(){ Id=4, Description="Brew Coffee", StepType = EnumStepType.Coffee},
            new RecipeStep(){ Id=5, Description="Add Sugar And Milk", StepType = EnumStepType.SugarMilk},
            new RecipeStep(){ Id=6, Description="Add Chocolate", StepType = EnumStepType.Chocolate}
        };

        public static List<RecipeStep> RecipeSteps = recipeSteps;
    }
}
