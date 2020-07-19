using System.Collections.Generic;
using System.Text;

namespace PizzaStore.Domain.Models
{
    public class Pizza
    {
        // STATE
        // fields
        // properties

        string imageUrl = "";
        private const double _diameter = 0;
        private static string _name = "pizza";
        private List<string> _toppings = new List<string>();


        public string Size = "";
        public string Crust = "";
        public List<string> Toppings
        {
            get
            {
                return _toppings;
            }
        }


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