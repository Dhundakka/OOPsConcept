using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace OOPsConcept
{

    // Dynamic Polymorphism/method overriding/ late binding
    // Method name same class name same different parameter

    // Base  class
    class Shape
    {
        public virtual void Draw()
        {
            Console.WriteLine("Draw");

        }
    }

        // derived class1
        class Circle : Shape
        {
            public override void Draw()
            {

                Console.WriteLine(" Drawing a Circle");
            }
        }

        // derived class2
        class Rectangle : Shape
        {
            public override void Draw()
            {
                Console.WriteLine(" Drawing Rectangle");



            }
        }

    // main class 
        internal class DynamicPolymorphism
        {
            
            static void Main()
            {
             Shape shape1 = new Shape();
             Shape shape2 = new Circle();
             Shape shape3 = new Rectangle();


            // Calling the draw method on each object
            shape1.Draw();
            shape2.Draw();
            shape3.Draw();


            }
        }
    }
