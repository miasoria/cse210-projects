using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your first name?");
        string name = Console.ReadLine();
        
        Console.Write("What is your second name?");
        string surname = Console.ReadLine();

        Console.WriteLine($"Your name is {surname}, {name} {surname}");
    }
}