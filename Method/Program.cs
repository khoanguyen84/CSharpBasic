using System;

namespace Method
{
    class Program
    {
        static void Main(string[] args)
        {
            // int size = 10;
            // int min = 1;
            // int max = 10;
            // int[] array_1 = new int[size];
            // Random rnd = new Random();
            // for(int i = 0; i< size; i++){
            //     array_1[i] = rnd.Next(min,max);
            // }
            int[] array_1 = GenerateArray(10);
            // PrintArray(array_1, "+");
            // Console.WriteLine(String.Join(",", array_1));
            int[] array_2 = GenerateArray(20, 50, 100);
            // PrintArray(array_2, "-");
            // Console.WriteLine(String.Join(",", array_2));
            int[] array_3 = GenerateArray(15, 24, 87);
            // PrintArray(array_3, "*");
            // Console.WriteLine(String.Join(",", array_3));
            string value = "12234";
            bool response =  int.TryParse(value, out int result);
            Console.WriteLine("response: "+ response);
            Console.WriteLine("result: "+ result);
            #region Lý thuyết hàm 
            // Tạo 5 mẳng 1 chiều với size, min, max khác nhau
            // method (function)
            // Tái sử dụng lại mã nguồn
            // Thể hiện 1 hành động nào đó

            // <Access Modifiers> <return type> <name_method>(<parameters>)
            // {
            //     // Các câu lệnh trong phương thức, nghiệp vụ
            //     // [return]
            // }

            // <Access Modifiers>: khả năng truy cập để sử dụng phương thức
            // + Internal
            // + Public
            // + Static
            // + Protected
            // + Private

            // <return type>: dữ liệu được trả về sau khi thực thi phương thức (output)
            // + void
            // + các kiểu dũ liệu nguyên thủy (int, float, double, string, bool,...)
            // + kiểu đối tượng (object, collection, collection generic, ...)

            // <name_method>: tên của phương thức
            // Đặc tên theo quy tắc đặt tên biến
            // Bắt đầu bởi 1 động từ
            // Format của tên phương thức là PascalCase (camelCase, PascalCase và snake_case)


            // <parameters>: tham số (input)
            // + Tham trị (pass by value)
            // + Tham chiếu (pass by reference)
            // + optional parameter (không bắt buộc)
            // + out parameter (tham số được lấy về)

            // + Overloading
            #endregion

            int number1 = 5;
            // Console.WriteLine($"number1: {number1}");
            // Increment3(ref number1);
            // Console.WriteLine($"number1: {number1}");
            // int number2 = 7;
            // Console.WriteLine($"number1: {number1}, number2: {number2}"); //5 -7
            // Swap(ref number1, ref number2);
            // Console.WriteLine($"number1: {number1}, number2: {number2}");
            int[] divison7  = Seven7th(out int number);
            Console.WriteLine(String.Join(",", divison7));
            Console.WriteLine("Number: " + number);

        }

        static void Swap(ref int number1, ref int number2){
            int temp = number1;
            number1 = number2;
            number2 = temp;
            Console.WriteLine($"number1: {number1}, number2: {number2}"); // 7-5
        }

        static void Increment3(ref int number1){
            number1+=3;
            Console.WriteLine($"number1: {number1}");
        }
        static int[] GenerateArray(int size, int min = 1, int max = 10)
        {
            int[] array = new int[size];
            Random rnd = new Random();
            for (int i = 0; i < size; i++)
            {
                array[i] = rnd.Next(min, max);
            }
            return array;
        }

        static void PrintArray(int[] array, string separator)
        {
            string str = "";
            for (int i = 0; i < array.Length; i++)
            {
                str += $"{array[i]} {separator} ";
            }
            Console.WriteLine(str);
        }

        static int[] Seven7th(out int number){
            int numberOf7 = 0;
            number = 7;
            int[] result = new int[0];
            while(numberOf7 < 7){
                if(number % 7 == 0){
                    numberOf7++;
                    Array.Resize(ref result, result.Length + 1);
                    result[result.Length - 1] = number;
                }
                number++;
            }
            return result;
        }

        /*
            Viết chương trình thực hiện các nhiệm vụ sau:
            1/ Tạo ra 1 mảng số nguyên có kích cỡ size, giá trị nhỏ nhất là min và giá trị lớn nhất là max
            2/ Hiển thị mảng này ra màn hình
            3/ Số lượng số chẳn có trong mảng
            4/ Số lượng số chính phương có trong mảng (n là 1 số chính phương khi, căn bặc 2 của n là 1 số nguyên)
            5/ Hàm lấy về mảng con từ vị trí Start đến vị trí End
        */ 

    }
}
