using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Recipes : MonoBehaviour
{
    private Sprite picture;
    private string r_name;
    private List<string> ingredients = new List<string>();
    private List<string> instructions = new List<string>();
    private List<string> categories = new List<string>();

    public void Recipe(Sprite picture, string r_name, List<string> ingredients, List<string> instructions, List<string> categories)
    {
        this.picture = picture;
        this.r_name = r_name;
        this.ingredients = new List<string>(ingredients);
        this.instructions = new List<string>(instructions);
        this.categories = new List<string>(categories);
    }

    public bool HasCategory(string category)
    {
        return categories.Contains(category);
    }

   
}


