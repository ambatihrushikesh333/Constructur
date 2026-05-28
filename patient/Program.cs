using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace patient
{
    class Patient
    {
        private string Pname;
        private int Page;
        private string medicalHistory;

        public string Name
        {
            get { return Pname; }
            set { Pname = value; }
        }
        public int Age
        {
            get { return Page; }
        }
        public string MedicalHistory
        {
            set { medicalHistory=value; }
        }

        public Patient(string name, int age)
        {
            this.Pname = name;
            this.Page = age;
        }
                                             
        
        public void DisplayPatientInfo()
        {
            Console.WriteLine("Patient Name: " + Pname);
            Console.WriteLine("Patient Age: " + Page);
            Console.WriteLine("Medical History: " + medicalHistory);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Patient p= new Patient("John Doe", 25);
            p.MedicalHistory= "Cancer";
            p.DisplayPatientInfo();

            Patient p2= new Patient("Jane Smith", 30);
            p2.MedicalHistory= "Diabetes";
            p2.DisplayPatientInfo();
        }
    }
}
