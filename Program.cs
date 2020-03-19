using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramTaxi 
{
    public class Taxi 
    {
        public string DriverName;
        public bool OnDuty;
        public int NumPassenger;
        public string Duty;

        public void TaxiInfo() 
        {
            if(OnDuty==true) 
            {
                Duty = "Yes";
            }
            else 
            {
                Duty = "No";
            }
            Console.WriteLine("Driver Name : " + DriverName);
            Console.WriteLine("On Duty : " + Duty);
            Console.WriteLine("Number of Passenger : " + NumPassenger + "\n");
        }

        public void PickUpPassenger() 
        {
            Console.WriteLine(DriverName + " sedang menjemput penumpang");
        }

        public void DropOffPassenger() 
        {
            Console.WriteLine(DriverName + " selesai mengantar penumpang");
        }
        
    }
    class Program 
    {
        static void Main(string[] args) 
        {
            Taxi taxi = new Taxi();

            taxi.DriverName = "Bima";
            taxi.OnDuty = true;
            taxi.NumPassenger = 4;

            taxi.TaxiInfo();
            taxi.PickUpPassenger();
            taxi.DropOffPassenger();

            Console.ReadKey();
        }
    }
}
