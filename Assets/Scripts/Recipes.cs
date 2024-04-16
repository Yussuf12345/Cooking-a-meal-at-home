using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Recipes : ScriptableObject
{
    public Sprite picture;
    public string r_name;
    public List<string> ingredients = new List<string>();
    public List<string> instructions = new List<string>();
    public List<string> categories = new List<string>();

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


