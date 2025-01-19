using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net.NetworkInformation;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static System.Collections.Specialized.BitVector32;
using static System.Net.Mime.MediaTypeNames;

namespace _15.Polymorphism_Csharp
{
    internal class Program
    {
        /* //1. Introduction to Polymorphism
         * class Animal
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
        */

        //2. Understanding Virtual Methods and Overriding Methods
        public class Employee
        {
            public virtual void MakeHRRequest()
            {
                Console.WriteLine("Employee makes an HR request.");
            }
        }

        public class Manager : Employee
        {
            public override void MakeHRRequest()
            {
                Console.WriteLine("Manager makes an HR request.");
            }
        }

        public class Engineer : Employee
        {
            public override void MakeHRRequest()
            {
                Console.WriteLine("Engineer makes an HR request.");
            }
        }


        static void Main(string[] args)
        {
            //Lesson 15. C#: Polymorphism

            //1. Introduction to Polymorphism
            /*Instructions
            The code editor showcases Polymorphism in action.Take a look at the code and 
            move to the next exercise when you are ready to learn how to implement Polymorphism within your class structure.
            
            //Code Solution 

            // Create instances of derived classes
            Animal myDog = new Dog();
            Animal myCat = new Cat();

            // Call the MakeSound method
            myDog.MakeSound(); // Output: Dog barks.
            myCat.MakeSound(); // Output: Cat meows.
            */

            //2. Understanding Virtual Methods and Overriding Methods
            /*Instructions
            Checkpoint 1 Enabled
            1.
            The following class structure defines a base class Employee with two derived classes, Manager and Engineer.Both the Employee and Manager classes have a method called MakeHRRequest().

            Inside the Main() method, an instance of the Manager class is placed in the manager1 variable and MakeHRRequest() is called using the Manager instance.

            Run the code. Note the warning about the shared method names along with the correct output from the Manager class’ MakeHRRequest() method.

            Checkpoint 2 Step instruction is unavailable until previous steps are completed
            2.
            To address this warning use a virtual method in the base class and override that method in the derived class.

            Inside the Employee class, make MakeHRRequest() a virtual method.

            Inside the Manager class, make MakeHRRequest() override the base class virtual method.

            Checkpoint 3 Step instruction is unavailable until previous steps are completed
            3.
            In the Engineer class define a method, MakeHRRequest(), that overrides the base class virtual method of the same name.The method body should output the following text, "Engineer makes an HR request."

            Checkpoint 4 Step instruction is unavailable until previous steps are completed
            4.
            Lastly, inside the Main() method, create an instance of Engineer called, engineer1. Using the instance inside engineer1 variable, call MakeHRRequest().
            */

            //Code Solution
            Manager manager1 = new Manager();
            manager1.MakeHRRequest();

            Engineer engineer1 = new Engineer();
            engineer1.MakeHRRequest();

        }

    }
}
