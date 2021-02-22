using System;
using LibraryTutorial;

namespace TestMathLib {
    class Program {
        static void Main(string[] args) {
             //extension method for Console WriteLine
            "This is a test".Print();

            //extension method using two parameters
            Console.WriteLine($"2 ^ 3 {2.Power(3)}");

            //using extension method First thing we did 
            Console.WriteLine($"3 squared is {3.Squared()}");

            //create instance of Math Library
            var mathLib = new MathLib();

            //confirming connection with console app and library
            //Console.WriteLine($" About is {mathLib.About}");


            //Test Methods in Console Project by printing

            Console.WriteLine($"12 + 3 {mathLib.Add(12, 3)}");

            Console.WriteLine($"12 - 3 {mathLib.Subtract(12, 3)}");

            Console.WriteLine($"12 * 3 {mathLib.Multiply(12, 3)}");

            Console.WriteLine($"12 % 3 {mathLib.Modulo(12, 3)}");

            Console.WriteLine($"12 ^ 3 {mathLib.Power(12, 3)}");





        }

    }
}
