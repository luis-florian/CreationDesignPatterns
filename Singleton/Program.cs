// See https://aka.ms/new-console-template for more information
using Singleton.Complex;

Console.WriteLine("Hello, World!");


// this is an example of how singleton works, and verify creting two instance of these and check if are the same 



/*
    Singleton.Basic.Singleton singletonInstance = Singleton.Basic.Singleton.Instance;
    Singleton.Basic.Singleton anotherInstance = Singleton.Basic.Singleton.Instance;
    // The two instances are the same.
    bool areEqual = ReferenceEquals(singletonInstance, anotherInstance);
    Console.WriteLine($"Are the instances equal? {areEqual}");
*/


// a second example of a Singleton implementation, with information that we going to share, and even creating different instance
// this always will be the same value



/*
    Singleton.Basic.Configurations configurations = Singleton.Basic.Configurations.Instance;
    Singleton.Basic.Configurations configurations_second = Singleton.Basic.Configurations.Instance;
    static void print(string name, Singleton.Basic.Configurations conf)
    {
        Console.WriteLine($"Printing properties of {name}: \n\t {conf.Id}, {conf.MachineName}, {conf.FolderPath}");
    }

    print(nameof(configurations), configurations);
    print(nameof(configurations_second), configurations_second);

    configurations.FolderPath = "C:/MyPath/There_is_my_File";

    print(nameof(configurations), configurations);
    print(nameof(configurations_second), configurations_second);

    configurations_second.MachineName = "Pedros-Machine";

    print(nameof(configurations), configurations);
    print(nameof(configurations_second), configurations_second);
*/

// ThreadSafety implementation and testing if this fail



/*
    static void threadsafetyRun()
    {
        Console.WriteLine("Thread Safety its running");
        Parallel.For(0, 10, i =>
        {
            Task.Run(() =>
            {
                // we can change ThreadSafety to ThreadNoSafety to test the difference
                ThreadSafety singletonInstance = ThreadSafety.Instance;
                singletonInstance.Name = Guid.NewGuid().ToString();
                Console.WriteLine($"Thread {Thread.CurrentThread.ManagedThreadId}: {singletonInstance.GetHashCode()}, name: {singletonInstance.Name}");
            });
        });

        Thread.Sleep(1000);
        Console.WriteLine("\n Thread No Safety its running");

        Parallel.For(0, 10, i =>
        {
            Task.Run(() =>
            {
                // we can change ThreadSafety to ThreadNoSafety to test the difference
                ThreadNoSafety singletonInstance = ThreadNoSafety.Instance;
                singletonInstance.Name = Guid.NewGuid().ToString();
                Console.WriteLine($"Thread {Thread.CurrentThread.ManagedThreadId}: {singletonInstance.GetHashCode()}, name: {singletonInstance.Name}");
            });
        });
    }

    threadsafetyRun();
*/




Console.ReadLine();
