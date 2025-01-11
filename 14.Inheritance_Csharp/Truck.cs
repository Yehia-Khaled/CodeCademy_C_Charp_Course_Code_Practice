using Accord.Math;
using Microsoft.VisualStudio.Services.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.Inheritance_Csharp
{
    internal class Truck : Vehicle
    {
        //1. Introduction to Inheritance
        /* public string LicensePlate
         { get; }

         public double Speed
         { get; private set; }

         public int Wheels
         { get; }

         public double Weight
         { get; }

         public Truck(double speed, double weight)
         {
             Speed = speed;
             LicensePlate = Tools.GenerateLicensePlate();
             Weight = weight;

             if (weight < 400)
             {
                 Wheels = 8;
             }
             else
             {
                 Wheels = 12;
             }
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

        //5. Remove Duplicate Code
        /*Instructions
        Checkpoint 1 Enabled
        1.
        Make Truck inherit from Vehicle:

        Use the colon syntax to announce that Truck inherits from the Vehicle class.
        Remove the duplicated properties and methods from Truck.
        

        //Code Solution
        public double Weight
        { get; }

        public Truck(double speed, double weight)
        {
            Speed = speed;
            LicensePlate = Tools.GenerateLicensePlate();
            Weight = weight;

            if (weight < 400)
            {
                Wheels = 8;
            }
            else
            {
                Wheels = 12;
            }
        */
        public double Weight
        { get; }

        public Truck(double speed, double weight)
        {
            Speed = speed;
            LicensePlate = Tools.GenerateLicensePlate();
            Weight = weight;

            if (weight < 400)
            {
                Wheels = 8;
            }
            else
            {
                Wheels = 12;
            }
        }
    }
}

