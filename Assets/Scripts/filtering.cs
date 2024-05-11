using System.Collections;
using System.Collections.Generic;
using System.Linq;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class filtering : MonoBehaviour
{
    //fdatabase reference
    public Database DB;
    //this a list of recipies for each filter for convenience
    List<Recipes> VegetarianRecipes = new List<Recipes>();
    List<Recipes> VeganRecipes = new List<Recipes>();
    List<Recipes> GlutenFreeRecipes = new List<Recipes>();
    List<Recipes> ChickenRecipes = new List<Recipes>();
    List<Recipes> BeefRecipes = new List<Recipes>();
    List<Recipes> DessertRecipes = new List<Recipes>();
    List<Recipes> SeafoodRecipes = new List<Recipes>();

    //list which contains the result, changes dynamically
    List<Recipes> resultlist = new List<Recipes>();

    //main prefab which acts as baseline for all results
    public minires prefab;
    //parent which will house the results objects
    public GameObject parent;

    //this is the menu where a in a reciepe, more info is clicked so it shows that recipe all details
    public Image single_pic;
    public TextMeshProUGUI single_name;
    public TextMeshProUGUI single_ingredients;
    public TextMeshProUGUI single_category;
    public TextMeshProUGUI single_instructions;
    public GameObject results_menu;
    public GameObject extra_menu;
    //scroll rects of results and single result expanded
    public ScrollRect scrl;
    public ScrollRect scrl2;
    public GameObject[] ons;
    public GameObject[] bigobs;
    public void checker()
    {
        //empty function that can be used later as utlity
       /* if (ons[1].activeSelf == true || ons[2].activeSelf == true)
        {
            ons[3].SetActive(false);
            ons[4].SetActive(false);
            ons[5].SetActive(false);
            bigobs[5].SetActive(false);
            bigobs[6].SetActive(false);
            bigobs[7].SetActive(false);
        }
        else
        {
            bigobs[5].SetActive(true);
            bigobs[6].SetActive(true);
            bigobs[7].SetActive(true);
        }

        if (ons[1].activeSelf == true || ons[2].activeSelf == true)
        {
            ons[3].SetActive(false);
            ons[4].SetActive(false);
            ons[5].SetActive(false);
            bigobs[5].SetActive(false);
            bigobs[6].SetActive(false);
            bigobs[7].SetActive(false);
        }
        else
        {
            bigobs[5].SetActive(true);
            bigobs[6].SetActive(true);
            bigobs[7].SetActive(true);
        }*/
    }
    public void display_all()
    {
        //this is a function which disply the results after filtering, it checks each filter one by one and adds the Recipe to result list
        //if the filter is on
        resultlist.Clear();
        if (ons[0].activeSelf == true)
        {
            for (int x = 0; x < GlutenFreeRecipes.Count; x++)
            {
                resultlist.Add(GlutenFreeRecipes[x]);
            }
        }
        if (ons[1].activeSelf == true)
        {
            for (int x = 0; x < VeganRecipes.Count; x++)
            {
                if (resultlist.Contains(VeganRecipes[x]) == false)
                {
                    resultlist.Add(VeganRecipes[x]);
                }
            }
        }
        if (ons[2].activeSelf == true)
        {
            for (int x = 0; x < VegetarianRecipes.Count; x++)
            {
                if (resultlist.Contains(VegetarianRecipes[x]) == false)
                {
                    resultlist.Add(VegetarianRecipes[x]);
                }
            }
        }
        if (ons[3].activeSelf == true)
        {
            for (int x = 0; x < ChickenRecipes.Count; x++)
            {
                if (resultlist.Contains(ChickenRecipes[x]) == false)
                {
                    resultlist.Add(ChickenRecipes[x]);
                }
            }
        }
        if (ons[4].activeSelf == true)
        {
            for (int x = 0; x < BeefRecipes.Count; x++)
            {
                if (resultlist.Contains(BeefRecipes[x]) == false)
                {
                    resultlist.Add(BeefRecipes[x]);
                }
            }
        }
        if (ons[5].activeSelf == true)
        {
            for (int x = 0; x < SeafoodRecipes.Count; x++)
            {
                if (resultlist.Contains(SeafoodRecipes[x]) == false)
                {
                    resultlist.Add(SeafoodRecipes[x]);
                }
            }
        }
        if (ons[6].activeSelf == true)
        {
            for (int x = 0; x < DessertRecipes.Count; x++)
            {
                if (resultlist.Contains(DessertRecipes[x]) == false)
                {
                    resultlist.Add(DessertRecipes[x]);
                }
            }
        }
        //here if no filter is choosen it justs shows all Recipes
        if (ons[0].activeSelf==false&& ons[1].activeSelf == false && ons[2].activeSelf == false && ons[3].activeSelf == false &&
            ons[4].activeSelf == false && ons[5].activeSelf == false && ons[6].activeSelf == false)
        {
            for (int x = 0; x < DB.DB.Count; x++)
            {
                resultlist.Add(DB.DB[x]);
            }           
        }

        //this reorders the list randomly so that the results aren't monotonic
        for (int i = resultlist.Count - 1; i > 0; i--)
        {
            int swapIndex = Random.Range(0, i + 1);
            Recipes temp = resultlist[i];
            resultlist[i] = resultlist[swapIndex];
            resultlist[swapIndex] = temp;
        }
       

        //fill the results UI with result list recipe details 
        for (int x = 0; x < resultlist.Count; x++)
        {
            minires temp = GameObject.Instantiate(prefab);
            temp.show_Name.text = resultlist[x].r_name;
            for (int z = 0; z < resultlist[x].ingredients.Count; z++)
            {
                temp.show_Ingredients.text = temp.show_Ingredients.text + resultlist[x].ingredients[z];
                if (z < resultlist[x].ingredients.Count - 1)
                {
                    temp.show_Ingredients.text = temp.show_Ingredients.text + ", ";
                }
            }
            temp.show_Result.sprite = resultlist[x].picture;
            temp.transform.SetParent(parent.transform);
            temp.filter = this;
            scrl.verticalNormalizedPosition = 1f;

        }
    }
    //this is a function which delete results once the user goes back to filter menu
    public void close_reset()
    {
        foreach (Transform child in parent.transform)
        {
            Destroy(child.gameObject);
        }
    }
    //this function is responsible for display the choosen reciepe expanded
    public void extra(string s_name)
    {
        int temp = 0;
        //determine which receipe we want to get more details of
        for (int x = 0; x < DB.DB.Count; x++)
        {
            if (DB.DB[x].r_name == s_name)
            {
                temp = x;
                break;
            }
        }
        //display its details
        single_name.text = s_name;
        single_pic.sprite = DB.DB[temp].picture;
        single_ingredients.text = "Ingredients: ";
        //here it loops on ingredients and lists them comma-seprated
        for (int z = 0; z < DB.DB[temp].ingredients.Count; z++)
        {
            single_ingredients.text = single_ingredients.text + DB.DB[temp].ingredients[z];
            if (z < DB.DB[temp].ingredients.Count - 1)
            {
                single_ingredients.text = single_ingredients.text + ", ";
            }
        }

        //here it loops on categories and lists them comma-seprated
        single_category.text = "Categories: ";
        for (int z = 0; z < DB.DB[temp].categories.Count; z++)
        {
            single_category.text = single_category.text + DB.DB[temp].categories[z];
            if (z < DB.DB[temp].categories.Count - 1)
            {
                single_category.text = single_category.text + ", ";
            }
        }

        //here it lists insutrctions where each instruction is displayed in a signle line
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

        //adjust the 3 text elements so they are placed below each other regardless of their length
        Vector2 txt_size = GetTextSize(single_ingredients);
        single_ingredients.rectTransform.sizeDelta = new Vector3(single_ingredients.rectTransform.sizeDelta.x, txt_size.y);

        txt_size = GetTextSize(single_category);
        single_category.rectTransform.sizeDelta = new Vector3(single_category.rectTransform.sizeDelta.x, txt_size.y);


        txt_size = GetTextSize(single_instructions);
        single_instructions.rectTransform.sizeDelta = new Vector3(single_instructions.rectTransform.sizeDelta.x, txt_size.y);
        //scroll back to the top of the result Recipe
        scrl2.verticalNormalizedPosition = 1f;
    }
    //get the text object width and height
    Vector2 GetTextSize(TextMeshProUGUI text)
    {
        float width = text.preferredWidth;
        float height = text.preferredHeight;
        return new Vector2(width, height);
    }
    //these are function that fill the values of the lists used for convenience
    void Start()
    {
        isVegetarian();
        isVegan();
        isGlutenFree();
        isChicken();
        isBeef();
        isSeafood();
        isDessert();
    }
    public void isVegetarian()
    {
        for (int i = 0; i < 30; i++)
        {
            if (DB.DB[i].HasCategory("Vegetarian"))
            {
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
    public void isChicken()
    {
        for (int i = 0; i < 30; i++)
        {
            if (DB.DB[i].HasCategory("Chicken"))
            {
                ChickenRecipes.Add(DB.DB[i]);
            }
        }
    }
    public void isBeef()
    {
        for (int i = 0; i < 30; i++)
        {
            if (DB.DB[i].HasCategory("Beef"))
            {
                BeefRecipes.Add(DB.DB[i]);
            }
        }
    }
    public void isDessert()
    {
        for (int i = 0; i < 30; i++)
        {
            if (DB.DB[i].HasCategory("Dessert"))
            {
                DessertRecipes.Add(DB.DB[i]);
            }
        }
    }
    public void isSeafood()
    {
        for (int i = 0; i < 30; i++)
        {
            if (DB.DB[i].HasCategory("Seafood"))
            {
                SeafoodRecipes.Add(DB.DB[i]);
            }
        }
    }
}
