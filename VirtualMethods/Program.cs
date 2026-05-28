using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualMethods
{
    class myclass
    {
        public void display()
        {
            Console.WriteLine("welcome to oops");
        }
        public virtual void show()
        {
            Console.WriteLine("show is caalling");
        }
    }

    class dc:myclass
    {
        public void Message()
        {
            Console.WriteLine("messsage iss calling");
        }
        public override void show()
        {
            Console.WriteLine("welcome to oops");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            myclass obj= new myclass();
            obj.display();
            obj.show();

            dc obj1 = new dc();
            obj1.Message();
            obj1.show(); 
        }
    }
}
