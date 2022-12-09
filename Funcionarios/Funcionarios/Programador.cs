using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funcionarios
{
    public class Programador : Funcionario
    {

        public Programador(string nome, string matricula, double salarioBase) : base(nome, matricula, salarioBase)
        {

        }
        public override double CalculaSalario()
        {
            Double NovoSalario = SalarioBase * 2;
            return NovoSalario;
        }
    }
}
