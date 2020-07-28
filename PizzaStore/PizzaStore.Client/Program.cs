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
            System.Console.WriteLine("Welcome to The Kool Kidz Pizza");
            System.Console.WriteLine("Where all the Kool Kidz eat pizza");
            System.Console.WriteLine();

            var startup = new Startup();
            var user = new User();

            string name1 = "Super";
            string name2 = "Duper";
            System.Console.WriteLine("Which Store would you like to use?");
            System.Console.WriteLine($"Press 1 for {name1}");
            System.Console.WriteLine($"Press 2 for {name2}");

           //var cart = new string[3];

            List<Pizza> cart = new List<Pizza>();
            //Menu(cart);
            
            var store = new Store(name1);
            var store2 = new Store(name2);
            int storeSelect;

            int.TryParse(Console.ReadLine(), out storeSelect);
            if (storeSelect == 1)
            {
                try
                {
                    Menu(startup.CreateOrder(user, store));
                }
                catch(Exception ex)
                {
                    System.Console.WriteLine(ex);
                }
            } else if (storeSelect == 2)
            {
                try
                {
                    Menu(startup.CreateOrder(user, store2));
                }
                catch(Exception ex)
                {
                    System.Console.WriteLine(ex);
                }
            }
        }

        static void Menu(Order order)
            {
                var exit = false;
                //double totalCost = 0;

                do
                {   
                    System.Console.WriteLine("What kind of Pizza would you like?");
                    Startup.PrintMenu();
                    int selectPizza;
                    int selectSize;
                    int selectCrust;
                    //string chosenSize = "";
                    //string chosenCrust = "";
                    int.TryParse(Console.ReadLine(), out selectPizza);
                    

                    switch (selectPizza)
                    {
                        
                        case 1:
                            string chosenSize = "";
                            string chosenCrust = "";
                            Startup.PrintSizes();
                            int.TryParse(Console.ReadLine(), out selectSize);
                            switch (selectSize)
                            {
                                case 1:
                                    chosenSize = "Small";                        
                                    break;

                                case 2:
                                    chosenSize = "Medium";
                                    break;
                                case 3:
                                    chosenSize = "Large";
                                    break;
                                default:
                                    System.Console.WriteLine();
                                    System.Console.WriteLine("Uhh... so... a Medium then.");
                                    chosenSize = "Medium";
                                    break;
                            }
                            Startup.PrintCrust();
                            int.TryParse(Console.ReadLine(), out selectCrust);
                            switch (selectCrust)
                            {
                                case 1:
                                    chosenCrust = "Thin";
                                    break;
                                case 2:
                                    chosenCrust = "Regular";
                                    break;
                                case 3:
                                    chosenCrust = "Deepdish";
                                    break;
                                default:
                                    System.Console.WriteLine();
                                    System.Console.WriteLine("Uhh... so... a regular crust then.");
                                    chosenCrust = "Regular";
                                    break;
                            }
                            System.Console.WriteLine();
                            System.Console.WriteLine($"Add a {chosenSize} Pepperioni and Sausage Pizza");
                            System.Console.WriteLine($"with {chosenCrust} crust to your order?");
                            System.Console.WriteLine("Select 1 for yes");
                            System.Console.WriteLine("Select 2 for no");
                            int confirmOrder;
                            int.TryParse(Console.ReadLine(), out confirmOrder);
                            switch(confirmOrder)
                            {
                                case 1:
                                    order.CreatePizza(chosenSize,chosenCrust, new List<string>{"Pepperoni","Sausage"});
                                    break;
                                case 2:
                                    break;
                            }

                            break;
                        case 2:
                            System.Console.WriteLine();
                            System.Console.WriteLine("Eww... No man you don't want to order that");
                            System.Console.WriteLine("You want to go back and select 1 instead.");
                            System.Console.WriteLine("You can thank us later!");
                            //System.Console.WriteLine();                     
                            break;
                        case 3:
                            Startup.PrintSizes();
                            int.TryParse(Console.ReadLine(), out selectSize);
                            chosenSize = "";
                            chosenCrust = "";
                            switch (selectSize)
                            {
                                case 1:
                                    chosenSize = "Small";
                                    break;

                                case 2:
                                    chosenSize = "Medium";
                                    break;
                                case 3:
                                    chosenSize = "Large";
                                    break;
                                default:
                                    System.Console.WriteLine();
                                    System.Console.WriteLine("Uhh... so... a Medium then.");
                                    chosenSize = "Medium";
                                    break;
                            }
                            Startup.PrintCrust();
                            int.TryParse(Console.ReadLine(), out selectCrust);
                            switch (selectCrust)
                            {
                                case 1:
                                    chosenCrust = "Thin";
                                    break;
                                case 2:
                                    chosenCrust = "Regular";
                                    break;
                                case 3:
                                    chosenCrust = "Deepdish";
                                    break;
                                default:
                                    System.Console.WriteLine();
                                    System.Console.WriteLine("Uhh... so... a regular crust then.");
                                    chosenCrust = "Regular";
                                    break;
                            }
                            System.Console.WriteLine();
                            System.Console.WriteLine($"Add a {chosenSize} Pineapple and Ham Pizza");
                            System.Console.WriteLine($"with {chosenCrust} crust to your order?");
                            System.Console.WriteLine("Select 1 for yes");
                            System.Console.WriteLine("Select 2 for no");
                            //int confirmOrder;
                            int.TryParse(Console.ReadLine(), out confirmOrder);
                            switch(confirmOrder)
                            {
                                case 1:
                                    order.CreatePizza(chosenSize,chosenCrust, new List<string>{"Pineapple","Ham"});
                                    break;
                                case 2:
                                    break;
                            }
                            break;

                        case 4:
                            Startup.PrintSizes();
                            int.TryParse(Console.ReadLine(), out selectSize);
                            List<string> customToppings = new List<string>();

                            chosenSize = "";
                            chosenCrust = "";

                            switch (selectSize)
                            {
                                case 1:
                                    chosenSize = "Small";
                                    break;

                                case 2:
                                    chosenSize = "Medium";
                                    break;
                                case 3:
                                    chosenSize = "Large";
                                    break;
                                default:
                                    System.Console.WriteLine();
                                    System.Console.WriteLine("Uhh... so... a Medium then.");
                                    chosenSize = "Medium";
                                    break;
                            }
                            Startup.PrintCrust();
                            int.TryParse(Console.ReadLine(), out selectCrust);
                            switch (selectCrust)
                            {
                                case 1:
                                    chosenCrust = "Thin";
                                    break;
                                case 2:
                                    chosenCrust = "Regular";
                                    break;
                                case 3:
                                    chosenCrust = "Deepdish";
                                    break;
                                default:
                                    System.Console.WriteLine();
                                    System.Console.WriteLine("Uhh... so... a regular crust then.");
                                    chosenCrust = "Regular";
                                    break;
                            }
                            bool doneToppings = false;
                            int numberOfToppings = 0;
                            System.Console.WriteLine("Which Toppings would you like?");
                            do
                            {
                                int selectTopping;
                                System.Console.WriteLine();
                                System.Console.WriteLine("Choose up to five toppings");
                                System.Console.WriteLine($"You have {numberOfToppings} so far");
                                Startup.PrintToppings();
                                int.TryParse(Console.ReadLine(), out selectTopping);
                                switch(selectTopping)
                                {
                                    case 1:
                                        customToppings.Add("Pepperoni");
                                        numberOfToppings = 1 + numberOfToppings;
                                        break;
                                    case 2:
                                        customToppings.Add("Sausage");
                                        numberOfToppings = 1 + numberOfToppings;
                                        break;
                                    case 3:
                                        customToppings.Add("Pineapple");
                                        numberOfToppings = 1 + numberOfToppings;
                                        break;
                                    case 4:
                                        customToppings.Add("Ham");
                                        numberOfToppings = 1 + numberOfToppings;
                                        break;
                                    case 5:
                                        customToppings.Add("Bacon");

                                        numberOfToppings = 1 + numberOfToppings;
                                        break;
                                    case 6:
                                        if (numberOfToppings > 1 )
                                        {
                                            doneToppings = true;
                                        }
                                        else
                                        {
                                            System.Console.WriteLine();
                                            System.Console.WriteLine("C'mon man, you need at least two toppings");
                                            System.Console.WriteLine("to make a good pizza.");
                                        }
                                        break;
                                    default:
                                        System.Console.WriteLine();
                                        System.Console.WriteLine("Sorry I didn't understand that.");
                                        break;
                                }


                            }while(!doneToppings && numberOfToppings < 5);



                            System.Console.WriteLine();
                            System.Console.WriteLine($"Add a {chosenSize} Custom Pizza");
                            System.Console.WriteLine($"with {chosenCrust} crust to your order?");
                            System.Console.WriteLine("Select 1 for yes");
                            System.Console.WriteLine("Select 2 for no");
                            //int confirmOrder;
                            int.TryParse(Console.ReadLine(), out confirmOrder);
                            switch(confirmOrder)
                            {
                                case 1:
                                    order.CreatePizza(chosenSize,chosenCrust, customToppings);
                                    break;
                                case 2:
                                    break;
                            }

                            break;
                        case 5:
                                DisplayCart(order);
                            break;
                        case 6:
                            int orderSize = order.Pizzas.Count;
                            if(orderSize > 0)
                            {
                                System.Console.WriteLine("Which pizza do you want to remove?");
                                DisplayCart(order);

                                int selectRemove;
                                //System.Console.WriteLine(orderSize);
                                int.TryParse(Console.ReadLine(), out selectRemove);
                                if (selectRemove <= orderSize && selectRemove > 0)
                                {
                                    order.DestroyPizza(selectRemove);
                                }
                                else
                                {
                                    System.Console.WriteLine();
                                    System.Console.WriteLine("Sorry we didn't understand that.");
                                }
                            }
                            else
                            {
                                System.Console.WriteLine();
                                System.Console.WriteLine("You need to order a pizza before you can remove one.");
                            }


                            break;
                        case 7:
                            var fmw = new FileManager();
                            fmw.Write(order);
                            
                            break;
                        case 8:
                            System.Console.WriteLine("goodbye!");
                            exit = true;
                            break;
                        case 9:
                            var fmr = new FileManager();
                            DisplayCart(fmr.Read());
                            break;
                        
                        
                            
                        
                    }
                } while (!exit);
                
            }
        
        static void DisplayCart(Order order)
        {
            double totalPrice = 0;
            int indexNumber = 0;
            foreach(var pizza in order.Pizzas)
            {
                indexNumber = indexNumber + 1;
                System.Console.WriteLine();
                System.Console.WriteLine($"#{indexNumber}");
                System.Console.WriteLine(pizza);
                System.Console.WriteLine($"${pizza.ComputePricing()}.00");
                totalPrice = totalPrice + pizza.ComputePricing();
                
            }
            System.Console.WriteLine();
            System.Console.WriteLine($"For a total of ${totalPrice}.00");
            System.Console.WriteLine();

        }
        
    }
}