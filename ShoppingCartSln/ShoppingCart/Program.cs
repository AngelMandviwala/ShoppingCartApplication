using ShoppingLibrary;
using System;
using System.Collections.Generic;

namespace ShoppingCartApp
{
    internal class Program
    {
        static void Main(string[] args)//display
        {
           var cart = new ShoppingCart();

            //construct the shopping cart item
            ShoppingCartItem shoppingCartItem = new ShoppingCartItem("xBox", 3950.99);
            //adds to the list
            cart.AddShoppingItem(shoppingCartItem);

            shoppingCartItem = new ShoppingCartItem("PS4", 5999.49);
            cart.AddShoppingItem(shoppingCartItem);

            shoppingCartItem = new ShoppingCartItem("Macbook", 25000);
            cart.AddShoppingItem(shoppingCartItem);

            shoppingCartItem = new ShoppingCartItem("Rice", 50);
            cart.AddShoppingItem(shoppingCartItem);
            
            //allows you to write the list to the console
            List<ShoppingCartItem> items = cart.GetShoppingCartItems();
            foreach(ShoppingCartItem item in items)
            {
                Console.Write(item.Name + "\t\t");
                Console.WriteLine(item.Price);
            }
            
            //writes the sub total and vat to the console
            Console.WriteLine("Sub Total: \t" + cart.GetSubTotal());
            Console.WriteLine("With VAT: \t" + cart.GetVat());
            
        }
        
    }
}
