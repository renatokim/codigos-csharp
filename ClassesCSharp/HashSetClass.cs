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

        public void SortedSet()
        {
            SortedSet<string> devedores = new SortedSet<string>();

            devedores.Add("Hugo");
            devedores.Add("Ettore");
            devedores.Add("Osni");
            devedores.Add("Alberto");
            devedores.Add("Victor");

            // Esse foreach vai mostrar os nomes na seguinte ordem:
            // Alberto, Ettore, Hugo, Osni e por fim Victor
            foreach (string nome in devedores)
            {
                Console.WriteLine(nome);
            }
        }

        public void SortedSetObject()
        {
            SortedSet<Usuario> usuarios = new SortedSet<Usuario>();

            var usuario28 = new Usuario { Id = 28 };
            var usuario51 = new Usuario { Id = 51 };
            var usuario51Outro = new Usuario { Id = 51 };

            var ehIgual = usuario28.CompareTo(usuario51);
            var notEhIgual = usuario51Outro.CompareTo(usuario51);
            var nullEhIgual = usuario51Outro.CompareTo(null);
            
            try
            {
                var OuterEhIgual = usuario51Outro.CompareTo("teste");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            usuarios.Add(new Usuario { Id = 59 });
            usuarios.Add(new Usuario { Id = 75 });
            usuarios.Add(new Usuario { Id = 28 });
            usuarios.Add(new Usuario { Id = 01 });
            usuarios.Add(new Usuario { Id = 100 });
            usuarios.Add(new Usuario { Id = 100 });
            usuarios.Add(new Usuario { Id = 100 });
            usuarios.Add(new Usuario { Id = 05 });
            usuarios.Add(new Usuario { Id = 96 });

            

            // Esse foreach vai mostrar os nomes na seguinte ordem:
            // Alberto, Ettore, Hugo, Osni e por fim Victor
            foreach (var nome in usuarios)
            {
                Console.WriteLine(nome.Id);
            }
        }

        public HashSet<string> GeraList()
        {
            HashSet<string> nomes = new HashSet<string>();
            for (int i = 0; i < 30000; i++)
            {
                nomes.Add("devedor");
            }
            return nomes;
        }
    }
}
