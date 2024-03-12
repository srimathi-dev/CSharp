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


        //Hashtable
        Console.WriteLine("---------------------------HASHTABLE---------------------------------");
        Hashtable data = new Hashtable();
        data.Add(1, "Sri");
        data.Add(2, 30);
        data.Add(3, 22);
        data.Add(4, "Sri"); // keys should be unique, values need not be unique
        data.Add(5, "Mathi");
        data.Add("6", 100);
        data.Add("7", null); // Key cannot be null, only value can be null

        Console.WriteLine(data);

        //foreach (var item in data)
        //{
        //    Console.WriteLine(item);
        //}

        foreach (DictionaryEntry item in data)
        {
            Console.WriteLine($"{item.Key} : {item.Value}");
        }

        Console.WriteLine("---------------------AFTER REMOVING--------------------------");
        data.Remove(4);
        data.Remove("7");


        foreach (DictionaryEntry item in data)
        {
            Console.WriteLine($"{item.Key} : {item.Value}");
        }

        Console.WriteLine("---------------------AFTER CLEARING--------------------------");

        data.Clear();

        foreach (DictionaryEntry item in data)
        {
            Console.WriteLine($"{item.Key} : {item.Value}");
        }

        Console.WriteLine("Data is cleared!!!!!!!!");


        //Dictionary

        Console.WriteLine("--------------------------DICTIONARY------------------------------");
        Dictionary<int, int> dict = new Dictionary<int, int>();
        dict.Add(1, 2);
        dict.Add(2, 3);
        dict.Add(3, 4);
        dict.Add(4, 5);

        for(int i = 0;i < dict.Count; i++)
        {
            Console.WriteLine($" KEY: {dict.Keys.ElementAt(i)} :  VALUE: {dict.Values.ElementAt(i)}");
        }


        Console.WriteLine("---------------------AFTER REMOVING--------------------------");
        dict.Remove(4);
        

        for (int i = 0; i < dict.Count; i++)
        {
            Console.WriteLine($" KEY: {dict.Keys.ElementAt(i)} :  VALUE: {dict.Values.ElementAt(i)}");
        }

        Console.WriteLine("---------------------AFTER CLEARING--------------------------");
        dict.Clear();

        Console.WriteLine("Cleared DICTIONARY!!!!!!!!!!!!!!!!!!!!!!");

        for (int i = 0; i < dict.Count; i++)
        {
            Console.WriteLine($" KEY: {dict.Keys.ElementAt(i)} :  VALUE: {dict.Values.ElementAt(i)}");
        }


    }
}
















