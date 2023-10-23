using Cysharp.Threading.Tasks;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using TMPro;
using UnityEngine;

public class DrinksListButton : MonoBehaviour
{
    public DrinksMachineMain DrinksMachine;
    private int recipeId;

    public TextMeshProUGUI Label;

    private void Start()
    {
        Label = GetComponentInChildren<TextMeshProUGUI>();
    }

    public async void ButtonClick()
    {
        Debug.Log("Button Pressed: "+ Label.text);
        await DrinksMachine.MakeDrink(recipeId);
    }

    public void Remove()
    {
        Destroy(this.gameObject);
    }

    public void SetButtonLabel(string newLabel)
    {
        Label.text = newLabel; 
    }

    public void SetRecipeId(int id)
    {
        recipeId = id;
    }
}
