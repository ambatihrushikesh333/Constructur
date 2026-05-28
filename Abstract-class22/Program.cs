using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_class22
{
    abstract class HMWBS
    {
        public void BillDetails()
        {
            Console.WriteLine("HMWBS bill generated");
        }
        public abstract void Getbill(double units);
    }

    class Residential : HMWBS
    {
        public override void Getbill(double units)
        {
            double bill = units * 5;
            Console.WriteLine("Residential bill: " + bill);
        }
    }

    class CommercialCustomer : HMWBS
    {
        public override void Getbill(double units)
        {
            double bill = units * 10;
            Console.WriteLine("Commercial bill: " + bill);
        }
    }

    class IndustrialCustomer : HMWBS
    {
        public override void Getbill(double units)
        {
            double bill = units * 15;
            Console.WriteLine("Industrial bill: " + bill);
        }
    }

    class AgriculturalCustomer : HMWBS
    {
        public override void Getbill(double units)
        {
            double bill = units * 8;
            Console.WriteLine("Agricultural bill: " + bill);
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            HMWBS obj = new Residential();
            obj.BillDetails();
            Console.WriteLine("Enter the number of units consumed:");
            double units = Convert.ToDouble(Console.ReadLine());
            obj.Getbill(units);
            obj = new CommercialCustomer();
            obj.Getbill(units);
            obj = new IndustrialCustomer();
            obj.Getbill(units);
            obj = new AgriculturalCustomer();
            obj.Getbill(units);
        }
    }
}
