using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请输入要计算数值的数组(空格隔开)");
            int count = 0;
            string str = Console.ReadLine();

            for(int i = 0; i < str.Length; i++)
            {
                if (str[i] == ' ')
                    count++;
            }

            count++;

            int[] Array = new int[count];
            int l = 0, countNum = 0;

            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == ' ' || i == str.Length - 1)
                {
                    Array[countNum] = Int32.Parse(str.Substring(l, i - l));
                    l = i;
                    countNum++;
                }
            }

            int maxNum, minNum, sum, equa;
            maxNum = minNum = Array[0];
            sum = 0;
            for (int i = 0; i < Array.Length; i++)
            {
                if (maxNum < Array[i]) maxNum = Array[i];
                if (minNum > Array[i]) minNum = Array[i];
                sum += Array[i];
            }
            equa = sum / Array.Length;

            Console.WriteLine($"最大值是{maxNum}，最小值是{minNum}，平均值是{equa}，和为{sum}");
        }
    }
}
