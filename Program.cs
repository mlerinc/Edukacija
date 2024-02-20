using System;
using System.Collections;

//Array List
public class Array
{
    public static void Main()
    {

        ArrayList myArrayList = new ArrayList();
        myArrayList.Add("Dwight");
        myArrayList.Add("Schrute");
        myArrayList.Add("Office");

        Console.WriteLine("myArrayList");
        Console.WriteLine(" Count: {0}", myArrayList.Count);
        Console.WriteLine(" Capacity: {0}", myArrayList.Capacity);
        Console.WriteLine(" IsReadOnly: {0}", myArrayList.IsReadOnly);
    }
}

// Sorted List
public class SortedList
{
    public static void Main()
    {
        SortedList<string, string> name = new SortedList<string,string>();
        SortedList mySortedList = new SortedList();
        name.Add("Dwight", "Schrute");
        name.Add("Michael", "Scott");
        name.Add("Jim", "Halpert");

        Console.WriteLine("employee of Dunder Mifflin:");
        foreach (var pair in name)
        {
            Console.WriteLine($"{pair.Key} {pair.Value}");
        }
    }
}



