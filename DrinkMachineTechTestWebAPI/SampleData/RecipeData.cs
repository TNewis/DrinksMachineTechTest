using DrinkMachineTechTestWebAPI.Models;

namespace DrinkMachineTechTestWebAPI.SampleData
{
    public static class RecipeData
    {
        private static readonly List<Recipe> recipes = new()
        {
            new Recipe(){ Id=0, Name="Lemon Tea", Steps= new List<OrderedStep>(){ new OrderedStep() { Order=1, StepId= 0}, 
                                                                                  new OrderedStep() { Order = 2, StepId = 2 }, 
                                                                                  new OrderedStep() { Order = 3, StepId = 1 },
                                                                                  new OrderedStep() { Order = 4, StepId = 3 }
                                                                                } },
            new Recipe(){ Id=1, Name="Coffee", Steps= new List<OrderedStep>(){ new OrderedStep() { Order=1, StepId= 0},
                                                                                  new OrderedStep() { Order = 2, StepId = 4 },
                                                                                  new OrderedStep() { Order = 3, StepId = 1 },
                                                                                  new OrderedStep() { Order = 4, StepId = 5 }
                                                                                } },
            new Recipe(){ Id=2, Name="Chocolate", Steps= new List<OrderedStep>(){ new OrderedStep() { Order=1, StepId= 0},
                                                                                  new OrderedStep() { Order = 2, StepId = 6 },
                                                                                  new OrderedStep() { Order = 3, StepId = 1 }
                                                                                } },
        };

        public static List<Recipe> Recipes = recipes;
    }
}
