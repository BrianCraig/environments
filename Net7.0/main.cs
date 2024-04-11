using System;

class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Running the 5 turns");
        Console.WriteLine("Turn 1 output");
        Console.WriteLine("----------------");
        Answer1.Program.Main(Array.Empty<string>());
        Console.WriteLine("----------------");
        Console.WriteLine("Turn 2 output");
        Console.WriteLine("----------------");
        Answer2.Program.Main(Array.Empty<string>());
        Console.WriteLine("----------------");
        Console.WriteLine("Turn 3 output");
        Console.WriteLine("----------------");
        Answer3.Program.Main(Array.Empty<string>());
        Console.WriteLine("----------------");
        Console.WriteLine("Turn 4 output");
        Console.WriteLine("----------------");
        Answer4.Program.Main(Array.Empty<string>());
        Console.WriteLine("----------------");
        Console.WriteLine("Turn 5 output");
        Console.WriteLine("----------------");
        Answer5.Program.Main(Array.Empty<string>());
        Console.WriteLine("----------------");
    }
}