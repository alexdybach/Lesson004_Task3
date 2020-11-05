using System;

namespace Lesson004_Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Marco\nAnswer:");
            string answer = Console.ReadLine();
            if (answer == "polo" || answer == "Polo" || answer == "POLO" || answer == "pOLO")
                Console.WriteLine("Correct Answer!");
            else if (answer == "" || answer == " ")
                Console.WriteLine("Empty line!");
            else
                Console.WriteLine("Incorrect!");

        }
    }
}
