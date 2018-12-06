using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesCSharp
{
    public class FlagsClass
    {
        [Flags]
        public enum Bandeira
        {
            Brasil = 1,
            Argentina = 2,
            Alemanha = 4,
            Japao = 8
        }

        public void MostrarBandeiras()
        {
            Bandeira bandeira;

            bandeira = Bandeira.Alemanha;
            bandeira |= Bandeira.Argentina;
            bandeira |= Bandeira.Brasil;
            bandeira |= Bandeira.Japao;
            bandeira |= Bandeira.Alemanha;

            Console.WriteLine(bandeira);

            int valorBandeira = (int)bandeira;

            var temAlemanha = bandeira.HasFlag(Bandeira.Alemanha);
            var temBrasil = bandeira.HasFlag(Bandeira.Brasil);

            var convertEmFlag = (Bandeira)6;

            Console.WriteLine(convertEmFlag);

            var stringFlags = bandeira.ToString().Split(',').Select(x => x.Trim()).OrderBy(x => x).ToList();

            var valorTotal = (int)bandeira;

            Console.WriteLine(valorTotal);

        }


    }
}
