﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.IntroToClasses_CSharp
{
    internal class Forest
    {
        public string name;
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

    }
}
