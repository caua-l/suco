using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA0209
{
    internal class Cliente : Pessoa
    {
        Cliente Roger = new  Cliente();
        private int senha;
        

        public void CadastrarSenha()
        {
            Console.WriteLine("Digite sua senha  : \n");
            Console.ReadLine();
            if (senha == 0 || senha == null)
            {
                Console.WriteLine("Senha inválida");
                return void;
            }
        }
        

    }
}
