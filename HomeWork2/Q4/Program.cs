using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q4
{
    class Program
    {
        static void Main(string[] args)
        {
            bool flag = true;
            int[,] Array = { { 1, 2, 3, 4 }, { 5, 1, 2, 3 }, { 9, 5, 1, 2 } };
            int m = Array.GetLength(0);
            int n = Array.GetLength(1);
            for (int i = 0; i < m - 1; i++)
            {
                for (int j = 0; j < n - 1; j++)
                {
                    if (Array[i, j] != Array[i + 1, j + 1])
                    {
                        flag = false;
                        Console.WriteLine("这不是托普利茨矩阵");
                    }
                }
            }
            if (flag)
            {
                Console.WriteLine("这是托普利茨矩阵");
            }


        }
    }
}
