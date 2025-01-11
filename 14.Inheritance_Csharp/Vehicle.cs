using Accord.Collections;
using Microsoft.VisualStudio.Services.Client.AccountManagement.Logging;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Microsoft.VisualStudio.Services.Graph.GraphResourceIds;

namespace _14.Inheritance_Csharp
{
    internal class Vehicle
    {
        //3. Create a Superclass
        /*
         * public string LicensePlate
        {
            get;
        }

        public double Speed
        {
            get;
            private set;
        }

        public int Wheels
        {
            get;
        }

        public void Honk()
        {
            Console.WriteLine("HONK!");
        }
        public void SpeedUp()
        {
            Speed += 5;
        }

        public void SlowDown()
        {
            Speed -= 5;
        }
        */

        //4. Access Inherited Members with Protected
        /*Instructions
        Checkpoint 1 Enabled
        1.
        In Vehicle, add a protected setter to each of these properties:

        LicensePlate
        Speed(update from private to protected)
        Wheels
        */

        //Code Solution
        /*public string LicensePlate
        { get; protected set; }

        public double Speed
        { get; protected set; }

        public int Wheels
        { get; protected set; }

        public void SpeedUp()
        {
            Speed += 5;
        }

        public void SlowDown()
        {
            Speed -= 5;
        }

        public void Honk()
        {
            Console.WriteLine("HONK!");
        }
        */


        //6. Access Inherited Members with Base
        /*Instructions
         Currently, the Sedan constructor implicitly calls the Vehicle default parameterless constructor, also known as Vehicle().

        Let’s explicitly define a constructor in Vehicle.It should:

        take one parameter, double speed
        set Speed to speed
        set LicensePlate to a random value using Tools.GenerateLicensePlate()
        Note that this is very similar to both the Sedan and Truck constructors.

        After doing this you may see the following error:

        error CS7036: There is no argument given that corresponds to the required formal parameter 'speed' of 'Vehicle.Vehicle(double)'


        This is good! It proves to us that the Sedan constructor is calling the parameterless constructor Vehicle(). Now that we have explicitly defined a constructor Vehicle(double speed), there is no more Vehicle(), hence the error.

        Checkpoint 2 Step instruction is unavailable until previous steps are completed
        2.
        Back in Sedan.cs:

        Delete the lines in the constructor that set Speed and LicensePlate.
        Call the superclass constructor using : base(speed).
        Checkpoint 3 Step instruction is unavailable until previous steps are completed
        3.
        Repeat the process in Truck.cs:

        Delete the lines in the constructor that set Speed and LicensePlate.
        Call the superclass constructor using : base(speed).
        Checkpoint 4 Step instruction is unavailable until previous steps are completed
        4.
        Since the LicensePlate and Speed properties defined in Vehicle are no longer accessed in Sedan or Truck, they no longer need to be protected. Switch those two setters to private.
        */


    }
}
