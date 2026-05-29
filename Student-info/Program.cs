using Student_info;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_info
{
    abstract class Person
    {
        protected string Name;
        protected int Age;

        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public void DisplayInformation()
        {
            Console.WriteLine("Name : " + Name);
            Console.WriteLine("Age  : " + Age);
        }

        public abstract void Role();
    }

    class Student : Person
    {
        public int RollNumber;

        public Student(string name, int age, int rollNumber)
            : base(name, age)
        {
            RollNumber = rollNumber;
        }

        public override void Role()
        {
            Console.WriteLine("Role : Student");
        }

        public void Study()
        {
            Console.WriteLine("Student is Studying");
        }
    }

    // Teacher Derived Class
    class Teacher : Person
    {
        // Property
        public string Subject;

        // Constructor
        public Teacher(string name, int age, string subject)
            : base(name, age)
        {
            Subject = subject;
        }

        // Override Abstract Method
        public override void Role()
        {
            Console.WriteLine("Role : Teacher");
        }

        // Teacher Method
        public void Teach()
        {
            Console.WriteLine("Teacher is Teaching");
        }
    }

    // Main Class
    class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student("Rahul", 20, 101);

            Console.WriteLine("----- Student Details -----");
            s1.DisplayInformation();
            Console.WriteLine("Roll Number : " + s1.RollNumber);
            s1.Role();
            s1.Study();

            Console.WriteLine();

            Teacher t1 = new Teacher("Suresh", 40, "Mathematics");

            Console.WriteLine("----- Teacher Details -----");
            t1.DisplayInformation();
            Console.WriteLine("Subject : " + t1.Subject);
            t1.Role();
            t1.Teach();

            Console.ReadLine();
        }
    }
}
