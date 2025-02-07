using System;

class Program
{
   
    static string RevereseString(string input)
    {
        
        if (input.Length <= 1)
        {
            return input;
        }

        
        return input[input.Length - 1] + RevereseString(input.Substring(0, input.Length - 1));
    }

    static void Main()
    {
        Console.WriteLine("Adj meg egy szöveget:");
        string beker = Console.ReadLine();

        
        string forditott = RevereseString(beker);
        Console.WriteLine("A szöveg fordítottja: " + forditott);
    }
}