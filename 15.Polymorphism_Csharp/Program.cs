using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net.NetworkInformation;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static System.Collections.Specialized.BitVector32;
using static System.Net.Mime.MediaTypeNames;
using static _15.Polymorphism_Csharp.Program;

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
        /*public class Employee
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
        */

        //3. Upcasting Objects
        /*//Code Solution
        public class Employee
        {
            // Virtual method in the base class
            public virtual void MakeHRRequest()
            {
                Console.WriteLine("Employee makes an HR request.");
            }
        }

        public class Engineer : Employee
        {
            // Override the virtual method in the derived class
            public override void MakeHRRequest()
            {
                Console.WriteLine("Engineer makes an HR request.");
            }
        }

        public class Manager : Employee
        {
            // Override the virtual method in the derived class
            public override void MakeHRRequest()
            {
                Console.WriteLine("Manager makes an HR request.");
            }
        }
        */

        //4. Downcasting Objects
        /*public class Employee
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

            public void MoveToOffice()
            {
                Console.WriteLine("Manager moves to office.");
            }
        }

        */
        //5.Using 'is' Operators
        //Code Solution
        public class Employee
        {
            // Virtual method in the base class
            public virtual void MakeHRRequest()
            {
                Console.WriteLine("Employee makes an HR request.");
            }
        }

        public class Engineer : Employee
        {
            // Override the virtual method in the derived class
            public override void MakeHRRequest()
            {
                Console.WriteLine("Engineer makes an HR request.");
            }
        }

        public class Manager : Employee
        {
            // Override the virtual method in the derived class
            public override void MakeHRRequest()
            {
                Console.WriteLine("Manager makes an HR request.");
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
            

            //Code Solution
            Manager manager1 = new Manager();
            manager1.MakeHRRequest();

            Engineer engineer1 = new Engineer();
            engineer1.MakeHRRequest();
            */

            //3. Upcasting Objects
            /*Instructions
            Checkpoint 1 Enabled
            1.
            In the Main method, create a Manager object named myManager.

            Checkpoint 2 Step instruction is unavailable until previous steps are completed
            2.
            In the Program class, upcast the Manager object myManager to an Employee reference named myEmployeeManager.

            Checkpoint 3 Step instruction is unavailable until previous steps are completed
            3.
            Now call MakeHRRequest() using the myEmployeeManager object. Even though the calling object is of type Employee, the output is that of the overridden method in the Manager class.
            

            //Code Solution
            Manager myManager = new Manager();

            Employee myEmployeeManager = myManager;

            myEmployeeManager.MakeHRRequest();
            */

            //4. Downcasting Objects
            /*Instructions
            Checkpoint 1 Enabled
            1.
            In the Program class, a Manager object is upcast to an Employee object called myEmployeeManager.

            Right below that line of code, define myManager of type Manager and set the variable’s value to a downcast myEmployeeManager.

            Checkpoint 2 Step instruction is unavailable until previous steps are completed
            2.
            Now use myManager to call the MoveToOffice() method.
            
            //Code Solution
            Employee myEmployeeManager = new Manager();
            // Your code below
            Manager myManager = (Manager)myEmployeeManager;

            myManager.MoveToOffice();
            */

            // 5.Using 'is' Operators
            /*Instructions
            Checkpoint 1 Enabled
            1.
            In the Main method, define a variable myEmployee and set it to an upcast new Engineer object.

            Checkpoint 2 Step instruction is unavailable until previous steps are completed
            2.
            Now inside a Console.WriteLine() statement, output the result of using the is operator to check if myEmployee can be cast to an Engineer.

            Be sure to not print anything other than the result of the is operation.

            Checkpoint 3 Step instruction is unavailable until previous steps are completed
            3.
            Inside another Console.WriteLine() statement, output the result of using the is operator to check if myEmployee can be cast to a Manager.

            Be sure to not print anything other than the result of the is operation.
            */

            //Code Solution
            Employee myEmployee = new Engineer();
            Console.WriteLine(myEmployee is Engineer);
            Console.WriteLine(myEmployee is Manager);

        }

    }
}
