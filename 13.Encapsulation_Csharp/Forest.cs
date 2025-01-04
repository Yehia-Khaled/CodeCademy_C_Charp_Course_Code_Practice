using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace _13.Encapsulation_Csharp
{
    internal class Forest
    {

        /* 
         * public string name;
        int trees;
        int age;
        public string biome;

        public Forest(string name, string biome)
        {
            this.name = name;
            this.biome = biome;
            age = 1;
        }

        public void Grow()
        {
            trees += 20;
            age++;
        }

        public void AnnounceForest()
        {
            Console.WriteLine($"The {name} {biome} Forest is {age} years old and has {trees} trees");
        }
        */

        //3. Properties: Code Solution
        /*private string name;
        public int trees;
        public int age;
        private string biome;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Biome
        {
            get { return biome; }
            set
            {
                if (value == "Tropical")
                    biome = "Tropical";
                else if (value == "Temperate")
                    biome = "Temperate";
                else if (value == "Boreal")
                    biome = "Boreal";
                else
                    biome = "Unknown";
            }
        }
        */

        //4. Auto-Implemented Properties :Code Solution
        /*public string Name
        {
            get; set;
        }


        public int Trees
        {
            get; set;
        }

        public int age;

        private string biome;
        public string Biome
        {
            get
            {
                return biome;
            }
            set
            {
                string[] validBiomes = { "Tropical", "Temperate", "Boreal" };
                if (Array.IndexOf(validBiomes, value) >= 0)
                {
                    biome = value;
                }
                else
                {
                    biome = "Unknown";
                }
            }

        }
        */
        //5. Get-Only Properties : Code solution
        /*private int age;

        public int Age
        {
            get { return age; }
            private set { age = value; }
        }

        public string Name
        { get; set; }

        public int Trees
        { get; set; }

        private string biome;
        public string Biome
        {
            get
            {
                return biome;
            }
            set
            {
                string[] validBiomes = { "Tropical", "Temperate", "Boreal" };
                if (Array.IndexOf(validBiomes, value) >= 0)
                {
                    biome = value;
                }
                else
                {
                    biome = "Unknown";
                }
            }
        }
        */

        //6. Static Fields and Properties
        /*
         *Instructions
            Checkpoint 1 Enabled
            1.
            We’ve filled out properties, constructors, and methods for the Forest class. Review the code in the editor and ensure you understand how the code works.

            Let’s create a static property on the Forest class to keep track of the total number of forests created.Define a public static property named ForestsCreated with a public getter and a private setter.

            Checkpoint 2 Step instruction is unavailable until previous steps are completed
            2.
            In the first constructor, increment ForestsCreated.This will add 1 to the property every time a Forest object is constructed.
           
         * //Code Solution
         // FIELDS/PROPERTIES
         public string Name
         { get; set; }

         public int Trees
         { get; set; }

         private int age;
         public int Age
         {
             get { return age; }
             private set
             {
                 if (value < 0)
                 {
                     age = 0;
                 }
                 else
                 {
                     age = value;
                 }
             }
         }

         public static int ForestsCreated
         {
             get;
             private set;
         }

         private string biome;
         public string Biome
         {
             get { return biome; }
             set
             {
                 string[] validBiomes = { "Tropical", "Temperate", "Boreal" };
                 if (Array.IndexOf(validBiomes, value) >= 0)
                 {
                     biome = value;
                 }
                 else
                 {
                     biome = "Unknown";
                 }
             }
         }

         // CONSTRUCTORS
         public Forest(string name, string biome)
         {
             Name = name;
             Biome = biome;
             Age = 0;
             Forest.ForestsCreated++;
         }

         public Forest(string name) : this(name, "Unknown")
         { }


         // METHODS
         public int Grow()
         {
             Trees += 30;
             Age += 1;
             return Trees;
         }

         public int Burn()
         {
             Trees -= 20;
             Age += 1;
             return Trees;
         }
         */

        //7. Static Methods
        /* Instructions
         Checkpoint 1 Enabled
         1.
         Let’s create a method that outputs some information about forests in general.We’ll use a field and property to store the explanation.

         Start by defining a private static string field named forestFacts.Do not initialize forestFacts with a value.

         Checkpoint 2 Step instruction is unavailable until previous steps are completed
         2.
         Next, define a private static property named ForestFacts with just a getter(no setter). Do not initialize ForestFacts with a value either.

         Checkpoint 3 Step instruction is unavailable until previous steps are completed
         3.
         Finally, define a public static method named PrintForestFacts() that writes the value of ForestFacts to the console.

         Note that ForestFacts is never assigned a value — we’ll address this in the next exercise.
        
        //code Solution
        // FIELDS/PROPERTIES
        public string Name
        { get; set; }

        public int Trees
        { get; set; }

        private int age;
        public int Age
        {
            get { return age; }
            private set
            {
                if (value < 0)
                {
                    age = 0;
                }
                else
                {
                    age = value;
                }
            }
        }

        private string biome;
        public string Biome
        {
            get { return biome; }
            set
            {
                string[] validBiomes = { "Tropical", "Temperate", "Boreal" };
                if (Array.IndexOf(validBiomes, value) >= 0)
                {
                    biome = value;
                }
                else
                {
                    biome = "Unknown";
                }
            }
        }

        public static int ForestsCreated
        {
            get; private set;
        }

        private static string forestFacts;
        private static string ForestFacts
        {
            get
            {
                return forestFacts;
            }
        }

        // CONSTRUCTORS
        public Forest(string name, string biome)
        {
            Name = name;
            Biome = biome;
            Age = 0;
            ForestsCreated++;
        }

        public Forest(string name) : this(name, "Unknown")
        { }


        // METHODS
        public int Grow()
        {
            Trees += 30;
            Age += 1;
            return Trees;
        }

        public int Burn()
        {
            Trees -= 20;
            Age += 1;
            return Trees;
        }

        public static void PrintForestFacts()
        {
            Console.WriteLine(ForestFacts);
        }
        */

        //8. Static Constructors
        /* Instructions
         Checkpoint 1 Enabled
         1.
         In the previous exercises, our forestsCreated and forestFacts fields were never given starting values! Let’s fix that.

         First, create a static constructor for Forest.

         Checkpoint 2 Step instruction is unavailable until previous steps are completed
         2.
         In the body of the static constructor, set the forestFacts field to this string:

         "Forests provide a diversity of ecosystem services including:\n\taiding in regulating climate.\n\tpurifying water.\n\tmitigating natural hazards such as floods.\n"

         Copy to Clipboard

         Checkpoint 3 Step instruction is unavailable until previous steps are completed
         3.
         Also, within the body of the static constructor, set the ForestsCreated property to 0.

         Checkpoint 4 Step instruction is unavailable until previous steps are completed
         4.
         In Program.cs, call Forest.PrintForestFacts() to check that the ForestFacts property was set.

         */


    }



}
