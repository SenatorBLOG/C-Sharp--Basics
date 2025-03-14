using System;

namespace NumberConverter
{
    class Program
    {
        static void Main(string[] args)


        {
            double userValue;
            string signStr;

            userValue = GetUserInput("Enter a number: ");
            signStr=CheckSign(userValue);
            Console.WriteLine($"{userValue} is {signStr}.");
            Console.ReadKey();
        }
        static double GetUserInput(string prompt)
        {
            string userInput;
            double userValue;
            Console.Write(prompt);
            userInput = Console.ReadLine();
            userValue = double.Parse(userInput);

            return userValue;
        }
        static string CheckSign(double number)
        {
            if (number > 0)
            {
                return "positive";
            }
            else if (number < 0)
            {
                return "negetive";
            }
            else 
            {
                return "zero";
            }
        }
    }
}