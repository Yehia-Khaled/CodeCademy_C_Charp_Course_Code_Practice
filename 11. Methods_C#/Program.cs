using System;

namespace _11.Methods_C_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Lesson 11. Methods in C#

            //2. Calling Methods
            /*Instructions
            Checkpoint 1 Enabled
            1.
            The designer of C# is "Anders Hejlsberg" — we’ve stored his name in a variable called designer. Call Console.WriteLine() using designer as an argument.

            Checkpoint 2 Step instruction is unavailable until previous steps are completed
            2.
            Now, let’s print only Anders’ second name.

            First, find the index of the space(" ") in the string designer and store it in a variable indexOfSpace.

            You’ll need to use the IndexOf() method.

            Checkpoint 3 Step instruction is unavailable until previous steps are completed
            3.
            The space character itself is not part of the second name.

            Create a new integer indexOfSecondName and instanciate it with a value of indexOfSpace plus 1.

            Checkpoint 4 Step instruction is unavailable until previous steps are completed
            4.
            Use Substring() and the variable indexOfSecondName to get the second name.

            Store the returned value in a variable secondName.You can view the documentation if you’re not sure how to use this method.

            Checkpoint 5 Step instruction is unavailable until previous steps are completed
            5.
            Print secondName to the console.
            
            //Code Solution
            string designer = "Anders Hejlsberg";
            Console.WriteLine(designer);
            int indexOfSpace = designer.IndexOf(" ");
            int indexOfSecondName = indexOfSpace + 1;

            string secondName = designer.Substring(indexOfSecondName);

            Console.WriteLine(secondName);
            */

            //3.Defining Methods
            /*Instructions
            Checkpoint 1 Enabled
            1.
            Define a method named VisitPlanets() outside of the Main() method and run the code.

            VisitPlanets() can print anything you’d like to the console, but something like “You visited many new planets…” would be appropriate.

            Checkpoint 2 Step instruction is unavailable until previous steps are completed
            2.
            Why isn’t your method executed? It’s not called within Main().Call it in Main() and run the code again.
            
            //Code Solution
            VisitPlanets();
            */

            //4. Method Parameters
            /*
             * //Instructions
             Checkpoint 1 Enabled
             1.
             The VisitPlanets() method has been re-written for you here.

             Add an int parameter named numberOfPlanets to the method.
                         Checkpoint 2 Step instruction is unavailable until previous steps are completed
             2.
             Change the method body so that it uses the parameter.If someone were to call your method, it should print how many planets they visited.For example, calling VisitPlanets(3) would cause this to be printed:

             You visited 3 new planets...

             Copy to Clipboard

             Checkpoint 3 Step instruction is unavailable until previous steps are completed
             3.
             Call VisitPlanets() three times in Main() with different arguments.
            */
            //Code Solution 
            VisitPlanets(3);
            VisitPlanets(6);
            VisitPlanets(10);

        }
        /*
        static void VisitPlanets()
        {
            Console.WriteLine("You visited many new planets…");
        }
        */

        //4. Method Parameters: Code Solution
        static void VisitPlanets(int numberOfPlanets)
        {
            Console.WriteLine($"You visited {numberOfPlanets} new planets...");
        }
    }
}
