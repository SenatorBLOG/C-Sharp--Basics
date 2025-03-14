using System.Diagnostics.CodeAnalysis;
using static System.Console;
namespace Lecture8
{

    class Program
    {
        static void Main(string[] args)
        {
            //objects and classes
            // object oriented programming

            string userInput;
            string[] strGrades;
            float average;

            Student student1 = new Student();

            Write("Enter the name of the student:  ");
            //student1.name = ReadLine();
            student1.SetName = (ReadLine());

            Write("Enter the age of the student:  ");
            int.TryParse(ReadLine(), out student1.Age);

            Write("IS  student married? (Y/N)  ");
            userInput = ReadLine();
            if (userInput.ToUpper() == "Y")
            {
                student1.Married = true;
            }
            else
            {
                student1.Married = false;
            }
            
            
            Write("Enter 5 grades");
            userInput = ReadLine();
            strGrades = userInput.Split('.');

            for (int i = 0; i < strGrades.Length; i++)
            {
                float.TryParse(strGrades[i], out student1.Grades[i]);
            }
            
            average = student1.CalcAvg(student1.Grades);
            Write($"The average is {average}");
        }
    }


    class Student
    {
        private string name; // filed , data member

        public int Age { set; get; }

        public bool Married {  set; get; }

        public float[] Grades = new float[5];

        public string Name
        {
            get
            {
                if (name != "")
                    return name;
                else
                    return "";
            }
            set
            {
                name = value;
            }
        }
                   
        string GetName()
        {
            if (name != "")
                return name;
            else 
                return "";
        }
        public void SetName(string n)
            { name = n; }

        static public float CalcAvg(float[] numbers)
         {
            float sum = 0;
            foreach (float number in numbers)
            {
                sum += number;
            }
            return sum / numbers.Length;
         }
    }
}