using bytebank.Bonificacao;
using bytebank.SistemaInterno;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank.Funcionarios
{
    public class GerenteDeContas:FuncionarioAutentivael, IBonificavel
    {

        public GerenteDeContas(string cpf) : base(cpf, 4000)
        {

        }
        

        public override void AumentarSalario()
        {
            this.Salario *= 1.05;
        }

        public bool Autenticar(string login,string senha)
        {
            return (Senha == senha && Login == login);
        }

        public double GetBonificacao()
        {
            return this.Salario * 10;
        }
    }
}
