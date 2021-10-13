using System;
using System.Collections.Generic;
using System.Text;
using Antra.CartApp.Service;

namespace Antra.CartApp.ConsoleApp
{
    public class ManageCart
    {
        CartService cs;
        public ManageCart()
        {
            cs = new CartService();
        }

        public void AddItemToCart(string item, int count)
        {
            if (item.Equals("Apple"))
            {
                for (int i = 0; i < count; i++)
                {
                    cs.AddApple();
                }
            }
            else if (item.Equals("Orange"))
            {
                for (int i = 0; i < count; i++)
                {
                    cs.AddOrange();
                }
            }
            else
            {
                Console.WriteLine("Invalid Input");
            }
        }

        public string checkoutCart()
        {
            return cs.checkout();
        }

        public void add() { 
            
        }
        public void Run()
        {
            Console.WriteLine("Wanna to add an item or checkout");
            Console.WriteLine("Please enter \"add\" or \"checkout\"");

            string option = Console.ReadLine();
            if (option.Equals("add"))
            {
                Console.WriteLine("What do you wnat to add to the cart?");
                Console.WriteLine("Enter \"Apple\" or \"Orange\"");
                string item = Console.ReadLine();
                Console.WriteLine("How many do you want to add?");
                Console.WriteLine("Enter an integer number");
                int quantity = Convert.ToInt32(Console.ReadLine());

                AddItemToCart(item, quantity);

                Run();

            }
            else if (option.Equals("checkout"))
            {
                Console.Write("Your total is ");
                Console.Write(checkoutCart());
            }
            else
            {
                Console.WriteLine("Lets try this again");

                Run();
            }
            
        }
    }
}
