using System;
using System.Collections;

namespace Lesson1
{
    class ArrayDemo
    {
        public static void Main(string[] args)
        {
            // int n1 = 5;
            // int n2 = 15;
            // int n3 = 25;
            // int n4 = 55;
            // int n5 = 15;


            // int[] numbers2 = new int[0];
            // int[] numbers = new int[10]{ 1,2,3,5,6,7,9,8,9,2};
            // int[] numbers3 = new int[]{ 1,2,3,5,6,7,9,8,9,2,5,6,7,8,9};
            // numbers[3] = 50;
            // int[] numbers = new int[10];
            // numbers[0] = 8;
            // numbers[1] = 8;
            // numbers[2] = 8;
            // numbers[3] = 8;
            // numbers[4] = 8;
            // numbers[5] = 8;
            // numbers[6] = 8;
            // numbers[7] = 8;
            // numbers[8] = 8;
            // numbers[9] = 8;
            // numbers[10] = 8;

            // Console.Write(numbers);
            // Console.Write(string.Join("\n", numbers3));
            // Console.Write($"numbers[{5}] = {numbers[5]}");
            // Console.WriteLine($"Size before = {numbers3.Length}");
            // Array.Resize(ref numbers, 20);
            // Console.WriteLine($"Size after = {numbers.Length}");
            // for(int i=0; i < numbers3.Length; i++){
            //     Console.Write(numbers3[i] + ",");
            // }
            // int[] numbers = new int[0];
            // int number = 0;
            // do{
            //     Console.Write("Enter number: ");
            //     number = int.Parse(Console.ReadLine());
            //     Array.Resize(ref numbers, numbers.Length + 1);
            //     numbers[numbers.Length - 1] = number;
            // }
            // while(number != 0);
            // Console.Write(String.Join("-", numbers));

            int[] numbers;
            int size = 0;
            int min = 10;
            int max = 90;
            Console.Write("Enter size: ");
            size = int.Parse(Console.ReadLine());
            numbers = new int[size];
            Random rnd = new Random();
            for (int i = 0; i < size; i++)
            {
                numbers[i] = rnd.Next(min, max);
            }
            Console.WriteLine(String.Join("-", numbers));
            Console.Write("Enter find number: ");
            int findValue = int.Parse(Console.ReadLine());
            int position = -1;
            for (int i = 0; i < size; i++)
            {
                if(numbers[i] == findValue){
                    position = i;
                    break;
                }
            }
            if(position == -1){
                Console.Write("Not found");
            }
            else{
                Console.Write($"{findValue} is at position {position}");
            }
        }
    }
}