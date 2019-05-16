namespace Laboratorio_05
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
            this.tbPHora = new System.Windows.Forms.TextBox();
            this.tbNHoras = new System.Windows.Forms.TextBox();
            this.tbSBruto = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.rbHorista = new System.Windows.Forms.RadioButton();
            this.rbCLT = new System.Windows.Forms.RadioButton();
            this.btRelatorio = new System.Windows.Forms.Button();
            this.tbEndereco = new System.Windows.Forms.TextBox();
            this.tbCPF = new System.Windows.Forms.TextBox();
            this.tbNome = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tbRelatorio = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(405, 254);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.tbPHora);
            this.tabPage1.Controls.Add(this.tbNHoras);
            this.tabPage1.Controls.Add(this.tbSBruto);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.rbHorista);
            this.tabPage1.Controls.Add(this.rbCLT);
            this.tabPage1.Controls.Add(this.btRelatorio);
            this.tabPage1.Controls.Add(this.tbEndereco);
            this.tabPage1.Controls.Add(this.tbCPF);
            this.tabPage1.Controls.Add(this.tbNome);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(397, 228);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Dados do Empregado";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tbPHora
            // 
            this.tbPHora.Enabled = false;
            this.tbPHora.Location = new System.Drawing.Point(207, 161);
            this.tbPHora.Name = "tbPHora";
            this.tbPHora.Size = new System.Drawing.Size(100, 20);
            this.tbPHora.TabIndex = 14;
            this.tbPHora.VisibleChanged += new System.EventHandler(this.rbHorista_CheckedChanged);
            // 
            // tbNHoras
            // 
            this.tbNHoras.Enabled = false;
            this.tbNHoras.Location = new System.Drawing.Point(207, 134);
            this.tbNHoras.Name = "tbNHoras";
            this.tbNHoras.Size = new System.Drawing.Size(100, 20);
            this.tbNHoras.TabIndex = 13;
            this.tbNHoras.VisibleChanged += new System.EventHandler(this.rbHorista_CheckedChanged);
            // 
            // tbSBruto
            // 
            this.tbSBruto.Enabled = false;
            this.tbSBruto.Location = new System.Drawing.Point(207, 107);
            this.tbSBruto.Name = "tbSBruto";
            this.tbSBruto.Size = new System.Drawing.Size(100, 20);
            this.tbSBruto.TabIndex = 12;
            this.tbSBruto.VisibleChanged += new System.EventHandler(this.rbCLT_CheckedChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Enabled = false;
            this.label6.Location = new System.Drawing.Point(115, 164);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Preço por hora:";
            this.label6.VisibleChanged += new System.EventHandler(this.rbHorista_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Enabled = false;
            this.label5.Location = new System.Drawing.Point(110, 137);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Numero de horas:";
            this.label5.VisibleChanged += new System.EventHandler(this.rbHorista_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Enabled = false;
            this.label4.Location = new System.Drawing.Point(120, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Salário Bruto:";
            this.label4.VisibleChanged += new System.EventHandler(this.rbCLT_CheckedChanged);
            // 
            // rbHorista
            // 
            this.rbHorista.AutoSize = true;
            this.rbHorista.Location = new System.Drawing.Point(20, 149);
            this.rbHorista.Name = "rbHorista";
            this.rbHorista.Size = new System.Drawing.Size(73, 17);
            this.rbHorista.TabIndex = 8;
            this.rbHorista.Text = "HORISTA";
            this.rbHorista.UseVisualStyleBackColor = true;
            this.rbHorista.CheckedChanged += new System.EventHandler(this.rbHorista_CheckedChanged);
            // 
            // rbCLT
            // 
            this.rbCLT.AutoSize = true;
            this.rbCLT.Location = new System.Drawing.Point(20, 126);
            this.rbCLT.Name = "rbCLT";
            this.rbCLT.Size = new System.Drawing.Size(45, 17);
            this.rbCLT.TabIndex = 7;
            this.rbCLT.Text = "CLT";
            this.rbCLT.UseVisualStyleBackColor = true;
            this.rbCLT.CheckedChanged += new System.EventHandler(this.rbCLT_CheckedChanged);
            // 
            // btRelatorio
            // 
            this.btRelatorio.Location = new System.Drawing.Point(147, 190);
            this.btRelatorio.Name = "btRelatorio";
            this.btRelatorio.Size = new System.Drawing.Size(110, 32);
            this.btRelatorio.TabIndex = 6;
            this.btRelatorio.Text = "Imprimir relatório";
            this.btRelatorio.UseVisualStyleBackColor = true;
            this.btRelatorio.Click += new System.EventHandler(this.btRelatorio_Click);
            // 
            // tbEndereco
            // 
            this.tbEndereco.Location = new System.Drawing.Point(79, 75);
            this.tbEndereco.Name = "tbEndereco";
            this.tbEndereco.Size = new System.Drawing.Size(279, 20);
            this.tbEndereco.TabIndex = 5;
            // 
            // tbCPF
            // 
            this.tbCPF.Location = new System.Drawing.Point(79, 44);
            this.tbCPF.Name = "tbCPF";
            this.tbCPF.Size = new System.Drawing.Size(115, 20);
            this.tbCPF.TabIndex = 4;
            // 
            // tbNome
            // 
            this.tbNome.Location = new System.Drawing.Point(79, 14);
            this.tbNome.Name = "tbNome";
            this.tbNome.Size = new System.Drawing.Size(279, 20);
            this.tbNome.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Endereço:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "CPF:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome:";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.tbRelatorio);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(397, 228);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Relatório";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tbRelatorio
            // 
            this.tbRelatorio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbRelatorio.Location = new System.Drawing.Point(26, 31);
            this.tbRelatorio.Multiline = true;
            this.tbRelatorio.Name = "tbRelatorio";
            this.tbRelatorio.Size = new System.Drawing.Size(346, 191);
            this.tbRelatorio.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(52, 11);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(291, 17);
            this.label7.TabIndex = 4;
            this.label7.Text = "Relatório do empregado e seu salário líquido";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(429, 278);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Empregados";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox tbPHora;
        private System.Windows.Forms.TextBox tbNHoras;
        private System.Windows.Forms.TextBox tbSBruto;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton rbHorista;
        private System.Windows.Forms.RadioButton rbCLT;
        private System.Windows.Forms.Button btRelatorio;
        private System.Windows.Forms.TextBox tbEndereco;
        private System.Windows.Forms.TextBox tbCPF;
        private System.Windows.Forms.TextBox tbNome;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbRelatorio;
        private System.Windows.Forms.Label label7;
    }
}

