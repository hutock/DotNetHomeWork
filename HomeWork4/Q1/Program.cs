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
            GenericList<int> G= new GenericList<int>();
            for (int i = 0; i < 10;  i++)
            {
                G.Add(i);
            }
            G.ForEach(a => Console.Write($"{a.data} "));

            Console.WriteLine();

            int max = int.MinValue;
            G.ForEach(a => max = (a.data <= max) ? max : a.data);
            Console.WriteLine($"最大值是{max}");

            int min = int.MaxValue;
            G.ForEach(a => min = (a.data >= min) ? min : a.data);
            Console.WriteLine($"最小值是{min}");

            int sum = 0;
            G.ForEach(a => sum += a.data);
            Console.WriteLine($"和是{sum}");
        }
        
    }

    public class GenericList<T>
    {
        public Node<T> head;
        public Node<T> tail;

        public GenericList()
        {
            this.head = null;
            this.tail = null;
        }

        public void Add(T data)
        {

            Node<T> node = new Node<T>(data);
            if (head == null)
            {
                head = node;
                tail = head;
            }
            else
            {
                tail.next = node;
                tail = node;
            }
        }

        public void ForEach(Action<Node<T>> action)
        {
            Node<T> elem = head;
            while (elem != null)
            {
                action(elem);
                elem = elem.next;
            }
        }
    }

    public class Node<T>
    {
        public T data { get; set; }
        public Node<T> next { get; set; }

        public Node(T data)
        {
            this.data = data;
            next = null;
        }
    }
}
