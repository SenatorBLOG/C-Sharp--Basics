using System;

namespace NumberConverter
{
    class Program
    {
        static void Main(string[] args)
        {

            int userInput=GetUserInput("Enter a decimal value between 1 to 10:  ");

            string romanNumeral=ConvertToRoman(userInput);

            if (romanNumeral != "Error")
            {
                Console.WriteLine($"The Roman numeral equivalent of {userInput} is {romanNumeral}");
            }
            else
            {
                Console.WriteLine($"Error: The numeric is outside of the acceptavle range.");
            }

            Console.ReadKey();
        }

        static int GetUserInput(string prompt)
        {
            Console.Write(prompt);
            int userValue = int.Parse(Console.ReadLine());

            return userValue;
        }

        static string ConvertToRoman (int number)
        {
            if (number < 1 || number > 10)
            {
                return "Error";
            }

            string[] romanNumerals = {"I","II","III", "IV", "V", "VI", "VII", "VIII", "IX", "X" };

            return romanNumerals [number - 1];
            }
            
        }

        static st
    }
        
