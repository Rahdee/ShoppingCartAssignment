using System;
using System.Collections.Generic;
using ShoppingLibrary1;

namespace ShoppingCartApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ShoppingCart cart = new ShoppingCart();

            Entertainment entertainment = new Entertainment("Nintendo 3DS", 2500.99);
            cart.AddShoppingCartItems(entertainment);

            entertainment = new Entertainment("Nintendo 2DS", 1500.99);
            cart.AddShoppingCartItems(entertainment);

            Sportsequipment sportsequipment = new Sportsequipment("Dumbellbar", 500.00);
            cart.AddShoppingCartItems(sportsequipment);

            sportsequipment = new Sportsequipment("Kettlebell", 400.99);
            cart.AddShoppingCartItems(sportsequipment);

            sportsequipment = new Sportsequipment("weight plate", 250.00);
            cart.AddShoppingCartItems(sportsequipment);


            // This displays a list of my items

            List<ShoppingCartItem> MyCartItems = cart.MyCartItems();

            foreach (ShoppingCartItem item in MyCartItems)
            {
                Console.WriteLine (item.product() + "\t\t" + item.Price());
            }

            Console.WriteLine("");

            Console.WriteLine ("Subtotal:\t\t" + cart.GetSubtotal());

            Console.WriteLine("");

            Console.WriteLine("GetVAT:\t\t\t" + cart.GetVAT());
        }
    }
}
