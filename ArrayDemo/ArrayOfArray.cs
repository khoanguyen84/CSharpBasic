using System;
namespace ArrayDemo
{
    class ArrayOfArray
    {
        public static void Main(string[] agrs)
        {
            // int[] numbers = new int[] { 3, 5, 4, 2, 5, 7, 3, 4, 6, 5 };
            // Mảng của mảng
            // int[][] matrix = new int[3][]{
            //     new int[]{ 2,3,4},
            //     new int[]{ 2,3,4, 6, 7,8,9},
            //     new int[]{ 2,3,4, 5,6}
            // };
            // Console.WriteLine(matrix[0][2]);
            // for(int i =0; i < matrix.Length;i++){
            //     for(int j=0; j < matrix[i].Length; j++)
            //     {
            //         Console.Write($"{matrix[i][j]} ");
            //     }
            //     Console.WriteLine();
            // }
            // mảng 2 chiều
            // int[,] jobs = new int[3, 4]{
            //     { 1,2,3,4},
            //     { 10,20,30,40},
            //     { 11,12,13,14}
            // };
            // Console.WriteLine(jobs[1, 2]);
            // for(int i = 0; i < jobs.GetLength(0);i++){
            //     for(int j=0; j< jobs.GetLength(1); j++){
            //         Console.Write($"{jobs[i,j]} ");
            //     }
            //     Console.WriteLine();
            // }

            // Console.Write("Enter row...");
            // int row = int.Parse(Console.ReadLine());
            // Console.Write("Enter column...");
            // int col = int.Parse(Console.ReadLine());
            int[][] numbers = new int[5][];
            Random rnd = new Random();
            for (int i = 0; i < numbers.Length; i++)
            {
                // Console.Write($"Enter item of row {i}...");
                // int col = int.Parse(Console.ReadLine());
                int[] array = new int[7];

                for (int j = 0; j < array.Length; j++)
                {
                    array[j] = rnd.Next(10, 50);
                }
                numbers[i] = array;
            }
            Console.WriteLine("===========================================");
            for (int i = 0; i < numbers.Length; i++)
            {
                for (int j = 0; j < numbers[i].Length; j++)
                {
                    Console.Write($"{numbers[i][j]} ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("===========================================");

            for (int j = 0; j < 7; j++)
            {
                for (int i = 0; i < 5; i++)
                {
                    Console.Write($"{numbers[i][j]} ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("===========================================");
            for (int i = 0; i < numbers.Length; i++)
            {
                for (int j = 0; j < numbers[i].Length; j++)
                {
                    // bool isPrime = true;
                    int count = 0;
                    for (int k = 1; k <= numbers[i][j]; k++)
                    {

                        if (numbers[i][j] % k == 0)
                        {
                            // isPrime = false;
                            count++;
                            // break;
                        }
                    }
                    // if(isPrime){
                    if (count == 2)
                    {
                        Console.Write($"{numbers[i][j]} ");
                    }
                    else
                    {
                        Console.Write($"00 ");
                    }
                }
                Console.WriteLine();
            }
            // Console.Write("Nhap vao so luong ham chau doan tau...");
            // int soHam = int.Parse(Console.ReadLine());
            // int[][] ham = new int[soHam][];
            // Random random = new Random();
            // for (int i = 0; i < ham.Length; i++)
            // {
            //     Console.Write($"Nhap so toa của doan tau vào ham {i}...");
            //     int soTao = int.Parse(Console.ReadLine());
            //     int[] doanTau = new int[soTao];
            //     for (int j = 0; j < doanTau.Length; j++)
            //     {
            //         doanTau[j] = random.Next(20, 60);
            //     }
            //     ham[i] = doanTau;
            // }
            // for (int i = 0; i < ham.Length; i++)
            // {
            //     for (int j = 0; j < ham[i].Length; j++)
            //     {
            //         Console.Write($"{ham[i][j]} ");
            //     }
            //     Console.WriteLine();
            // }
            Console.WriteLine("+++++++++++++++++++");
            int[] sort = new int[] { 4, 5, 3, 7, 9, 5, 4, 9, 2 };
            for (int j = 0; j < sort.Length; j++)
            {
                Console.Write($"{sort[j]} ");
            }
            for (int i = 0; i < sort.Length; i++)
            {
                int min = sort[i];
                int position = i;
                for (int j = i + 1; j < sort.Length; j++)
                {
                    if (min > sort[j])
                    {
                        min = sort[j];
                        position = j;
                    }
                }
                int temp = sort[i];
                sort[i] = sort[position];
                sort[position] = temp;
            }
            Console.WriteLine("+++++++++++++++++++");
            for (int j = 0; j < sort.Length; j++)
            {
                Console.Write($"{sort[j]} ");
            }
        }
    }
}