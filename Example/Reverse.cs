using System;
namespace Example
{
    class Reverse
    {
        public int ReverseNumber(int number)
        {
            bool isNegative = number < 0;
            number = Math.Abs(number);
            int surplus = 0;
            int reverse = 0;
            while (number > 0)
            {
                surplus = number % 10;
                number = number / 10;
                reverse = reverse* 10 + surplus;
            }
            return isNegative ? reverse * -1 : reverse;
        }
    }
}