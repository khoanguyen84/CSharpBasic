using System;

namespace Ex168 {
    class Program {
        static void Main (string[] args) {
            int size = 20;
            int min = 5;
            int max = 25;
            int[] numbers = GenerateArray (size, min, max);
            PrintArray (numbers);
            Console.WriteLine($"5^K: {Exist5PowerK(numbers)}");
        }

        static int[] GenerateArray (int size, int min, int max) {
            int[] numbers = new int[size];
            Random rnd = new Random ();
            for (int i = 0; i < size; i++) {
                numbers[i] = rnd.Next (min, max);
            }
            return numbers;
        }

        static void PrintArray (int[] numbers) {
            for (int i = 0; i < numbers.Length; i++) {
                Console.WriteLine (numbers[i]);
            }
        }

        static bool Is5PowerK (int number) {
            int temp = number;
            while (temp > 1) {
                if (temp % 5 != 0) {
                    return false;
                }
                temp = temp / 5;
            }
            return true && number >= 5;
        }

        static int Exist5PowerK(int[] numbers){
            int position = -1;
            int max = 0;
            for(int i = 0; i< numbers.Length; i++){
                if(Is5PowerK(numbers[i])){
                    if(numbers[i] > max){
                        max = numbers[i];
                        position = i;
                    }
                    
                }
            }
            if(position != 1){
                return max;
            }
            return 0;
        }
    }
}