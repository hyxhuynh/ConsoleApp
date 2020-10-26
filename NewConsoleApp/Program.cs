using System;

namespace NewConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, what is your name?");
            var name = Console.ReadLine();
            Console.WriteLine("Hi " + name);
            Console.WriteLine("How old are you?");
            var age = Console.ReadLine();
            Console.WriteLine(name + " is " + age + " years old. Is it correct? (Y/N)");
            var confirmation = Console.ReadLine().ToLower();

            while (confirmation == "n")
            {
                Console.WriteLine("How old are you?");
                age = Console.ReadLine();
                Console.WriteLine(name + " is " + age + " years old. Is it correct? (Y/N)");
                confirmation = Console.ReadLine().ToLower();
            }

            if (confirmation == "y")
            {
                Console.WriteLine(name + " is " + age + " years old.");
                Console.WriteLine("Thank you for inputing your information!");
            }
        }
    }
}
