using System.Collections.Generic;
using PizzaStore.Domain.Models;
using System;

namespace PizzaStore.Client
{
    public class Startup
    {
        public Order CreateOrder(User user, Store store)
        {
            try
            {
                var order = new Order();


                user.Orders.Add(order);
                store.Orders.Add(order);
                
                return order;
            }
            catch
            {
                throw new System.Exception("we messed up");
                //return null;
            }
            finally
            {
                //GC.GetGeneration(user);
                GC.Collect();
            }
        }
        internal static void PrintMenu()
        {
            System.Console.WriteLine();
            System.Console.WriteLine("Select 1 for Pepperoni and Sausage Pizza");
            System.Console.WriteLine("Select 2 for Anchovies and Mushroom Pizza");
            System.Console.WriteLine("Select 3 for Pineapple and Ham Pizza");
            System.Console.WriteLine("Select 4 for Custom Pizza");
            System.Console.WriteLine("Select 5 to display your order");
            System.Console.WriteLine("Select 6 to remove Pizza");
            System.Console.WriteLine("Select 7 to exit");
            //System.Console.WriteLine();
        }

        internal static void PrintSizes()
        {
            System.Console.WriteLine();
            System.Console.WriteLine("Select 1 for a Small Pizza for $5.00");
            System.Console.WriteLine("Select 2 for a Medium Pizza for $8.00");
            System.Console.WriteLine("Select 3 for a Large Pizza for $12.00");
        }

        internal static void PrintCrust()
        {
            System.Console.WriteLine();
            System.Console.WriteLine("Select 1 for Thin Crust");
            System.Console.WriteLine("Select 2 for Regular Crust");
            System.Console.WriteLine("Select 3 for Deep dish Crust");
        }

        internal static void PrintToppings()
        {
            System.Console.WriteLine();
            System.Console.WriteLine("Select 1 for Pepperoni");
            System.Console.WriteLine("Select 2 for Sausage");
            System.Console.WriteLine("Select 3 for Pineapple");
            System.Console.WriteLine("Select 4 for Ham");
            System.Console.WriteLine("Select 5 for Bacon");
            System.Console.WriteLine("Select 6 when you are done");
            
        }
    }
}