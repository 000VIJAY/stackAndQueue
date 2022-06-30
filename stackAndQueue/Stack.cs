using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stackAndQueue
{
    public class Stack
    {
        Node data;
        public void Push(int value)
        {
            Node node = new Node(value);
            if (data == null)
            {
                node.next = null;
            }
            else
            {
                node.next = data;
            }
            data = node;
            Console.WriteLine("{0} pushed to stack ", value);
        }
        public void Display()
        {
            Node temp = data;
            while (temp != null)
            {
                Console.WriteLine("data: " + temp.data);
                temp = temp.next;
            }
        }
    }
}
