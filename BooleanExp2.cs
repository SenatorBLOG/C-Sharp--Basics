xusing System;

namespace NumberConverter
{
    class Program
    {
        static void Main(string[] args)


        {
            double userValue1, userValue2, reaterNum;
            string signStr;

            userValue1 = GetUserInput("Enter the first number: ");
            userValue2 = GetUserInput("Enter the second number: ");
            signStr=CheckSign(userValue1);
            greaterNum=GreaterNumber(userValue1, userValue2);
            Console.WriteLine($"Between {userValue1} and {userValue2}, {greaterNum} is greater");
            Console.WriteLine($"{userValue1} is {signStr}.");
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

        static double GreaterNumber(double number1, double number2)
        {
            if (number1 > number2)
            {
                return number1;
            }
            else
            {
                return number2;
            }
        }
    }
}