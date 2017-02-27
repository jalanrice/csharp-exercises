using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C2Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, double> students = new Dictionary<string, double>();
            string newStudent;

            Console.WriteLine("Enter your students (or ENTER to finish):");
            do
            {
                Console.Write("name: ");
                newStudent = Console.ReadLine();
                if (newStudent != "")
                {
                    // Get the student's grade
                    Console.Write("grade: ");
                    double newGrade = double.Parse(Console.ReadLine());

                    students.Add(newStudent, newGrade);
                }
            }
            while (newStudent != "");

            // Print class roster
            Console.WriteLine("\nClass roster:");
            StringBuilder roster = new StringBuilder();


            foreach (KeyValuePair<string, double> student in students)
            {
                roster.Append(student.Key + " (" + student.Value.ToString() + ")\n");
            }

            double sum = students.Values.Sum();
            double avg = sum / students.Count;
            Console.WriteLine(roster);
            Console.WriteLine("Average grade: " + avg);

            Console.ReadLine();
        }
    }
}
