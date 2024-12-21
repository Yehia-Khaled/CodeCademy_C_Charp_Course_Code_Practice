using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //C#: Arrays

            /*//Accessing Array Items
            string[] summerStrut;

            summerStrut = new string[] { "Juice", "Missing U", "Raspberry Beret", "New York Groove", "Make Me Feel", "Rebel Rebel", "Despacito", "Los Angeles" };

            int[] ratings = { 5, 4, 4, 3, 3, 5, 5, 4 };
            Console.WriteLine($"You rated the song {summerStrut[1]} {ratings[1]} stars. ");
            */

            /*//Editing Arrays
            string[] summerStrut;

            summerStrut = new string[] { "Juice", "Missing U", "Raspberry Beret", "New York Groove", "Make Me Feel", "Rebel Rebel", "Despacito", "Los Angeles" };

            int[] ratings = { 5, 4, 4, 3, 3, 5, 5, 4 };
            summerStrut[7] = "Can You see me";
            ratings[7] = 5;
            */

            //Built-In Methods
               /*
                Using an Array method, find the position for the first 3-star rated song and save it to a variable. Print a message to the console, like “Song number X is rated three stars”.

                Remember that in C# arrays are 0-indexed, but when talking about the list of song titles outside the context of our program, we would consider the first song number 1.

                Checkpoint 2 Passed
                2.
                Using an Array method, reverse the order of the titles in summerStrut. Print out the first and last titles to confirm that the elements have been reordered.

                Checkpoint 3 Passed
                3.
                Organize the playlist alphabetically. To check that it worked, print the first and last song titles to the console.
                
                string[] summerStrut;
      
                summerStrut = new string[] { "Juice", "Missing U", "Raspberry Beret", "New York Groove", "Make Me Feel", "Rebel Rebel", "Despacito", "Los Angeles" };
      
                int[] ratings = { 5, 4, 4, 3, 3, 5, 5, 4 };
                Console.WriteLine($"Song number {Array.IndexOf(ratings,3) + 1 } is rated three stars");
                Array.Reverse(summerStrut);
                Console.WriteLine(summerStrut[0] +" "+summerStrut[7]);
                Array.Sort(summerStrut);
                Console.WriteLine($" Output after array sort music 1 is {summerStrut[0]} and last one is {summerStrut[7]} ");
               */
    }
    }
}
