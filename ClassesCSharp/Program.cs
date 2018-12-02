using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            var hasCode = new HashSetClass();
            //hasCode.HashSetClassPrint();
            //hasCode.SortedSet();
            //hasCode.SortedSetObject();
            var lista = hasCode.GeraList();
            foreach (var item in lista)
            {
                Console.WriteLine(item);
            }

        }
    }
}
