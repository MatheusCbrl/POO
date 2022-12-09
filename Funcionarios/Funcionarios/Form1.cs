using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Funcionarios
{
    public partial class Form1 : Form
    {
        public List<Funcionario> Funcionarios;

        public Form1()
        {
            InitializeComponent();
            Funcionarios = new List<Funcionario>();

        }

        private void btnCria_Click(object sender, EventArgs e)
        {
            //cria um objeto de cada tipo e os armazena em uma lista

            if (rdProgramador.Checked == true)
            {

                Programador fun = new Programador(txtNome.Text, txtMatricula.Text, Convert.ToDouble(txtSalariobase.Text));
                Funcionarios.Add(fun);
                ListFuncionario.Items.Add(fun);
            } else if (rdAnalista.Checked == true)
            {
                Analista fun1 = new Analista(Convert.ToDouble(txtExtra.Text),txtNome.Text, txtMatricula.Text, Convert.ToDouble(txtSalariobase.Text));
                Funcionarios.Add(fun1);
                ListFuncionario.Items.Add(fun1);


            } else if (rdSuporte.Checked == true)
            {
                Suporte_Tecnico fun2 = new Suporte_Tecnico(txtNome.Text, txtMatricula.Text, Convert.ToDouble(txtSalariobase.Text));
                Funcionarios.Add(fun2);
                ListFuncionario.Items.Add(fun2);
            }


        }

        private void btnCalcula_Click(object sender, EventArgs e)
        {
            //calcula a folha salarial dos três funcionários e imprime o valor total

            double somaValores = Funcionarios.Sum(func => func.CalculaSalario());

            ListFuncionario.Items.Add("Valor total(folhas salariais): " + somaValores);

            //MessageBox.Show(somaValores.ToString());
        }

        private void btnConceitos_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Foi utilizado conceitos de " +
                "Polimorfismo, Listas, Classes abstradas, construtores...");
        }

        private void rdSuporte_CheckedChanged(object sender, EventArgs e)
        {

        }

       
    }
}
