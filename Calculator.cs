﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lommeregner

{

    internal class Calculator
    {
        public static int Add(int x, int y)
        { 
            return x + y; }

        public static int Subtract(int x, int y)
        {
            return x - y;
        }

        public static double Divide(int x, int y)
        {
            return x / y;
        }
        public static int Multiply(int x, int y)
        {
            return x * y;
        }
    }
 
}