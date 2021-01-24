﻿using System;
using System.Collections.Generic;

namespace QueueAndStack
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Queue<string> myQueue = new Queue<string>();

           
            Stack<string> myStack = new Stack<string>();


           
            myQueue.Enqueue(" The Customer is seated");
            myQueue.Enqueue("The Customer eat and then ask for check");
            myQueue.Enqueue("The Customer then leaves the resturant");

            
            myStack.Push("Dirty Dishes");
            myStack.Push("Clean Dishes");
            myStack.Push("Stack of clean Dishes");


            //Peek() is a useful method as it just looks at the value without removing the item.
            Console.WriteLine("First: ");
            Console.WriteLine(myQueue.Peek());
            Console.WriteLine("");

            //Dequeue() removes the first item in queue and returns it.
            Console.WriteLine("Then: ");
            Console.WriteLine(myQueue.Dequeue());
            Console.WriteLine("");

            //Pop() removes the last item on the stack and returns it.
            Console.WriteLine("Pop: ");
            Console.WriteLine(myStack.Pop());
            Console.WriteLine("");

            //As you will be able to see the items were removed after dequeueing/poping.
            foreach (var item in myQueue)
            {
                Console.WriteLine("Queue: " + item);
            }

            Console.WriteLine("");

            foreach (var item in myStack)
            {
                Console.WriteLine("Stack: " + item);
            }

            Console.ReadLine();
        }
    }

    class MyClass
    {
        public MyClass(string text)
        {
            Text = text;
        }

        public string Text { get; set; }
    }
}