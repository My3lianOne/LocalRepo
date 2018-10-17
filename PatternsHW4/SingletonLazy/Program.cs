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
            Lazy<SingletonLazy> instanceOne = new Lazy<SingletonLazy>();
            instanceOne.Value.SetName("InstanceOne");

            Console.WriteLine(SingletonLazy.Name);
            Console.ReadLine();
        }
    }

    class SingletonLazy
    {
        public SingletonLazy() { }

        public static string Name { get; private set; }

        private static SingletonLazy instance;

        private static object syncRoot = new Object();

        public static SingletonLazy Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (syncRoot)
                    {
                        instance = new SingletonLazy();
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