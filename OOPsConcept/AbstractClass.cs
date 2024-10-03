using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPsConcept
{
    public abstract class Animal1
    {
        // Abstract method (no implementation)

        public  abstract void MakeSound();  

        // non Abstract method (this has implementation)

        public void Eat()
        {
            Console.WriteLine(" Animal is Eating");
        }

    }
    public class Dog : Animal1
    {
        public override void MakeSound()
        {
            Console.WriteLine(" Dog is barking");
        }
    }
    public class Cat : Animal1
    {
        // implimentation of the abstract method

        public override void MakeSound()
        {
            Console.WriteLine(" cat is making sound meows ");
        }
    }
    internal class AbstractClass
    {
        static void Main()
        {
            Dog dog = new Dog();    
            dog.MakeSound();
            dog.Eat();

            Cat cat = new Cat();
            cat.MakeSound();
            cat.Eat();



        }
    }
}
