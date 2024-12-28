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
            
            //Code Solution 
            VisitPlanets(3);
            VisitPlanets(6);
            VisitPlanets(10);
            */

            //5. Return Statement
            /*Instructions
             Checkpoint 1 Enabled
             1.
             Let’s define a static method DecoratePlanet() that takes a planet name as input and returns a fancy welcome message.

             First, write the method declaration. It should have a string parameter and return a string.
                         Note: A build error, error CS0161, at this step is notifying you that this method should return a string but does not. In the next step,
                 you will add the required return statement to the method.

             Checkpoint 2 Step instruction is unavailable until previous steps are completed
             2.
             Write the method body so that it returns a fancy welcome to the planet using string interpolation. For example, calling

             DecoratePlanet("Mars");

                         Copy to Clipboard

                         returns:

             "*.*.* Welcome to Mars *.*.*"

             Copy to Clipboard

             Checkpoint 3 Step instruction is unavailable until previous steps are completed
             3.
             Call the method with the argument "Jupiter" and print its output to the console.
            

            //Code Solution
            Console.WriteLine(DecoratePlanet("Jupiter"));
            */

            //6. Method Overloading 
            /*//Instructions
            Checkpoint 1 Enabled
            1.
            Let’s practice implementing our own overloads by building a method called IntroduceFriends() with 3 overloads.

            First write a method IntroduceFriends() that takes 2 string arguments.

            If you call it, like:

            IntroduceFriends("Laika", "Albert");

                        Copy to Clipboard

                        it should print a message including the names in the console, like:

            These are my friends, Laika and Albert!

            Copy to Clipboard

            Checkpoint 2 Step instruction is unavailable until previous steps are completed
            2.
            Then write another method IntroduceFriends() that takes 3 string arguments. When you call it:

            IntroduceFriends("Naomi", "Jasmine", "Cyrus");

                        Copy to Clipboard

                        it should print a message including the names in the console, like:

            These are my friends, Naomi, Jasmine, and Cyrus!

            Copy to Clipboard

            Checkpoint 3 Step instruction is unavailable until previous steps are completed
            3.
            Add a third IntroduceFriends() method with 0 arguments.When you call it:

            IntroduceFriends();
                        Copy to Clipboard

                        everyone knows each other, and no one needs an introduction!Print a message like:

                        There is no one who needs to be introduced.
            
            // Code Solution
            IntroduceFriends("Laika", "Albert");
            IntroduceFriends("Laika", "Albert", "Hany");
            IntroduceFriends();
            */

            //7. Out Parameters
            /*
             * //Instructions
            Checkpoint 1 Enabled
            1.
            Let’s start by working with another existing method that utilizes an out parameter, Double.TryParse().

            The program in the code editor already defines a variable called scoreAsString, which holds a score(out of 100) as a string.

            To begin, define 2 variables:

                        a bool named outcome, which will store whether or not the string was successfully parsed as a double
                        a double named scoreAsDouble, which will store the parsed value
            Checkpoint 2 Step instruction is unavailable until previous steps are completed
            2.
            Next, call Double.TryParse() to convert scoreAsString to a double, passing scoreAsDouble as the out argument.Save the result of the function call to the variable outcome.

            The signature for Double.TryParse() looks like:

            public static bool TryParse(string? s, out double result);

                        Copy to Clipboard

                        Checkpoint 3 Step instruction is unavailable until previous steps are completed
            3.
            Print outcome and scoreAsDouble to the console.

            Checkpoint 4 Step instruction is unavailable until previous steps are completed
            4.
            Now, let’s create a method of our own that uses an out parameter!

            Declare a method Whisper() with a string parameter and out bool parameter. It should return a string.

            Checkpoint 5 Step instruction is unavailable until previous steps are completed
            5.
            Whisper() should return a lowercase version of its string argument.

            Once defined, you should be able to call it like:

                        string statement = "Hello World";
                        Whisper(statement, out bool marker);
                        // should return  "hello world" and set marker to true;

                        Copy to Clipboard

                        Checkpoint 6 Step instruction is unavailable until previous steps are completed
            6.
            Call Whisper() in the Main() method, passing statement as its string argument, then print the returned value to the console.

            Make sure to use an out modifier when calling the method!
            */
            //Code Solution
            string scoreAsString = "85.6";
            string statement = "Hello World";

            double scoreAsDouble;
            bool outcome;

            outcome = Double.TryParse(scoreAsString, out scoreAsDouble);

            Console.WriteLine($"{outcome}, {scoreAsDouble}");

            string whispered = Whisper(statement, out bool marker);
            Console.WriteLine(whispered);

        }
        /*
        static void VisitPlanets()
        {
            Console.WriteLine("You visited many new planets…");
        }
        

        //4. Method Parameters: Code Solution
        static void VisitPlanets(int numberOfPlanets)
        {
            Console.WriteLine($"You visited {numberOfPlanets} new planets...");
        }
        
        //5. Return Statement: Code Solution
        static string DecoratePlanet(string planet)
        {
            return $"*..*..* Welcome to {planet} *..*..*";
        }
        
        //6. Method Overloading:Code
        static void IntroduceFriends(string st1, string st2)
        {
            Console.WriteLine($"These are my friends, {st1} and {st2}!");
        }
        static void IntroduceFriends(string st1, string st2, string st3)
        {
            Console.WriteLine($"These are my friends, {st1} ,{st3} and {st3}!");
        }
        static void IntroduceFriends()
        {
            Console.WriteLine($"There is no one who needs to be introduced.");
        }
        */
        //7. Out Parameters: Code Solution
        static string Whisper(string phrase, out bool wasWhisperCalled)
        {
            wasWhisperCalled = true;
            return phrase.ToLower();
        }

    }
}
