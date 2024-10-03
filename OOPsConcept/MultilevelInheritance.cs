using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPsConcept
{ 
    class MyVehicle
    {
        public void start()
        {
            Console.WriteLine("The vehicle is started");

        }
    }
    class OffRiding : MyVehicle
    {
        public void drive()
        {
            Console.WriteLine(" The car is Driving");

        }
    }
    class SportsCar : OffRiding
    {
        public void turboBoost()
        {
            Console.WriteLine(" The sports car in turbo mode");
        }
    }
    internal class MultilevelInheritance
    {
        static void Main()
        {
            SportsCar s = new SportsCar();
            s.start();
            s.drive();
            s.turboBoost();

        }
    }
}
