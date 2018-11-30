using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace UsandoThreads
{
    public class Monitor
    {
        public bool status = false;
        StreamWriter file;

        public void ExecutarMonitor()
        {
            IList<Thread> threads = new List<Thread>();

            for (int i = 0; i < 1000; i++)
            {
                var thread = new Thread(Imprimir);
                thread.Start();

                threads.Add(thread);
            }
        }

        void Imprimir()
        {
            Console.Write("A");
            Console.Write("B");

            lock (this)
            {
                Console.Write("C");
                Console.Write("D");                
            }

            Console.Write("E");
            Console.Write("F");
        }
    }
}
