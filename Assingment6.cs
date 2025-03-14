/* Mikhail Senatorov 300407626*/
using System.IO
using System.Diagnostics.CodeAnalysis;
using static System.Console;
namespace Arrays
{
class Program
{
	static void Main(string[] args)

	{
		const int NO_OF_COURSES = 5;
		int count;
		
		Student student = new Student(NO_OF_COURSES);
		
        FileStream fsTxt = new FileStream("grades.txt", FileMode.Open, FileAccess.Read);
        StreamReader txtReader = new StreamReader(fsTxt);
        
        FileStream fsBin = new FileStream("out.bin", FileMode.Open, FileAccess.Write);
        BinaryWriter bw = new BinaryWriter(fsBin);
        
        While (count < NO_OF_COURSES){
            
        }
        
        txtReader.Close();
        fsTxt.Close();
        
        
        
	}
}
class Student
{
	public string Name { get; set; }
	public float[] Grades { get; set; }
	public float GPA { get; set; }

	public void GetGPA();
	{
		float sum = 0;
		foreach (float grade in Grades)
		{
			sum += grade;
		}
		GPA = sum / Grades.Length;
	}


	public Student(int number)
	{
		Grades = new float[number];
	}
}
}
