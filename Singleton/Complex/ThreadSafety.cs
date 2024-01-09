using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton.Complex
{
    public class ThreadSafety
    {
        private static readonly object lockObject = new();
        private static ThreadSafety? instance;

        private ThreadSafety() 
        {
            Id = Random.Shared.Next();
            Console.WriteLine($"Singleton instance created on thread {Thread.CurrentThread.ManagedThreadId}, Id {Id}");
        }

        public static ThreadSafety Instance
        {
            get
            {
                lock (lockObject)
                {
                    if (instance == null)
                    {
                        instance = new ThreadSafety();
                    }
                    return instance;
                }
            }
        }

        public int Id { get; }
        public string Name { get; set;  }
    }

    public class ThreadNoSafety
    {
        private static ThreadNoSafety? instance;

        private ThreadNoSafety()
        {
            Id = Random.Shared.Next();
            Console.WriteLine($"Singleton instance created on thread {Thread.CurrentThread.ManagedThreadId}, Id {Id}");
        }

        public static ThreadNoSafety Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ThreadNoSafety();
                }
                return instance;
            }
        }
        public int Id { get; }
        public string Name { get; set; }
    }
}
