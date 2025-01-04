using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        //Code Solution
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
    }



}
