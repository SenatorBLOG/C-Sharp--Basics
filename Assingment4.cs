/*
 * Programmer: Mikhail Senatorov
 * Date: Fall 2024
 * Purpose: This program uses 5 methods for the assignment
 */

using System;
using static System.Console;

namespace WeightedAverageCalc
{
    class WAC
    {
        static void Main(string[] args)
        {
            // constant weights are defined here
            const float ASSIGNMENTS_PERCENTAGE = 0.2f;
            const float MIDTERM_EXAM_PERCENTAGE = 0.3f;
            const float QUIZ_PERCENTAGE = 0.1f;
            const float FINAL_EXAM_PERCENTAGE = 0.3f;

            // variables for storing the grades of a student
            float assignments;
            float midtermExam;
            float quiz1;
            float quiz2;
            float finalExam;


            bool isInputValid;  // For checking the validity of each input
            
            Title = "CSIS1175 - Assignment 3 - By Mikhail Senatorov";

            DisplayBanner("Total Weighted Average Calculator");

            // Call GetUserInput for each input and check validity directly in the if statement
            if (GetUserInput("Assignments", 0, 100, out assignments) &&
                GetUserInput("Midterm Exam", 0, 100, out midtermExam) &&
                GetUserInput("Quiz1", 0, 100, out quiz1) &&
                GetUserInput("Quiz2", 0, 100, out quiz2) &&
                GetUserInput("Final Exam", 0, 100, out finalExam))
            {
                // Total Weighted Average is sum of products of grades and their weight
                float totalWeightedAverage = 0;
                totalWeightedAverage += WeightedGrade(assignments, ASSIGNMENTS_PERCENTAGE);
                totalWeightedAverage += WeightedGrade(midtermExam, MIDTERM_EXAM_PERCENTAGE);
                totalWeightedAverage += WeightedGrade((quiz1 + quiz2), QUIZ_PERCENTAGE);
                totalWeightedAverage += WeightedGrade(finalExam, FINAL_EXAM_PERCENTAGE);

                WriteLine("\n");
                DisplayTableRow("Assessment", "Percentage", "Your Grade", " ");
                DisplayTableRow("--------------", "----------", "----------", " ");

                DisplayTableRow("Assignments", ASSIGNMENTS_PERCENTAGE, assignments, LetterGrade(assignments));
                DisplayTableRow("MidTerm Exam", MIDTERM_EXAM_PERCENTAGE, midtermExam, LetterGrade(midtermExam));
                DisplayTableRow("Quiz1", QUIZ_PERCENTAGE, quiz1, LetterGrade(quiz1));
                DisplayTableRow("Quiz2", QUIZ_PERCENTAGE, quiz2, LetterGrade(quiz2));
                DisplayTableRow("Final Exam", FINAL_EXAM_PERCENTAGE, finalExam, LetterGrade(finalExam));


                WriteLine("----------------------------------------");

                // Display the Floor value of totalWeightedAverage
                DisplayTableRow("Weighted Total", 1, (float)Math.Floor(totalWeightedAverage),LetterGrade(totalWeightedAverage));

                WriteLine("\n");

                float weightedExams = 0;  // Initialize weightedExams to 0
                weightedExams += WeightedGrade(midtermExam, MIDTERM_EXAM_PERCENTAGE);
                weightedExams += WeightedGrade((quiz1 + quiz2), QUIZ_PERCENTAGE);
                weightedExams += WeightedGrade(finalExam, FINAL_EXAM_PERCENTAGE);
                weightedExams /= 0.8f;

                // Display the Ceiling value of weightedExams
                WriteLine("\nThe Weighted Average Total on Exams (Midterm, Quizzes, Final exam) is {0:F2} ({1})", Math.Ceiling(weightedExams), LetterGrade((float)Math.Ceiling(weightedExams)));

                if (weightedExams >= 50)
                {
                    WriteLine("The student PASSES the course.");
                }
                else
                {
                    WriteLine("The student FAILS the course.");
                }
            }
            else
            {
                WriteLine("One or more inputs were invalid. Please check your grades and try again.");
            }

            Write("\nPress a key to quit...");
            ReadKey();
        }
        
        static bool GetUserInput(string textMessage, byte min, byte max, out float userInputValue)
        {
            Write($"Enter your grade for {textMessage}: ");
            bool fromParse = float.TryParse(ReadLine(), out userInputValue);  // Converts input from string to float

            if (!fromParse)
            {
                WriteLine($"Invalid input. Please enter a numeric value between {min} and {max}.");
                userInputValue = 0;  // Reset value to 0
                return false;
            }
            else if (userInputValue < min || userInputValue > max)
            {
                WriteLine($"Invalid input. Please enter a value between {min} and {max}.");
                userInputValue = 0;  // Reset value to 0
                return false;
            }
            else 
            return true;

        }

        static void DisplayBanner(string title)
        {
            Console.Write("\\***********************************************\\\n");
            Console.Write("\\\t\t\t\t\t\t\\\n");
            Console.Write($"\\\t\"{title}\"\t\\\n");
            Console.Write("\\\t\t\t\t\t\t\\\n");	
            Console.Write("\\***********************************************\\\n\n\n");
        }
        static void DisplayTableRow(string assessment, string percentage, string grade, string letterGrade)
        {
            Console.WriteLine("{0,18} {1,10} {2,8} {3,-2}", assessment, percentage, grade, letterGrade);
        }
        static void DisplayTableRow(string assessment, float percentage, float grade, string letterGrade)
        {
            Console.WriteLine("{0,18} {1,10:P0} {2,8:F2} {3,-2}", assessment, percentage, grade, letterGrade);
        }
        static float WeightedGrade(float grade, float percentage)
        {
            return grade * percentage;
        }
        static string LetterGrade(float grade)
        {
            if (grade < 50)
                return "F";
            else if (grade >= 50 && grade < 55)
                return "D";
            else if (grade >= 55 && grade < 60)
                return "C-";
            else if (grade >= 60 && grade < 65)
                return "C";
            else if (grade >= 65 && grade < 70)
                return "C+";
            else if (grade >= 70 && grade < 75)
                return "B-";
            else if (grade >= 75 && grade < 80)
                return "B";
            else if (grade >= 80 && grade < 85)
                return "B+";
            else if (grade >= 85 && grade < 90)
                return "A-";
            else if (grade >= 90 && grade < 95)
                return "A";
            else 
                return "A+";
        }


    }
}
    

