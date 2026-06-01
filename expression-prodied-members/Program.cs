using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace expression_prodied_members
{
    class   ExpresionProddieddMembers
    {
        public void PrintMessage() => Console.WriteLine("HELLO!, WORLD");

        public int Square(int x) => x*x;
        public ExpresionProddieddMembers() => Console.WriteLine("Constructor called!");
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            ExpresionProddieddMembers obj = new ExpresionProddieddMembers();
                obj.PrintMessage();
           Console.WriteLine(obj.Square(10));
        }
    }
}
