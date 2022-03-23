using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taxi
{
    public class Taxi
    {
        public string DriverName { get; set; }
        public bool OnDuty { get; set; }
        public int NumPassenger { get; set; }
        
        

        //method
        public void TaxiInfo ()
        {
            Console.WriteLine("Nama: {0}", DriverName);
            if (OnDuty = true)
            {
                Console.WriteLine("On Duty: yes");
            }
            else
            {
                Console.WriteLine("On Duty: no");
            }
            Console.WriteLine("Number of Passenger: {0}", NumPassenger);

            
        }
        public void PickUpPassenger()
        {
            Console.WriteLine("\n{0} sedang menjemput penumpang", DriverName);
        }
        public void DropOffPassenger()
        {
            Console.WriteLine("{0} selesai mengantar penumpang", DriverName);
        }
    }

}
