using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructAbstract
{
    
    abstract class Person
    {
        protected string Name;
        protected int Age;
        public Person(string name, int age)
        {
            Name = name;
            Age = age;
            Console.WriteLine("Person Constructor is called");
        }
        public void DisplayInformation()
        {
            Console.WriteLine($"Name :{Name},Age : {Age}");
        }

        public abstract void Role();
    }
    class Student : Person
    {
        public int rollNo;
        public Student(string name, int age, int rollNo) : base(name, age)
        {
            this.rollNo = rollNo;
            Console.WriteLine("Student Constructor is called");
        }
        public override void Role()
        {
            Console.WriteLine("I am a student.");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Student s= new Student("John", 20, 101);
            s.DisplayInformation();
            s.Role();
            Console.ReadLine();
        }
    }
}
