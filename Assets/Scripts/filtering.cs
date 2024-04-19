using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class filtering : MonoBehaviour
{
    public Database DB;
    List<Recipes> VegetarianRecipes = new List<Recipes>();
    List<Recipes> VeganRecipes = new List<Recipes>();
    List<Recipes> GlutenFreeRecipes = new List<Recipes>();
    public minires prefab;
    public GameObject parent;


    public Image single_pic;
    public TextMeshProUGUI single_name;
    public TextMeshProUGUI single_ingredients;
    public TextMeshProUGUI single_category;
    public TextMeshProUGUI single_instructions;
    public GameObject results_menu;
    public GameObject extra_menu;
    public ScrollRect scrl;
    public ScrollRect scrl2;

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
                    temp.show_Ingredients.text = temp.show_Ingredients.text + ", ";
                }
            }
            temp.show_Result.sprite = VegetarianRecipes[x].picture;
            temp.transform.SetParent(parent.transform);
            temp.filter = this;
            scrl.verticalNormalizedPosition = 1f;

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
                    temp.show_Ingredients.text = temp.show_Ingredients.text + ", ";
                }
            }
            temp.show_Result.sprite = VeganRecipes[x].picture;
            temp.transform.SetParent(parent.transform);
            temp.filter = this;
            scrl.verticalNormalizedPosition = 1f;

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
                    temp.show_Ingredients.text = temp.show_Ingredients.text + ", ";
                }
            }
            temp.show_Result.sprite = GlutenFreeRecipes[x].picture;
            temp.transform.SetParent(parent.transform);
            temp.filter = this;
            scrl.verticalNormalizedPosition = 1f;

        }
    }
    public void close_reset()
    {
        foreach (Transform child in parent.transform)
        {
            Destroy(child.gameObject);
        }
    }
    public void extra(string s_name)
    {
        int temp = 0;
        for(int x=0;x<DB.DB.Count;x++)
        {
            if (DB.DB[x].r_name== s_name)
            {
                temp = x;
                break;
            }
        }
        single_name.text = s_name;
        single_pic.sprite = DB.DB[temp].picture;
        single_ingredients.text = "Ingredients: ";
        for (int z = 0; z < DB.DB[temp].ingredients.Count; z++)
        {
            single_ingredients.text = single_ingredients.text + DB.DB[temp].ingredients[z];
            if (z < DB.DB[temp].ingredients.Count - 1)
            {
                single_ingredients.text = single_ingredients.text + ", ";
            }
        }
       

        single_category.text = "Categories: ";
        for (int z = 0; z < DB.DB[temp].categories.Count; z++)
        {
            single_category.text = single_category.text + DB.DB[temp].categories[z];
            if (z < DB.DB[temp].categories.Count - 1)
            {
                single_category.text = single_category.text + ", ";
            }
        }


        single_instructions.text = "Instructions: <br>";
        for (int z = 0; z < DB.DB[temp].instructions.Count; z++)
        {
            single_instructions.text = single_instructions.text + DB.DB[temp].instructions[z];
            if (z < DB.DB[temp].instructions.Count - 1)
            {
                single_instructions.text = single_instructions.text + "<br>";
            }
        }
      
        results_menu.SetActive(false);
        extra_menu.SetActive(true);


        Vector2 txt_size = GetTextSize(single_ingredients);
        single_ingredients.rectTransform.sizeDelta = new Vector3(single_ingredients.rectTransform.sizeDelta.x, txt_size.y);

        txt_size = GetTextSize(single_category);
        single_category.rectTransform.sizeDelta = new Vector3(single_category.rectTransform.sizeDelta.x, txt_size.y);


        txt_size = GetTextSize(single_instructions);
        single_instructions.rectTransform.sizeDelta = new Vector3(single_instructions.rectTransform.sizeDelta.x, txt_size.y);

        scrl2.verticalNormalizedPosition = 1f;
    }
    Vector2 GetTextSize(TextMeshProUGUI text)
    {
        float width = text.preferredWidth;
        float height = text.preferredHeight;
        return new Vector2(width, height);
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
