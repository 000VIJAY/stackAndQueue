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
        public void Peak()   
        {
            if (this.data == null)
            {
                Console.WriteLine("Stack is empty");
            }
            Console.WriteLine("{0} is in the top of the stack", this.data.data);
        }
        public void pop()
        {
            if (this.data == null)
            {
                Console.WriteLine("Stack is empty, Deletation is not possible");
                return;
            }
            Console.WriteLine("value popped:{0}", this.data.data);
            this.data = this.data.next;
        }
        public void IsEmpty()
        {
            while (this.data != null)
            {
                pop();
            }
        }
    }
}
