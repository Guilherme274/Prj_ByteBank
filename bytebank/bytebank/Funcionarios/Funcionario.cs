using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank.Funcionarios
{
    public abstract class Funcionario
    {
        public  string Nome { get; set; }
        public  string Cpf { get; private set; }
        public double Salario { get; protected set; }

        public static int TotalDeFuncionarios { get; private set; } // com private set você proíbe a escrita da propriedade fora da classe a qual foi criada

         // com virtual dizemos que qualquer superclasse que herdar esse método pode reescreve - lo
        
        public Funcionario(string cpf, double salario) // construtor padrão
        {
            this.Salario = salario;
            this.Cpf = cpf;
            TotalDeFuncionarios++;
            //Console.WriteLine("Criando um funcionário ");
        }
        public abstract void AumentarSalario();

        
    }
}
