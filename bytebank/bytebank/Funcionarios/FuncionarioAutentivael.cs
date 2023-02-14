using bytebank.SistemaInterno;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank.Funcionarios
{
    public abstract class FuncionarioAutentivael : Funcionario, IAutenticavel
    {
        protected FuncionarioAutentivael(string cpf, double salario) : base(cpf, salario)
        {
        }

        public string Senha { get; set ; }
        public string Login { get; set ; }

        

        public bool Autenticar(string login, string senha)
        {
            return (Senha == senha && Login == login);
        }

        
    }
}
