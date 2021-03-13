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
            Square s = new Square();
            Rectangle r = new Rectangle(4, -5);
            Triangle t = new Triangle(3, 8, 5);

            s.Side = 10;

            Console.WriteLine($"Square's area is {s.Area}");
            Console.WriteLine($"Rectangle's area is {r.Area}");
            Console.WriteLine($"Triangle's area is {t.Area}");
        }
    }

    public interface graph
    {
        double Area { get; }//图形面积属性
        bool isLegal();//合法性判定
        void show();//打印重要信息
    }

    public class Rectangle : graph
    {
        //长度属性
        public double Length { get; set; }
        //宽度属性
        public double Width { get; set; }
        //实现长方形面积属性
        public double Area
        {
            get {
                //做合法性判断，非法时输出警告
                if (!this.isLegal())
                {
                    Console.WriteLine("error:illegal");
                }
                return this.Length * this.Width;
            }
        }
        //无参构造函数
        public Rectangle() : this(0, 0) { }
        //有参构造函数
        public Rectangle(double length, double width)
        {
            this.Length = length;
            this.Width = width;
        }
        //实现合法性判断函数
        public bool isLegal()
        {
            //长度不可为负数或者零
            if (this.Length <= 0 || this.Width <= 0)
                return false;
            return true;
        }
        //实现打印重要信息函数
        public void show()
        {
            //合法时输出
            if (this.isLegal())
                Console.WriteLine($"My length is {this.Length}, my length is {this.Width}, my area is {this.Area}");
        }
    }

    public class Square : graph
    {
        //正方形边长属性
        public double Side { get; set; }
        //实现正方形面积属性
        public double Area
        {
            get {
                //合法性判断，非法时输出警告
                if (!this.isLegal())
                    Console.WriteLine("error:illegal");
                return this.Side * this.Side;
            }
        }
        //无参构造函数
        public Square() : this(0) { }
        //带参构造函数
        public Square(double side)
        {
            this.Side = side;
        }
        //实现合法性判断函数
        public bool isLegal()
        {
            //正方形边长不能为零或负数
            if (this.Side <= 0)
                return false;
            return true;
        }
        //实现打印重要信息函数
        public void show()
        {
            //当且仅当图形合法时输出
            if (this.isLegal())
                Console.WriteLine($"My side is {this.Area}, my area is {this.Area}");
        }
    }

    public class Triangle : graph
    {
        //三角形三边长属性
        public double Side_1 { get; set; }
        public double Side_2 { get; set; }
        public double Side_3 { get; set; }
        //实现三角形面积属性
        public double Area
        {
            get {
                //合法性判断，非法时输出警告
                if (!this.isLegal())
                {
                    Console.WriteLine("error:illegal");
                    return 0;
                }
                //使用海伦公式计算面积
                double p = (this.Side_1 + this.Side_2 + this.Side_3) / 2;
                return Math.Sqrt(p * (p - this.Side_1) * (p - this.Side_2) * (p - this.Side_3));
            }
        }
        //无参构造函数
        public Triangle() : this(0, 0, 0) { }
        //带参构造函数
        public Triangle(double side1, double side2, double side3)
        {
            this.Side_1 = side1;
            this.Side_2 = side2;
            this.Side_3 = side3;
        }
        //实现合法性判断函数
        public bool isLegal()
        {
            //三角形任意两边和大于第三边，差小于第三边
            if ((this.Side_1 - this.Side_2 < this.Side_3) && (this.Side_1 + this.Side_2 > this.Side_3)
                && (this.Side_1 - this.Side_3 < this.Side_2) && (this.Side_1 + this.Side_3 > this.Side_2)
                && (this.Side_3 - this.Side_2 < this.Side_1) && (this.Side_3 + this.Side_2 > this.Side_1))
                return true;
            return false;
        }
        //实现打印重要信息函数
        public void show()
        {
            //当且仅当图形形状合法时输出
            if (this.isLegal())
                Console.WriteLine($"My 3 sides are {this.Side_1}、{this.Side_2}、{this.Side_3}, my area is {this.Area}");
        }
    }
}
