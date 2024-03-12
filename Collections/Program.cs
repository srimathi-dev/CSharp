using System.Collections;


public class Collections
{
    static void Main(string[] args)
    {

        //Array 
        Console.WriteLine("------------------------ARRAY------------------------");
        int[] num = { 1, 2, 3, 4, 5 };

        Console.WriteLine("The numbers are : ");
        for (int i = 0; i < num.Length; i++)
        {
            Console.WriteLine(num[i]);
        }


        Console.WriteLine("Using foreach loop");
        foreach (int i in num)
        {
            Console.WriteLine(i);
        }

        //After changing value
        num[2] = 10;

        Console.WriteLine("After changing value");
        foreach (int i in num)
        {
            Console.WriteLine(i);
        }

        //ArrayList
        Console.WriteLine("---------------------------ARRAYLIST-------------------------");
        ArrayList dataBook = new ArrayList();
        dataBook.Add(500);
        dataBook.Add(1000);
        dataBook.Add("Sri");
        dataBook.Add("Mathi");
        dataBook.Add(22.0f);
        dataBook.Add(false);

        foreach (var item in dataBook)
        {
            Console.WriteLine(item);
        }

        Console.WriteLine("After Removing");

        dataBook.RemoveRange(2, 2);

        foreach (var item in dataBook)
        {
            Console.WriteLine(item);
        }

        //LIST
        Console.WriteLine("---------------LIST ----------------------------------");
        List<string> names = new List<string>();
        names.Add("Sri");
        names.Add("Mathi");
        names.Add("Jayu");
        names.Add("Akila");
        names.Add("Sai");
        names.Add("Ajju");

        foreach (var item in names)
        {
            Console.WriteLine(item);
        }

        Console.WriteLine("After Removing");

        names.RemoveRange(4, 2);
        foreach (var item in names)
        {
            Console.WriteLine(item);
        }



    }
}
















