using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.IntroToClasses_CSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1.Introduction to Classes and Abstraction
            /*    Instructions
                Reference the image for some conceptual examples of custom classes.Note that each class is associated with 2 variables and 1 method.The variables represent the state, such as whether or not the lightbulb is on and how many watts it consumes.The methods represent behaviors, such as turning the lightbulb on.

                NOTE: Testing this kind of code takes longer, so some checkpoints in this lesson will need more time to run.It’s worth the wait!
            */

            //2. Defining Classes
            /*
             * Instructions
            Checkpoint 1 Enabled
            1.
            We will define our class in Forest.cs and work with that class in the Main() method in Program.cs.

            Within the namespace DefiningClasses, build an empty Forest class in Forest.cs.

            Checkpoint 2 Step instruction is unavailable until previous steps are completed
            2.
            In Main() within Program.cs, make a new instance of the Forest class and store the result in variable f.

            //Code Solution
            Forest f = new Forest();
            */

            //3. Fields
            /*
             * Instructions
            Checkpoint 1 Enabled
            1.
            In Forest.cs, add 4 fields to the Forest class.

            2 fields of type string:

            name
            biome
            2 fields of type int:

            trees
            age
            Include the public keyword before each field’s type declaration.

            NOTE: at this point, the compiler will throw several warnings indicating that these fields are declared but never assigned values. Do not worry, we will address this in the next step!

            Checkpoint 2 Step instruction is unavailable until previous steps are completed
            2.
            In Program.cs, within Main(), a Forest object has already been instantiated. Set values for each of the 4 fields.

            Checkpoint 3 Step instruction is unavailable until previous steps are completed
            3.
            In Main(), print the name field to the console.
            
            //Code Solution
            Forest f = new Forest();
            f.name = "Test";
            f.biome = "Palm";

            f.trees = 3;
            f.age = 5;
            Console.WriteLine($"Tree name is {f.name}");
            */

            //4. Methods
            /*Instructions
            Checkpoint 1 Enabled
            1.
            In the Forest class, define a public method Grow(). It should:

            take zero arguments
            increase the trees property by 30 and the age property by 1
            return the updated number of trees
            Checkpoint 2 Step instruction is unavailable until previous steps are completed
            2.
            Define a public method Burn(). It should:

            take zero arguments
            decrease the trees field by 20 and increase the age property by 1
            return the updated number of trees
            */
            //Code Solution
            Forest f = new Forest();
            f.name = "Congo";
            f.trees = 0;
            f.age = 0;
            f.biome = "Tropical";

            Console.WriteLine(f.name);




        }
    }
}
