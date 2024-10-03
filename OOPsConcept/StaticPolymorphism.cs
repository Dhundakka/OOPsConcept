using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPsConcept
{
    class MathOperations
    {

        public int Add(int a, int b)
        {
            return a + b;
        }

        public double Add(double a, double b)
        {
            return a + b;
        }
    }
    internal class StaticPolymorphism
    {
        static void Main()
        {
            MathOperations math = new MathOperations();

            //calling the overload method

            int sum = math.Add(1, 2);
            double sum1 = math.Add(3,4);

            Console.WriteLine( " Sum of Integer " +sum);
            Console.WriteLine("sum of Double " + sum1);


        }
    }
}
