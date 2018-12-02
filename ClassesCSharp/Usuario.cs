using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesCSharp
{
    public class Usuario : IComparable
    {
        public int Id { get; set; }
        public string Login { get; set; }
        public string Senha { get; set; }

        public int CompareTo(object obj)
        {
            if (obj == null) return 1;

            Usuario otherTemperature = obj as Usuario;
            if (otherTemperature != null)
                return this.Id.CompareTo(otherTemperature.Id);
            else
                throw new ArgumentException("Object is not a Usuario");
        }
    }
}
