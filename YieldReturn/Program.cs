using System;
using System.Collections;

namespace YieldReturn {
    class Program {
        static void Main(string[] args) {
            // NO YIELD
            //NoYield();

            // YIELD
            WithYield();

            Console.ReadLine();
        }

        #region NO YIELD
        static void NoYield() {
            // without using yield return
            // we have to create an array
            // call the FuncNoYield method
            // which creates the array 
            // iterating over each item
            int[] a = new int[10];
            a = FuncNoYield(2, 10);
            for (int i = 0; i < 10; i++) {
                Console.WriteLine(a[i]);
            }
        }

        private static int[] FuncNoYield(int start, int number) {
            int[] _number = new int[number];

            for (int i = 0; i < number; i++) {
                _number[i] = start + 2 * i;
            }
            return _number;
        }
        #endregion

        #region WITH YIELD
        static void WithYield() {
            // Using the yield return feature
            // we don't create an object
            foreach (var item in FuncWithYield(2, 10)) {
                Console.WriteLine(item);
            }
        }

        private static IEnumerable FuncWithYield(int start, int number) {
            for (int i = 0; i < number; i++) {
                // this method keeps track of which iterations we are on
                yield return start + 2 * i;
            }
        }
        #endregion

    }
}
