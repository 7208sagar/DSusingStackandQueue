using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructureUsingStackAndQueue
{
    class LinkedListStack
    {
        public Node top;

        /// <summary>
        /// Parameterized constructor to Initializes a new instance of the <see cref="LinkedListStack"/> class.
        /// </summary>
        public LinkedListStack()
        {
            this.top = null;
        }

        /// <summary>
        /// Pushes the specified value into stack.
        /// </summary>
        /// <param name="value">The value.</param>
        internal void push(int value)
        {
            Node node = new Node(value);
            if (this.top == null)
            {
                node.next = null;
            }
            else
            {
                node.next = this.top;
            }
            this.top = node;
            Console.WriteLine(value);
        }

        /// <summary>
        /// Displays this instance.
        /// </summary>
        internal void Display()
        {
            Node temp = this.top;
            while (temp != null)
            {
                Console.WriteLine("Inserted into the stack Successfully = " + temp.data);
                temp = temp.next;
            }
        }
    }
}