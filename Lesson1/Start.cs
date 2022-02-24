using System;
namespace Lesson1
{
    class Start
    {
        public static void Main(string[] arg)
        {
            Console.Write("Enter size: ");
            int size = int.Parse(Console.ReadLine());
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    // if (j <= i)
                    // {
                    //     Console.Write("* ");
                    // }
                    // else
                    // {
                    //     Console.Write("  ");
                    // }
                    Console.Write(j <= i ? "* " : "  ");
                }
                Console.WriteLine();
            }

            int n1 = 8, n2 = 10, n3 = 7;
            Console.Write("Max: " + ((n1 > n2 && n1 > n3) ? n1 : (n2 > n3) ? n2 : n3));
        }
    }
}