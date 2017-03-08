using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C5School
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    public class Student
    {
        private string name;
        private int studentId;
        private int numberOfCredits;
        private double gpa;

        public string Name
        {
            get { return name; }
            protected internal set { name = value; }
        }

        public int StudentId
        {
            get { return studentId; }
            protected internal set { studentId = value; }
        }

        public int NumberOfCredits
        {
            get { return numberOfCredits; }
            protected internal set { numberOfCredits = value; }
        }

        public double Gpa
        {
            get { return gpa; }
            protected internal set { gpa = value; }
        }
    }

    public class Course
    {
        private string title;
        private readonly Dictionary<string, int> courseId;
        private string instructor;
        private int credits;
        private Dictionary<string, string> location;
        private string description;
        private List<string> textbooks;
        private List<int> roster;
        private Dictionary<string, List<int>> studentsEnrolled;


        public string Title
        {
            get { return title; }
            protected internal set { title = value; }
        }

        public Dictionary<string, int> CourseId
        {
            get { return courseId; }
        }

        public string Instructor
        {
            get { return instructor; }
            protected internal set { instructor = value; }
        }

        public int Credits
        {
            get { return credits; }
            protected internal set { credits = value; }
        }

        public Dictionary<string, string> Location
        {
            get { return location; }
            protected internal set { location = value; }
        }

        public string Description
        {
            get { return description; }
            protected internal set { description = value; }
        }

        public List<string> Textbooks
        {
            get { return textbooks; }
            protected internal set { textbooks = value; }
        }

        public List<int> Roster
        {
            get { return roster; }
            protected internal set { roster = value; }
        }

        public Dictionary<string, List<int>> StudentsEnrolled()
        {
            foreach (int id in roster)
            {
                studentsEnrolled.Add(Student.Name, Student.Gpa);
            }

        }
    }
}
