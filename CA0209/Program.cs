using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CA0209
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cliente Roger = new Cliente();
            Roger.CadastrarSenha();
            Pessoa Fernando = new Pessoa();
            Fernando.CadastrarNome();
            Fernando.ExibirNome(); 
        }
    }
}
