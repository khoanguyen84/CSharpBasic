// Nhập vào ĐTB = value (0 <= ĐTB <=10)
// Hiển thị ra màn hình Xếp loại dựa vào ĐTB
// ĐTB >= 9 -> Xuất sắc
// ĐTB >= 8 -> Giởi
// ĐTB >= 7 -> Khá
// ĐTB >= 5 -> Trung bình
// Còn lại là yếu

// Sử dụng if...else
// Sử dụng toán tử 3 ngôi ? : 
// Sử dụng switch..case
using System;
namespace Lesson1
{
    class Rank
    {
        public static void Main(string[] args)
        {
            // aveScore phải number
            // aveScore >=0 and <=10
            const string stop = "N";
            const string coutinue = "Y";
            string confirmed = coutinue;
            do
            {
                double aveScore = 0;
                bool isNumber = true;

                do
                {
                    Console.Write("Enter average score: ");
                    isNumber = double.TryParse(Console.ReadLine(), out aveScore);
                }
                while (!isNumber || aveScore < 0 || aveScore > 10);

                string result = "Excelence";
                if (aveScore < 5)
                {
                    result = "Bad";
                }
                if (aveScore >= 5 && aveScore < 7)
                {
                    result = "Medium";
                }
                if (aveScore >= 7 && aveScore < 8)
                {
                    result = "Good";
                }
                if (aveScore >= 8 && aveScore < 9)
                {
                    result = "Very Good";
                }
                Console.WriteLine(result);
                Console.Write("Are you want to countinue? (Y/N): ");
                confirmed = Console.ReadLine().ToUpper();
            }
            while (confirmed != stop);


            // Console.Write("Enter average score: ");
            // isNumber = double.TryParse(Console.ReadLine(), out aveScore);
            // while (!isNumber || aveScore < 0 || aveScore > 10)
            // {
            //     Console.Write("Enter average score: ");
            //     isNumber = double.TryParse(Console.ReadLine(), out aveScore);
            // }

            // Console.Write("Enter average score: ");
            // isNumber = double.TryParse(Console.ReadLine(), out aveScore);
            // for (; !isNumber || aveScore < 0 || aveScore > 10;)
            // {
            //     Console.Write("Enter average score: ");
            //     isNumber = double.TryParse(Console.ReadLine(), out aveScore);
            // }

            // if (aveScore >= 9)
            // {
            //     Console.WriteLine("Excelence");
            // }
            // else if (aveScore >= 8)
            // {
            //     Console.WriteLine("Very Good");
            // }
            // else if (aveScore >= 7)
            // {
            //     Console.WriteLine("Good");
            // }
            // else if (aveScore >= 5)
            // {
            //     Console.WriteLine("Medium");
            // }
            // else
            // {
            //     Console.WriteLine("Bad");
            // }

            // if (aveScore >= 9)
            // {
            //     Console.WriteLine("Excelence");
            // }
            // else
            // {
            //     if (aveScore >= 8)
            //     {
            //         Console.WriteLine("Very Good");
            //     }
            //     else
            //     {
            //         if (aveScore >= 7)
            //         {
            //             Console.WriteLine("Good");
            //         }
            //         else
            //         {
            //             if (aveScore >= 5)
            //             {
            //                 Console.WriteLine("Medium");
            //             }
            //             else
            //             {
            //                 Console.WriteLine("Bad");
            //             }
            //         }
            //     }
            // }

        }
    }
}
