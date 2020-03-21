using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class
{

    public class Taxi
    {
        public string DriverName { get; set; }
        public bool OnDuty { get; set; }
        public int NumbOfPassenger { get; set; }
        public string status { get; set; }

        public void TaxiInfo()
        {
            Console.WriteLine("Driver Name         : {0}", DriverName);
            if (OnDuty == true)
            {
                status = "Yes";
            }
            else
            {
                status = "No";
            }
            Console.WriteLine("On Duty             : {0}", status);
            Console.WriteLine("Number of Passenger : {0}\n", NumbOfPassenger);
        }

        public void PickUpPassenger()
        {
            Console.WriteLine("{0} sedang menjemput penumpang", DriverName);
        }

        public void DropOfPassenger()
        {
            Console.WriteLine("{0} sedang mengantar penumpang", DriverName);
        }

    }

    class Program
    {
        static void Main(string[] args)
        {

            Taxi taxi = new Taxi();

            taxi.DriverName = "Jono";
            taxi.OnDuty = true;
            taxi.NumbOfPassenger = 10;

            taxi.TaxiInfo();
            taxi.PickUpPassenger();
            taxi.DropOfPassenger();

            Console.ReadKey();
        }
    }
}