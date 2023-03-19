using System;
namespace OOP_3
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Student vuong = new Student("Vương", true);
            vuong.Fullname = "Vương Nguuyễn";
            // Console.Write(vuong.Greatting());
            Console.Write(vuong.Fullname);

            List<string> names = new List<string>();
            names.Add("Vương");
            names.Add("Khoa");
            names.Add("Mỹ");
            Console.WriteLine($"Length: {names.Count}");
            Console.WriteLine();
            names.RemoveAt(1);
            Console.WriteLine($"Length: {names.Count}");
        }
    }
}
// SQL/CSDL
// 1. Hệ thống lệnh liên quan đến kiến trúc của CSDL (Schema)
// 2. Hệ thống lệnh liên quan đến truy vấn CSDL (data)