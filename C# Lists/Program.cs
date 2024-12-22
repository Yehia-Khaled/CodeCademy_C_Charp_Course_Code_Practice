﻿using System;

namespace C__Lists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * //Introduction to Lists
            List<string> citiesList = new List<string> { "Delhi", "Los Angeles", "Saint Petersburg" };

            citiesList.Add("New York City");

            citiesList.Remove("Delhi");

            citiesList.AddRange(new string[] { "Cairo", "Johannesburg" });

            bool hasNewDelhi = citiesList.Contains("New Delhi");

            foreach (string city in citiesList)
            {
                Console.WriteLine(city);
            }
            */

            //Creating and Adding
            /*Instructions
            Checkpoint 1 Passed
            1.
            Create a list to hold the top women’s marathon times in minutes.Create an empty list of type double and store it in a variable marathons.

            Checkpoint 2 Passed
            2.
            Jemima Sumgong won the 2016 marathon in Rio de Janeiro with a time of 144.07 minutes and Tiki Gelana won the 2012 marathon in London with a time of 143.12 minutes. (That’s just 2 hours 23 minutes and 7.2 seconds!)

            Use two Add() statements to add those values to the list.

            Checkpoint 3 Passed
            3.
            Print the second value in the list to the console.
           
            List<double> marathons = new List<double>();
            marathons.Add(144.07);
            marathons.Add(143.12);
            Console.WriteLine(marathons[1]);
             */

            //Object Initialization
            /*Instructions
            Checkpoint 1 Passed
            1.
            The current code creates an empty list and uses Add() to add elements.

            Delete those lines and make the same list with an object initialization.
            List<double> marathons = new List<double>();
            marathons.Add(144.07);
            marathons.Add(143.12);
            marathons.Add(146.73);
            marathons.Add(146.33);

            // Do not delete the code below
            double time = marathons[1];

            Console.WriteLine($"The 2012 marathon was ran in {time} minutes!");
            
            /*List<double> marathons = new List<double> { 144.07, 143.12, 146.73, 146.33 };
            double time = marathons[1];

            Console.WriteLine($"The 2012 marathon was ran in {time} minutes!");
            */

            /*
             * //Count and Contains
            Instructions
            Checkpoint 1 Passed
            1.
            The list marathons has been initialized for you.Print the Count to the console.

            Checkpoint 2 Passed
            2.
            In the 2000 Sydney Olympic Games, Naoko Takahashi won the marathon with a time of 143.23 minutes(the Olympic record until 2012 in London).

            Use Add() to add that value to the list.

            Checkpoint 3 Passed
            3.
            Make sure that 143.23 was added to the list.Call the Contains() method and print the returned value to the console.

            Checkpoint 4 Passed
            4.
            Print Count again.Make sure it increased to 5!

                     List<double> marathons = new List<double>
                      {
                        144.07,
                        143.12,
                        146.73,
                        146.33
                      };

                    Console.WriteLine(marathons.Count);
                    marathons.Add(143.23);
                    bool returnMarthon = marathons.Contains(143.23);
                    Console.WriteLine(returnMarthon);
                    Console.WriteLine($"Marthon count after add one time is {marathons.Count}.");
            */

            //Removing
            /*Instructions
            Checkpoint 1 Enabled
            1.
            The list marathons has been initialized for you.Print the second element in the list.

            Checkpoint 2 Step instruction is unavailable until previous steps are completed
            2.
            Remove the item 143.12(which is currently the second item in the list) and store the result in a bool variable named removed.

            Checkpoint 3 Step instruction is unavailable until previous steps are completed
            3.
            Print the second element again and the value of removed.The second element should be different and removed should be true.
            
            List<double> marathons = new List<double>
              {
                144.07,
                143.12,
                146.73,
                146.33
              };

            Console.WriteLine(marathons[1]);
            bool removed = marathons.Remove(143.12);
            Console.WriteLine(marathons[1]);
            Console.WriteLine($"Removed Value is {removed}.");
            */

            //Clearing
            /*Instructions
            Checkpoint 1 Enabled
            1.
            The marathons list has a bunch of old values that we need to remove.

            Use Clear() to remove all of them.
                  List<double> marathons = new List<double>
            {
            148.22,
            156.10,
            153.88,
            155.34,
            160.89
            };
      
            // Clear the list here
            marathons.Clear();
      
            Console.WriteLine($"Count: {marathons.Count}");
            */

            /*//Looping through Lists
            Instructions
            Checkpoint 1 Enabled
            1.
            The second for loop in the code is used to print out a bib for each runner. Replace it with a foreach loop that achieves the same objective.
            */
            Console.WriteLine("Add commit to Git Repository Locally");
            Console.WriteLine("Add commit to Git Repository On GitHub website");



        }

    }

}
