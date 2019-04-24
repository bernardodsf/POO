using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laboratorio_03
{
    public partial class Form1 : Form
    {
        Materia[] mat = new Materia[20];
        Materia[] list_mat = new Materia[20];

        Aluno[] aluno = new Aluno[30];

        int i = 0;
        int j = 0;
        int k = 0;
        int id = 0;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void btSalvar_Click(object sender, EventArgs e)
        {
            if (tbNome.Text != " " && tbPeriodo.Text != " " && tbNro.Text != " ")
            {
                aluno[i] = new Aluno();
                aluno[i].setNome(tbNome.Text);
                aluno[i].setPeriodo(tbPeriodo.Text);
                aluno[i].setMatricula(tbNro.Text);
                cbAluno.Items.Add(tbNome.Text);
                cbRelatorio.Items.Add(tbNome.Text);
                tbNome.Text = " ";
                tbPeriodo.Text = " ";
                tbNro.Text = " ";
                i++;
            }
            else
            {
                MessageBox.Show("Preencha todos os campos!");
            }
        }

        private void btSalvarMat_Click(object sender, EventArgs e)
        {
            if (tbNomeMat.Text != " " && tbCodMat.Text != " ")
            {
                mat[j] = new Materia();
                mat[j].setNome(tbNomeMat.Text);
                mat[j].setCod(tbCodMat.Text);
                cbMat.Items.Add(tbNomeMat.Text);
                tbNomeMat.Text = " ";
                tbCodMat.Text = " ";
                j++;
            }
            else
            {
                MessageBox.Show("Preencha todos os campos!");
            }
        }

        private void btAddMat_Click(object sender, EventArgs e)
        {
            if (cbAluno.Text != " " && cbMat.Text != " ")
            {
                int k = 0;
                for (k = 0; k < 20; k++)
                    if (mat[k].getNome() == cbMat.Text)
                        break;
                aluno[id].setMaterias(mat[k]);
                cbMat.Text = " ";
                cbAluno.Text = " ";
            }
            else
            {
                MessageBox.Show("Selecione matéria/aluno!");
            }
        }
        
        private void btBuscar_Click(object sender, EventArgs e)
        {
            tbRelatorio.Text = " ";
            int s = 0;
            for (s = 0; s < 30; id++)
            {
                if (cbRelatorio.SelectedItem.Equals(aluno[s].getNome()))
                {
                    break;
                }
            }
            tbRelatorio.Text = "Nome: " + aluno[s].getNome() + Environment.NewLine + "Periodo: " +
                aluno[s].getPeriodo() + Environment.NewLine + "Matricula: " + aluno[s].getMatricula();
            tbRelatorio.Text = tbRelatorio.Text + Environment.NewLine + "Materias Cadastradas:\n";
            while (true)
            {
                tbRelatorio.Text = tbRelatorio.Text + Environment.NewLine + aluno[s].getMaterias(k);
                k++;
                if (aluno[s].getMaterias(k) == "fim")
                {
                    break;
                }
            }
            k = 0;
        }

        private void cbAluno_SelectedIndexChanged(object sender, EventArgs e)
        {
            id = 0;
            for (id = 0; id < 30; id++)
            {
                if (cbAluno.SelectedItem.Equals(aluno[id].getNome()))
                {
                    break;
                }
            }
        }
    }
}