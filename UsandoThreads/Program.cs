using AutoMapper;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using UsandoThreads.AutoMapper;

namespace UsandoThreads
{
    class Program
    {
        static void Main(string[] args)
        {
            var classeJoin = new Join();
            //classeJoin.ExecutarJoin();

            var classeMonitor = new Monitor();
            //classeMonitor.ExecutarMonitor();

            var processStartInfoClass = new ProcessStartInfoClass();
            //processStartInfoClass.TxtStart();

            var autoMapperClass = new AutoMapperClass();
            autoMapperClass.AutoMapperFunction();

        }
    }
}
