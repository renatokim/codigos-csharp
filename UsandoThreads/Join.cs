using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace UsandoThreads
{
    public class Join
    {
        public void ExecutarJoin()
        {
            var threads = new List<Thread>();

            for (int i = 0; i < 1000; i++)
            {
                var thread = new Thread(new ParameterizedThreadStart(Imprimir));
                thread.Start(i);

                threads.Add(thread);
            }

            foreach (Thread thread in threads)
            {
                thread.Join();
            }

            Console.Write("FIM...");
        }

        void Imprimir(object id)
        {
            var indice = (int)id;
            Thread.Sleep(1000);

            try
            {
                if (indice == 50)
                {
                    //Console.Read();
                    throw new Exception("################################## ");
                }

                Console.Write(indice + " ");
            }
            catch (Exception ex)
            {
                Console.Write("ERROR: " + ex.Message);
            }
        }
    }
}
