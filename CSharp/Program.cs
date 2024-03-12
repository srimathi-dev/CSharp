using System;

public class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter your age: ");
        string ageStr = Console.ReadLine();
        int age;

        bool res = int.TryParse(ageStr, out age);

        if (age > 10 && age < 50)
        {
            Console.WriteLine("Yayyy!!!,");

            if (age > 10 && age < 18)
            {
                Console.WriteLine("Allowed to travel in Rollercoster for 1 time!");
                Console.WriteLine("Allowed to eat Pizza once in 6 months");
                Console.WriteLine("Allowed to consume cool drinks once in a month!");
            }

            else if (age > 18 && age < 50)
            {
                Console.WriteLine("Allowed to travel in Rollercoster!");
                Console.WriteLine("Allowed to eat Pizzas");
                Console.WriteLine("Allowed to consume cool drinks!");
                Console.WriteLine("You are allowed to do everything with a proper limit!!!!!!");
            }

        }

        else
        {
            Console.WriteLine("Not Allowed to travel in Rollercoster!");
            Console.WriteLine("Not Allowed to eat Pizzas");
            Console.WriteLine("Not Allowed to consume cool drinks!");
        }

        string color = Console.ReadLine();

        switch (color.ToLower())
        {
            case "yellow":
                Console.WriteLine("Yellow");
                break;
            case "red":
                Console.WriteLine("red");
                break;
            case "blue":
                Console.WriteLine("blue");
                break;
            case "green":
                Console.WriteLine("green");
                break;
            default:
                Console.WriteLine("Invalid color");
                break;
        }
    }
}


