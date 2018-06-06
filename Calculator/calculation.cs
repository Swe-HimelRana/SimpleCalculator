/*
 * Creating a simple Calculator Using C#
 * Name: Himel
 * ID: 153-35-1389
 * Spftware Engineering at Daffodil International University
 * This is not my first calculator so try to make something more effiecient. 
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Calculation
    {
        // Addition
        public static double addition(double num1, double num2)
        {
            return num1 + num2;
        }
        // Multiplication
        public static double multiplication(double num1, double num2)
        {
            return num1 * num2;
        }

        // Substruction
        public static double substruction(double num1, double num2)
        {
            return num1 - num2;
        }

        // Multiplication
        public static double division(double num1, double num2)
        {
            return num1 / num2;
        }

        // root
        public static double sqrt(double num)
        {
            return Math.Sqrt(num);
        }

        // Squire
        public static double squire(double num)
        {
            return num * num;
        }

    }
}
