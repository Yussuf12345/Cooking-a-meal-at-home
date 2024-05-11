using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
public class minires : MonoBehaviour
{
    //this is a utlity class used to represent a single result and all its componennets
    public int saved_index;//unique index to represent a resul (not used ATM)
    public Image show_Result;//recipeie result image
    public TextMeshProUGUI show_Name;//text component to show recipie name
    public TextMeshProUGUI show_Ingredients;//text component to show ingredients
    public filtering filter;//reference to filter script
    public void open()
    {
        filter.extra(show_Name.text);//a function that calls extra in filter, here it uses recipie name which means it assumes recipe is unique, later this could be changed to saved_index 
    }
}
