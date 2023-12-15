using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio17
{
     public class Utilizador
    {
        public static string Nome;
        public static string Email;
        public static string Password;

        public Utilizador(string nome, string email, string password)
        {
            Nome = nome;
            Email = email;
            Password = password;
            List<Utilizador> numeros = new List<Utilizador>();
        }
    }
}
