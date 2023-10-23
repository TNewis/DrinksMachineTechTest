using DrinkMachineTechTestWebAPI.Models;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WorldObjectManager : MonoBehaviour
{

    public GameObject BoilWater;
    public GameObject Cup;
    public GameObject Lemon;
    public GameObject SugarMilk;
    public GameObject Chocolate;
    public GameObject Tea;
    public GameObject Coffee;

    // Start is called before the first frame update
    void Start()
    {
        HideWorldModels();
    }

    public void HideWorldModels()
    {
        BoilWater.SetActive(false);
        Cup.SetActive(false);
        Lemon.SetActive(false);
        SugarMilk.SetActive(false);
        Chocolate.SetActive(false);
        Tea.SetActive(false);
        Coffee.SetActive(false);
    }

    public void SetWorldModel(EnumStepType enumStepType)
    {
        HideWorldModels();

        switch (enumStepType)
        {
            case EnumStepType.BoilWater:
                BoilWater.SetActive(true);
                break;
            case EnumStepType.Tea:
                Tea.SetActive(true);
                break;
            case EnumStepType.Coffee:
                Coffee.SetActive(true);
                break;
            case EnumStepType.Chocolate:
                Chocolate.SetActive(true);
                break;
            case EnumStepType.Lemon:
                Lemon.SetActive(true);
                break;
            case EnumStepType.SugarMilk:
                SugarMilk.SetActive(true);
                break;
            case EnumStepType.Cup:
                Cup.SetActive(true);
                break;
            default:
                break;
        }
    }
}
