using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractSingleInheratance
{
    abstract class Vehicle
    {
        protected  string vehicleName;

        public Vehicle(string vehicleName)
        {
            this.vehicleName = vehicleName;
            Console.WriteLine("Vehicle is called");
        }
        public void ShowVehicleDetails()
        {
            Console.WriteLine($"Vehicle Name : {vehicleName}");
        }
        public abstract void VehicleType();
    }
    abstract class VehicleModdel:Vehicle
    {
        protected string modelName;
        public VehicleModdel(string vehicleName, string modelName) : base(vehicleName)
        {
            this.modelName = modelName;
            Console.WriteLine("VehicleModel is called");
        }
        public void DetailsName()
        {
            Console.WriteLine($"Model Name : {modelName}");
        }
        public abstract void ModelType();
    }

    class VehicaleData:VehicleModdel
    {
        public int vehicalenum;
        public VehicaleData(string vehicleName, string modelName, int vehicalenum) : base(vehicleName, modelName)
        {
            this.vehicalenum = vehicalenum;
            Console.WriteLine("VehicaleData is called");
        }
        public override void ModelType()
        {
            Console.WriteLine("suv");
        }
        public override void VehicleType()
        {
            Console.WriteLine("Carss");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            VehicaleData v = new VehicaleData("Toyota", "ab",9999);
            v.ModelType();
            v.DetailsName();
            v.ShowVehicleDetails();
            v.VehicleType();
            Console.ReadLine();
        }
    }
}
