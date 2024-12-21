using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace ConverstionDataTypes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your favorite number!: ");

            // Turn that answer into an int
            string faveNumber = Console.ReadLine();
            int num = Convert.ToInt32(faveNumber);
            Console.WriteLine(num);
            //      int faveNumber=Convert.ToInt32(Console.ReadLine());

        }
    }
}
