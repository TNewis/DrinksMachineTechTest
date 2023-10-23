using DrinkMachineTechTestWebAPI.Models;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class DrinksListUI : MonoBehaviour
{

    public GameObject buttonListPanel;
    public GameObject recipeButton;

    public TextMeshProUGUI StepDescription;

    private List<DrinksListButton> buttons = new List<DrinksListButton>();

    private void Start()
    {
        
    }

    public void UpdateDrinksList(List<Recipe> recipes, DrinksMachineMain drinksMachineMain)
    {
        ClearButtonList();

        foreach(Recipe recipe in recipes)
        {
            var button = Instantiate(recipeButton, buttonListPanel.transform);
            var drinksListButton = button.GetComponent<DrinksListButton>();
            drinksListButton.DrinksMachine = drinksMachineMain;
            drinksListButton.SetButtonLabel(recipe.Name);
            drinksListButton.SetRecipeId(recipe.Id);
            buttons.Add(drinksListButton);
        }

    }

    public void UpdateStepDescription(string description)
    {
        StepDescription.text = description;
    }

    private void ClearButtonList()
    {
        foreach(DrinksListButton button in buttons)
        {
            button.Remove();
        }
        buttons.Clear();
    }
}
