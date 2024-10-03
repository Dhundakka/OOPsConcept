using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPsConcept
{
    class MyShape
    {
        public void draw()
        {
            Console.WriteLine(" Drawing a Shape");
        }
    }

    class MyCircle : MyShape
    {
        public void drawCircle()
        {
            Console.WriteLine(" Drawing a Circle");

        }
    }
    class MyRectangle : MyShape
    {
        public void drawRectangle()
        {
            Console.WriteLine("Drawing the Rectangle");
        }
    }
    class Trangle : MyShape
    {
        public void drawTrangle()
        {
            Console.WriteLine(" Drawing a Traingle");
        }
    }

    internal class HirarchicalInheritance
    {
        static void Main()
        {
            MyShape shape = new MyShape();
            shape.draw();
            
            MyCircle circle = new MyCircle();
            circle.drawCircle();
           

            MyRectangle rectangle = new MyRectangle();
            rectangle.drawRectangle();

            Trangle trangle = new Trangle();
            trangle.drawTrangle();

        }
    }
}
