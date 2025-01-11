using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.Inheritance_Csharp
{
    internal class Vehicle
    {
        //3. Create a Superclass
        public string LicensePlate
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

    }
}
