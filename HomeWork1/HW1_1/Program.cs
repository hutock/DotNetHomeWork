using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW1_1
{
    class Program
    {
        static void Main(string[] args)
        {
            double num1, num2, ans;
            num1 = num2 = ans = 0;
            char charact = ' ';

            Console.WriteLine("Please enter your formula in Next line:");

            string formula = Console.ReadLine();

            //检查算式是否违法
            bool flag = true;

            for (int i = 0; i < formula.Length; i++)
            {
                if (!char.IsDigit(formula[i]))
                {
                    flag = false;
                    charact = formula[i];
                    num1 = Double.Parse(formula.Substring(0, i));
                    num2 = Double.Parse(formula.Substring(i + 1));
                }
            }
            if (flag)
                Console.WriteLine("ILLEGAL FORMULA!!!!");
            else
            {
                switch (charact)
                {
                    case '+': 
                        ans = num1 + num2;
                        break;
                    case '-':
                        ans = num1 - num2;
                        break;
                    case '*':
                        ans = num1 * num2;
                        break;
                    case '/':
                        ans = num1 / num2;
                        break;
                }
                Console.WriteLine($"Answer is {ans}");
            }


        }
    }
}
