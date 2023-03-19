using System;

namespace Array2D
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = 5;
            int[][] matrix = new int[5][]{
                new int[]{ 1,2,3,4,5},
                new int[]{ 1,2,3,4,5},
                new int[]{ 1,2,3,4,5},
                new int[]{ 1,2,3,4,5},
                new int[]{ 1,2,3,4,5},
            };

            for(int i = 0; i < matrix.Length; i++){
                Array.Resize(ref matrix[i], matrix[i].Length + 1);
                int posCell = matrix[i].Length - 1;
                for(int j = 0; j < posCell; j++){
                    matrix[i][posCell] += matrix[i][j];
                }
            }
            Array.Resize(ref matrix, matrix.Length + 1);
            int newRow = matrix.Length - 1;
            matrix[newRow] = new int[size + 1];

            for(int j = 0; j < matrix.Length; j++){
                matrix[newRow][j] = 0;
                for(int i = 0; i < matrix.Length - 1; i++){
                    matrix[newRow][j] += matrix[i][j];
                }
            }

            for (int i = 0; i < matrix.Length; i++)
            {
                for (int j = 0; j < matrix[i].Length; j++)
                {
                    Console.Write($"{matrix[i][j]}\t");
                }
                Console.WriteLine();
            }
            // int[] rowArray = new int[size];
            // int[] colArray = new int[size];
            // for (int i = 0; i < size; i++)
            // {
            //     rowArray[i] = 0;
            //     for (int j = 0; j < size; j++)
            //     {
            //         rowArray[i] += matrix[i][j];
            //     }
            // }
            // for (int i = 0; i < size; i++)
            // {
            //     for (int j = 0; j < size; j++)
            //     {
            //         Console.Write($"{matrix[i][j]} ");
            //     }
            //     Console.WriteLine();
            // }
            // Console.WriteLine(String.Join(",", rowArray));
            // for (int j = 0; j < size; j++)
            // {
            //     colArray[j] = 0;
            //     for (int i = 0; i < size; i++)
            //     {
            //         colArray[j] += matrix[i][j];
            //     }
            // }
            // Console.WriteLine(String.Join(",", colArray));
            // Array.Resize(ref colArray, colArray.Length + 1);
            // for (int i = 0; i < colArray.Length - 1 ; i++)
            // {
            //     colArray[colArray.Length - 1] += colArray[i];
            // }

            // for (int i = 0; i < matrix.Length; i++)
            // {
            //     Array.Resize(ref matrix[i], matrix[i].Length + 1);
            //     matrix[i][matrix[i].Length - 1] = rowArray[i];
            // }

            // Array.Resize(ref matrix, matrix.Length + 1);
            // matrix[matrix.Length - 1] = colArray;
  
            // for (int i = 0; i < matrix.Length; i++)
            // {
            //     for (int j = 0; j < matrix[i].Length; j++)
            //     {
            //         Console.Write($"{matrix[i][j]}\t");
            //     }
            //     Console.WriteLine();
            // }
        }
    }
}
