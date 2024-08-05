﻿using System.Collections;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StackAndQueue.StackAndQueue;
using StackAndQueue.ReverseStackUsingQueue;
using StackAndQueue.DeleteMiddleElement;

namespace StackAndQueue.StackAndQueue
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" **************** Stack ****************");
            StackClass stackClass = new StackClass();
            stackClass.Push(1);
            stackClass.Push(2);
            stackClass.Push(3);
            stackClass.Push(4);
            stackClass.Push(5);

            Console.WriteLine($"The Stack Before Pop :");
            stackClass.PrintStack();
            Console.WriteLine($"The Stack After Pop {stackClass.Pop()} :");
            stackClass.PrintStack();
            Console.WriteLine($"Is The Stack Empty? {stackClass.IsEmpty()}");
            Console.WriteLine();

            Console.WriteLine(" **************** Queue ****************");
            QueueClass queueClass = new QueueClass();
            queueClass.EnQueue(10);
            queueClass.EnQueue(20);
            queueClass.EnQueue(30);
            queueClass.EnQueue(40);
            queueClass.EnQueue(50);

            Console.WriteLine($"The Queue Before DeQueue :");
            queueClass.PrintQueue();
            Console.WriteLine($"The Queue After DeQueue {queueClass.DeQueue()} :");
            queueClass.PrintQueue();
            Console.WriteLine($"Is The Queue Empty? {queueClass.IsEmpty()}");
            Console.WriteLine();

            // Reverse Stack using Queue
            Console.WriteLine(" **************** Reverse Stack ****************");
            StackClass reverseS = new StackClass();
            reverseS.Push(1);
            reverseS.Push(2);
            reverseS.Push(3);
            reverseS.Push(4);
            reverseS.Push(5);
            StackWithReverse stackWithReverse = new StackWithReverse();
            
            Console.WriteLine("The Stack Before Reverse :");
            reverseS.PrintStack();
            Console.WriteLine("The Stack After Reverse :");
            stackWithReverse.ReverseStack(reverseS);

            Console.WriteLine(" **************** Delete Middle Element from Stack ****************");
            StackClass deleteMiddleStack = new StackClass();
            deleteMiddleStack.Push(1);
            deleteMiddleStack.Push(2);
            deleteMiddleStack.Push(3);
            deleteMiddleStack.Push(4);
            deleteMiddleStack.Push(5);
            deleteMiddleStack.Push(6);

            Console.WriteLine("Before:");
            deleteMiddleStack.PrintStack();

            StackWithDeleteMiddle stackWithDeleteMiddle = new StackWithDeleteMiddle();
            stackWithDeleteMiddle.DeleteMiddle(deleteMiddleStack);

            Console.WriteLine("After:");
            deleteMiddleStack.PrintStack();
        }
    }
}