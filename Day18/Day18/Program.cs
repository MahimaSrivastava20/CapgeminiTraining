// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using System;
using System.Threading;
using System.Threading.Tasks;
using System.IO;
using System.Diagnostics;
using System.IO;

class Program
{
    static int counter = 0;
    static object lockObj = new object();
    public static async Task Main()
    {


        /*----------first program----------

                Thread thread = new Thread(new ParameterizedThreadStart(PrintMessage));
                thread.Start("Hello from thread");

                static void PrintMessage(object message)
                {
                    Console.WriteLine(message);
                }*/

        //-----------Second program--------
        /*

        Thread worker = new Thread(DoWork);
        worker.Start();
        Console.WriteLine("Main Thread Continues.....");
    }
    static void DoWork()
    {
        for(int i = 1; i <= 5; i++)
        {
            Console.WriteLine("Worker thread: "+ i);
            Thread.Sleep(1000);
        }*/

        //--------Third program-----------
        /*

        Parallel.For(0, 5, i =>
        {
            Console.WriteLine($"Processing item {i}");
        });*/

        //----------Fourth program-----------    

        /*
        int[] numbers = new int[10];
        for(int i = 0; i < numbers.Length; i++)
            numbers[i] = i + 1;
        int sum = 0;
        Parallel.For(0, numbers.Length, i =>
        {
            sum += numbers[i]; //not thread-safe (for demonstration)
        });
        Console.WriteLine("Sum: "+ sum);
        */

        //---------------Fifth program-------------
        /*
        int[] numbers = new int[10];
        for(int i = 0; i < numbers.Length; i++)
            numbers[i] = i + 1;
        int sum = 0;
        Parallel.For(
            0,
            numbers.Length,
            () => 0, //Thread-local initialization
            (i, loopState, localSum) =>
            {
                return localSum + numbers[i];
            },
            localSum =>
            {
                Interlocked.Add(ref sum, localSum);
            });
        Console.WriteLine("Sum: "+sum);

//------can stop a task but not block the task----  
//(async returns task method)

        Console.WriteLine("----Async method----");
        async Task<int> GetDataAsync()
        {
            await Task.Delay(1000);
            return 42;
        }
        Console.WriteLine(await GetDataAsync());
        */

        /*
        Console.WriteLine("Start reading file......");
        string content = await File.ReadAllTextAsync("data.txt");
        Console.WriteLine("File content:  (.* - *.)");
        Console.WriteLine(content);
        Console.WriteLine("End of program");*/


//==========================================================================================================//
//                                                Day 19                                                    //
//==========================================================================================================//


//-----------------------------------------------FIRST---------------------------------------------------
        /*
        Process currentProcess = Process.GetCurrentProcess();
        Console.WriteLine("Current Process ID: "+ currentProcess.Id);
        Console.WriteLine("Process Name: "+ currentProcess.ProcessName);
        Console.WriteLine("Process start time: "+ currentProcess.StartTime);
        Console.WriteLine("Process Thread: "+currentProcess.Threads);
        Console.WriteLine("Process CPU Time: "+currentProcess.TotalProcessorTime);
        */

//-------------------------------------------------SECOND----------------------------------------------
        /*
        Thread worker = new Thread(DoWork);
        // Start the thread
        worker.Start();
        Console.WriteLine("Main thread continues...");

        // Optional: Wait for worker thread to finish
        worker.Join();
        Console.WriteLine("Main thread finished");
    }
    static void DoWork()
    {
        for (int i = 1; i <= 5; i++)
        {
            Console.WriteLine("Worker thread: " + i);
            Thread.Sleep(500); // Simulate work
        }   
        Process.Start("notepad.exe");
        //Process.Start("cmd.exe");
        */

//-------------------------------------THIRD--------------------------------------
        /*
        Thread t1 = new Thread(Increment);
        Thread t2 = new Thread(Increment);
        t1.Start();
        //Console.WriteLine("Final Counter Value: "+ counter);
        t2.Start();
        // t1.Join();
        // t2.Join();
        Console.WriteLine("Final Counter Value: "+ counter);
    }
    static void Increment()
    {
        for(int i = 0; i < 10000; i++)
        {
            counter++;
        }*/

        //======extended code=========
        /*
        Thread t1 = new Thread(Increment);
        Thread t2 = new Thread(Increment);
        t1.Start();
        //Console.WriteLine("Final Counter Value: "+ counter);
        t2.Start();
        t1.Join();
        t2.Join();
        Console.WriteLine("Final Counter Value: "+ counter);
    }
    static void Increment()
    {
        for(int i = 0; i < 100000; i++)
        {
            lock(lockObj)
            {
            counter++;
            }
        }
        */

//--------------------------------------------FOURTH-------------------------------------
        
        try
        {
            Task t = Task.Run(() => throw new Exception("Task Error"));
            t.Wait();
        }        
        catch  (AggregateException ex)
        {
            Console.WriteLine(ex.InnerExceptions[0].Message);
        }
//------------------------------------FIFTH EXTENDED FOURTH------------------------------------------        
        Task t1 = Task.Run(() => Console.WriteLine("Task 1"));
        Task t2 = Task.Run(() => Console.WriteLine("Task 2"));

        Task.WhenAll(t1,t2).ContinueWith(t => Console.WriteLine("All tasks completed"));

//-------------------------------------------SIXTH---------------------------------------------------
        

    }
}