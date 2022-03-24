using System;

namespace ArrayDemo
{
    class Program
    {
        public static void Main(string[] args)
        {
            int[] numbers = new int[] { 3, 5, 4, 2, 5, 7, 3, 4, 6, 5 };
            #region 
            // int position = 0;
            // int value = 5;
            // while(position < numbers.Length){
            //     if(numbers[position] == value){
            //         for(int i = position + 1; i < numbers.Length; i++){
            //             numbers[i-1] = numbers[i];
            //         }
            //         Array.Resize(ref numbers, numbers.Length - 1);
            //     }
            //     position++;
            // }
            // Console.Write(String.Join(",", numbers));
            #endregion
            int[] filter = new int[0];
            // duyệt qua mảng number
            for (int i = 0; i < numbers.Length; i++)
            {
                // kiểm tra giá trị numbers[i] đã xuát hiện trong mảng filer chưa?
                bool isNotExistInFilter = true;
                for (int j = 0; j < filter.Length; j++)
                {
                    if (filter[j] == numbers[i])
                    {
                        isNotExistInFilter = false;
                        break;
                    }
                }
                if (isNotExistInFilter)
                {
                    Array.Resize(ref filter, filter.Length + 1);
                    filter[filter.Length - 1] = numbers[i];
                }
            }
            // Console.Write(String.Join(",", filter));
            // int number = 10;
            // float result = (float)number/3;
            double number = 10.1;
            int result = (int)number/3;
            // Console.Write(result);
            string dateStr = "2022 03 26";
            string[] dateArr = dateStr.Split(" ");
            DateTime date = new DateTime(int.Parse(dateArr[0]), int.Parse(dateArr[1]), int.Parse(dateArr[2]));
            Console.Write($"date of week {dateStr}: {date.DayOfWeek}");
        }
    }
}
