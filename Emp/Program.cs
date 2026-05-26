using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emp
{
    public class Person
    {
        public int Age;
        public string Name;

        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }
        public Person(Person previousperson)
        {
            Name = previousperson.Name;
            Age = previousperson.Age;
        }
        public string Details()
        {
            return "Name is " + Name + " and age is " + Age;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person("Jay", 30);

            Person person2 = new Person(person1);
            
            person1.Age = 34;
            person2.Age = 23;

            person2.Name = "Jack";
            Console.WriteLine(person1.Details());   
            Console.WriteLine(person2.Details());
        }
    }
}
