using System;

class program11
{
    public static void Main()
    {
        Console.WriteLine("Escribe algo:");

        string varString = Console.ReadLine();
        string varStringResult = "";

        for (int i = varString.Length - 1; i >= 0; i--)
        {
            varStringResult += varString[i];
        }

        Console.WriteLine("el texto es: " + varStringResult);
    }
}
