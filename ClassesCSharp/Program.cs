using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
            
            var flags = new FlagsClass();
            //flags.MostrarBandeiras();

            var clone = new CloneClass();
            //clone.Acoes();

            var observable = new ObservableCollectionClass();
            observable.MostarObservable();
        }


    }
}
