using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace PatternsHW4
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            while (i < 5)
            {
                var thread = new Thread(() =>
                {
                    ThreadSafeSingleton instanceOne = ThreadSafeSingleton.Instance;
                    instanceOne.SetName("Первый");
                });
                thread.Start();

                ThreadSafeSingleton instanceTwo = ThreadSafeSingleton.Instance;
                instanceTwo.SetName("Второй");

                i++;
            }
            Console.WriteLine(ThreadSafeSingleton.Name);                    
            Console.ReadLine();
        }
    }

    class ThreadSafeSingleton
    {
        public ThreadSafeSingleton() { }

        public static string Name { get; private set; }

        private static ThreadSafeSingleton instance;

        private static object syncRoot = new Object();

        public static ThreadSafeSingleton Instance
        {
            get {
                if (instance == null)
                {
                    lock (syncRoot)
                    {
                        instance = new ThreadSafeSingleton();
                    }
                }
                return instance;                
            }                 
        }

        public void SetName(string name)
        {
            Name = name;
        }
    }

    
}
