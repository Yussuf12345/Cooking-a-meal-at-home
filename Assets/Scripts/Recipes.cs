using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Recipes : ScriptableObject
{
    //this is the object which represents a recipe details
    public Sprite picture;//recipe picture
    public string r_name;//recipe name
    public List<string> ingredients = new List<string>();//recipe ingredients as a list
    public List<string> instructions = new List<string>();//recipe instructions as a list
    public List<string> categories = new List<string>();//recipe category as a list

    //this is a utlity function to intlialize the recipe values
    public void Recipe(Sprite picture, string r_name, List<string> ingredients, List<string> instructions, List<string> categories)
    {
        this.picture = picture;
        this.r_name = r_name;
        this.ingredients = new List<string>(ingredients);
        this.instructions = new List<string>(instructions);
        this.categories = new List<string>(categories);
    }
    //utlity function to check if a recipe has a certain category
    public bool HasCategory(string category)
    {
        return categories.Contains(category);
    }
    //utlity function to check if a recipe has a certain Ingredient
    public bool HasIngredient(string ingredient)
    {
        return ingredients.Contains(ingredient);
    }

}


