using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Collections.Specialized.BitVector32;
using static System.Net.Mime.MediaTypeNames;

namespace _15.Polymorphism_Csharp
{
    internal class Program
    {
        class Animal
        {
            public virtual void MakeSound()
            {
                Console.WriteLine("Animal makes a sound.");
            }
        }



        class Dog : Animal
        {
            public override void MakeSound()
            {
                Console.WriteLine("Dog barks.");
            }
        }

        // Define the Cat class here
        class Cat : Animal
        {
            public override void MakeSound()
            {
                Console.WriteLine("Cat meows.");
            }
        }
        static void Main(string[] args)
        {
            //Lesson 15. C#: Polymorphism

            //1. Introduction to Polymorphism
            /*Instructions
            The code editor showcases Polymorphism in action.Take a look at the code and 
            move to the next exercise when you are ready to learn how to implement Polymorphism within your class structure.
            */
            //Code Solution 

            // Create instances of derived classes
            Animal myDog = new Dog();
            Animal myCat = new Cat();

            // Call the MakeSound method
            myDog.MakeSound(); // Output: Dog barks.
            myCat.MakeSound(); // Output: Cat meows.

        }

    }
}
