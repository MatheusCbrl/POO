using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funcionarios
{
    public class Suporte_Tecnico : Funcionario
    {
        public Suporte_Tecnico( string nome, string matricula, double salarioBase) : base(nome, matricula, salarioBase)
        {
            
        }

        public override double CalculaSalario()
        {
            return SalarioBase;
        }
    }
}
