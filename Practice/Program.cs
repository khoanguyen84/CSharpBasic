using System;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            while(input[0] != 'q'){
                Console.WriteLine(input);

                input = Console.ReadLine();
                float a = 7;
                float b = 8;
                float c = (float)(Math.Sqrt(a*a + b*b));
            }
        }
    }
}
