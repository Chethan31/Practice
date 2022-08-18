using System.Diagnostics;

//Console.WriteLine("No of cores in our system are:" + Environment.ProcessorCount);
//Console.WriteLine("Main method running in thread id:" + Thread.CurrentThread.ManagedThreadId);

Stopwatch w = Stopwatch.StartNew();
Console.WriteLine("Running Sequenially....");
M1();
M2();
Console.WriteLine(w.ElapsedMilliseconds);

//Thread
w=Stopwatch.StartNew();
Console.WriteLine("Running using Multi Threading....");
//First way
ThreadStart ts1 = new ThreadStart(M1);
Thread t1 = new Thread(M1);
t1.Start();
//Second way
Thread t2 = new Thread(M2);
t2.Start();
//wait for t1 and t2 to complete excecute
t1.Join();
t2.Join();
Console.WriteLine(w.ElapsedMilliseconds);

//Task
Console.WriteLine("Running Using Task.....");
w = Stopwatch.StartNew();
Task tt1 = new Task(M1);
tt1.Start();
Task tt2 = new Task(M2);
tt2.Start();
//wait for tt1 and tt2 to complete excecute
tt1.Wait();
tt2.Wait();
Console.WriteLine(w.ElapsedMilliseconds);

//Parallel
Console.WriteLine("Running Using Parallel.....");
w = Stopwatch.StartNew();
Parallel.Invoke(M1, M2);
Console.WriteLine(w.ElapsedMilliseconds);

Console.WriteLine("Running Using Parallel for.....");
w = Stopwatch.StartNew();
Parallel.Invoke(M11, M22);
Console.WriteLine(w.ElapsedMilliseconds);

//Firt method
static void M1()
{
    //  Console.WriteLine("M1 running in thread id:" + Thread.CurrentThread.ManagedThreadId);
    for (int i = 0; i < 10; i++)
    {
        //complexCode
        Thread.Sleep(500);
    }
}
static void M2()
{
    // Console.WriteLine("M2 running in thread id:" + Thread.CurrentThread.ManagedThreadId);
    for (int i = 0; i < 10; i++)
    {
        //complexCode
        Thread.Sleep(500);
    }
}

//Second method
static void M11()
{
    //  Console.WriteLine("M1 running in thread id:" + Thread.CurrentThread.ManagedThreadId);
    //for (int i = 0; i < 10; i++)
    Parallel.For(1, 11, i =>
    {
        //complexCode
        Thread.Sleep(500);
    });
}
static void M22()
{
    // Console.WriteLine("M2 running in thread id:" + Thread.CurrentThread.ManagedThreadId);
    Parallel.For(1, 11, i =>
    {
        //complexCode
        Thread.Sleep(500);
    });
}