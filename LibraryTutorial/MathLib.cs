using System;

namespace LibraryTutorial {
    public class MathLib {
        //public string About { get; set; } = "About Math Lib";

        public int Add(int i, int j) {
            return i + j;
        }
        public int Subtract(int i, int j) {
            return i - j;
        }
        public int Multiply(int i, int j) {
            return i * j;
        }
        public int Divide(int i, int j) {
            return i / j;
        }
        public int Modulo(int i, int j) {
            return i - (i / j * j);

        }
        public int Power(int i, int j) {
            var answer = 1;
            for (int idx = 0; idx < j; idx++) {
                answer *= i;

            }
            return answer;
        }
    }
}

