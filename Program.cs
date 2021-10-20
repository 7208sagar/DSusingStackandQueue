using System;
using System.Collections.Generic;
using System.Text;

namespace DSusingStackandQueue
{
    class Program
    {
        static void Main(string[] args)
        {
                Console.WriteLine("Welcome to stack and queue problem");
                LinkedListStack linkedListStack = new LinkedListStack();
                linkedListStack.push(70);
                linkedListStack.push(30);
                linkedListStack.push(56);
                linkedListStack.Display();
                linkedListStack.peek();
                linkedListStack.Display();
                linkedListStack.pop();
                linkedListStack.Display();
                linkedListStack.isEmpty();
                linkedListStack.Display();
                LinkedListQueue linkedListQueue = new LinkedListQueue();
                linkedListQueue.Enqueue(56);
                linkedListQueue.Enqueue(30);
                linkedListQueue.Enqueue(70);
                linkedListQueue.Display();
        }
        }
    }

