// C#

using System;

class Program
{
    static void Main(string[] args)
    {
        //! ask for first name and store it in a variable
        Console.WriteLine("Hello Prep1 World!");
        Console.WriteLine("What is your First Name?");
        string firstName = Console.ReadLine();

        //! ask for last name and store it in a variable
        Console.WriteLine("What is your Last Name?");
        string lastName = Console.ReadLine();

    //! print the full name in the format "last name, first name last name"
        Console.WriteLine($"Your name is {lastName}, {firstName} {lastName}");
    }
}