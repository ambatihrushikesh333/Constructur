using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_class
{
    class Abstract
    {
        public void strat()
        {
            Console.WriteLine("Start the class");
        }
         
        public void Resume()
        {
            Console.WriteLine("resume the class");
        }

        public void Display()
        {
            Console.WriteLine("WELCOME");
        }
        class Derivedclass:Abstract
        {
            public override void End()
            {
                Console.WriteLine("session has end");
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
