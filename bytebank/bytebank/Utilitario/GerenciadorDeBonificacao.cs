using bytebank.Bonificacao;
using bytebank.Funcionarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank.Utilitario
{
    public class GerenciadorDeBonificacao : IBonificavel
    {
        public double TotalDeBonificacao { get; private set; }

        public double GetBonificacao()
        {
            return 10;
        }

        //public void Registrar(Funcionario funcionario)
        //{
        //    this.TotalDeBonificacao += funcionario.GetBonificacao();
        //}

        
    }
}
