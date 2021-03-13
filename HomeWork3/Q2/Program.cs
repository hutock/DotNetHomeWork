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
            GraphFactory graphFactory = new GraphFactory();
            Q1.graph[] graphArray = new Q1.graph[10];

            Console.WriteLine("Please enter ten graph what you want(Rectangle:R、Square:S、Triangle:T):");

            for (int i = 0; i < 10; i++)
            {
                string _input = Console.ReadLine();
                graphArray[i] = graphFactory.getGraph(_input);
                graphFactory.handleGraph(graphArray[i]);
            }

            double sum = 0;

            for (int i = 0; i < 10; i++)
            {
                if (graphArray[i] != null)
                {
                    sum += graphArray[i].Area;
                    graphArray[i].show();
                }
            }

            Console.WriteLine($"The sum of area is {sum}");
        }
    }

    //图形工厂类
    class GraphFactory
    {
        //工厂生产图形产品
        public Q1.graph getGraph(string graphType)
        {
            if(graphType == null)
            {
                return null;
            }
            else if(graphType == "S")
            {
                return new Q1.Square();
            }
            else if(graphType == "T")
            {
                return new Q1.Triangle();
            }
            else if(graphType == "R")
            {
                return new Q1.Rectangle();
            }
            return null;
        }

        //处理图形产品(随机生成图形)
        public void handleGraph(Q1.graph graph)
        {
            if(graph is Q1.Square)
            {
                handleSquare((Q1.Square)graph);
            }
            else if (graph is Q1.Rectangle)
            {
                handleRectangle((Q1.Rectangle)graph);
            }
            else if (graph is Q1.Triangle)
            {
                handleTriangle((Q1.Triangle)graph);
            }
        }
        //正方形处理函数
        private void handleSquare(Q1.Square square)
        {
            Random ran = new Random();

            square.Side = ran.Next(1, 10);
        }
        //长方形处理函数
        private void handleRectangle(Q1.Rectangle rectangle)
        {
            Random ran = new Random();

            rectangle.Length = ran.Next(1, 10);
            rectangle.Width = ran.Next(1, 10);
        }
        //三角形处理函数
        private void handleTriangle(Q1.Triangle triangle)
        {
            Random ran = new Random();

            triangle.Side_1 = ran.Next(1, 10);
            triangle.Side_2 = ran.Next(1, 10);
            triangle.Side_3 = ran.Next(1, 10);
        }
    }


}
