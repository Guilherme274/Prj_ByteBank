using bytebank.Bonificacao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank.Funcionarios
{
    public class Auxiliar:Funcionario, IBonificavel
    {
        public Auxiliar(string cpf) : base(cpf, 2000)
            {

            }
       

        public override void AumentarSalario()
        {
            this.Salario *= 1.1;
        }

        public double GetBonificacao()
        {
            throw new NotImplementedException();
        }
    }
}
