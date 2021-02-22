using System;
using LibraryTutorial;

namespace TestMathLib {
    class Program {
        static void Main(string[] args) {
            //create instance of Math Library
            var mathLib = new MathLib();

            //confirming connection with console app and library
            //Console.WriteLine($" About is {mathLib.About}");




            Console.WriteLine($"12 + 3 {mathLib.Add(12, 3)}");

            Console.WriteLine($"12 - 3 {mathLib.Subtract(12, 3)}");

            Console.WriteLine($"12 * 3 {mathLib.Multiply(12, 3)}");

            Console.WriteLine($"12 % 3 {mathLib.Modulo(12, 3)}");

            Console.WriteLine($"12 ^ 3 {mathLib.Power(12, 3)}");





        }

    }
}
