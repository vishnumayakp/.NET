﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsConcept
{
    public class Calculator
    {
        public int Add(int num1,int num2)
        {
            return num1 + num2;
        }

        public int Add(int num1, int num2,int num3)
        {
            return num1 + num2 + num3;

        }

        public double Add(double num1,double num2)
        {
            return num1 + num2;
        }

        public double Add(double num1,int num2)
        {
            return num1 + num2;
        }
    }
}
