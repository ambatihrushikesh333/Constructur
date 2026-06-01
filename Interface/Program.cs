using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    interface IShape
    {
        void Area();
        double Perimeter();
    }

    public class Circle:IShape
    {
        public double Radius { get; set; }
        public void Area()
        {
            Console.WriteLine("Area of Circle: " + (Math.PI * Radius * Radius));
        }

        public double Perimeter()
        {
            return 2 * Math.PI * Radius;
        }
    }

    class Rectangle : IShape
    {
        public double Length { get; set; }
        public double Width { get; set; }
        public void Area()
        {
            Console.WriteLine("Area of Rectangle: " + (Length * Width));
        }
        public double Perimeter()
        {
            return 2 * (Length + Width);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            IShape circle = new Circle { Radius = 5 };
            circle.Area();
            Console.WriteLine("Perimeter of Circle: " + circle.Perimeter());

            IShape rectangle = new Rectangle { Length = 4, Width = 6 };
            rectangle.Area();
            Console.WriteLine("Perimeter of Rectangle: " + rectangle.Perimeter());
        }
    }
}
