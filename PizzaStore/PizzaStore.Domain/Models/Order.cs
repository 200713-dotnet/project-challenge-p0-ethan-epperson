using System.Collections.Generic;
using System;

namespace PizzaStore.Domain.Models
{
    public class Order
    {
        public List<Pizza> Pizzas { get; set;}

        public DateTime DateOrdered {get; set;}

        private int NumberOfPizzasOrdered;

        private double TotalCostOfOrder;
        
        public void CreatePizza(string size, string crust, List<string> toppings)
        {
            if(NumberOfPizzasOrdered < 50)
            {
                Pizza p = new Pizza(size, crust, toppings);
                    if(TotalCostOfOrder + p.ComputePricing() < 250)
                    {
                        Pizzas.Add(p);
                        NumberOfPizzasOrdered = NumberOfPizzasOrdered + 1;
                        TotalCostOfOrder = TotalCostOfOrder + p.ComputePricing();
                    }
                    else
                    {
                        System.Console.WriteLine();
                        System.Console.WriteLine("Sorry but orders can't go over $250");
                        System.Console.WriteLine("Trust us, its for your own good.");

                    }
                        
            }
            else
            {
                System.Console.WriteLine();
                System.Console.WriteLine("Sorry we can't make more then 50 pizzas at a time.");
            }
            
        }

        public void DestroyPizza(int i)
        {
            i = i - 1;
            Pizza p = Pizzas[i];
            double removeCost = p.ComputePricing();
            Pizzas.RemoveAt(i);
            NumberOfPizzasOrdered = NumberOfPizzasOrdered - 1;
            TotalCostOfOrder = TotalCostOfOrder - removeCost;
            
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
            TotalCostOfOrder = 0;
        }
    }
}
