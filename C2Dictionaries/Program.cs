using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C2Dictionaries
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> students = new Dictionary<int, string>();
            string newName;

            Console.WriteLine("Enter your students (or ENTER to finish):");
            do
            {
                Console.Write("Student's name: ");
                newName = Console.ReadLine();

                if (newName != "")
                {
                    Console.Write("Student's ID: ");
                    int newStudentID = int.Parse(Console.ReadLine());

                    students.Add(newStudentID, newName);
                }
            }
            while (newName != "");
            Console.WriteLine("\nClass Roster:");
            foreach (KeyValuePair<int, string> student in students)
            {
                Console.WriteLine(student.Key + " " + student.Value);
            }

            Console.ReadLine();
        }
    }
}
