using System;

namespace SumDivideTen
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhập số thứ nhất:");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Nhập số thứ hai:");
            double num2 = Convert.ToDouble(Console.ReadLine());

            double sum = num1 + num2;

            double result = sum % 10;

            Console.WriteLine("Tổng của " + num1 + "và" + num2 + "là:" + sum);
            Console.WriteLine("Kết quả sau khi chia cho 10 là:" + result);

            Console.ReadLine();
        }
    }
}