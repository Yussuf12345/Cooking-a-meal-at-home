using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class filtering : MonoBehaviour
{
    public Database DB;
    List<Recipes> VegetarianRecipes = new List<Recipes>();
    List<Recipes> VeganRecipes = new List<Recipes>();
    List<Recipes> GlutenFreeRecipes = new List<Recipes>();
    public minires prefab;
    public GameObject parent;
    public void display_Vegetarian()
    {
        for(int x=0;x< VegetarianRecipes.Count; x++)
        {
            minires temp = GameObject.Instantiate(prefab);
            temp.show_Name.text = VegetarianRecipes[x].r_name;
            for (int z = 0; z < VegetarianRecipes[x].ingredients.Count; z++)
            {
                temp.show_Ingredients.text = temp.show_Ingredients.text + VegetarianRecipes[x].ingredients[z];
                if (z < VegetarianRecipes[x].ingredients.Count - 1)
                {
                    temp.show_Ingredients.text = temp.show_Ingredients.text + ",";
                }
            }
            temp.show_Result.sprite = VegetarianRecipes[x].picture;
            temp.transform.SetParent(parent.transform);
        }
    }
    public void display_Vegan()
    {
        for (int x = 0; x < VeganRecipes.Count; x++)
        {
            minires temp = GameObject.Instantiate(prefab);
            temp.show_Name.text = VeganRecipes[x].r_name;
            for (int z = 0; z < VeganRecipes[x].ingredients.Count; z++)
            {
                temp.show_Ingredients.text = temp.show_Ingredients.text + VeganRecipes[x].ingredients[z];
                if (z < VeganRecipes[x].ingredients.Count - 1)
                {
                    temp.show_Ingredients.text = temp.show_Ingredients.text + ",";
                }
            }
            temp.show_Result.sprite = VeganRecipes[x].picture;
            temp.transform.SetParent(parent.transform);
        }
    }
    public void display_GlutenFree()
    {
        for (int x = 0; x < GlutenFreeRecipes.Count; x++)
        {
            minires temp = GameObject.Instantiate(prefab);
            temp.show_Name.text = GlutenFreeRecipes[x].r_name;
            for (int z = 0; z < GlutenFreeRecipes[x].ingredients.Count; z++)
            {
                temp.show_Ingredients.text = temp.show_Ingredients.text + GlutenFreeRecipes[x].ingredients[z];
                if (z < GlutenFreeRecipes[x].ingredients.Count - 1)
                {
                    temp.show_Ingredients.text = temp.show_Ingredients.text + ",";
                }
            }
            temp.show_Result.sprite = GlutenFreeRecipes[x].picture;
            temp.transform.SetParent(parent.transform);
        }
    }
    public void close_reset()
    {
        while (parent.GetComponentInChildren<minires>() != null)
        {
           Destroy(parent.GetComponentInChildren<minires>().gameObject,0f);
        }
    }
    public void extra()
    {

    }
    // Start is called before the first frame update
    void Start()
    {
        isVegetarian();
        isVegan();
        isGlutenFree();
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
