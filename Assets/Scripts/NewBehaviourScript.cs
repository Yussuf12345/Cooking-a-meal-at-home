using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
public class DietaryPreferences : MonoBehaviour
{
    // Define variables to store user preferences
    public bool isVegetarian = false;
    public bool isGlutenFree = false;
    public bool isVegan = false;
    public List<string> excludedIngredients = new List<string>();

    // You can add more dietary preferences here (e.g., vegan, dairy-free, etc.)

    // Method to apply the user's preferences
    public void ApplyPreferences()
    {
        // You'll implement this method to filter recipe suggestions based on preferences
        // For now, let's just print the selected preferences.
        Debug.Log($"Vegetarian: {isVegetarian}, Gluten-Free: {isGlutenFree},isVegan:{isVegan}");
        Debug.Log("Excluded Ingredients:");
        foreach (string ingredient in excludedIngredients)
        {
            Debug.Log(ingredient);
        }
    }
}