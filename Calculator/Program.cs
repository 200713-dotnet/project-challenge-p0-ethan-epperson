using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to our Basic Calculator");
            var stay = true;
            do
                {
                Console.WriteLine("Menu");
                System.Console.WriteLine("Press 1 for Addition");
                System.Console.WriteLine("Press 2 for Subtraction");
                System.Console.WriteLine("Press 3 for Multiplication");
                System.Console.WriteLine("Press 4 for Division");
                System.Console.WriteLine("Press 5 to exit");

                var operatorInput = Console.ReadLine();

                switch(operatorInput)
                {
                    case "1": 
                    // var input1 = Console.ReadLine();
                    // var input2 = Console.ReadLine();
                        
                        var inputAdd1 = double.Parse(Console.ReadLine()); //explicit parsing with 0
                        double inputAdd2;
                        double.TryParse(Console.ReadLine(), out inputAdd2); //explicit parsing with boolean exception

                        Add(inputAdd1,inputAdd2);
                        break;

                    case "2":
                        double inputSub1;
                        double inputSub2;

                        if (double.TryParse(Console.ReadLine(), out inputSub1))
                        {
                            System.Console.WriteLine("valid");
                        }
                        else
                        {
                            System.Console.WriteLine("not valid");
                        }

                        if (double.TryParse(Console.ReadLine(), out inputSub2))
                        {
                            System.Console.WriteLine("valid");
                        }
                        else
                        {
                            System.Console.WriteLine("not valid");
                        }
                        Subtract(inputSub1,inputSub2);
                        break;
                    case "3":
                        break;
                    case "4":
                        break;
                    case "5":
                        stay = false;
                        break;

                }
            } while(stay);
            

            /*
            casting
            "2" -> 2.0
            "2a" -> error
            when it comes to casting thing of actors/actessress. They are not
            the characters but they are representing the characters

            parsing
            "2a" -> 2.0
            */
        }
    static void Add(double operand1, double operand2)
    {
        var result = operand1 + operand2;
        System.Console.WriteLine($"Your result is: {result}");


    }

    static void Subtract(double operand1, double operand2)
    {
        var result = operand1 - operand2;
        System.Console.WriteLine("Your result is: " + result);
    }

    static void Multiply()
    {

    }

    static void divide()
    {

    }
    }


}
