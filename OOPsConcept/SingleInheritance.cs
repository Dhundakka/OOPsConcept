using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPsConcept
{

    //Base Class
    class Vehicle
    {
        public string brand { get; set; }

        public void drive()
        {
            Console.WriteLine($" { brand} is Driving ");
        }
    }
    class Car : Vehicle
    {
        public int NoOfDoors { get; set; }

        public void showCarInfo()
        {
            Console.WriteLine($" {brand} car has {NoOfDoors} door");
        }

    }
    internal class SingleInheritance
    {
        static void Main()
        {
            Car car = new Car();
            car.brand = "Mahindra";
            car.NoOfDoors = 4;
            car.showCarInfo();

        }
    }
}
