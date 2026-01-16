using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Node
    {
        public int data;
        public Node next;

        public Node(int Data)
        {
            data = Data;
            next = null;
        }
    }

    public class LinkedlistStack
    {
        private Node top;

        public LinkedlistStack()
        {
            top = null;
        }

        public void Push(int value)
        {
            Node newnode = new Node (value);
            if (top == null)
            {
                newnode.next= null;
            }
            else
            {
                newnode.next = top;
            }
            top = newnode;
            Console.WriteLine(value + " pushed to stack.");
        }

        public void Pop()
        {
            if(top == null)
            {
                Console.WriteLine("Stack Underflow. Deletion not possible!");
                return;
            }
            int poppedValue = top.data;
            top = top.next;
            Console.WriteLine("Item popped is " + poppedValue);
        }

        public void Peek()
        {
            if (top == null)
            {
                Console.WriteLine("Stack Underflow.");
                return;
            }
            Console.WriteLine(top.data + " is on the top of stack");
        }
    }
    public class Program
    {
        static void Main(string[] args)
        {
            LinkedlistStack stk = new LinkedlistStack();
            stk.Push(10);
            stk.Push(20);
            stk.Push(30);
            stk.Push(40);
            stk.Push(50);

            stk.Pop();   //50
            stk.Pop();   //40

            stk.Peek();  //30

            Console.ReadKey();
        }
    }
}
