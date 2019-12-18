using System;
using System.Threading;

namespace MutexTest
{
    public class Program
    {
        private static readonly Mutex mutex = new Mutex(false, "testmutex");

        private string bases = "сontext";

        public static void Main(string[] args)
        {
            if (mutex.WaitOne(TimeSpan.FromSeconds(1)))
            {
                Console.WriteLine("I will sleep 5 seconds and then release named mutex.");
                Thread.Sleep(5000);
                mutex.ReleaseMutex();
            }
            else
            {
                Console.WriteLine("Mutex is busy now. Goodbye.");
                Environment.Exit(-1);
            }
        }
    }
}