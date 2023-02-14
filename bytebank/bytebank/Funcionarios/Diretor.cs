using bytebank.Bonificacao;
using bytebank.Funcionarios;
using bytebank.SistemaInterno;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank
{
    public class Diretor :  FuncionarioAutentivael, IBonificavel // herança dos atributos, comportamentos da classe funcionario
    {
        

       

        public Diretor(string cpf):base(cpf, 5000)
        {
            
            //Console.WriteLine("Criando um diretor. ");
        }

        public override void AumentarSalario()
        {
            this.Salario *= 1.15;
        }

        public bool Autenticar(string login,string senha)
        {
            return (Senha == senha && Login == login);
        }

        public double GetBonificacao()
        {
            throw new NotImplementedException();
        }
    }
}
