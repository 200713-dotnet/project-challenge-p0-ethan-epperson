using System.Collections.Generic;
using System;

namespace PizzaStore.Domain.Models
{
    public class Order
    {
        public List<Pizza> Pizzas { get; set;}

        public DateTime DateOrdered {get; set;}

        private int NumberOfPizzasOrdered;
        
        public void CreatePizza(string size, string crust, List<string> toppings)
        {
           if(NumberOfPizzasOrdered < 50)
           {
                Pizzas.Add(new Pizza(size, crust, toppings));
                NumberOfPizzasOrdered = NumberOfPizzasOrdered + 1;
           }
           else
           {
               System.Console.WriteLine("Sorry we can't make more then 50 pizzas at a time.");
           }
        }

        public void DestroyPizza(int i)
        {
            i = i - 1;
            Pizzas.RemoveAt(i);
            NumberOfPizzasOrdered = NumberOfPizzasOrdered - 1;
        }
/*
        public void DisplayOrder()
        {
            foreach(var pizza in Pizzas)
            {
                System.Console.WriteLine();
                System.Console.WriteLine(pizza);
                
            }
        }
*/


        public Order()
        {
            Pizzas = new List<Pizza>();
            NumberOfPizzasOrdered = 0;
        }
    }
}
