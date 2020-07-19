using System;
using System.Collections.Generic;
using PizzaStore.Domain.Models;

namespace PizzaStore.Client
{
    class Program
    {
        static void Main()
        {
            Welcome();
        }
        static void Welcome()
        {
            System.Console.WriteLine("Welcome to PizzaWorld");
            System.Console.WriteLine("Best Pizza in the World");
            System.Console.WriteLine();

           //var cart = new string[3];

            List<Pizza> cart = new List<Pizza>();
            //Menu(cart);
            var startup = new Startup();
            var user = new User();
            var store = new Store();
            try
            {
                Menu(startup.CreateOrder(user, store));
            }
            catch(Exception ex)
            {
                System.Console.WriteLine(ex);
            }
        }

        static void Menu(Order order)
            {
                var exit = false;

                do
                {   
                    Startup.PrintMenu();
                    int select;

                    int.TryParse(Console.ReadLine(), out select);

                    switch (select)
                    {
                        case 1:
                            order.CreatePizza("L","Stuffed", new List<string>{"cheese"});                  
                            System.Console.WriteLine("added Cheese");
                            break;
                        case 2:
                            order.CreatePizza("L","Stuffed", new List<string>{"Pepperoni"});                          
                            System.Console.WriteLine("added Pepperoni");
                            break;
                        case 3:
                            order.CreatePizza("L","Stuffed", new List<string>{"Pinapple"});                           
                            System.Console.WriteLine("added Hawaiian");
                            break;
                        case 4:
                            order.CreatePizza("L","Stuffed", new List<string>{"Custom"});
                            System.Console.WriteLine("added Custom");
                            break;
                        case 5:
                                DisplayCart(order);
                            break;
                        case 6:
                            var fmw = new FileManager();
                            fmw.Write(order);
                            System.Console.WriteLine("goodbye!");
                            exit = true;
                            break;
                        case 7:
                            var fmr = new FileManager();
                            DisplayCart(fmr.Read());
                            break;
                            
                        
                    }
                } while (!exit);
                
            }
        static void DisplayCart(Order order)
        {
            foreach(var pizza in order.Pizzas)
            {
                System.Console.WriteLine(pizza);
            }
        }
        
    }
}
