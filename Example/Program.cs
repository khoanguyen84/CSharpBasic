using System;

namespace Example {
    class Program {
        static void Main (string[] args) {
            // int[] A = new int[] { 1, 8, 3, 7, 10, 2 };
            // int[] A = new int[] { 1, 5, 3, 1, 1, 1, 1, 1, 1 };
            int[] A = new int[] { };
            
            // Console.WriteLine (POE.f(A));

            POE poe = new POE ();
            Console.WriteLine (poe.f (A));

                        
            // int poeValue = poe.f (A);
            // if (poeValue == -1) {
            //     Console.WriteLine ("-1 Reason: NO POE.");
            // } else {
            //     string beforePOE = "";
            //     string afterPOE = "";
            //     for (int i = 0; i < poeValue; i++) {
            //         if(i == poeValue - 1){
            //             beforePOE += $"a[{i}]";
            //         }
            //         else{
            //             beforePOE += $"a[{i}] + ";
            //         }
            //     }
            //     for (int i = poeValue; i < A.Length; i++) {
            //         if(i == A.Length - 1){
            //             afterPOE += $"a[{i}]";
            //         }
            //         else{
            //             afterPOE += $"a[{i}] + ";
            //         }
            //     }

            //     Console.WriteLine ($"{poeValue} Reason: {beforePOE} is equal to {afterPOE}");
            // }

            // Reverse reverse = new Reverse();

            // Console.WriteLine(reverse.ReverseNumber(0));
            Console.WriteLine(ReverseNumber(234234));
        }

        public static int ReverseNumber(int number)
        {
            bool isNegative = number < 0;
            number = Math.Abs(number);
            int surplus = 0;
            int reverse = 0;
            while (number > 0)
            {
                surplus = number % 10;
                number = number / 10;
                reverse = reverse* 10 + surplus;
            }
            return isNegative ? reverse * -1 : reverse;
        }
    }
}