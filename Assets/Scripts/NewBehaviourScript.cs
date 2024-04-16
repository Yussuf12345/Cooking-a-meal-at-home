using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public Database DB;
    List<Recipes> VegetarianRecipes = new List<Recipes>();
    List<Recipes> VeganRecipes = new List<Recipes>();
    List<Recipes> GlutenFreeRecipes = new List<Recipes>();


    // Start is called before the first frame update
    void Start()
    {
        isVegetarian();
        isVegan();
        isGlutenFree();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void isVegetarian()
    {
        for (int i=0; i < 30; i++)
        {
            if (DB.DB[i].HasCategory("Vegetarian")) {
                VegetarianRecipes.Add(DB.DB[i]);
            }
            
        }
    }
    public void isVegan()
    {
        for (int i = 0; i < 30; i++)
        {
            if (DB.DB[i].HasCategory("Vegan"))
            {
                VeganRecipes.Add(DB.DB[i]);
            }

        }
    }
    public void isGlutenFree()
    {
        for (int i = 0; i < 30; i++)
        {
            if (DB.DB[i].HasCategory("Gluten-free"))
            {
                GlutenFreeRecipes.Add(DB.DB[i]);
            }

        }
    }

}
