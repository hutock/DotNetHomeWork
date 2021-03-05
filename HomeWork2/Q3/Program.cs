using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q3
{
    class Program
    {
        static void Main(string[] args)
        {
            bool[] Array = new bool[101];
            for (int i = 2; i <= 100; i++)
            {
                Array[i] = true;
            }
            //10 * 10 = 100
            for (int i = 2; i <= 100; i++)
            {
                if (Array[i])
                {
                    for (int j = 2 * i; j <= 100; j += i)
                    {
                        Array[j] = false;
                    }
                }
            }
            Console.WriteLine("2到100之间的质数为：");
            for (int i = 2; i < 101; i++)
            {
                if (Array[i])
                {
                    Console.Write($"{i} ");
                }
            }

        }
    }
}
