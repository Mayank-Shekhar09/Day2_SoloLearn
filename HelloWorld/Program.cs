﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("C# is cool");
            CircleArea cr = new CircleArea();
            cr.Area();
            DivisibleBy3 dvobj = new DivisibleBy3();
            dvobj.DivBy3();

        }
    }
}
