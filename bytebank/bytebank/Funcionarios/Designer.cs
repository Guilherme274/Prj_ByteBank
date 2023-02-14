using bytebank.Bonificacao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank.Funcionarios
{
    public class Designer:Funcionario, IBonificavel
    {
        public Designer(string cpf) : base(cpf, 3000)
        {

        }
       

        public override void AumentarSalario()
        {
            this.Salario *= 1.11;
        }

        public double GetBonificacao()
        {
            throw new NotImplementedException();
        }
    }
}
