using Microsoft.TeamFoundation.Build.WebApi;
using Microsoft.TeamFoundation.WorkItemTracking.WebApi.Models;
using Microsoft.VisualStudio.Services.Users;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Microsoft.VisualStudio.Services.Graph.GraphResourceIds;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TreeView;

namespace _14.Inheritance_Csharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* 14.Inheritance_Csharp*/

            //1. Introduction to Inheritance
            //Instructions
            //Check out Sedan.cs and Truck.cs.What code is duplicated across these types?


            //3. Create a Superclass
            /*
             * Instructions
             Checkpoint 1 Enabled
             1.
             In Vehicle.cs, build an empty Vehicle class within the LearnInheritance namespace.

             Checkpoint 2 Step instruction is unavailable until previous steps are completed
             2.
             In Vehicle.cs, define:

             string LicensePlate property (getter only)
             double Speed property (getter and private setter)
             int Wheels property(getter only)
                 void Honk() method
                 SpeedUp() method
                 SlowDown() method
             SpeedUp() and SlowDown() should add and remove 5 from Speed, respectively.

             Honk() should write a message to the console(such as HONK!).

             Checkpoint 3 Step instruction is unavailable until previous steps are completed
             3.
             In Sedan.cs, use the colon syntax to declare that Sedan inherits the Vehicle class.

             Checkpoint 4 Step instruction is unavailable until previous steps are completed
             4.
             Do you see a bunch of warning CS0108 in the console? Since Sedan is inheriting members from Vehicle, those members should not be redefined!

             Remove all of the inherited members from Sedan.cs.You will still see errors regarding Sedan accessing members that it is not allowed to — that’s okay! We’ll fix those in the next exercise.
             */


        }
    }
}
