using System.Collections.Generic;
using System.Text;

namespace PizzaStore.Domain.Models
{
    public class Pizza
    {
        // STATE
        // fields
        // properties

        //string imageUrl = "";
        private const double _diameter = 0;
        private static string _name = "pizza";
        public List<string> _toppings = new List<string>();
        
        private double CostOfPizza;

        public string Size = "";
        public string Crust = "";
        public List<string> Toppings
        {
            get
            {
                return Toppings1;
            }
        }

        public double ComputePricing()
        {
            if(Size == "Small")
            {
                CostOfPizza = 5.00;

            }
            else if (Size == "Medium")
            {
                CostOfPizza = 8.00;

            }
            else if (Size == "Large")
            {
                CostOfPizza = 12.00;

            }
            else
            {
                System.Console.WriteLine();
                System.Console.WriteLine("We're not sure what happend");
                System.Console.WriteLine("but your pizza doesn't have a size or price.");
                CostOfPizza = 0;
            }
            return CostOfPizza;
        }

        public List<string> Toppings1 { get => _toppings; set => _toppings = value; }


        // BEHAVIOR
        // methods
        // constructors
        // finalizers
        public Pizza(string size, string crust, List<string> toppings)
        {
            Size = size;
            Crust = crust;
            Toppings.AddRange(toppings);

        }
        public Pizza()
        {
            Size = "";
            Crust = "";
            // intentionally empty
        }

        void AddToppings(string topping)
        {
            Toppings.Add(topping);
        }


        public override string ToString()
        {
            var sb = new StringBuilder();

            foreach(var t in Toppings)
            {
                sb.Append(t + ", ");
            }
            return $"{Crust} \n{Size} \n{sb}";
        }

    }
}