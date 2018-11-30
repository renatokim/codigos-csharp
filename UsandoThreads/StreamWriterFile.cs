using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsandoThreads
{
    public class StreamWriterFile
    {
        public void StreamWriter()
        {
            lock(this)
            {
                using (StreamWriter file = new StreamWriter(@"writeLines.txt"))
                {
                    file.Write("A");
                    file.Write("B");

                    file.Write("C");
                    file.Write("D");

                    file.Write("E");
                    file.Write("F");
                }
            }
        }

        public void AppendText()
        {
            lock (this)
            {
                using (StreamWriter file = File.AppendText(@"writeLines.txt"))
                {
                    file.Write("A");
                    file.Write("B");

                    file.Write("C");
                    file.Write("D");

                    file.Write("E");
                    file.Write("F");
                }
            }
        }
    }
}
