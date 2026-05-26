//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace copy_constructors
//{
//    class student
//    {
//        public int Sid;
//        public string Sname;

//        public student(int sid, string sname)
//        {
//            Sid = sid;
//            Sname = sname;
//        }
//        public student(student stu)
//        {
//            Sid = stu.Sid;
//            Sname = stu.Sname;
//        }
//        public void studentdisplay()
//        {
//            Console.WriteLine("Student id is " + Sid);
//            Console.WriteLine("Student name is " + Sname);
//        }
//    }
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            student stu1 = new student(101, "John");
//            stu1.studentdisplay();
//            student stu2 = new student(stu1);
//            stu2.studentdisplay();
//        }
//    }
//}
