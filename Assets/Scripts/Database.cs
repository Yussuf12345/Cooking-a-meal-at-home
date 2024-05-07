using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Database : MonoBehaviour
{
    public List<Recipes> DB = new List<Recipes>();
    public Sprite[] pic;
    void Awake()
    {
        Recipes rp = ScriptableObject.CreateInstance<Recipes>();

        List<string> Ingredients = new List<string>
        {
            "Spaghetti.",
            "Eggs",
            "Bacon.",
            "Parmesan",
            "Cheese",
        };
        List<string> Instructions = new List<string>
        {
            "1. Cook spaghetti according to package instructions.",
            "2. In a bowl, whisk eggs and mix in grated Parmesan cheese.",
            "3. In a pan, fry bacon until crispy.",
            "4. Drain spaghetti and add to the pan with bacon.",
            "5. Quickly pour egg and cheese mixture over hot spaghetti, stirring constantly to coat the pasta and create a creamy sauce."
        };
        List<string> Categories = new List<string> { "Pasta", "Italian", "Beef" };
        rp.Recipe(pic[0], "Pasta Carbonara", Ingredients, Instructions, Categories);
        DB.Add(rp);

        rp = ScriptableObject.CreateInstance<Recipes>();
        Ingredients =  new List<string>
        {
            "Pizza dough.",
            "Tomato sauce",
            "Fresh mozzarella cheese.",
            "Basil leaves."
        };
        Instructions = new List<string>
        {
            "1. Preheat oven to 500?F (260?C). ",
            "2. Roll out the pizza dough into a circle. ",
            "3. Spread tomato sauce over the dough. ",
            "4. Tear the mozzarella into small pieces and place on top of the sauce. ",
            "5. Bake in the preheated oven for 10-12 minutes, until the crust is golden and the cheese is bubbly. ",
            "6. Remove from oven and sprinkle with fresh basil leaves."
            
        };
        Categories = new List<string> { "Pizza", "Italian", "Vegetarian" };

        rp.Recipe(pic[1], "Classic Margherita Pizza", Ingredients, Instructions, Categories);
        DB.Add(rp);

        rp = ScriptableObject.CreateInstance<Recipes>();
        Ingredients = new List<string>
        {
            "Fettuccine pasta.",
            "Chicken breast.",
            "Heavy cream",
            "Parmesan cheese",
            "Butter."
            
        };
        Instructions = new List<string>
        {
            "1. Cook fettuccine pasta according to package instructions." ,
            "2. Season chicken breast with salt and pepper, then grill or saut? until fully cooked." ,
            "3. In a saucepan, melt butter over medium heat. " ,
            "4. Add heavy cream and bring to a simmer. " ,
            "5. Stir in grated Parmesan cheese until the sauce is smooth and creamy. " ,
            "6. Slice the cooked chicken breast and add it to the sauce. ",
            "7. Serve the chicken Alfredo over the cooked fettuccine pasta."
            
        };
        Categories = new List<string> { "Pasta", "Italian", "Chicken" };

        rp.Recipe(pic[2], "Chicken Alfredo", Ingredients, Instructions, Categories);
        DB.Add(rp);

        rp = ScriptableObject.CreateInstance<Recipes>();
        Ingredients = new List<string>
        {
            "All-purpose flour." ,
            "Baking soda." ,
            "Salt." ,
            "Unsalted butter." ,
            "Brown sugar." ,
            "Granulated sugar" ,
            "Eggs. " ,
            "Vanilla extract. ",
            "Chocolate chips."
            
        };
        Instructions = new List<string>
        {
            "1. Preheat oven to 350?F (175?C).",
            "2. In a small bowl, whisk together flour, baking soda, and salt.",
            "3. In a large bowl, cream together butter, brown sugar, and granulated sugar until smooth.",
            "4. Beat in eggs one at a time, then stir in vanilla. ",
            "5. Gradually blend in the dry ingredients. ",
            "6. Stir in chocolate chips. ",
            "7. Drop rounded tablespoons of dough onto ungreased baking sheets. ",
            "8. Bake 10-12 minutes until golden brown. " ,
            "9. Allow cookies to cool on baking sheet for 5 minutes before transferring to a wire rack to cool completely."
        };
        Categories = new List<string> { "Dessert", "Cookies", "Vegetarian" };

        rp.Recipe(pic[3], "Chocolate Chip Cookies", Ingredients, Instructions, Categories);
        DB.Add(rp);

        rp = ScriptableObject.CreateInstance<Recipes>();
        Ingredients = new List<string>
        {
            "Beef sirloin" ,
            "Soy sauce" ,
            "Garlic" ,
            "Ginger" ,
            "Vegetable oil" ,
            "Broccoli" ,
            "Bell peppers" ,
            "Onion."
           
        };
        Instructions = new List<string>
        {
            "1. Slice beef sirloin into thin strips." ,
            "2. In a bowl, mix soy sauce, minced garlic, and grated ginger. " ,
            "3. Marinate the beef strips in the soy sauce mixture for at least 30 minutes. " ,
            "4. Heat vegetable oil in a large skillet over medium-high heat. " ,
            "5. Add marinated beef strips and cook until browned. " ,
            "6. Add broccoli florets, sliced bell peppers, and sliced onion to the skillet. ",
            "7. Stir-fry until vegetables are tender-crisp and beef is cooked through. ",
            "8. Serve hot over rice."
        };
        Categories = new List<string> { "Stir-Fry", "Beef", "Gluten-free" };

        rp.Recipe(pic[4], "Beef Stir-Fry", Ingredients, Instructions, Categories);
        DB.Add(rp);

        rp = ScriptableObject.CreateInstance<Recipes>();
        Ingredients = new List<string>
        {
           "Lasagna noodles",
           "Marinara sauce",
           "Ricotta cheese",
           "Mozzarella cheese",
           "Parmesan cheese",
           "Spinach",
           "Zucchini",
           "Bell peppers",
           "Onion"
        };
        Instructions = new List<string>
        {
            "1. Cook lasagna noodles according to package instructions.",
           "2. In a bowl, mix ricotta cheese, grated mozzarella cheese, grated Parmesan cheese, and chopped spinach.",
           "3. In a large baking dish, layer marinara sauce, lasagna noodles, ricotta cheese mixture, sliced zucchini, sliced bell peppers, and sliced onion.",
           "4. Repeat layers, ending with a layer of marinara sauce on top.",
           "5. Cover with foil and bake at 350?F (175?C) for 45 minutes.",
           "6. Remove foil and bake for an additional 15 minutes, until bubbly and golden.",
           "7. Let lasagna rest for 10 minutes before slicing and serving."
        };
        Categories = new List<string> { "Lasagna", "Vegetarian" };

        rp.Recipe(pic[5], "Vegetable Lasagna", Ingredients, Instructions, Categories);
        DB.Add(rp);

        rp = ScriptableObject.CreateInstance<Recipes>();
        Ingredients = new List<string>
        {
           "Chicken breast",
           "Yogurt",
           "Lemon juice",
           "Garam masala",
           "Cumin",
           "Paprika",
           "Tomato sauce",
           "Heavy cream",
           "Butter",
           "Onion",
           "Garlic",
           "Ginger"
        };
        Instructions = new List<string>
        {
           "1. Cut chicken breast into bite-sized pieces.",
           "2. In a bowl, mix yogurt, lemon juice, garam masala, cumin, and paprika.",
           "3. Marinate chicken pieces in the yogurt mixture for at least 1 hour.",
           "4. In a large skillet, melt butter over medium heat.",
           "5. Add chopped onion, minced garlic, and grated ginger. Cook until softened.",
           "6. Add marinated chicken pieces and cook until browned.",
           "7. Stir in tomato sauce and heavy cream.",
           "8. Simmer for 15-20 minutes, until the chicken is cooked through and the sauce has thickened.",
           "9. Serve over rice."
        };
        Categories = new List<string> { "Indian", "Chicken" };

        rp.Recipe(pic[6], "Chicken Tikka Masala", Ingredients, Instructions, Categories);
        DB.Add(rp);

        rp = ScriptableObject.CreateInstance<Recipes>();
        Ingredients = new List<string>
        {
           "Romaine lettuce",
           "Caesar dressing",
           "Croutons",
           "Parmesan cheese"
        };
        Instructions = new List<string>
        {
            "1. Wash and chop romaine lettuce into bite-sized pieces.",
           "2. In a large bowl, toss lettuce with Caesar dressing.",
           "3. Add croutons and grated Parmesan cheese.",
           "4. Toss to combine.",
           "5. Serve immediately."
        };
        Categories = new List<string> { "Salad", "Vegetarian", "Gluten-free" };

        rp.Recipe(pic[7], "Caesar Salad", Ingredients, Instructions, Categories);
        DB.Add(rp);

        rp = ScriptableObject.CreateInstance<Recipes>();
        Ingredients = new List<string>
        {
           "Spaghetti",
           "Ground beef",
           "Onion",
           "Carrot",
           "Celery",
           "Garlic",
           "Tomato paste",
           "Canned tomatoes",
           "Red wine",
           "Beef broth",
           "Olive oil",
           "Salt",
           "Pepper",
           "Parmesan cheese"
        };
        Instructions = new List<string>
        {
            "1. Finely chop onion, carrot, and celery.",
           "2. In a large pot, heat olive oil over medium heat.",
           "3. Add chopped vegetables and minced garlic. Cook until softened.",
           "4. Add ground beef and cook until browned.",
           "5. Stir in tomato paste and cook for 2-3 minutes.",
           "6. Add canned tomatoes, red wine, and beef broth.",
           "7. Season with salt and pepper.",
           "8. Simmer sauce for 1-2 hours, stirring occasionally.",
           "9. Cook spaghetti according to package instructions.",
           "10. Serve sauce over cooked spaghetti, sprinkled with grated Parmesan cheese."
        };
        Categories = new List<string> { "Pasta", "Italian", "Gluten-free", "Beef" };

        rp.Recipe(pic[8], "Spaghetti Bolognese", Ingredients, Instructions, Categories);
        DB.Add(rp);

        rp = ScriptableObject.CreateInstance<Recipes>();
        Ingredients = new List<string>
        {
            "All-purpose flour",
           "Cocoa powder",
           "Baking powder",
           "Baking soda",
           "Salt",
           "Butter",
           "Sugar",
           "Eggs",
           "Vanilla extract",
           "Buttermilk",
           "Hot water"
        };
        Instructions = new List<string>
        {
            "1. Preheat oven to 350?F (175?C).",
           "2. Grease and flour two 9-inch round cake pans.",
           "3. In a medium bowl, sift together flour, cocoa powder, baking powder, baking soda, and salt.",
           "4. In a large bowl, cream together butter and sugar until light and fluffy.",
           "5. Beat in eggs one at a time, then stir in vanilla.",
           "6. Beat in flour mixture alternately with buttermilk, starting and ending with flour mixture.",
           "7. Stir in hot water until batter is smooth.",
           "8. Pour batter into prepared pans.",
           "9. Bake for 30 to 35 minutes, until a toothpick inserted into the center comes out clean.",
           "10. Allow cakes to cool in pans for 10 minutes, then remove from pans and cool completely on wire racks.",
           "11. Frost as desired."
        };
        Categories = new List<string> { "Dessert", "Cake", "Vegetarian" };

        rp.Recipe(pic[9], "Chocolate Cake", Ingredients, Instructions, Categories);
        DB.Add(rp);

        rp = ScriptableObject.CreateInstance<Recipes>();
        Ingredients = new List<string>
        {
            "Chicken breast",
           "Onion",
           "Carrots",
           "Celery",
           "Garlic",
           "Chicken broth",
           "Egg noodles",
           "Bay leaf",
           "Thyme",
           "Salt",
           "Pepper"
        };
        Instructions = new List<string>
        {
           "1. Chop onion, carrots, celery, and garlic.",
           "2. In a large pot, heat olive oil over medium heat.",
           "3. Add chopped vegetables and garlic. Cook until softened.",
           "4. Add chicken broth, bay leaf, thyme, salt, and pepper.",
           "5. Bring to a boil, then reduce heat and simmer for 20 minutes.",
           "6. Add shredded chicken breast and egg noodles. Cook until noodles are tender.",
           "7. Remove bay leaf before serving."
        };
        Categories = new List<string> { "Soup", "Chicken" };

        rp.Recipe(pic[10], "Chicken Noodle Soup", Ingredients, Instructions, Categories);
        DB.Add(rp);

        rp = ScriptableObject.CreateInstance<Recipes>();
        Ingredients = new List<string>
        {
           "Ground beef",
           "Onion",
           "Garlic",
           "Tomato paste",
           "Chili powder",
           "Cumin",
           "Paprika",
           "Salt",
           "Pepper",
           "Tortillas",
           "Toppings (cheese, lettuce, tomato, sour cream)"
        };
        Instructions = new List<string>
        {
            "1. Finely chop onion and garlic.",
           "2. In a large skillet, cook ground beef over medium-high heat until browned.",
           "3. Add chopped onion and garlic. Cook until onion is translucent.",
           "4. Stir in tomato paste, chili powder, cumin, paprika, salt, and pepper.",
           "5. Cook for another 5 minutes, stirring occasionally.",
           "6. Serve beef mixture in tortillas with desired toppings."
        };
        Categories = new List<string> { "Mexican", "Beef" };

        rp.Recipe(pic[11], "Beef Tacos", Ingredients, Instructions, Categories);
        DB.Add(rp);

        rp = ScriptableObject.CreateInstance<Recipes>();
        Ingredients = new List<string>
        {
            "Arborio rice",
           "Mushrooms",
           "Onion",
           "Garlic",
           "White wine",
           "Vegetable broth",
           "Parmesan cheese",
           "Butter",
           "Olive oil",
           "Salt",
           "Pepper"
        };
        Instructions = new List<string>
        {
            "1. Finely chop onion and garlic.",
           "2. Slice mushrooms.",
           "3. In a large skillet, heat olive oil over medium heat.",
           "4. Add chopped onion and garlic. Cook until softened.",
           "5. Add sliced mushrooms and cook until browned.",
           "6. Stir in Arborio rice and cook for 2-3 minutes.",
           "7. Add white wine and cook until absorbed.",
           "8. Gradually add vegetable broth, stirring constantly, until rice is creamy and cooked through.",
           "9. Stir in grated Parmesan cheese and butter.",
           "10. Season with salt and pepper.",
           "11. Serve hot."
        };
        Categories = new List<string> { "Risotto", "Vegetarian", "Vegan" };

        rp.Recipe(pic[12], "Mushroom Risotto", Ingredients, Instructions, Categories);
        DB.Add(rp);

        rp = ScriptableObject.CreateInstance<Recipes>();
        Ingredients = new List<string>
        {
            "Romaine lettuce",
           "Cucumber",
           "Cherry tomatoes",
           "Red onion",
           "Kalamata olives",
           "Feta cheese",
           "Olive oil",
           "Red wine vinegar",
           "Lemon juice",
           "Oregano",
           "Salt",
           "Pepper"
        };
        Instructions = new List<string>
        {
            "1. Chop romaine lettuce into bite-sized pieces.",
           "2. Dice cucumber, halve cherry tomatoes, thinly slice red onion, and crumble feta cheese.",
           "3. In a large bowl, combine lettuce, cucumber, tomatoes, red onion, Kalamata olives, and feta cheese.",
           "4. In a small bowl, whisk together olive oil, red wine vinegar, lemon juice, oregano, salt, and pepper.",
           "5. Pour dressing over salad and toss to combine.",
           "6. Serve immediately."
        };
        Categories = new List<string> { "Salad", "Greek", "Vegetarian" };

        rp.Recipe(pic[13], "Greek Salad", Ingredients, Instructions, Categories);
        DB.Add(rp);

        rp = ScriptableObject.CreateInstance<Recipes>();
        Ingredients = new List<string>
        {
            "Beef sirloin",
           "Onion",
           "Mushroom",
           "Garlic",
           "Beef broth",
           "Sour cream",
           "Worcestershire sauce",
           "Flour",
           "Butter",
           "Olive oil",
           "Salt",
           "Pepper",
           "Egg noodles"
        };
        Instructions = new List<string>
        {
            "1. Slice beef sirloin into thin strips.",
           "2. Finely chop onion, mushroom, and garlic.",
           "3. In a large skillet, heat olive oil and butter over medium-high heat.",
           "4. Add sliced beef and cook until browned.",
           "5. Remove beef from skillet and set aside.",
           "6. In the same skillet, add chopped onion, mushroom, and garlic. Cook until softened.",
           "7. Stir in flour and cook for 1-2 minutes.",
           "8. Gradually stir in beef broth, sour cream, and Worcestershire sauce.",
           "9. Add cooked beef back to the skillet and simmer for 10 minutes.",
           "10. Season with salt and pepper.",
           "11. Serve over cooked egg noodles."
        };
        Categories = new List<string> { "Beef" };

        rp.Recipe(pic[14], "Beef Stroganoff", Ingredients, Instructions, Categories);
        DB.Add(rp);

        rp = ScriptableObject.CreateInstance<Recipes>();
        Ingredients = new List<string>
        {
            "Pumpkin puree",
           "Onion",
           "Garlic",
           "Vegetable broth",
           "Coconut milk",
           "Curry powder",
           "Cumin",
           "Coriander",
           "Ginger",
           "Olive oil",
           "Salt",
           "Pepper"
        };
        Instructions = new List<string>
        {
            "1. Finely chop onion and garlic.",
           "2. In a large pot, heat olive oil over medium heat.",
           "3. Add chopped onion and garlic. Cook until softened.",
           "4. Stir in pumpkin puree, vegetable broth, coconut milk, curry powder, cumin, coriander, ginger, salt, and pepper.",
           "5. Bring to a boil, then reduce heat and simmer for 15-20 minutes.",
           "6. Use an immersion blender to blend soup until smooth.",
           "7. Serve hot."
        };
        Categories = new List<string> { "Soup", "Vegetarian","Gluten-free", "Vegan" };

        rp.Recipe(pic[15], "Pumpkin Soup", Ingredients, Instructions, Categories);
        DB.Add(rp);

        rp = ScriptableObject.CreateInstance<Recipes>();
        Ingredients = new List<string>
        {
            "Chicken breast",
           "Eggs",
           "Bread crumbs",
           "Parmesan cheese",
           "Marinara sauce",
           "Mozzarella cheese",
           "Olive oil",
           "Salt",
           "Pepper",
           "Spaghetti"
        };
        Instructions = new List<string>
        {
        };
        Categories = new List<string> { "Chicken", "Italian" };

        rp.Recipe(pic[16], "Chicken Parmesan", Ingredients, Instructions, Categories);
        DB.Add(rp);

        rp = ScriptableObject.CreateInstance<Recipes>();
        Ingredients = new List<string>
        {
            "All-purpose flour",
           "Baking soda",
           "Salt",
           "Butter",
           "Sugar",
           "Eggs",
           "Vanilla extract",
           "Ripe bananas",
           "Walnuts (optional)"
        };
        Instructions = new List<string>
        {
            "1. Preheat oven to 350?F (175?C).",
           "2. Grease and flour a 9x5 inch loaf pan.",
           "3. In a medium bowl, whisk together flour, baking soda, and salt.",
           "4. In a large bowl, cream together butter and sugar.",
           "5. Beat in eggs one at a time, then stir in vanilla.",
           "6. Mix in mashed bananas.",
           "7. Stir in flour mixture until just combined.",
           "8. Fold in chopped walnuts if desired.",
           "9. Pour batter into prepared loaf pan.",
           "10. Bake for 60-65 minutes, until a toothpick inserted into the center comes out clean.",
           "11. Allow bread to cool in pan for 10 minutes, then remove from pan and cool completely on a wire rack."
        };
        Categories = new List<string> { "Dessert", "Bread", "Vegetarian" };

        rp.Recipe(pic[17], "Banana Bread", Ingredients, Instructions, Categories);
        DB.Add(rp);

        rp = ScriptableObject.CreateInstance<Recipes>();
        Ingredients = new List<string>
        {
            "Tomatoes",
           "Onion",
           "Garlic",
           "Vegetable broth",
           "Fresh basil",
           "Olive oil",
           "Salt",
           "Pepper",
           "Sugar",
           "Heavy cream"
        };
        Instructions = new List<string>
        {
            "1. Preheat oven to 400?F (200?C).",
           "2. Halve tomatoes and place them on a baking sheet.",
           "3. Drizzle with olive oil, salt, and pepper.",
           "4. Roast tomatoes in the preheated oven for 30-40 minutes, until softened and slightly caramelized.",
           "5. In a large pot, heat olive oil over medium heat.",
           "6. Add chopped onion and minced garlic. Cook until softened.",
           "7. Add roasted tomatoes, vegetable broth, chopped fresh basil, sugar, salt, and pepper.",
           "8. Bring to a boil, then reduce heat and simmer for 20-30 minutes.",
           "9. Use an immersion blender to blend soup until smooth.",
           "10. Stir in heavy cream.",
           "11. Serve hot."
        };
        Categories = new List<string> { "Soup", "Vegetarian" };

        rp.Recipe(pic[18], "Tomato Basil Soup", Ingredients, Instructions, Categories);
        DB.Add(rp);

        rp = ScriptableObject.CreateInstance<Recipes>();
        Ingredients = new List<string>
        {
            "Ground beef",
           "Onion",
           "Garlic",
           "Worcestershire sauce",
           "Salt",
           "Pepper",
           "Hamburger buns",
           "Toppings (cheese, lettuce, tomato, pickles, onions)"
        };
        Instructions = new List<string>
        {
            "1. Finely chop onion and garlic.",
           "2. In a large bowl, mix together ground beef, chopped onion, minced garlic, Worcestershire sauce, salt, and pepper.",
           "3. Form mixture into patties.",
           "4. Cook patties on a grill or in a skillet over medium-high heat until cooked through.",
           "5. Serve patties on hamburger buns with desired toppings."
        };
        Categories = new List<string> { "Beef", "Burgers" };

        rp.Recipe(pic[19], "Beef Burgers", Ingredients, Instructions, Categories);
        DB.Add(rp);

        rp = ScriptableObject.CreateInstance<Recipes>();
        Ingredients = new List<string>
        {
            "Tomatoes",
           "Fresh mozzarella cheese",
           "Fresh basil leaves",
           "Olive oil",
           "Balsamic glaze",
           "Salt",
           "Pepper"
        };
        Instructions = new List<string>
        {
            "1. Slice tomatoes and fresh mozzarella cheese into thin slices.",
           "2. Arrange tomato slices, mozzarella slices, and fresh basil leaves on a plate.",
           "3. Drizzle with olive oil and balsamic glaze.",
           "4. Season with salt and pepper.",
           "5. Serve immediately."
        };
        Categories = new List<string> { "Salad", "Italian", "Vegetarian", "Vegan" };

        rp.Recipe(pic[20], "Caprese Salad", Ingredients, Instructions, Categories);
        DB.Add(rp);

        rp = ScriptableObject.CreateInstance<Recipes>();
        Ingredients = new List<string>
        {
             "All-purpose flour",
           "Baking powder",
           "Salt",
           "Sugar",
           "Milk",
           "Eggs",
           "Butter",
           "Vanilla extract",
           "Maple syrup"
        };
        Instructions = new List<string>
        {
            "1. In a large bowl, whisk together flour, baking powder, salt, and sugar.",
           "2. In another bowl, whisk together milk, eggs, melted butter, and vanilla extract.",
           "3. Pour wet ingredients into dry ingredients and stir until just combined.",
           "4. Heat a griddle or large skillet over medium heat.",
           "5. Grease with butter.",
           "6. Pour 1/4 cup of batter onto the griddle for each pancake.",
           "7. Cook until bubbles form on the surface, then flip and cook until golden brown.",
           "8. Serve with maple syrup."
        };
        Categories = new List<string> { "Breakfast", "Pancakes", "Vegetarian" };

        rp.Recipe(pic[21], "Pancakes", Ingredients, Instructions, Categories);
        DB.Add(rp);

        rp = ScriptableObject.CreateInstance<Recipes>();
        Ingredients = new List<string>
        {
            "Eggs",
           "Onion",
           "Red bell pepper",
           "Garlic",
           "Tomato sauce",
           "Paprika",
           "Cumin",
           "Chili powder",
           "Salt",
           "Pepper",
           "Olive oil",
           "Feta cheese",
           "Parsley"
        };
        Instructions = new List<string>
        {
            "1. Finely chop onion, red bell pepper, and garlic.",
           "2. In a large skillet, heat olive oil over medium heat.",
           "3. Add chopped onion and red bell pepper. Cook until softened.",
           "4. Add minced garlic, paprika, cumin, chili powder, salt, and pepper. Cook for another minute.",
           "5. Stir in tomato sauce and simmer for 10-15 minutes.",
           "6. Using a spoon, create small wells in the sauce and crack eggs into the wells.",
           "7. Cover and cook until eggs are set, about 5-7 minutes.",
           "8. Crumble feta cheese over the top and sprinkle with chopped parsley.",
           "9. Serve hot."
        };
        Categories = new List<string> { "Breakfast", "Middle Eastern", "Vegetarian" };

        rp.Recipe(pic[22], "Shakshuka", Ingredients, Instructions, Categories);
        DB.Add(rp);

        rp = ScriptableObject.CreateInstance<Recipes>();
        Ingredients = new List<string>
        {
            "Shrimp",
           "Linguine pasta",
           "Lemon",
           "Garlic",
           "Red pepper flakes",
           "Olive oil",
           "Butter",
           "Salt",
           "Pepper",
           "Parsley",
           "Parmesan cheese"
        };
        Instructions = new List<string>
        {
            "1. Cook linguine pasta according to package instructions.",
           "2. Peel and devein shrimp.",
           "3. In a large skillet, heat olive oil and butter over medium heat.",
           "4. Add minced garlic and red pepper flakes. Cook until garlic is fragrant.",
           "5. Add shrimp and cook until pink and cooked through.",
           "6. Add cooked pasta to the skillet with shrimp.",
           "7. Squeeze lemon juice over the pasta and shrimp.",
           "8. Season with salt, pepper, and chopped parsley.",
           "9. Serve hot, sprinkled with grated Parmesan cheese."
        };
        Categories = new List<string> { "Pasta", "Seafood" };

        rp.Recipe(pic[23], "Lemon Garlic Shrimp Pasta", Ingredients, Instructions, Categories);
        DB.Add(rp);

        rp = ScriptableObject.CreateInstance<Recipes>();
        Ingredients = new List<string>
        {
            "Romaine lettuce",
           "Grilled chicken breast",
           "Caesar dressing",
           "Croutons",
           "Parmesan cheese"
        };
        Instructions = new List<string>
        {
            "1. Wash and chop romaine lettuce into bite-sized pieces.",
           "2. Slice grilled chicken breast into strips.",
           "3. In a large bowl, toss lettuce with Caesar dressing.",
           "4. Add chicken strips, croutons, and grated Parmesan cheese.",
           "5. Toss to combine.",
           "6. Serve immediately."
        };
        Categories = new List<string> { "Salad", "Chicken" };

        rp.Recipe(pic[24], "Chicken Caesar Salad", Ingredients, Instructions, Categories);
        DB.Add(rp);

        rp = ScriptableObject.CreateInstance<Recipes>();
        Ingredients = new List<string>
        {
            "Eggplant",
           "Zucchini",
           "Yellow squash",
           "Onion",
           "Bell peppers",
           "Garlic",
           "Tomato sauce",
           "Olive oil",
           "Herbes de Provence",
           "Salt",
           "Pepper"
        };
        Instructions = new List<string>
        {
            "1. Chop eggplant, zucchini, yellow squash, onion, and bell peppers into bite-sized pieces.",
           "2. Mince garlic.",
           "3. In a large skillet, heat olive oil over medium heat.",
           "4. Add chopped vegetables and minced garlic. Cook until softened.",
           "5. Stir in tomato sauce and herbes de Provence.",
           "6. Simmer for 15-20 minutes.",
           "7. Season with salt and pepper.",
           "8. Serve hot or at room temperature."
        };
        Categories = new List<string> { "Vegetarian", "French", "Vegan" };

        rp.Recipe(pic[25], "Ratatouille", Ingredients, Instructions, Categories);
        DB.Add(rp);

        rp = ScriptableObject.CreateInstance<Recipes>();
        Ingredients = new List<string>
        {
            "Whole chicken",
           "Lemon",
           "Garlic",
           "Fresh herbs (such as rosemary, thyme, and parsley)",
           "Olive oil",
           "Salt",
           "Pepper"
        };
        Instructions = new List<string>
        {
            "1. Preheat oven to 425?F (220?C).",
           "2. Zest and juice lemon.",
           "3. Finely chop garlic and fresh herbs.",
           "4. In a small bowl, mix lemon zest, lemon juice, minced garlic, chopped herbs, olive oil, salt, and pepper.",
           "5. Rub mixture all over the whole chicken, inside and out.",
           "6. Place chicken on a roasting pan.",
           "7. Roast in the preheated oven for 1 hour to 1 hour and 30 minutes, until chicken is cooked through and juices run clear.",
           "8. Let chicken rest for 10 minutes before carving."
        };
        Categories = new List<string> { "Chicken", "Roast" };

        rp.Recipe(pic[26], "Lemon Herb Roast Chicken", Ingredients, Instructions, Categories);
        DB.Add(rp);

        rp = ScriptableObject.CreateInstance<Recipes>();
        Ingredients = new List<string>
        {
            "Pizza dough",
           "Tomato sauce",
           "Mozzarella cheese",
           "Toppings (pepperoni, mushrooms, bell peppers, onions, olives, \"Gluten-free\")"
        };
        Instructions = new List<string>
        {
            "1. Preheat oven to 500?F (260?C).",
           "2. Roll out pizza dough into a circle.",
           "3. Spread tomato sauce over the dough.",
           "4. Sprinkle grated mozzarella cheese over the sauce.",
           "5. Add desired toppings.",
           "6. Bake in preheated oven for 10-12 minutes, until crust is golden and cheese is bubbly.",
           "7. Remove from oven and let cool slightly before slicing and serving."
        };
        Categories = new List<string> { "Pizza", "Italian", "Vegetarian" };

        rp.Recipe(pic[27], "Homemade Pizza", Ingredients, Instructions, Categories);
        DB.Add(rp);

        rp = ScriptableObject.CreateInstance<Recipes>();
        Ingredients = new List<string>
        {
            "Potatoes",
           "Carrots",
           "Peas",
           "Onion",
           "Garlic",
           "Ginger",
           "Tomato",
           "Coconut milk",
           "Curry powder",
           "Turmeric",
           "Cumin",
           "Coriander",
           "Olive oil",
           "Salt",
           "Pepper"
        };
        Instructions = new List<string>
        {
            "1. Chop potatoes, carrots, onion, garlic, ginger, and tomato.",
           "2. In a large pot, heat olive oil over medium heat.",
           "3. Add chopped onion, garlic, and ginger. Cook until softened.",
           "4. Stir in curry powder, turmeric, cumin, and coriander. Cook for another minute.",
           "5. Add chopped potatoes, carrots, and tomato.",
           "6. Pour in coconut milk and bring to a simmer.",
           "7. Cook until vegetables are tender.",
           "8. Season with salt and pepper.",
           "9. Serve hot over rice."
        };
        Categories = new List<string> { "Vegetarian", "Curry", "Gluten-free", "Vegan" };

        rp.Recipe(pic[28], "Vegetable Curry", Ingredients, Instructions, Categories);
        DB.Add(rp);

        rp = ScriptableObject.CreateInstance<Recipes>();
        Ingredients = new List<string>
        {
            "Chicken breast",
           "Onion",
           "Garlic",
           "Enchilada sauce",
           "Corn tortillas",
           "Cheese",
           "Olive oil",
           "Salt",
           "Pepper",
           "Cilantro"
        };
        Instructions = new List<string>
        {
            "1. Preheat oven to 350?F (175?C).",
           "2. Cook chicken breast and shred.",
           "3. Finely chop onion and garlic.",
           "4. In a large skillet, heat olive oil over medium heat.",
           "5. Add chopped onion and garlic. Cook until softened.",
           "6. Stir in shredded chicken and some enchilada sauce.",
           "7. Spread a thin layer of enchilada sauce on the bottom of a baking dish.",
           "8. Fill each corn tortilla with chicken mixture and roll up.",
           "9. Place rolled enchiladas in the baking dish.",
           "10. Pour remaining enchilada sauce over the top.",
           "11. Sprinkle with grated cheese.",
           "12. Bake in preheated oven for 20-25 minutes, until cheese is melted and bubbly.",
           "13. Serve hot, garnished with chopped cilantro."
        };
        Categories = new List<string> { "Mexican", "Chicken" };

        rp.Recipe(pic[29], "Chicken Enchiladas", Ingredients, Instructions, Categories);
        DB.Add(rp);

        rp = ScriptableObject.CreateInstance<Recipes>();
        Ingredients = new List<string>
        {
            "Ladyfingers",
           "Espresso",
           "Mascarpone cheese",
           "Eggs",
           "Sugar",
           "Cocoa powder"
        };
        Instructions = new List<string>
        {
            "1. Brew espresso and let it cool.",
           "2. Separate egg yolks from whites.",
           "3. In a bowl, whisk together egg yolks and sugar until light and creamy.",
           "4. Add mascarpone cheese and mix until smooth.",
           "5. In another bowl, beat egg whites until stiff peaks form.",
           "6. Fold egg whites into the mascarpone mixture.",
           "7. Dip ladyfingers into the cooled espresso and layer them in a dish.",
           "8. Spread half of the mascarpone mixture over the ladyfingers.",
           "9. Repeat with another layer of soaked ladyfingers and mascarpone mixture.",
           "10. Refrigerate for at least 4 hours, or overnight.",
           "11. Before serving, dust with cocoa powder."
        };
        Categories = new List<string> { "Dessert", "Italian", "Vegetarian" };

        rp.Recipe(pic[30], "Tiramisu", Ingredients, Instructions, Categories);
        DB.Add(rp);


        rp = ScriptableObject.CreateInstance<Recipes>();
        Ingredients = new List<string>
        {
            "Bread",
            "Cheese",
            "Butter"
        };
        Instructions = new List<string>
        {
            "1. Butter one side of each slice of bread.",
            "2. Place cheese between the unbuttered sides of the bread.",
            "3. Grill sandwich in a pan over medium heat until golden brown and cheese is melted."
        };
        Categories = new List<string> { "Sandwich", "Vegetarian" };
        rp.Recipe(pic[31], "Grilled Cheese Sandwich", Ingredients, Instructions, Categories);
        DB.Add(rp);

       
        rp = ScriptableObject.CreateInstance<Recipes>();
        Ingredients = new List<string>
        {
            "Bread",
            "Eggs",
            "Milk",
            "Cinnamon",
            "Vanilla extract",
            "Butter",
            "Maple syrup"
        };
        Instructions = new List<string>
        {
            "1. Whisk together eggs, milk, cinnamon, and vanilla extract.",
            "2. Dip bread slices into the egg mixture.",
            "3. Melt butter in a pan over medium heat.",
            "4. Cook bread slices until golden brown on both sides.",
            "5. Serve with maple syrup."
        };
        Categories = new List<string> { "Breakfast", "Vegetarian" };
        rp.Recipe(pic[32], "French Toast", Ingredients, Instructions, Categories);
        DB.Add(rp);

        
        rp = ScriptableObject.CreateInstance<Recipes>();
        Ingredients = new List<string>
        {
            "Macaroni pasta",
            "Cheese",
            "Milk",
            "Butter",
            "Flour",
            "Salt",
            "Pepper"
        };
        Instructions = new List<string>
        {
            "1. Cook macaroni according to package instructions.",
            "2. Melt butter in a saucepan over medium heat.",
            "3. Whisk in flour and cook for 1 minute.",
            "4. Gradually whisk in milk until smooth.",
            "5. Add cheese and stir until melted.",
            "6. Season with salt and pepper.",
            "7. Drain macaroni and add to cheese sauce.",
            "8. Stir to combine and serve hot."
        };
        Categories = new List<string> { "Pasta", "Vegetarian" };
        rp.Recipe(pic[33], "Mac and Cheese", Ingredients, Instructions, Categories);
        DB.Add(rp);

        
        rp = ScriptableObject.CreateInstance<Recipes>();
        Ingredients = new List<string>
        {
            "All-purpose flour",
            "Baking powder",
            "Salt",
            "Sugar",
            "Milk",
            "Eggs",
            "Butter",
            "Vanilla extract",
            "Blueberries",
            "Maple syrup"
        };
        Instructions = new List<string>
        {
            "1. In a large bowl, whisk together flour, baking powder, salt, and sugar.",
            "2. In another bowl, whisk together milk, eggs, melted butter, and vanilla extract.",
            "3. Pour wet ingredients into dry ingredients and stir until just combined.",
            "4. Heat a griddle or large skillet over medium heat.",
            "5. Grease with butter.",
            "6. Pour 1/4 cup of batter onto the griddle for each pancake.",
            "7. Cook until bubbles form on the surface, then flip and cook until golden brown.",
            "8. Serve with maple syrup."
        };
        Categories = new List<string> { "Breakfast", "Pancakes", "Vegetarian" };
        rp.Recipe(pic[34], "Bluberry Pancakes", Ingredients, Instructions, Categories);
        DB.Add(rp);

        
        rp = ScriptableObject.CreateInstance<Recipes>();
        Ingredients = new List<string>
        {
            "Eggs",
            "Milk",
            "Salt",
            "Pepper",
            "Butter",
            "Fillings of your choice (cheese, vegetables, meat)"
        };
        Instructions = new List<string>
        {
            "1. Whisk together eggs, milk, salt, and pepper.",
            "2. Melt butter in a pan over medium heat.",
            "3. Pour egg mixture into the pan.",
            "4. As the eggs cook, gently push the cooked edges toward the center of the pan.",
            "5. Add your desired fillings to one half of the omelette.",
            "6. Fold the other half of the omelette over the fillings.",
            "7. Cook for a few more minutes, until the fillings are heated through.",
            "8. Serve hot."
        };
        Categories = new List<string> { "Breakfast", "Vegetarian" };
        rp.Recipe(pic[35], "Omelette", Ingredients, Instructions, Categories);
        DB.Add(rp);

       
        rp = ScriptableObject.CreateInstance<Recipes>();
        Ingredients = new List<string>
        {
            "Romaine lettuce",
            "Caesar dressing",
            "Croutons",
            "Shrimp",
            "Parmesan cheese"
        };
        Instructions = new List<string>
        {
            "1. Wash and chop romaine lettuce into bite-sized pieces.",
            "2. In a large bowl, toss lettuce with Caesar dressing.",
            "3. Add croutons and grated Parmesan cheese.",
            "4. Toss to combine.",
            "5. Serve immediately."
        };
        Categories = new List<string> { "Salad", "Seafood" };
        rp.Recipe(pic[36], "Shrimp Caesar Salad", Ingredients, Instructions, Categories);
        DB.Add(rp);

        
        rp = ScriptableObject.CreateInstance<Recipes>();
        Ingredients = new List<string>
        {
            "Avocados",
            "Lime juice",
            "Onion",
            "Cilantro",
            "Jalapeno pepper (optional)",
            "Salt",
            "Pepper"
        };
        Instructions = new List<string>
        {
            "1. Mash avocados in a bowl.",
            "2. Add lime juice, chopped onion, chopped cilantro, and chopped jalapeno pepper (if using).",
            "3. Season with salt and pepper.",
            "4. Stir to combine and serve with chips or vegetables."
        };
        Categories = new List<string> { "Dip", "Mexican", "Vegan", "Gluten-free" };
        rp.Recipe(pic[37], "Guacamole", Ingredients, Instructions, Categories);
        DB.Add(rp);

       
        rp = ScriptableObject.CreateInstance<Recipes>();
        Ingredients = new List<string>
        {
            "Tuna",
            "Mayonnaise",
            "Celery",
            "Onion",
            "Lemon juice",
            "Salt",
            "Pepper",
            "Bread"
        };
        Instructions = new List<string>
        {
            "1. Flake tuna into a bowl.",
            "2. Add mayonnaise, chopped celery, chopped onion, and lemon juice.",
            "3. Season with salt and pepper.",
            "4. Stir to combine and serve on bread."
        };
        Categories = new List<string> { "Sandwich", "Fish" };
        rp.Recipe(pic[38], "Tuna Salad", Ingredients, Instructions, Categories);
        DB.Add(rp);

        
        rp = ScriptableObject.CreateInstance<Recipes>();
        Ingredients = new List<string>
        {
            "Chicken",
            "Mayonnaise",
            "Celery",
            "Onion",
            "Grapes",
            "Salt",
            "Pepper",
            "Bread"
        };
        Instructions = new List<string>
        {
            "1. Shred or chop chicken into a bowl.",
            "2. Add mayonnaise, chopped celery, chopped onion, and halved grapes.",
            "3. Season with salt and pepper.",
            "4. Stir to combine and serve on bread."
        };
        Categories = new List<string> { "Sandwich", "Chicken" };
        rp.Recipe(pic[39], "Chicken Salad", Ingredients, Instructions, Categories);
        DB.Add(rp);


        rp = ScriptableObject.CreateInstance<Recipes>();
        Ingredients = new List<string>
        {
            "Fruits of your choice (strawberries, blueberries, raspberries, grapes, oranges, etc.)"
        };
        Instructions = new List<string>
        {
            "1. Wash and chop fruits.",
            "2. Combine fruits in a bowl.",
            "3. Serve chilled."
        };
        Categories = new List<string> { "Salad", "Fruit", "Vegan", "Gluten-free" };
        rp.Recipe(pic[40], "Fruit Salad", Ingredients, Instructions, Categories);
        DB.Add(rp);

        
        rp = ScriptableObject.CreateInstance<Recipes>();
        Ingredients = new List<string>
        {
            "Greek yogurt",
            "Berries (strawberries, blueberries, raspberries, etc.)",
            "Honey"
        };
        Instructions = new List<string>
        {
            "1. Spoon Greek yogurt into a bowl.",
            "2. Top with berries and a drizzle of honey.",
            "3. Serve immediately."
        };
        Categories = new List<string> { "Breakfast", "Snack", "Vegetarian" };
        rp.Recipe(pic[41], "Greek Yogurt with Berries and Honey", Ingredients, Instructions, Categories);
        DB.Add(rp);

       
        rp = ScriptableObject.CreateInstance<Recipes>();
        Ingredients = new List<string>
        {
            "Oats",
            "Milk",
            "Fruit (banana, berries, apple, etc.)",
            "Nuts (almonds, walnuts, pecans, etc.)"
        };
        Instructions = new List<string>
        {
            "1. Cook oats according to package instructions.",
            "2. Top with your favorite fruit and nuts.",
            "3. Serve hot."
        };
        Categories = new List<string> { "Breakfast", "Vegetarian" };
        rp.Recipe(pic[42], "Oatmeal with Fruit and Nuts", Ingredients, Instructions, Categories);
        DB.Add(rp);

        
        rp = ScriptableObject.CreateInstance<Recipes>();
        Ingredients = new List<string>
        {
            "Fruit (banana, berries, mango, etc.)",
            "Liquid (milk, yogurt, juice)",
            "Ice"
        };
        Instructions = new List<string>
        {
            "1. Combine all ingredients in a blender.",
            "2. Blend until smooth.",
            "3. Serve immediately."
        };
        Categories = new List<string> { "Drink", "Fruit", "Vegan" };
        rp.Recipe(pic[43], "Smoothie", Ingredients, Instructions, Categories);
        DB.Add(rp);

        
        rp = ScriptableObject.CreateInstance<Recipes>();
        Ingredients = new List<string>
        {
            "Nuts (almonds, walnuts, pecans, etc.)",
            "Dried fruit (raisins, cranberries, apricots, etc.)",
            "Seeds (sunflower seeds, pumpkin seeds)",
            "Chocolate chips (optional)"
        };
        Instructions = new List<string>
        {
            "1. Combine all ingredients in a bowl.",
            "2. Mix well.",
            "3. Store in an airtight container."
        };
        Categories = new List<string> { "Snack", "Vegan" };
        rp.Recipe(pic[44], "Trail Mix", Ingredients, Instructions, Categories);
        DB.Add(rp);

        
        rp = ScriptableObject.CreateInstance<Recipes>();
        Ingredients = new List<string>
        {
            "Popcorn kernels",
            "Oil",
            "Salt"
        };
                Instructions = new List<string>
        {
            "1. Heat oil in a large pot over medium heat.",
            "2. Add popcorn kernels and cover the pot.",
            "3. Cook, shaking the pot occasionally, until the popping slows down.",
            "4. Remove from heat and season with salt.",
            "5. Serve immediately."
        };
        Categories = new List<string> { "Snack", "Vegan", "Gluten-free" };
        rp.Recipe(pic[45], "Popcorn", Ingredients, Instructions, Categories);
        DB.Add(rp);

        
        rp = ScriptableObject.CreateInstance<Recipes>();
        Ingredients = new List<string>
        {
            "Potatoes",
            "Olive oil",
            "Salt",
            "Pepper",
            "Toppings of your choice (butter, sour cream, cheese, chives, etc.)"
        };
        Instructions = new List<string>
        {
            "1. Preheat oven to 400∞F (200∞C).",
            "2. Scrub potatoes clean.",
            "3. Rub potatoes with olive oil, salt, and pepper.",
            "4. Pierce potatoes with a fork.",
            "5. Bake in the preheated oven for 1 hour, or until tender.",
            "6. Serve with your favorite toppings."
        };
        Categories = new List<string> { "Side Dish", "Potato", "Vegan", "Gluten-free" };
        rp.Recipe(pic[46], "Baked Potato", Ingredients, Instructions, Categories);
        DB.Add(rp);

       
        rp = ScriptableObject.CreateInstance<Recipes>();
        Ingredients = new List<string>
        {
            "Vegetables of your choice (broccoli, carrots, cauliflower, Brussels sprouts, etc.)",
            "Olive oil",
            "Salt",
            "Pepper",
            "Herbs of your choice (rosemary, thyme, etc.)"
        };
        Instructions = new List<string>
        {
            "1. Preheat oven to 400∞F (200∞C).",
            "2. Chop vegetables into bite-sized pieces.",
            "3. Toss vegetables with olive oil, salt, pepper, and herbs.",
            "4. Spread vegetables on a baking sheet.",
            "5. Roast in the preheated oven for 20-30 minutes, or until tender and slightly browned.",
            "6. Serve hot."
        };
        Categories = new List<string> { "Side Dish", "Vegetable", "Vegan", "Gluten-free" };
        rp.Recipe(pic[47], "Roasted Vegetables", Ingredients, Instructions, Categories);
        DB.Add(rp);

        
        rp = ScriptableObject.CreateInstance<Recipes>();
        Ingredients = new List<string>
        {
            "Rice",
            "Water"
        };
        Instructions = new List<string>
        {
            "1. Rinse rice in a fine-mesh sieve.",
            "2. In a saucepan, combine rice and water.",
            "3. Bring to a boil, then reduce heat and simmer for 15-20 minutes, or until water is absorbed and rice is tender.",
            "4. Fluff with a fork and serve hot."
        };
        Categories = new List<string> { "Side Dish", "Vegan", "Gluten-free" };
        rp.Recipe(pic[48], "Rice", Ingredients, Instructions, Categories);
        DB.Add(rp);

        
        rp = ScriptableObject.CreateInstance<Recipes>();
        Ingredients = new List<string>
        {
            "Quinoa",
            "Water"
        };
        Instructions = new List<string>
        {
            "1. Rinse quinoa in a fine-mesh sieve.",
            "2. In a saucepan, combine quinoa and water.",
            "3. Bring to a boil, then reduce heat and simmer for 15 minutes, or until water is absorbed and quinoa is tender.",
            "4. Fluff with a fork and serve hot."
        };
        Categories = new List<string> { "Side Dish", "Vegan", "Gluten-free" };
        rp.Recipe(pic[49], "Quinoa", Ingredients, Instructions, Categories);
        DB.Add(rp);

       
        rp = ScriptableObject.CreateInstance<Recipes>();
        Ingredients = new List<string>
        {
            "Potatoes",
            "Milk",
            "Butter",
            "Salt",
            "Pepper"
        };
        Instructions = new List<string>
        {
            "1. Peel and chop potatoes into even-sized pieces.",
            "2. Boil potatoes in a pot of water until tender.",
            "3. Drain potatoes and return to the pot.",
            "4. Add milk, butter, salt, and pepper.",
            "5. Mash potatoes until smooth.",
            "6. Serve hot."
        };
        Categories = new List<string> { "Side Dish", "Potato", "Vegan" };
        rp.Recipe(pic[50], "Mashed Potatoes", Ingredients, Instructions, Categories);
        DB.Add(rp);

       
        rp = ScriptableObject.CreateInstance<Recipes>();
        Ingredients = new List<string>
        {
            "Potatoes",
            "Oil",
            "Salt"
        };
        Instructions = new List<string>
        {
            "1. Peel and cut potatoes into fries.",
            "2. Soak fries in cold water for 30 minutes.",
            "3. Dry fries thoroughly.",
            "4. Heat oil in a deep fryer or large pot to 375∞F (190∞C).",
            "5. Fry fries in batches until golden brown and crispy.",
            "6. Drain on paper towels and season with salt.",
            "7. Serve hot."
        };
        Categories = new List<string> { "Side Dish", "Potato", "Vegan" };
        rp.Recipe(pic[51], "French Fries", Ingredients, Instructions, Categories);
        DB.Add(rp);

        
        rp = ScriptableObject.CreateInstance<Recipes>();
        Ingredients = new List<string>
        {
            "Lettuce",
            "Vegetables of your choice (tomatoes, cucumbers, carrots, etc.)",
            "Olive oil",
            "Vinegar",
            "Dijon mustard",
            "Salt",
            "Pepper"
        };
        Instructions = new List<string>
        {
            "1. Wash and chop lettuce and vegetables.",
            "2. In a small bowl, whisk together olive oil, vinegar, Dijon mustard, salt, and pepper.",
            "3. Pour dressing over salad and toss to combine.",
            "4. Serve immediately."
        };
        Categories = new List<string> { "Salad", "Vegan" };
        rp.Recipe(pic[52], "Salad with Vinaigrette", Ingredients, Instructions, Categories);
        DB.Add(rp);

        
        rp = ScriptableObject.CreateInstance<Recipes>();
        Ingredients = new List<string>
        {
            "Vegetables of your choice (onion, carrots, celery, etc.)",
            "Vegtable broth",
            "Herbs and spices of your choice"
        };
        Instructions = new List<string>
        {
            "1. Chop vegetables.",
            "2. In a large pot, sautÅEvegetables in oil until softened.",
            "3. Add broth and herbs and spices.",
            "4. Bring to a boil, then reduce heat and simmer for 20-30 minutes, or until vegetables are tender.",
            "5. Serve hot."
        };
        Categories = new List<string> { "Soup", "Vegan" };
        rp.Recipe(pic[53], "Soup", Ingredients, Instructions, Categories);
        DB.Add(rp);

        
        rp = ScriptableObject.CreateInstance<Recipes>();
        Ingredients = new List<string>
        {
            "Ground beef",
            "Onion",
            "Garlic",
            "Chili powder",
            "Cumin",
            "Oregano",
            "Tomatoes",
            "Kidney beans",
            "Salt",
            "Pepper"
        };
        Instructions = new List<string>
        {
            "1. In a large pot, brown ground beef or turkey over medium heat.",
            "2. Add chopped onion and minced garlic, and cook until softened.",
            "3. Stir in chili powder, cumin, oregano, salt, and pepper.",
            "4. Add tomatoes, kidney beans, and water.",
            "5. Bring to a boil, then reduce heat and simmer for at least 30 minutes, or up to several hours.",
            "6. Serve hot."
        };
        Categories = new List<string> { "Soup", "Chili", "Beef" }; 
        rp.Recipe(pic[54], "Chili", Ingredients, Instructions, Categories);
        DB.Add(rp);

        
        rp = ScriptableObject.CreateInstance<Recipes>();
        Ingredients = new List<string>
        {
            "Tortillas",
            "Chicken",
            "Toppings of your choice (lettuce, tomato, cheese, onion, cilantro, etc.)"
        };
        Instructions = new List<string>
        {
            "1. Cook your chosen protein.",
            "2. Warm tortillas.",
            "3. Fill tortillas with protein and your favorite toppings.",
            "4. Serve immediately."
        };
        Categories = new List<string> { "Mexican", "Tacos", "Chicken" };
        rp.Recipe(pic[55], "Chicken Tacos", Ingredients, Instructions, Categories);
        DB.Add(rp);

       
        rp = ScriptableObject.CreateInstance<Recipes>();
        Ingredients = new List<string>
        {
            "Large tortillas",
            "Rice",
            "Beans",
            "Protein of your choice (ground beef, chicken, fish, etc.)",
            "Toppings of your choice (lettuce, tomato, cheese, onion, cilantro, etc.)"
        };
        Instructions = new List<string>
        {
            "1. Cook rice and beans.",
            "2. Cook your chosen protein.",
            "3. Warm tortillas.",
            "4. Fill tortillas with rice, beans, protein, and your favorite toppings.",
            "5. Fold burritos and serve immediately."
        };
        Categories = new List<string> { "Mexican", "Burritos" };
        rp.Recipe(pic[56], "Burritos", Ingredients, Instructions, Categories);
        DB.Add(rp);


        rp = ScriptableObject.CreateInstance<Recipes>();
        Ingredients = new List<string>
        {
            "Pizza dough",
            "Tomato sauce",
            "Cheese",
            "Chicken",
            "Toppings of your choice"
        };
        Instructions = new List<string>
        {
            "1. Preheat oven to 450∞F (230∞C).",
            "2. Roll out pizza dough.",
            "3. Spread tomato sauce over the dough.",
            "4. Sprinkle with cheese and add your favorite toppings.",
            "5. Bake in preheated oven for 10-15 minutes, or until crust is golden brown and cheese is melted and bubbly.",
            "6. Serve hot."
        };
        Categories = new List<string> { "Pizza", "Italian", "Chicken" };
        rp.Recipe(pic[57], "Chicken Pizza", Ingredients, Instructions, Categories);
        DB.Add(rp);

        
        rp = ScriptableObject.CreateInstance<Recipes>();
        Ingredients = new List<string>
        {
            "Pasta",
            "Tomato sauce",
            "Olive oil",
            "Garlic",
            "Salt",
            "Pepper",
            "Parmesan cheese"
        };
        Instructions = new List<string>
        {
            "1. Cook pasta according to package instructions.",
            "2. In a saucepan, heat olive oil over medium heat.",
            "3. Add minced garlic and cook until fragrant.",
            "4. Stir in tomato sauce, salt, and pepper.",
            "5. Simmer for 10 minutes.",
            "6. Drain pasta and add to sauce.",
            "7. Stir to combine and serve hot, sprinkled with Parmesan cheese."
        };
        Categories = new List<string> { "Pasta", "Italian", "Vegetarian" };
        rp.Recipe(pic[58], "Pasta with Tomato Sauce", Ingredients, Instructions, Categories);
        DB.Add(rp);

        
        rp = ScriptableObject.CreateInstance<Recipes>();
        Ingredients = new List<string>
        {
            "Beef",
            "Vegetables of your choice (potatoes, carrots, peas, etc.)",
            "Curry paste or powder",
            "Coconut milk",
            "Rice"
        };
        Instructions = new List<string>
        {
            "1. Chop protein and vegetables into bite-sized pieces.",
            "2. In a large pot, sautÅEprotein and vegetables in oil until softened.",
            "3. Stir in curry paste or powder and cook for 1 minute.",
            "4. Add coconut milk and water.",
            "5. Bring to a boil, then reduce heat and simmer for 20-30 minutes, or until protein and vegetables are cooked through.",
            "6. Serve over rice."
        };
        Categories = new List<string> { "Curry", "Indian", "Beef" };
        rp.Recipe(pic[60], "Beef Curry", Ingredients, Instructions, Categories);
        DB.Add(rp);

        rp = ScriptableObject.CreateInstance<Recipes>();
        Ingredients = new List<string>
        {
            "Salmon fillets",
            "Lemon",
            "Fresh dill",
            "Olive oil",
            "Salt",
            "Pepper"
        };
        Instructions = new List<string>
        {
            "1. Preheat oven to 400∞F (200∞C).",
            "2. Place salmon fillets on a baking sheet lined with parchment paper.",
            "3. Drizzle with olive oil and season with salt and pepper.",
            "4. Squeeze fresh lemon juice over the salmon.",
            "5. Sprinkle with chopped fresh dill.",
            "6. Bake for 12-15 minutes, or until salmon is cooked through.",
            "7. Serve hot with your favorite sides."
        };
        Categories = new List<string> { "Fish" };
        rp.Recipe(pic[61], "Salmon with Lemon and Dill", Ingredients, Instructions, Categories);
        DB.Add(rp);

        rp = ScriptableObject.CreateInstance<Recipes>();
        Ingredients = new List<string>
        {
            "White fish fillets (such as tilapia or cod)",
            "Taco seasoning",
            "Corn tortillas",
            "Mango",
            "Red onion",
            "Cilantro",
            "Lime juice",
            "Salt",
            "Pepper",
            "Avocado (optional)"
        };
        Instructions = new List<string>
        {
            "1. Preheat oven to 400∞F (200∞C).",
            "2. Season fish fillets with taco seasoning.",
            "3. Bake for 10-12 minutes, or until fish is cooked through.",
            "4. While fish is baking, prepare the mango salsa by combining diced mango, red onion, cilantro, lime juice, salt, and pepper.",
            "5. Warm tortillas.",
            "6. Flake cooked fish and serve in tortillas with mango salsa and optional avocado slices.",
        };
        Categories = new List<string> { "Fish", "Mexican" };
        rp.Recipe(pic[62], "Fish Tacos with Mango Salsa", Ingredients, Instructions, Categories);
        DB.Add(rp);

        rp = ScriptableObject.CreateInstance<Recipes>();
        Ingredients = new List<string>
        {
            "Cod fillets",
            "Parmesan cheese",
            "Bread crumbs",
            "Olive oil",
            "Lemon juice",
            "Garlic powder",
            "Salt",
            "Pepper"
        };
        Instructions = new List<string>
        {
            "1. Preheat oven to 400∞F (200∞C).",
            "2. In a bowl, combine Parmesan cheese, bread crumbs, olive oil, lemon juice, garlic powder, salt, and pepper.",
            "3. Place cod fillets on a baking sheet.",
            "4. Press Parmesan mixture onto the top of each fillet.",
            "5. Bake in preheated oven for 15-20 minutes, or until fish is cooked through and flakes easily with a fork."
        };
        Categories = new List<string> { "Fish" };
        rp.Recipe(pic[63], "Baked Cod with Parmesan Crust", Ingredients, Instructions, Categories);
        DB.Add(rp);

    }
}
