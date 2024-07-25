﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackAndQueue.StackAndQueue
{
    public class StackClass
    {
        private Node Top;

        public StackClass() {
            Top = null;
        }

        // IsEmpty Method => Check If THe Stack Is Null
        public bool IsEmpty()
        {
            return Top == null;
        }

        // Push Method => Add Node To The Top Of The Stack
        public void Push(int data)
        {
            Node newNode = new Node(data);
            newNode.Next = Top;
            Top = newNode;
        }

        // Pop Method => Remove & Return The Top Node From The Stack
        public int Pop()
        {
            if (IsEmpty())
            {
                throw new Exception("The Stack Is Empty!");
            }

            int data = Top.Data;
            Top = Top.Next;
            return data;
        }

        // Peek Method => Return The Top Node From The Stack
        public int Peek()
        {
            return Top.Data;
        }

        // Print Method => To Print The Stack
        public void PrintStack()
        {
            Node newNode = Top;
            while (newNode != null)
            {
                Console.WriteLine(newNode.Data + " ");
                newNode = newNode.Next;
            }
            Console.WriteLine();
        }
    }
}