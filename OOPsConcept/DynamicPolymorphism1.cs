using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPsConcept
{
    class Animall
    {
        public virtual void Draw()
        {
            Console.WriteLine("Draw");
        }
    }


        class Circlee : Animall
        {
            public override void Draw()
            {
                Console.WriteLine("Draw the Circle");
            }
        }
        class Rectanglee : Animall
        {
            public override void Draw()
            {
                Console.WriteLine("Draw the Recrangle");
            }
        }
    

    internal class DynamicPolymorphism1
    {
        static void Main()
        {
            Animall animal1 = new Animall();
            Animall animal2 = new Circlee();
            Animall animal3 = new Rectanglee();
            
            animal1.Draw();
            animal2.Draw();
            animal3.Draw();

        }
    }   
}