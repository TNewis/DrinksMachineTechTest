using Cysharp.Threading.Tasks;
using DrinkMachineTechTestWebAPI.Models;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class DrinksMachineMain : MonoBehaviour
{
    public UnityDrinksAPI drinksAPI;
    public DrinksListUI drinksListUI;

    public WorldObjectManager WorldObjectManager;

    private List<Recipe> recipes;
    // Start is called before the first frame update
    async UniTaskVoid Start()
    {
        recipes = await drinksAPI.GetRecipes();
        UpdateDrinksListUI(recipes);
    }

    private void UpdateDrinksListUI(List<Recipe> recipes)
    {
        drinksListUI.UpdateDrinksList(recipes, this);
    }

    public async UniTask MakeDrink(int id)
    {
        var recipe = recipes.First(r => r.Id == id);

        foreach(OrderedStep orderedStep in recipe.Steps.OrderBy(r => r.Order))
        {
            var step = await drinksAPI.GetRecipeStep(orderedStep.StepId);

            drinksListUI.UpdateStepDescription(step.Description);
            WorldObjectManager.SetWorldModel(step.StepType);

            var response= await drinksAPI.PerformStep(step.Id, null);
            if (!response.Success)
            {
                drinksListUI.UpdateStepDescription("Something went wrong.");
                continue;
            }

            Debug.Log("Drink Step: " + step.Description.ToString() +". Success:"+ response.Success.ToString() + " " + response.ErrorMessage);
        }

        drinksListUI.UpdateStepDescription("Drink complete! Enjoy!");
        WorldObjectManager.HideWorldModels();
    }
}
