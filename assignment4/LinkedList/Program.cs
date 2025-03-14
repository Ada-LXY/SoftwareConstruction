using System;

namespace GenericLinkedList
{
    // 定义链表节点类
    public class Node<T>
    {
        public T Data { get; set; }
        public Node<T> Next { get; set; }
        public Node(T data)
        {
            Data = data;
        }
    }

    // 定义泛型链表类
    public class LinkedList<T> where T : IComparable<T>
    {
        private Node<T> head;

        public void Add(T data)
        {
            
            if (head == null)
            {
                head = new Node<T>(data);
            }
            
            else
            {
                Node<T> current = head;
                while (current.Next != null)
                {
                    current = current.Next;
                }
                current.Next = new Node<T>(data);
            }
        }

        // 实现 ForEach 方法
        public void ForEach(Action<T> action)
        {
            Node<T> current = head;
            while (current != null)
            {
                action(current.Data);
                current = current.Next;
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // 创建链表并添加元素
            LinkedList<int> list = new LinkedList<int>();
            list.Add(10);
            list.Add(20);
            list.Add(30);
            list.Add(40);
            list.Add(50);

            // 打印链表元素
            Console.WriteLine("链表元素：");
            list.ForEach(x => Console.WriteLine(x));

            // 求最大值
            int max = int.MinValue;
            list.ForEach(x => { if (x > max) max = x; });
            Console.WriteLine($"最大值：{max}");

            // 求最小值
            int min = int.MaxValue;
            list.ForEach(x => { if (x < min) min = x; });
            Console.WriteLine($"最小值：{min}");

            // 求和
            int sum = 0;
            list.ForEach(x => sum += x);
            Console.WriteLine($"和：{sum}");
        }
    }
}