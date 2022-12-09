using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funcionarios
{
    public class Analista : Funcionario
    {

        public double Extra { get; set; }

        
        public Analista(double extra, string nome, string matricula, double salarioBase) : base (nome, matricula, salarioBase)
        {
            Extra = extra;
        }


        public override double CalculaSalario()
        {
            Double NovoSalario = SalarioBase + Extra;
            return NovoSalario;
        }

    }
}
