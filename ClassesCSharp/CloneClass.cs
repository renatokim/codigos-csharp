using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesCSharp
{
    public class CloneClass
    {
        public void Acoes()
        {
            var usuarioUm = new Usuario
            {
                Id = 1,
                Login = "Renato",
                Senha = "1234"

            };

            var usuarioDois = usuarioUm.Clone() as Usuario;

            usuarioDois.Id = 5;

            var usuarioTres = usuarioUm;

            usuarioTres.Id = 9;

        }
        
    }
}
