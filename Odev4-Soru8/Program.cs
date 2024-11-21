// See https://aka.ms/new-console-template for more information
using System.ComponentModel.DataAnnotations;

class program
{
    public static void Main()
    {

        string[] dizi = { "Ahmet", "Mehmet", "Hamza", "Yüksel", "Mustafa", "Muhammed" };

        
        List <string> list = new List<string>();

        list = metod.List(dizi);

        foreach (string s in list)
        {
            Console.WriteLine(s);
        }




    }
}


class metod
{
    public static List<string> List(string[] dizi)
    {
        List<string> list1 = new List<string>();
        foreach (string d in dizi)
        {
            if (d.Length > 5)
            {
                list1.Add(d);
            }
        }
        return list1;
    }
}

