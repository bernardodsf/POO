namespace Laboratorio_07
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
            this.label1 = new System.Windows.Forms.Label();
            this.btPush = new System.Windows.Forms.Button();
            this.btPop = new System.Windows.Forms.Button();
            this.btImprime = new System.Windows.Forms.Button();
            this.btMaior = new System.Windows.Forms.Button();
            this.btMenor = new System.Windows.Forms.Button();
            this.btInverte = new System.Windows.Forms.Button();
            this.tbPop = new System.Windows.Forms.RichTextBox();
            this.tbPush = new System.Windows.Forms.RichTextBox();
            this.tbPilha = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "PILHA:";
            // 
            // btPush
            // 
            this.btPush.Location = new System.Drawing.Point(175, 44);
            this.btPush.Name = "btPush";
            this.btPush.Size = new System.Drawing.Size(75, 23);
            this.btPush.TabIndex = 2;
            this.btPush.Text = "PUSH";
            this.btPush.UseVisualStyleBackColor = true;
            this.btPush.Click += new System.EventHandler(this.btPush_Click);
            // 
            // btPop
            // 
            this.btPop.Location = new System.Drawing.Point(175, 88);
            this.btPop.Name = "btPop";
            this.btPop.Size = new System.Drawing.Size(75, 23);
            this.btPop.TabIndex = 3;
            this.btPop.Text = "POP";
            this.btPop.UseVisualStyleBackColor = true;
            this.btPop.Click += new System.EventHandler(this.btPop_Click);
            // 
            // btImprime
            // 
            this.btImprime.Location = new System.Drawing.Point(175, 132);
            this.btImprime.Name = "btImprime";
            this.btImprime.Size = new System.Drawing.Size(75, 23);
            this.btImprime.TabIndex = 4;
            this.btImprime.Text = "IMPRIME";
            this.btImprime.UseVisualStyleBackColor = true;
            this.btImprime.Click += new System.EventHandler(this.btImprime_Click);
            // 
            // btMaior
            // 
            this.btMaior.Location = new System.Drawing.Point(175, 176);
            this.btMaior.Name = "btMaior";
            this.btMaior.Size = new System.Drawing.Size(75, 23);
            this.btMaior.TabIndex = 5;
            this.btMaior.Text = "MAIOR";
            this.btMaior.UseVisualStyleBackColor = true;
            this.btMaior.Click += new System.EventHandler(this.btMaior_Click);
            // 
            // btMenor
            // 
            this.btMenor.Location = new System.Drawing.Point(175, 220);
            this.btMenor.Name = "btMenor";
            this.btMenor.Size = new System.Drawing.Size(75, 23);
            this.btMenor.TabIndex = 6;
            this.btMenor.Text = "MENOR";
            this.btMenor.UseVisualStyleBackColor = true;
            this.btMenor.Click += new System.EventHandler(this.btMenor_Click);
            // 
            // btInverte
            // 
            this.btInverte.Location = new System.Drawing.Point(175, 264);
            this.btInverte.Name = "btInverte";
            this.btInverte.Size = new System.Drawing.Size(75, 23);
            this.btInverte.TabIndex = 7;
            this.btInverte.Text = "INVERTE";
            this.btInverte.UseVisualStyleBackColor = true;
            this.btInverte.Click += new System.EventHandler(this.btInverte_Click);
            // 
            // tbPop
            // 
            this.tbPop.Location = new System.Drawing.Point(266, 88);
            this.tbPop.Name = "tbPop";
            this.tbPop.Size = new System.Drawing.Size(81, 22);
            this.tbPop.TabIndex = 9;
            this.tbPop.Text = "";
            // 
            // tbPush
            // 
            this.tbPush.Location = new System.Drawing.Point(266, 44);
            this.tbPush.Name = "tbPush";
            this.tbPush.Size = new System.Drawing.Size(81, 23);
            this.tbPush.TabIndex = 10;
            this.tbPush.Text = "";
            // 
            // tbPilha
            // 
            this.tbPilha.Location = new System.Drawing.Point(59, 29);
            this.tbPilha.Name = "tbPilha";
            this.tbPilha.Size = new System.Drawing.Size(100, 322);
            this.tbPilha.TabIndex = 11;
            this.tbPilha.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 363);
            this.Controls.Add(this.tbPilha);
            this.Controls.Add(this.tbPush);
            this.Controls.Add(this.tbPop);
            this.Controls.Add(this.btInverte);
            this.Controls.Add(this.btMenor);
            this.Controls.Add(this.btMaior);
            this.Controls.Add(this.btImprime);
            this.Controls.Add(this.btPop);
            this.Controls.Add(this.btPush);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Pilha de Inteiros";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btPush;
        private System.Windows.Forms.Button btPop;
        private System.Windows.Forms.Button btImprime;
        private System.Windows.Forms.Button btMaior;
        private System.Windows.Forms.Button btMenor;
        private System.Windows.Forms.Button btInverte;
        private System.Windows.Forms.RichTextBox tbPop;
        private System.Windows.Forms.RichTextBox tbPush;
        private System.Windows.Forms.RichTextBox tbPilha;
    }
}

