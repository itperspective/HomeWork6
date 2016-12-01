using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork6
{
    class Program
    {
        static void Main(string[] args)
        {
            int size;
            Console.WriteLine("Please Enter array size:");
            while(!Int32.TryParse(Console.ReadLine(), out size))
            {
                Console.WriteLine("Please Enter int!!!");
            }

            int[] array = new int[size];

            Buffer buffer = new Buffer(array);
            MyStack mystack = new MyStack(array);
            MyQueue myqueue = new MyQueue(array);

            Buffer BufferMyStack = new MyStack(array);
            Buffer BufferMyQueue = new MyQueue(array);

            //**********************************************BufferQueue_START********************************
            //int input = 0;
            //int enqueue;

            //while (input != 9)
            //{
            //    Console.WriteLine("\n Please enter '1' to dequeue from the queue, or '2' to enqueue to the queue. Enter '9' to exit:");
            //    while (!Int32.TryParse(Console.ReadLine(), out input))
            //    {
            //        Console.WriteLine("Please enter int");
            //    }

            //    if (input == 1)
            //    {
            //        if (! myqueue.IsEmpty())
            //        {
            //            myqueue.Dequeue();
            //            myqueue.Print();
            //            input = 0;
            //        }

            //        else
            //        {
            //            Console.WriteLine("The queue is empty!!");
            //        }
            //    }

            //    if (input == 2)
            //    {
            //        if (!myqueue.IsFull())
            //        {
            //            Console.WriteLine("Please enter value to enqueue:");
            //            while (!Int32.TryParse(Console.ReadLine(), out enqueue))
            //            {
            //                Console.WriteLine("Please enter int");
            //            }
            //            myqueue.Enqueue(enqueue);
                        
            //            myqueue.Print();
            //            input = 0;
            //        }

            //        else
            //        {
            //            Console.WriteLine("The queue is full!!");
            //        }
            //    }

            //}
            //**************************************************BufferQueue_END**********************************

            //*************************************************Sorter_START**********************
            //Console.WriteLine("Please Enter array values:");
            //for (int i=0; i<array.Length; i++)
            //{
            //    while(!Int32.TryParse(Console.ReadLine(), out array[i]))
            //    {
            //        Console.WriteLine("Please Enter int!!!");
            //    }
            //}

            //Sorter sorter = new Sorter(array);
            //BubbleSorter bubble = new BubbleSorter(array);
            //InsertionSorter insert = new InsertionSorter(array);

            //Sorter SorterBubbleSorter = new BubbleSorter(array);
            //Sorter SorterInsertionSorter = new InsertionSorter(array);

            //bubble.Sort();
            //bubble.Print();

            //insert.Sort();
            //insert.Print();

            //sorter.Print();
            //************************************************Sorter_END************************





            Console.ReadLine();


        }
    }
}
