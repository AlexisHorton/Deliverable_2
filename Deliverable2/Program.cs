using System;

namespace Deliverable2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hey, wassup? Whatcha wanna say to the bot?");
            string response = "";
            string previousResponse = "empty";

            while (response.ToLower() != "bye")
            {
                response = Console.ReadLine().ToLower();

                if (response == previousResponse)
                {
                    Console.WriteLine("Oops! You've already said that.");
                }
                else if (response == "sup")
                {
                    Console.WriteLine("I am good.");
                }
                else if (response == "hello")
                {
                    Console.WriteLine("Hi, good to see you! :)");
                }
                else if (response == "hello there")
                {
                    Console.WriteLine("General Kenobi.");
                }
                else if (response == "bye")
                {
                    Console.WriteLine("Good bye!");
                }
                else
                {
                    Console.WriteLine("Invalid response.");
                }
                Console.WriteLine("Wanna say something else?");
                previousResponse = response;
            }
        }
    }
}
