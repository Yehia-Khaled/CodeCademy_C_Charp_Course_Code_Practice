using System;

namespace _12.IntroToClasses_CSharp
{
    internal class Forest
    {
        /*
        string name;
        public string biome;

        public int trees;
        public int age;
        //4. Methods Code Solution
        public int Grow()
        {
            trees += 30;
            age++;
            return trees;
        }
        public int Burn()
        {
            trees -= 20;
            age++;
            return trees;
        }
        */
        //5. this: Code solution
        /*public string name;
        public int trees;
        public int age;
        public string biome;

        public int Grow()
        {
            this.trees += 30;
            this.age++;
            return this.trees;
        }

        public int Burn()
        {
            trees -= 20;
            age++;
            return trees;
        }
        

        //6. Constructors
        public string name;
        public int trees;
        public int age;
        public string biome;

        public Forest(string name, string biome)
        {
            this.name = name;
            this.biome = biome;
            age = 1;
        }


        public int Grow()
        {
            this.trees += 30;
            this.age++;
            return this.trees;
        }

        public int Burn()
        {
            trees -= 20;
            age++;
            return trees;
        }
        */

        //7.Overloading Constructors :Code Solution
        public string name;
        public int trees;
        public int age;
        public string biome;

        public Forest(string name, string biome)
        {
            this.name = name;
            this.biome = biome;
            age = 1;
        }
        public Forest(string name) : this(name, "Unknown")
        {
            Console.WriteLine("No biome provided ,vlue defaulted to Unknown");
        }

        public int Grow()
        {
            this.trees += 30;
            this.age++;
            return this.trees;
        }

        public int Burn()
        {
            trees -= 20;
            age++;
            return trees;
        }
    }
}
