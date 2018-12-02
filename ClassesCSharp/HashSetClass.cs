using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesCSharp
{
    public class HashSetClass
    {
        public void HashSetClassPrint()
        {
            var listaUsuarios = new List<Usuario>();

            var user = new Usuario();
            user.Id = 1;

            var user2 = new Usuario();
            user2.Id = 2;

            var user3 = user2;
            user3.Id = 3;

            var hasCode = user.GetHashCode();
            var hasCode2 = user2.GetHashCode();
            var hasCode3 = user3.GetHashCode();

            user.Login = "teste";

            var hasCodeModificado = user.GetHashCode();

            listaUsuarios.Add(user);
            listaUsuarios.Add(user);
            listaUsuarios.Add(user);
            listaUsuarios.Add(user2);
            listaUsuarios.Add(user2);
            listaUsuarios.Add(user2);
            listaUsuarios.Add(user3);
            listaUsuarios.Add(user3);
            listaUsuarios.Add(user3);

            HashSet<Usuario> usuarios = new HashSet<Usuario>();

            usuarios.Add(user);
            usuarios.Add(user);
            usuarios.Add(user);
            usuarios.Add(user);
            usuarios.Add(user2);
            usuarios.Add(user3);

            foreach (var item in listaUsuarios)
            {
                usuarios.Add(item);
            }

            HashSet<string> devedores = new HashSet<string>();
            // Podemos adicionar elementos no conjunto utilizando o método Add
            devedores.Add("victor");
            devedores.Add("osni");
            devedores.Add("victor");
            devedores.Add("osni");
            devedores.Add("victor");
            devedores.Add("osni");
            devedores.Add("victor");
            devedores.Add("osni");
            devedores.Add("victor");
            devedores.Add("osni");

            foreach (string devedor in devedores)
            {
                Console.WriteLine(devedor);
            }
        }
    }
}
