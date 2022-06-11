using System;
using System.Text;

namespace Menu
{
    class Program
    {
        const int additional = 1;
        const int substract = 2;
        const int multiple = 3;
        const int devision = 4;
        const int exist = 5;

        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;
            int selector = 0;
            do
            {
                Console.WriteLine("================Menu================");
                Console.WriteLine("1. Phép cộng");
                Console.WriteLine("2. Phép trừ");
                Console.WriteLine("3. Phép nhân");
                Console.WriteLine("4. Phép chia");
                Console.WriteLine("5. Kết thúc");
                Console.Write("Vui lòng chọn phép tính: ");
                int.TryParse(Console.ReadLine(), out selector);

                Process(selector);

            }
            while(selector != exist);
        }

        static void Process(int selector){
            Console.Clear();
            switch(selector){
                case additional:{
                    Console.WriteLine("Phép cộng");
                    break;
                }
                case substract:{
                    Console.WriteLine("Phép trừ");
                    break;
                }
                case multiple:{
                    Console.WriteLine("Phép nhân");
                    break;
                }
                case devision:{
                    Console.WriteLine("Phép chia");
                    break;
                }
                case exist:{
                    Environment.Exit(0);
                    break;
                }
                default:{
                    Console.WriteLine("Chức năng này không tồn tại!\nBạn vui lòng chọn các chức từ 1 -> 5.");
                    break;
                }
            }
        }
    }
}
