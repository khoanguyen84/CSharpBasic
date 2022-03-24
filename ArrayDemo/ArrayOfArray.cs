using System;
namespace ArrayDemo
{
    class ArrayOfArray
    {
        public static void Main(string[] agrs)
        {
            // int[] numbers = new int[] { 3, 5, 4, 2, 5, 7, 3, 4, 6, 5 };
            // Mảng của mảng
            int[][] matrix = new int[3][]{
                new int[]{ 2,3,4},
                new int[]{ 2,3,4, 6, 7,8,9},
                new int[]{ 2,3,4, 5,6}
            };
            // Console.WriteLine(matrix[0][2]);
            // for(int i =0; i < matrix.Length;i++){
            //     for(int j=0; j < matrix[i].Length; j++)
            //     {
            //         Console.Write($"{matrix[i][j]} ");
            //     }
            //     Console.WriteLine();
            // }
            // mảng 2 chiều
            int[,] jobs = new int[3, 4]{
                { 1,2,3,4},
                { 10,20,30,40},
                { 11,12,13,14}
            };
            // Console.WriteLine(jobs[1, 2]);
            for(int i = 0; i < jobs.GetLength(0);i++){
                for(int j=0; j< jobs.GetLength(1); j++){
                    Console.Write($"{jobs[i,j]} ");
                }
                Console.WriteLine();
            }
        }
    }
}