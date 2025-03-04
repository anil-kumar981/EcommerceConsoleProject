using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace ecommerce
{
    internal class all_items
    {
        Dictionary<string, List<Dictionary<string, dynamic>>> items = new Dictionary<string, List<Dictionary<string, dynamic>>>
        {
            {
                "men", new List<Dictionary<string, dynamic>>
                {
                    new Dictionary<string, dynamic>
                    {
                        { "item", "shoes" },
                        { "brand", "Jordan" },
                        { "price", 3000 }
                    },
                    new Dictionary<string, dynamic>
                    {
                        { "item", "t-shirt" },
                        { "brand", "Nike" },
                        { "price", 1500 }
                    }
                }
            },
            {
                "women", new List<Dictionary<string, dynamic>>
                {
                    new Dictionary<string, dynamic>
                    {
                        { "item", "dress" },
                        { "brand", "Gucci" },
                        { "price", 8000 }
                    },
                    new Dictionary<string, dynamic>
                    {
                        { "item", "heels" },
                        { "brand", "Louis Vuitton" },
                        { "price", 5000 }
                    }
                }
            }
        };
        addToCart add = new addToCart();
        public void display()
        {
            foreach (var category in items)
            {
                Console.WriteLine($"Category: {category.Key}");
                foreach (var item in category.Value)
                {
                    Console.WriteLine($"  {item["item"]} by {item["brand"]} - ${item["price"]}");
                }
            }
            Console.WriteLine("For men's press 1 , For women's press 2 ");
            var choice = Console.ReadLine();
        
            while (true)
            {
                if (choice == "1")
                {
                    var menCategory = items["men"];
                    Console.WriteLine("MEN PRODUCTS : ");
                    foreach (var item in menCategory) { Console.WriteLine($"  {item["item"]} by {item["brand"]} - ${item["price"]}"); }
                    Console.WriteLine("Add To Cart\nFor shoes press 1 , and for t-shirt press 2 ");
                    var choice1= Console.ReadLine();
                    if (choice1 == "1") { add.additem(menCategory[0]); }  
                    else if (choice1 == "2") { add.additem(menCategory[1]); }
                    else { Console.WriteLine("Try again with valid input!"); }
                    Console.WriteLine("/----------------------/\n");
                    Console.WriteLine("Your Cart :- ");
                    cartItems();
                }
                else if (choice == "2")
                {
                    var womenCategory = items["women"];
                    Console.WriteLine("WOMEN PRODUCTS : ");
                    foreach (var item in womenCategory) { Console.WriteLine($"  {item["item"]} by {item["brand"]} - ${item["price"]}"); }
                    Console.WriteLine("For dress press 1 , and for heels press 2 ");
                    var choice1 = Console.ReadLine();
                    if (choice1 == "1") { add.additem(womenCategory[0]); }  
                    else if (choice1 == "2") { add.additem(womenCategory[1]); }
                    else { Console.WriteLine("Try again with valid input!"); }
                    Console.WriteLine("/----------------------/\n");
                    Console.WriteLine("Your Cart :- ");
                    cartItems();
                }
                else if (choice == "3") 
                { 
                    break;
                }
               else if (choice == "4")
                {
                    Console.WriteLine("/----------------------/\n");
                    Console.WriteLine("Your Cart :- ");
                    cartItems();
                }
                else
                { 
                    Console.WriteLine("Invalid input! Please press correct button! "); 
                }
               
                Console.WriteLine("\nFor EXIT PRESS 3 :, For Continue with Men's press 1, for Women's press 2 , for viewing the cart press 4 \n");
                choice = Console.ReadLine();
              
            }
        }
        public void cartItems()
        {
            add.display();
        }
    }
}
