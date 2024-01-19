using System;
namespace ConsoleReadLine2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name?");

            // Reading user input
            string userName = Console.ReadLine();

            // Responding to user input
            Console.WriteLine("Hello, " + userName + "!");

            Console.WriteLine("What is your favorite color?");
            string favoriteColor = Console.ReadLine();

            // Responding with the favorite color
            Console.WriteLine("Ah, " + favoriteColor + " is a great color!");

            Console.WriteLine(userName + ", who likes " + favoriteColor + ", welcome to the program!");
        }
    }
}
