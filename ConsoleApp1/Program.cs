using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Employee
    {
        public int Eid;
        public string Ename;
        public int Eage;
        public double Salary;
        public static string Companyname;

        public Employee(int eid, string ename, int eage,double salary)
        {
            Eid = eid;
            Ename = ename;
            Eage = eage;
            Salary = salary;
        }

        static Employee()
        {
            Companyname = "Microsoft";
        }

        public void Employeedisplay()
        {
            Console.WriteLine("Employee id is " + Eid);
            Console.WriteLine("Employee name is " + Ename);
            Console.WriteLine("Employee age is " + Eage);
            Console.WriteLine("Empoyee salary is " + Salary);
        }

        public static void Companydisplay()
        {
            Console.WriteLine("Company name is " + Companyname);
        }

        public void Hike()
        {
            double hike = Salary * 10 / 100;
            Salary = Salary + hike;

            Console.WriteLine("Updated Salary is " + Salary);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee emp1 = new Employee(101, "John", 30, 50000);
            emp1.Employeedisplay();
            Employee.Companydisplay();
            emp1.Hike();
        }
    }
}
