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

        private static int nextStudentId = 1;

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
        public Student(string name, int studentId, int numberOfCredits, double gpa)
        {
            Name = name;
            StudentId = studentId;
            NumberOfCredits = numberOfCredits;
            Gpa = gpa;
        }

        public Student(string name, int studentId)
            : this(name, studentId, 0, 0) { }

        public Student(string name)
            : this(name, nextStudentId)
        {
            nextStudentId++;
        }

        public void AddGrade(int courseCredits, double grade)
        {
            double courseQualityScore = courseCredits * grade;
            double qualityScore = gpa * numberOfCredits;
            qualityScore += courseQualityScore;
            numberOfCredits += courseCredits;
            gpa = qualityScore / numberOfCredits;

        }

        public string GetGradeLevel()
        {
            string gradeLevel = "";
            if (numberOfCredits < 30)
            {
                gradeLevel = "Freshman";
            }
            else if (numberOfCredits < 60)
            {
                gradeLevel = "Sophmore";
            }
            else if (numberOfCredits < 90)
            {
                gradeLevel = "Junior";
            }
            else
                gradeLevel = "Senior";
                
            
            return gradeLevel;
        }

        public override String ToString()
        {
            return Name + " (Credits: " + NumberOfCredits + ", GPA: " + Gpa + ")";
        }

        public override bool Equals(object obj)
        {
            Student studentObj = obj as Student;

            return studentObj.studentId == this.studentId;
        }

    }

    public class Course
    {
        private string title;
        private readonly Tuple<string, int> courseId;
        private string instructor;
        private int credits;
        private Tuple<string, int> location;
        private string description;
        private List<string> textbooks;
        private List<int> roster;
        private Dictionary<string, List<int>> studentsEnrolled;


        public string Title
        {
            get { return title; }
            protected internal set { title = value; }
        }

        public Tuple<string, int> CourseId
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

        public Tuple<string, int> Location
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

        public override string ToString()
        {
            return String.Format("Course Title: {0}\nCourse Id {1}{2}\nInstructor: {3}\nCredits: {4}\nLocation: {5} room {6}\nDescription:{7}",
                title, courseId.Item1, courseId.Item2, instructor, credits, location.Item1, location.Item2, description);
        }


        public override bool Equals(object obj)
        {
            Course courseObj = obj as Course;

            return courseObj.courseId == this.courseId;
        }

        //public Dictionary<string, List<int>> StudentsEnrolled()
        //{
        //    foreach (int id in roster)
        //    {
        //        studentsEnrolled.Add(Student.Name, Student.Gpa);
        //    }

        //}
    }
}
