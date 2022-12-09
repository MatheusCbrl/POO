using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funcionarios
{
    public abstract class Funcionario
    {
        public string Nome { get; set; }

        public string Matricula { get; set; }

        public double SalarioBase { get; set; }


 


        public Funcionario (string nome, string matricula, double salarioBase)
        {
            this.Nome = nome;
            this.Matricula = matricula;
            this.SalarioBase = salarioBase;
        }


        public virtual double CalculaSalario()
        {
            return 0;
        }

        public override string ToString()
        {
            return $"Nome: {Nome} | Matrícula: {Matricula} | Folha Salarial: {CalculaSalario()}";
           
        }
       
    }
}
