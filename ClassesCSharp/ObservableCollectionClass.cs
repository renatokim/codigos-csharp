using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesCSharp
{
    public class ObservableCollectionClass
    {
        public void MostarObservable()
        {
            var nomes = new ObservableCollection<string>();
            nomes.Add("Renato");
            nomes.Add("Isabella");
            nomes.Add("Fabianne");

            nomes.CollectionChanged += nomesChanged;


            nomes.Add("Nelita");
            nomes.Remove("Fabianne");

            nomes.Add("Rodrigo");
        }

        private void nomesChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            if (sender is IEnumerable)
            {
                var collection = (ObservableCollection<string>)sender;

                foreach (var item in collection)
                {
                    Console.WriteLine(item);
                }
            }  
        }
    }
}
