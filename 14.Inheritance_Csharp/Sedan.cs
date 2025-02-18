﻿//using Microsoft.TeamFoundation.WorkItemTracking.Client.Wiql;
using Accord.Math;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.Inheritance_Csharp
{
    internal class Sedan : Vehicle
    {
        //1. Introduction to Inheritance
        /*public string LicensePlate
        { get; }

        public double Speed
        { get; private set; }

        public int Wheels
        { get; }

        public Sedan(double speed)
        {
            Speed = speed;
            LicensePlate = Tools.GenerateLicensePlate();
            Wheels = 4;
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
        //3. Create a Superclass
        /*
         * //Code Solution
        public Sedan(double speed)
        {
            Speed = speed;
            LicensePlate = Tools.GenerateLicensePlate();
            Wheels = 4;
        }
        */

        //6. Access Inherited Members with Base
        public Sedan(double speed) : base(speed)
        {

            Wheels = 4;
        }
    }


}
