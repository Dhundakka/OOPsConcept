using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPsConcept
{
    public abstract class Shapee
    {
        // Abstract method (No Implementation)
        public abstract double calculateArea(double a, double b);


        // Non abstract method ( Has an Implementation)

        public void display()
        {
            Console.WriteLine("Display the shape");
        }
    }

    class Rectanglle : Shapee
    {
        public override double calculateArea(double a, double b)
        {
            return a * b;
        }
        class Circle : Shapee
        {

            public override double calculateArea(double a, double b)
            {
                return Math.PI * a * b;
            }

        }







        internal class AbstractClass1
        {
            static void Main()
            {

            }
        }

    }
    |
