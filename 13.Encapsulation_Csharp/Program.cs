using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.Remoting.Contexts;
using System.Security.AccessControl;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace _13.Encapsulation_Csharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //2. Access Modifiers
            /*Instructions
            Checkpoint 1 Enabled
            1.
            Take a look at the program in the editor. In Program.cs, we initialize a new Forest object, f, then increase the trees and age fields directly in Main().Both before and after updating the field values, we call a helper function AnnounceForest() to print a string about the forest object to the console.

            Run the program as is and observe the output.

            Checkpoint 2 Step instruction is unavailable until previous steps are completed
            2.
            We’ve decided that the age and trees fields should only be updated within the Forest class definition so we can have better control over them.

            In Forest.cs, update both properties so they will not be accessible outside the class definition.

            NOTE: this will result in an error in the terminal, as the code in Main() is attempting to access something that it cannot anymore.Don’t worry, we will address this error in the following step!

            Checkpoint 3 Step instruction is unavailable until previous steps are completed
            3.
            Since we’ve made the trees and age fields private, they can no longer be accessed outside the Forest class, and our code is yielding an error!

            To address this, we’ve already started the definition of a new method, Grow(), within Forest.cs.Remove the 2 lines that update trees and age from Program.cs and add them to the body of the Grow() method. Adjust the code so it references the instance variables instead of the instance f.

            Where you removed the code in Program.cs, add a call to the Grow() method.
           

            //Code Solution
            Forest f = new Forest("Congo", "Tropical");
            f.AnnounceForest();


            f.Grow();

            f.AnnounceForest();
            */

            //3. Properties
            /*Instructions
            Checkpoint 1 Enabled
            1.
            Within the Forest class, define a basic Name property for the name field.The getter and setter will have no validation.

            Checkpoint 2 Step instruction is unavailable until previous steps are completed
            2.
            In Forest.cs, update the name field so it can only be accessed within the Forest class.

            In Program.cs, replace any use of the field f.name with the property f.Name.

            Checkpoint 3 Step instruction is unavailable until previous steps are completed
            3.
            Back in Forest.cs, define a Biome property for the biome field, with a getter and setter.The setter should only allow three values: "Tropical", "Temperate", and "Boreal". If any other value is used, set biome to "Unknown".

            Update the biome field so it can only be accessed within the Forest class.

            For example, this is how it would work in Program.cs:

            f.Biome = "Tropical";
            // Prints Tropical
            Console.WriteLine(f.Biome); 

            f.Biome = "Desert";
            // Prints Unknown
            Console.WriteLine(f.Biome); 
            

            //Code Solution
            Forest f = new Forest();
            f.Name = "Congo";
            f.trees = 0;
            f.age = 0;
            f.Biome = "Tropical";

            Console.WriteLine(f.Name);
            Console.WriteLine($"biome name is {f.Biome}");
            */


            //4. Auto-Implemented Properties
            /* Instructions
             Checkpoint 1 Enabled
             1.
             We have defined basic fields and properties for name and trees in the code editor.

             Replace the current name field and Name property with an auto - implemented Name property.

             Checkpoint 2 Step instruction is unavailable until previous steps are completed
             2.
             Replace the current trees field and Trees property with an automatic Trees property.
            

            //Code Solution 
            Forest f = new Forest();
            f.Name = "Congo";
            f.Trees = 0;
            f.age = 0;
            f.Biome = "Tropical";

            Console.WriteLine(f.Name);
            */

            //5. Get-Only Properties
            /*Instructions
            Checkpoint 1 Enabled
            1.
            In Forest.cs, define an Age property for the age field.It should have a public getter and a private setter.

            Checkpoint 2 Step instruction is unavailable until previous steps are completed
            2.
            In Program.cs, within the Main() method, try to set the value of f.Age.You should see an error:

            error CS0272: The property or indexer 'Forest.Age' cannot be used in this context because the set accessor is inaccessible

            Copy to Clipboard

            This error means that the private setter prevented us from setting Age outside of the class (which is good!).
            */

            //Code Solution 
            Forest f = new Forest();
            f.Name = "Congo";
            f.Trees = 0;
            f.Biome = "Tropical";
            f.Age = 15;

        }
    }
}
