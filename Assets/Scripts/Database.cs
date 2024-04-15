using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Database : MonoBehaviour
{
    public List<Recipes> DB = new List<Recipes>();
    public Sprite[] pic;
    void Start()
    {
        Recipes rp = new Recipes();

        List<string> Ingredients = new List<string>
        {
            "1. Spaghetti.",
            "2. Eggs",
            "3. Bacon.",
            "4. Parmesan",
            "5. Cheese",
        };
        List<string> Instructions = new List<string>
        {
            "1. Cook spaghetti according to package instructions.",
            "2. In a bowl, whisk eggs and mix in grated Parmesan cheese.",
            "3. In a pan, fry bacon until crispy.",
            "4. Drain spaghetti and add to the pan with bacon.",
            "5. Quickly pour egg and cheese mixture over hot spaghetti, stirring constantly to coat the pasta and create a creamy sauce."
        };
        List<string> Categories = new List<string> { "Pasta", "Italian" };
        rp.Recipe(pic[0], "Pasta Carbonara", Ingredients, Instructions, Categories);
        DB.Add(rp);
    }
    class Program
    {
        static void Main()
        {

            

            Recipe[] recipes = {
            new Recipe("Pasta Carbonara", "Spaghetti, Eggs, Bacon, Parmesan Cheese",
                       pastaCarbonaraInstructions, pastaCarbonaraCategories),


        };

            foreach (var recipe in recipes)
            {
                recipe.PrintRecipe();
            }
        }



    }
}
