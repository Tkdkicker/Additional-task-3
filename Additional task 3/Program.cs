using System;

namespace Additional_task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a day of the week");
            string userInput = Console.ReadLine();

            switch (userInput)
            {
                case "Monday":
                    Console.WriteLine("You chose " + userInput);
                    break;
                case "Tuesday":
                    Console.WriteLine("You chose " + userInput);
                    break;
                case "Wednesday":
                    Console.WriteLine("You chose " + userInput);
                    break;
                case "Thursday":
                    Console.WriteLine("You chose " + userInput);
                    break;
                case "Friday":
                    Console.WriteLine("You chose " + userInput);
                    break;
                case "Saturday":
                    Console.WriteLine("You chose " + userInput);
                    break;
                case "Sunday":
                    Console.WriteLine("You chose " + userInput);
                    break;
            }
        }
    }
}
