using System;
namespace Method
{
    class OverLoad
    {
        public static void Main(string[] agrs){
            Console.WriteLine($"Are of rectange: " + GetArea(5, 7));
            Console.WriteLine($"Are of rectange: " + GetArea(5.5, 7.7));
            Console.WriteLine($"Are of square: " + GetArea(5));
            Console.WriteLine(GetPrimer(1,2,4,5,6,6,7));

            Console.WriteLine(Sum(1,2,3,4,5,56,6,7,78,8,7,5,4,4,4,3,3,6));

        }

        // Get Area Rectangle
        static int GetArea(int width, int height){
            return width * height;
        }
        static double GetArea(double width, double height){
            return width * height;
        }
        // Get Area Square
        static int GetArea(int side){
            return side * side;
        }

        static int GetPrimer(params int[] paras){
            int total = 0;
            foreach(int number in paras){
                total+= number;
            }
            return total;
        }

        static int Sum(params int[] numbers){
            int total = 0;
            // for(int i=0; i< numbers.Length; i++){
            //     total += numbers[i];
            // }
            foreach(int number in numbers){
                total += number;
            }
            return total;
        }

        // Sum(1,3,4,5,6,7,7,8,9,9,0,0,0,-,7,6,5,5)
    }
}