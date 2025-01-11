using System;
using System.Collections.Generic;
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
        public string LicensePlate
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

    }
}
