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
        private string name;
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
    }
}
