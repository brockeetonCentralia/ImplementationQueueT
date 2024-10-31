using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Queue<string> printQueue = new Queue<string>();

        // Simulate adding tasks to the print queue
        printQueue.Enqueue("Print document 1");
        printQueue.Enqueue("Print document 2");
        printQueue.Enqueue("Print document 3");

        Console.WriteLine("Current Print Queue:");
        PrintQueue(printQueue);

        // Process (dequeue) the first task
        Console.WriteLine("\nProcessing: " + printQueue.Dequeue());

        Console.WriteLine("\nPrint Queue after processing:");
        PrintQueue(printQueue);

        // Peek at the next task to be processed
        Console.WriteLine("\nNext task to be processed: " + printQueue.Peek());

        // Check how many tasks are in the queue
        Console.WriteLine("\nNumber of tasks in queue: " + printQueue.Count);

        printQueue.Enqueue("Print document 2841");
        Console.WriteLine("/////////");
        printQueue.Dequeue();
        

        //PrintQueue(printQueue);
        Console.WriteLine("/////////");
        Console.WriteLine(printQueue.Peek());

    }

    // Helper function to print the queue contents
    static void PrintQueue(Queue<string> queue)
    {
        foreach (var task in queue)
        {
            Console.WriteLine(task);
        }
    }
}