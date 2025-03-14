/*
 * Programmer: Mikhail Senatorov
 * Date: Fall 2024
 * Purpose: MidTerm Exam (Check if a number of 6 digits is symmetric or not)
 */

using System;
using static System.Console;

namespace MidTermExam
{
    class SymmetricNumberCheck
    {
        static void Main(string[] args)
        {
            int userValue;
            if(GetUserValue("Enter a 6-digit number", out userValue) && IsSixDigits(userValue))
            {
                if(IsSymmetric(userValue))
                {
                    WriteLine("The number is symmetric.");
                }
                else
                {
                    WriteLine("The number is not symmetric.");
                }
            }
            else
            {
                WriteLine("Invalid input. Enter a valid 6-digit number.");
            }
            Write("\nPress a key to quit...");
            ReadKey();
        } 
        static bool GetUserValue(string message, out int userInputValue)
        {
            Write($"{message}: ");
            bool isValid = int.TryParse(ReadLine(), out userInputValue);
            return isValid;
        }
        static bool IsSixDigits(int number)
        {
            return number >= 100000 || number <= 999999;
        }
        static bool IsSymmetric(int number)
        {
            string numberString = number.ToString();
            for (int i = 0; i<3; i++)
            {
                if (numberString[i] != numberString[5-i])
                {
                    return false;
                }
            }
            return true;
        }
    }
}
