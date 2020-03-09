using System;

namespace Lab1
{
    class Program
    { 

        static void DifferenceTwoNums(ref double num1, ref double num2)
        {
            Console.WriteLine("Разность двух чисел: " + (num1 - num2));
        }
         
        static void Main(string[] args)
        {
            double num1 = 4, num2 = 3;
            DifferenceTwoNums(ref num1, ref num2);


        }
    }
}
