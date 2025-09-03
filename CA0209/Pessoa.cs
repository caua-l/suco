using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA0209
{
    class Pessoa
    {
        private string nome;
        private string cpf;
        private string rg;
        private string telefone;
        private string endereço;
        private string dataNascimento;
        private string email;
        private string estadoCivil;
        
        //Métodos de cadastro
        public void CadastrarNome(){
            Console.WriteLine("Digite seu nome");
            nome = Console.ReadLine();
        }
        public void CadastrarCPF()
        {
            Console.WriteLine("Digite seu CPF");
            cpf = Console.ReadLine();
        }
        public void CadastrarRG()
        {
            Console.WriteLine("Digite seu RG");
            rg = Console.ReadLine();
        }
        public void CadastrarTelefone()
        {
            Console.WriteLine("Digite seu número de telefone");
            telefone = Console.ReadLine();
        }
        public void CadastrarEndereço()
        {
            Console.WriteLine("Digite o seu endereço");
            endereço = Console.ReadLine();
        }
        public void CadastrarDataNasc()
        {
            Console.WriteLine("Digite sua data de aniversário");
            dataNascimento = Console.ReadLine();
        }
        public void CadastarEmail()
        {
            Console.WriteLine("Digite seu email");
            email = Console.ReadLine();
        }
        public void CadastarEstadoCivil()
        {
            Console.WriteLine("Digite seu estado civil");
            estadoCivil = Console.ReadLine();
        }
        
        //Métodos de exibição

        public void ExibirNome()
        {
            Console.WriteLine("Nome: {0}", nome);
        }
    }
}
