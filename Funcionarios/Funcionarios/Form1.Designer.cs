namespace Funcionarios
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnCria = new System.Windows.Forms.Button();
            this.btnCalcula = new System.Windows.Forms.Button();
            this.ListFuncionario = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtSalariobase = new System.Windows.Forms.TextBox();
            this.txtMatricula = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.rdProgramador = new System.Windows.Forms.RadioButton();
            this.rdAnalista = new System.Windows.Forms.RadioButton();
            this.rdSuporte = new System.Windows.Forms.RadioButton();
            this.txtExtra = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnConceitos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCria
            // 
            this.btnCria.Location = new System.Drawing.Point(58, 217);
            this.btnCria.Name = "btnCria";
            this.btnCria.Size = new System.Drawing.Size(95, 23);
            this.btnCria.TabIndex = 0;
            this.btnCria.Text = "Cria Funcionario";
            this.btnCria.UseVisualStyleBackColor = true;
            this.btnCria.Click += new System.EventHandler(this.btnCria_Click);
            // 
            // btnCalcula
            // 
            this.btnCalcula.Location = new System.Drawing.Point(159, 217);
            this.btnCalcula.Name = "btnCalcula";
            this.btnCalcula.Size = new System.Drawing.Size(159, 23);
            this.btnCalcula.TabIndex = 1;
            this.btnCalcula.Text = "Calcula a Folha Salarial";
            this.btnCalcula.UseVisualStyleBackColor = true;
            this.btnCalcula.Click += new System.EventHandler(this.btnCalcula_Click);
            // 
            // ListFuncionario
            // 
            this.ListFuncionario.FormattingEnabled = true;
            this.ListFuncionario.Location = new System.Drawing.Point(328, 12);
            this.ListFuncionario.Name = "ListFuncionario";
            this.ListFuncionario.Size = new System.Drawing.Size(288, 277);
            this.ListFuncionario.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nome";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(55, 28);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(267, 20);
            this.txtNome.TabIndex = 4;
            // 
            // txtSalariobase
            // 
            this.txtSalariobase.Location = new System.Drawing.Point(55, 106);
            this.txtSalariobase.Name = "txtSalariobase";
            this.txtSalariobase.Size = new System.Drawing.Size(267, 20);
            this.txtSalariobase.TabIndex = 6;
            // 
            // txtMatricula
            // 
            this.txtMatricula.Location = new System.Drawing.Point(55, 67);
            this.txtMatricula.Name = "txtMatricula";
            this.txtMatricula.Size = new System.Drawing.Size(267, 20);
            this.txtMatricula.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Matricula";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(52, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Salario base";
            // 
            // rdProgramador
            // 
            this.rdProgramador.AutoSize = true;
            this.rdProgramador.Location = new System.Drawing.Point(55, 132);
            this.rdProgramador.Name = "rdProgramador";
            this.rdProgramador.Size = new System.Drawing.Size(85, 17);
            this.rdProgramador.TabIndex = 10;
            this.rdProgramador.TabStop = true;
            this.rdProgramador.Text = "Programador";
            this.rdProgramador.UseVisualStyleBackColor = true;
            // 
            // rdAnalista
            // 
            this.rdAnalista.AutoSize = true;
            this.rdAnalista.Location = new System.Drawing.Point(146, 132);
            this.rdAnalista.Name = "rdAnalista";
            this.rdAnalista.Size = new System.Drawing.Size(62, 17);
            this.rdAnalista.TabIndex = 11;
            this.rdAnalista.TabStop = true;
            this.rdAnalista.Text = "Analista";
            this.rdAnalista.UseVisualStyleBackColor = true;
            // 
            // rdSuporte
            // 
            this.rdSuporte.AutoSize = true;
            this.rdSuporte.Location = new System.Drawing.Point(214, 132);
            this.rdSuporte.Name = "rdSuporte";
            this.rdSuporte.Size = new System.Drawing.Size(104, 17);
            this.rdSuporte.TabIndex = 12;
            this.rdSuporte.TabStop = true;
            this.rdSuporte.Text = "Suporte Técnico";
            this.rdSuporte.UseVisualStyleBackColor = true;
            this.rdSuporte.CheckedChanged += new System.EventHandler(this.rdSuporte_CheckedChanged);
            // 
            // txtExtra
            // 
            this.txtExtra.Location = new System.Drawing.Point(55, 181);
            this.txtExtra.Name = "txtExtra";
            this.txtExtra.Size = new System.Drawing.Size(267, 20);
            this.txtExtra.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(55, 165);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Extra Analista";
            // 
            // btnConceitos
            // 
            this.btnConceitos.Location = new System.Drawing.Point(58, 257);
            this.btnConceitos.Name = "btnConceitos";
            this.btnConceitos.Size = new System.Drawing.Size(260, 23);
            this.btnConceitos.TabIndex = 15;
            this.btnConceitos.Text = "Conceitos utilzados de POO";
            this.btnConceitos.UseVisualStyleBackColor = true;
            this.btnConceitos.Click += new System.EventHandler(this.btnConceitos_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(637, 330);
            this.Controls.Add(this.btnConceitos);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtExtra);
            this.Controls.Add(this.rdSuporte);
            this.Controls.Add(this.rdAnalista);
            this.Controls.Add(this.rdProgramador);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtMatricula);
            this.Controls.Add(this.txtSalariobase);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ListFuncionario);
            this.Controls.Add(this.btnCalcula);
            this.Controls.Add(this.btnCria);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCria;
        private System.Windows.Forms.Button btnCalcula;
        private System.Windows.Forms.ListBox ListFuncionario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtSalariobase;
        private System.Windows.Forms.TextBox txtMatricula;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton rdProgramador;
        private System.Windows.Forms.RadioButton rdAnalista;
        private System.Windows.Forms.RadioButton rdSuporte;
        private System.Windows.Forms.TextBox txtExtra;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnConceitos;
    }
}

