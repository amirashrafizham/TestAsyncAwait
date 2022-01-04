// See https://aka.ms/new-console-template for more information

using System.Diagnostics;

class Program
{
    static async Task Main(string[] args)
    {
        Console.WriteLine($"Main Thread Started. Id : {Thread.CurrentThread.ManagedThreadId}; Thread Pool: {Thread.CurrentThread.IsThreadPoolThread}; Background: {Thread.CurrentThread.IsBackground}");
        //SyncrhonousMethod_returnValue();
        //await AsynchronousMethod_returnValue();

        //SyncrhonousMethod_void();
        //await AsyncrhonousMethod_void();

        Console.WriteLine($"Main Thread Ended. Id : {Thread.CurrentThread.ManagedThreadId}; Thread Pool: {Thread.CurrentThread.IsThreadPoolThread}; Background: {Thread.CurrentThread.IsBackground}");
    }


    static async Task AsynchronousMethod_returnValue()
    {

        var sw = new Stopwatch();
        sw.Start();
        //Method1();
        //Method2();

        Task<int> task1 = Method1Async();
        Task<int> task2 = Method2Async();
        Task<int> task3 = Method3Async();

        int task1Result = await task1;
        int task2Result = await task2;
        int task3Result = await task3;

        Console.WriteLine($"Sum for Method 1 : {task1Result}");
        Console.WriteLine($"Sum for Method 2 : {task2Result}");
        Console.WriteLine($"Sum for Method 3 : {task3Result}");

        Console.WriteLine($"Time taken to run {sw.ElapsedMilliseconds * 0.001:N2} seconds");
    }

