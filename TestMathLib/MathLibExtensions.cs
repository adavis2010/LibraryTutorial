using System;
using System.Collections.Generic;
using System.Text;

namespace TestMathLib {
    //class must be marked static
    public static class MathLibExtensions {
        //extension method with two parameters
        public static int Power(this int i, int j){
            var answer = 1;
                for(var idx = 0; idx < j; idx++) {
                answer *= i;
            }
            return answer;

        }

        // extension method
        public static int Squared(this int i) {
            return i * i;

        }

    }
}
