using System;

public class Program
{
    static void Main(string[] args)
    {
        Printer();

        Console.WriteLine(Calc());

        Console.WriteLine(add(10, 10));

        Names("Sri");
        Names("Akila");
        Names("Jayu");

        Calculator(25, 10);
    }

    public static void Names(string name)
    {
        Console.WriteLine($"I'm, {name}");
    }


    //Parameterized function
    public static int add(int x, int y)
    {
        int z = x + y;
        return z;
    }
    //Return type function
    public static int Calc()
    {
        int number_1 = 100;
        int number_2 = 10;
        int res = number_1 * number_2;
        return res;
    }
    //Non-return type function
    public static void Printer()
    {
        int num1 = 10;
        int num2 = 20;
        int num3 = num1 + num2;
        Console.WriteLine(num3);
        Console.WriteLine("From Function");
        //Console.ReadKey();
    }



    public static void Calculator(int num1, int num2)
    {
        var res = num1 + num2;
        Console.WriteLine($"Addition :  {res}");
        res = num1 - num2;
        Console.WriteLine($"Subtraction :  {res}");
        res = num1 * num2;
        Console.WriteLine($"Multiplication :  {res}");
        res = num1 / num2;
        Console.WriteLine($"Division :  {res}");
        res = num1 % num2;
        Console.WriteLine($"Modulo :  {res}");

    }
}