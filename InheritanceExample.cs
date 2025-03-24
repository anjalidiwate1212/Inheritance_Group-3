using System;

namespace OOPs.Inheritance
{

    public class University
    {
        private string firstName;
        private string lastName;


        public University(string firstName, string lastName)
        {
            this.firstName = firstName;
            this.lastName = lastName;
        }

        public virtual void DisplayInfo()
        {
            Console.WriteLine($"Employee: {firstName} {lastName}");
        }
    }


    public class Student1 : University
    {
        private int _semester;

        public Student1(string firstName, string lastName, int semester) : base(firstName, lastName)
        {
            _semester = semester;
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"ReportCount: {_semester} ");
        }
    }
    public class Cr : Student1
    {
        private int _no_of_students;

        public Cr(string firstName, string lastName, int semester, int nof) : base(firstName, lastName, semester)
        {
            _no_of_students = nof;
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Count of Students: { _no_of_students} ");
        }
    }

    public class InheritanceExample2
    {
        public static void RunExample()
        {
            Console.WriteLine("\n--- Inheritance Example ---");

            Student1 m = new Student1("Anjali", "Diwate", 2);
            m.DisplayInfo();

            Cr c = new Cr("Anjali", "Diwate", 2, 50); 
            c.DisplayInfo();

            Console.WriteLine();

        }
    }
}



   
