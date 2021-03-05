using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请输入要因数分解的数：");

            int numInput = Int32.Parse(Console.ReadLine());

            Console.Write($"{numInput} = ");

            while (Check(numInput, out int a))
            {
                Console.Write($"{a}×");
                numInput /= a;
            }

            Console.Write($"{numInput}");
        }

        static bool Check(int num, out int a)
        {
            for (int i = 2; i * i <= num; i++)
            {
                if (num % i == 0)
                {
                    a = i;
                    return true;
                }
            }
            a = num;
            return false;
        }
    }
}
