using DrinkMachineTechTestWebAPI.Models;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.Networking;
using Cysharp.Threading.Tasks;
using Newtonsoft.Json;
using System;

public class UnityDrinksAPI : MonoBehaviour
{

    public string APIAddress;
    // Start is called before the first frame update
    void Start()
    {
        GetRecipes();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private string GetFullAPIAddress(string endpoint)
    {
        return "https://" + APIAddress + endpoint;
    }

    public async Task<List<Recipe>> GetRecipes()
    {
        var request = UnityWebRequest.Get(GetFullAPIAddress(DrinksAPIEndpoints.Recipe));
        var result = await request.SendWebRequest();
        var recipes= JsonConvert.DeserializeObject<List<Recipe>>(result.downloadHandler.text);

        return recipes;
    }

    public async Task<List<RecipeStep>> GetRecipeSteps()
    {
        var request = UnityWebRequest.Get(GetFullAPIAddress(DrinksAPIEndpoints.RecipeStep));
        var result = await request.SendWebRequest();
        var recipeSteps = JsonConvert.DeserializeObject<List<RecipeStep>>(result.downloadHandler.text);

        return recipeSteps;
    }

    public async Task<RecipeStep> GetRecipeStep(int Id)
    {
        var request = UnityWebRequest.Get(GetFullAPIAddress(DrinksAPIEndpoints.RecipeStepById(Id)));
        var result = await request.SendWebRequest();
        var recipeStep = JsonConvert.DeserializeObject<RecipeStep>(result.downloadHandler.text);

        return recipeStep;
    }

    public async Task<PerformStepResponse> PerformStep(int Id, DateTime? dateTime)
    {
        var requestData = new PerformStepRequest() { StepId=Id, TimeRequested= dateTime ?? DateTime.Now };

        var request = UnityWebRequest.Post(GetFullAPIAddress(DrinksAPIEndpoints.PerformStep), JsonConvert.SerializeObject(requestData), "application/json");
        var result = await request.SendWebRequest();
        var recipeStep = JsonConvert.DeserializeObject<PerformStepResponse>(result.downloadHandler.text);

        return recipeStep;
    }
}

public static class DrinksAPIEndpoints
{
    public const string Recipe = "/api/Recipe";
    public const string RecipeStep = "/api/RecipeStep";
    public const string PerformStep = "/api/Barista";

    public static string RecipeStepById(int id) 
    {
        return $"/api/RecipeStep/{id}";
    }
}
