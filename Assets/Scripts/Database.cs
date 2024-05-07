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
        List<string> Categories = new List<string> { "Pasta", "Italian" };
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
        Categories = new List<string> { "Pasta", "Italian" };

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
        Categories = new List<string> { "Pasta", "Italian", "Gluten-free" };

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

        rp.Recipe(pic[19], "Beef Buregers", Ingredients, Instructions, Categories);
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


    }
}
