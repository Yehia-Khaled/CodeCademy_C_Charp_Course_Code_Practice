using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Security.AccessControl;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

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
            */

            //Code Solution
            Forest f = new Forest("Congo", "Tropical");
            f.AnnounceForest();


            f.Grow();

            f.AnnounceForest();

        }
    }
}
