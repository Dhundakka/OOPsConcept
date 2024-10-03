using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPsConcept
{
    class Calculator
    {
        public int Add(int x, int y)
        {

            return x + y;
        }

        public double Add(double x, double y)
        {

            return x + y;
        }

        public double Add(double x, double y, double z)
        {

            return x + y + z;
        }

        public double Add(int x, double y)
        {

            return x + y;
        }


    }

    internal class StaticPolymorphism1
    {
        static void Main()
        {
            Calculator math = new Calculator();

            int sum = math.Add(1, 2);
            double sum1 = math.Add(20, 30);
            double sum2 = math.Add(10, 20, 30);
            double sum3 = math.Add(11, 21);

            Console.WriteLine(sum);
            Console.WriteLine(sum1);
            Console.WriteLine(sum2);
            Console.WriteLine(sum3);


        }

    }
}

