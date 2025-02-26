//! C#

using System;

class Program{
    static void Main(string[]arg)
    {
        Concsole.WriteLine("What is your name?");
        string name  = Console.ReadLine();

        Concsole.WriteLine("How old are you?");
        int age = Convert.ToInt32(Console.ReadLine());

        Concsole.WriteLine("what is your height?");
        double height = Convert.ToDouble(Console.ReadLine());

        Concsole.WriteLine("What is your weight?");
        double weight = Convert.ToDouble(Console.ReadLine());

        Conscole.WriteLine($"your name is {name} and you are {age} years old. You are {height} meters tall and weigh {weight} kg.");
    }
}