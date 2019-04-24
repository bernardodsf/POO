namespace Laboratorio_03
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.cbMat = new System.Windows.Forms.ComboBox();
            this.cbAluno = new System.Windows.Forms.ComboBox();
            this.btAddMat = new System.Windows.Forms.Button();
            this.btSalvar = new System.Windows.Forms.Button();
            this.tbNro = new System.Windows.Forms.TextBox();
            this.tbPeriodo = new System.Windows.Forms.TextBox();
            this.tbNome = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btSalvarMat = new System.Windows.Forms.Button();
            this.tbCodMat = new System.Windows.Forms.TextBox();
            this.tbNomeMat = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.cbRelatorio = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tbRelatorio = new System.Windows.Forms.TextBox();
            this.btBuscar = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(3, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(418, 235);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.cbMat);
            this.tabPage1.Controls.Add(this.cbAluno);
            this.tabPage1.Controls.Add(this.btAddMat);
            this.tabPage1.Controls.Add(this.btSalvar);
            this.tabPage1.Controls.Add(this.tbNro);
            this.tabPage1.Controls.Add(this.tbPeriodo);
            this.tabPage1.Controls.Add(this.tbNome);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(410, 209);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "ALUNO";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // cbMat
            // 
            this.cbMat.FormattingEnabled = true;
            this.cbMat.Location = new System.Drawing.Point(267, 113);
            this.cbMat.Name = "cbMat";
            this.cbMat.Size = new System.Drawing.Size(121, 21);
            this.cbMat.TabIndex = 13;
            // 
            // cbAluno
            // 
            this.cbAluno.FormattingEnabled = true;
            this.cbAluno.Location = new System.Drawing.Point(267, 66);
            this.cbAluno.Name = "cbAluno";
            this.cbAluno.Size = new System.Drawing.Size(121, 21);
            this.cbAluno.TabIndex = 12;
            this.cbAluno.SelectedIndexChanged += new System.EventHandler(this.cbAluno_SelectedIndexChanged);
            // 
            // btAddMat
            // 
            this.btAddMat.Location = new System.Drawing.Point(267, 163);
            this.btAddMat.Name = "btAddMat";
            this.btAddMat.Size = new System.Drawing.Size(75, 23);
            this.btAddMat.TabIndex = 11;
            this.btAddMat.Text = "Adicionar";
            this.btAddMat.UseVisualStyleBackColor = true;
            this.btAddMat.Click += new System.EventHandler(this.btAddMat_Click);
            // 
            // btSalvar
            // 
            this.btSalvar.Location = new System.Drawing.Point(77, 163);
            this.btSalvar.Name = "btSalvar";
            this.btSalvar.Size = new System.Drawing.Size(75, 23);
            this.btSalvar.TabIndex = 10;
            this.btSalvar.Text = "Salvar";
            this.btSalvar.UseVisualStyleBackColor = true;
            this.btSalvar.Click += new System.EventHandler(this.btSalvar_Click);
            // 
            // tbNro
            // 
            this.tbNro.Location = new System.Drawing.Point(77, 113);
            this.tbNro.Name = "tbNro";
            this.tbNro.Size = new System.Drawing.Size(111, 20);
            this.tbNro.TabIndex = 7;
            // 
            // tbPeriodo
            // 
            this.tbPeriodo.Location = new System.Drawing.Point(77, 66);
            this.tbPeriodo.Name = "tbPeriodo";
            this.tbPeriodo.Size = new System.Drawing.Size(111, 20);
            this.tbPeriodo.TabIndex = 6;
            // 
            // tbNome
            // 
            this.tbNome.Location = new System.Drawing.Point(77, 20);
            this.tbNome.Name = "tbNome";
            this.tbNome.Size = new System.Drawing.Size(169, 20);
            this.tbNome.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(211, 116);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Matérias:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(218, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Aluno:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Matrícula:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Período:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome: ";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btSalvarMat);
            this.tabPage2.Controls.Add(this.tbCodMat);
            this.tabPage2.Controls.Add(this.tbNomeMat);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(410, 209);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "MATÉRIA";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btSalvarMat
            // 
            this.btSalvarMat.Location = new System.Drawing.Point(82, 153);
            this.btSalvarMat.Name = "btSalvarMat";
            this.btSalvarMat.Size = new System.Drawing.Size(75, 23);
            this.btSalvarMat.TabIndex = 4;
            this.btSalvarMat.Text = "Salvar";
            this.btSalvarMat.UseVisualStyleBackColor = true;
            this.btSalvarMat.Click += new System.EventHandler(this.btSalvarMat_Click);
            // 
            // tbCodMat
            // 
            this.tbCodMat.Location = new System.Drawing.Point(82, 65);
            this.tbCodMat.Name = "tbCodMat";
            this.tbCodMat.Size = new System.Drawing.Size(100, 20);
            this.tbCodMat.TabIndex = 3;
            // 
            // tbNomeMat
            // 
            this.tbNomeMat.Location = new System.Drawing.Point(82, 24);
            this.tbNomeMat.Name = "tbNomeMat";
            this.tbNomeMat.Size = new System.Drawing.Size(215, 20);
            this.tbNomeMat.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(32, 68);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Código:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(31, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Matéria:";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.cbRelatorio);
            this.tabPage3.Controls.Add(this.label8);
            this.tabPage3.Controls.Add(this.tbRelatorio);
            this.tabPage3.Controls.Add(this.btBuscar);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(410, 209);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "RELATÓRIO";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // cbRelatorio
            // 
            this.cbRelatorio.FormattingEnabled = true;
            this.cbRelatorio.Location = new System.Drawing.Point(49, 12);
            this.cbRelatorio.Name = "cbRelatorio";
            this.cbRelatorio.Size = new System.Drawing.Size(238, 21);
            this.cbRelatorio.TabIndex = 4;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 15);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 13);
            this.label8.TabIndex = 3;
            this.label8.Text = "Aluno:";
            // 
            // tbRelatorio
            // 
            this.tbRelatorio.Location = new System.Drawing.Point(6, 43);
            this.tbRelatorio.Multiline = true;
            this.tbRelatorio.Name = "tbRelatorio";
            this.tbRelatorio.Size = new System.Drawing.Size(395, 157);
            this.tbRelatorio.TabIndex = 2;
            // 
            // btBuscar
            // 
            this.btBuscar.Location = new System.Drawing.Point(293, 6);
            this.btBuscar.Name = "btBuscar";
            this.btBuscar.Size = new System.Drawing.Size(108, 31);
            this.btBuscar.TabIndex = 1;
            this.btBuscar.Text = "Buscar";
            this.btBuscar.UseVisualStyleBackColor = true;
            this.btBuscar.Click += new System.EventHandler(this.btBuscar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 238);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Cadastro Aluno";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btAddMat;
        private System.Windows.Forms.Button btSalvar;
        private System.Windows.Forms.TextBox tbNro;
        private System.Windows.Forms.TextBox tbPeriodo;
        private System.Windows.Forms.TextBox tbNome;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btSalvarMat;
        private System.Windows.Forms.TextBox tbCodMat;
        private System.Windows.Forms.TextBox tbNomeMat;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TextBox tbRelatorio;
        private System.Windows.Forms.Button btBuscar;
        private System.Windows.Forms.ComboBox cbMat;
        private System.Windows.Forms.ComboBox cbAluno;
        private System.Windows.Forms.ComboBox cbRelatorio;
        private System.Windows.Forms.Label label8;
    }
}

