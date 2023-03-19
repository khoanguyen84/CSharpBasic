
using System;
using System.Text;
namespace Lesson1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;
            // Console.ForegroundColor = ConsoleColor.Blue;
            // int number = 55;
            // Console.WriteLine(number);
            // var value = true;
            // Console.WriteLine(value);
            // ctrL + / ~ comment source code
            // Console.WriteLine("sbyte.MinValue: " + sbyte.MinValue);
            // Console.WriteLine("sbyte.MaxValue: " + sbyte.MaxValue);
            // int a = 15, b = 17, c = 101;
            // Console.Write("Nhập vào a: ");
            // int a = Convert.ToInt32(Console.ReadLine());
            // Console.Write("Nhập vào b: ");
            // int b = Convert.ToInt32(Console.ReadLine());
            // Console.Write("Nhập vào c: ");
            // int c = Convert.ToInt32(Console.ReadLine());
            // Console.WriteLine(a + "x2 + " + b + "x - " + c + " = 0");
            // Console.WriteLine(String.Format("{0}x2 + {1}x + {2} = 0", a, b, c));
            // String template
            // Console.WriteLine($"{a}x2 + {b}x + {c} = 0");
            // Console.Write("Nhập vào tên: ");
            // var name = Console.ReadLine();
            // Console.Write("Nhập vào tuổi: ");
            // // int age = int.Parse(Console.ReadLine());
            // int.TryParse(Console.ReadLine(), out int age);
            // // string title = age  > 20 ? "ông" : "anh";
            // Console.Write("Nhập vào giới tính: ");
            // string gender = Console.ReadLine();
            // Console.WriteLine($"Tôi tên là {name}, tôi  năm nay {age} tuổi và tôi là {gender}.");

            //Convert datatype / parse
            // Constance
            // const double Pi = 3.14;
            // string value = "4.5";
            // bool result = int.TryParse(value, out int a);
            // Console.WriteLine(result);
            // Console.Write("Nhấn 1 phím bất kỳ: ");
            // Console.WriteLine($"Bạn vừa bấm phìm: {Console.ReadKey().KeyChar}");
            Console.Write("Nhập và số a: ");
            var a = int.Parse(Console.ReadLine());
            Console.Write("Nhập và số b: ");
            var b = int.Parse(Console.ReadLine());
            // var a = "5";
            // var b = "6";
            Console.WriteLine($"{a} + {b} = {a + b}");
        }
    }
}
