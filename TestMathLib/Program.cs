using System;
using LibraryTutorial;

namespace TestMathLib {
    class Program {
        static void Main(string[] args) {
            //create instance of Math Library
            var mathLib = new MathLib();

            //confirming connection with console app and library
            Console.WriteLine($" About is {mathLib.About}");
        }
    }
}