    static async Task<int> Method1Async()
    {
        Console.WriteLine($"Method 1 Child Thread Started. Id : {Thread.CurrentThread.ManagedThreadId}; Thread Pool: {Thread.CurrentThread.IsThreadPoolThread}; Background: {Thread.CurrentThread.IsBackground}");
        int sum = 0;
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine($"Method 1 iteration : {i}");
            sum = sum + i;
        }
        await Task.Delay(1000);
        Console.WriteLine($"Method 1 Child Thread Ended. Id : {Thread.CurrentThread.ManagedThreadId}; Thread Pool: {Thread.CurrentThread.IsThreadPoolThread}; Background: {Thread.CurrentThread.IsBackground}");
        return sum;
    }

    static async Task<int> Method2Async()
    {
        Console.WriteLine($"Method 2 Child Thread Started. Id : {Thread.CurrentThread.ManagedThreadId}; Thread Pool: {Thread.CurrentThread.IsThreadPoolThread}; Background: {Thread.CurrentThread.IsBackground}");
        int sum = 0;
        for (int i = 0; i < 10; i += 2)
        {
            Console.WriteLine($"Method 2 iteration : {i}");
            sum = sum + i;
        }
        await Task.Delay(1000);
        Console.WriteLine($"Method 2 Child Thread Ended. Id : {Thread.CurrentThread.ManagedThreadId}; Thread Pool: {Thread.CurrentThread.IsThreadPoolThread}; Background: {Thread.CurrentThread.IsBackground}");
        return sum;
    }

    static async Task<int> Method3Async()
    {
        Console.WriteLine($"Method 3 Child Thread Started. Id : {Thread.CurrentThread.ManagedThreadId}; Thread Pool: {Thread.CurrentThread.IsThreadPoolThread}; Background: {Thread.CurrentThread.IsBackground}");
        int sum = 0;
        for (int i = 0; i < 10; i += 3)
        {
            Console.WriteLine($"Method 3 iteration : {i}");
            sum = sum + i;
        }
        await Task.Delay(1000);
        Console.WriteLine($"Method 3 Child Thread Ended. Id : {Thread.CurrentThread.ManagedThreadId}; Thread Pool: {Thread.CurrentThread.IsThreadPoolThread}; Background: {Thread.CurrentThread.IsBackground}");
        return sum;
    }

    static void SyncrhonousMethod_returnValue()
    {
        var sw = new Stopwatch();
        sw.Start();

        var intMethod1 = Method1();
        var intMethod2 = Method2();
        var intMethod3 = Method3();

        Console.WriteLine($"Sum of method 1: {intMethod1}");
        Console.WriteLine($"Sum of method 2: {intMethod2}");
        Console.WriteLine($"Sum of method 3: {intMethod3}");

        Console.WriteLine($"Time taken to run {sw.ElapsedMilliseconds * 0.001:N2} seconds");
    }

    static int Method1()
    {
        Console.WriteLine($"Method 1 Child Thread Started. Id : {Thread.CurrentThread.ManagedThreadId}; Thread Pool: {Thread.CurrentThread.IsThreadPoolThread}; Background: {Thread.CurrentThread.IsBackground}");
        int sum = 0;
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine($"Method 1 iteration : {i}");
            sum = sum + i;
        }
        Thread.Sleep(1000);
        Console.WriteLine($"Method 1 Child Thread Ended. Id : {Thread.CurrentThread.ManagedThreadId}; Thread Pool: {Thread.CurrentThread.IsThreadPoolThread}; Background: {Thread.CurrentThread.IsBackground}");
        return sum;
    }

    static int Method2()
    {
        Console.WriteLine($"Method 2 Child Thread Started. Id : {Thread.CurrentThread.ManagedThreadId}; Thread Pool: {Thread.CurrentThread.IsThreadPoolThread}; Background: {Thread.CurrentThread.IsBackground}");
        int sum = 0;
        for (int i = 0; i < 10; i += 2)
        {
            Console.WriteLine($"Method 2 iteration : {i}");
            sum = sum + i;
        }
        Thread.Sleep(1000);
        Console.WriteLine($"Method 2 Child Thread Ended. Id : {Thread.CurrentThread.ManagedThreadId}; Thread Pool: {Thread.CurrentThread.IsThreadPoolThread}; Background: {Thread.CurrentThread.IsBackground}");
        return sum;
    }

    static int Method3()
    {
        Console.WriteLine($"Method 3 Child Thread Started. Id : {Thread.CurrentThread.ManagedThreadId}; Thread Pool: {Thread.CurrentThread.IsThreadPoolThread}; Background: {Thread.CurrentThread.IsBackground}");
        int sum = 0;
        for (int i = 0; i < 10; i += 3)
        {
            Console.WriteLine($"Method 3 iteration : {i}");
            sum = sum + i;
        }
        Thread.Sleep(1000);
        Console.WriteLine($"Method 3 Child Thread Ended. Id : {Thread.CurrentThread.ManagedThreadId}; Thread Pool: {Thread.CurrentThread.IsThreadPoolThread}; Background: {Thread.CurrentThread.IsBackground}");
        return sum;
    }


    static void SyncrhonousMethod_void()
    {
        var sw = new Stopwatch();
        sw.Start();

        Method11();
        Method22();
        Method33();

        Console.WriteLine($"Time taken to run {sw.ElapsedMilliseconds * 0.001:N2} seconds");
    }

    static void Method11()
    {
        Console.WriteLine($"Method 1 Child Thread Started. Id : {Thread.CurrentThread.ManagedThreadId}; Thread Pool: {Thread.CurrentThread.IsThreadPoolThread}; Background: {Thread.CurrentThread.IsBackground}");
        int sum = 0;
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine($"Method 1 iteration : {i}");
            sum = sum + i;
        }
        Thread.Sleep(1000);
        Console.WriteLine($"Method 1 Child Thread Ended. Id : {Thread.CurrentThread.ManagedThreadId}; Thread Pool: {Thread.CurrentThread.IsThreadPoolThread}; Background: {Thread.CurrentThread.IsBackground}");
    }

    static void Method22()
    {
        Console.WriteLine($"Method 2 Child Thread Started. Id : {Thread.CurrentThread.ManagedThreadId}; Thread Pool: {Thread.CurrentThread.IsThreadPoolThread}; Background: {Thread.CurrentThread.IsBackground}");
        int sum = 0;
        for (int i = 0; i < 10; i += 2)
        {
            Console.WriteLine($"Method 2 iteration : {i}");
            sum = sum + i;
        }
        Thread.Sleep(1000);
        Console.WriteLine($"Method 2 Child Thread Ended. Id : {Thread.CurrentThread.ManagedThreadId}; Thread Pool: {Thread.CurrentThread.IsThreadPoolThread}; Background: {Thread.CurrentThread.IsBackground}");
    }

    static void Method33()
    {
        Console.WriteLine($"Method 3 Child Thread Started. Id : {Thread.CurrentThread.ManagedThreadId}; Thread Pool: {Thread.CurrentThread.IsThreadPoolThread}; Background: {Thread.CurrentThread.IsBackground}");
        int sum = 0;
        for (int i = 0; i < 10; i += 3)
        {
            Console.WriteLine($"Method 3 iteration : {i}");
            sum = sum + i;
        }
        Thread.Sleep(1000);
        Console.WriteLine($"Method 3 Child Thread Ended. Id : {Thread.CurrentThread.ManagedThreadId}; Thread Pool: {Thread.CurrentThread.IsThreadPoolThread}; Background: {Thread.CurrentThread.IsBackground}");
    }





    static async Task AsyncrhonousMethod_void()
    {
        var sw = new Stopwatch();
        sw.Start();

        Task task1 = Method11Async();
        Task task2 = Method22Async();
        Task task3 = Method33Async();

        await Task.WhenAll(task1, task2, task3);

        Console.WriteLine($"Time taken to run {sw.ElapsedMilliseconds * 0.001:N2} seconds");
    }

    static async Task Method11Async()
    {
        Console.WriteLine($"Method 1 Child Thread Started. Id : {Thread.CurrentThread.ManagedThreadId}; Thread Pool: {Thread.CurrentThread.IsThreadPoolThread}; Background: {Thread.CurrentThread.IsBackground}");
        int sum = 0;
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine($"Method 1 iteration : {i}");
            sum = sum + i;
        }
        await Task.Delay(1000);
        Console.WriteLine($"Method 1 Child Thread Ended. Id : {Thread.CurrentThread.ManagedThreadId}; Thread Pool: {Thread.CurrentThread.IsThreadPoolThread}; Background: {Thread.CurrentThread.IsBackground}");
    }

    static async Task Method22Async()
    {
        Console.WriteLine($"Method 2 Child Thread Started. Id : {Thread.CurrentThread.ManagedThreadId}; Thread Pool: {Thread.CurrentThread.IsThreadPoolThread}; Background: {Thread.CurrentThread.IsBackground}");
        int sum = 0;
        for (int i = 0; i < 10; i += 2)
        {
            Console.WriteLine($"Method 2 iteration : {i}");
            sum = sum + i;
        }
        await Task.Delay(1000);
        Console.WriteLine($"Method 2 Child Thread Ended. Id : {Thread.CurrentThread.ManagedThreadId}; Thread Pool: {Thread.CurrentThread.IsThreadPoolThread}; Background: {Thread.CurrentThread.IsBackground}");
    }

    static async Task Method33Async()
    {
        Console.WriteLine($"Method 3 Child Thread Started. Id : {Thread.CurrentThread.ManagedThreadId}; Thread Pool: {Thread.CurrentThread.IsThreadPoolThread}; Background: {Thread.CurrentThread.IsBackground}");
        int sum = 0;
        for (int i = 0; i < 10; i += 3)
        {
            Console.WriteLine($"Method 3 iteration : {i}");
            sum = sum + i;
        }
        await Task.Delay(1000);
        Console.WriteLine($"Method 3 Child Thread Ended. Id : {Thread.CurrentThread.ManagedThreadId}; Thread Pool: {Thread.CurrentThread.IsThreadPoolThread}; Background: {Thread.CurrentThread.IsBackground}");
    }


    static async Task<int> valueX()
    {
        await Task.WhenAll();
        return 5;
    }
    static async Task<int> valueY()
    {
        await Task.WhenAll();
        return 5;
    }

}






