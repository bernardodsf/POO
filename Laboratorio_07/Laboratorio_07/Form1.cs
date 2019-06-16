using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laboratorio_07
{
    public partial class Form1 : Form
    {
        Pilha p = new Pilha();

        public Form1()
        {
            InitializeComponent();
        }

        private void btPush_Click(object sender, EventArgs e)
        {
            try
            {
                p.Push(Convert.ToInt32(tbPush.Text));
                tbPush.Clear();
            }
            catch (FormatException)
            {
                System.Windows.Forms.MessageBox.Show("O dado é inválido", "ERRO");
                tbPush.Clear();
            }
        }

        private void btPop_Click(object sender, EventArgs e)
        {
            p.Pop(tbPop);
            tbPilha.Clear();
        }

        private void btImprime_Click(object sender, EventArgs e)
        {
            p.Print(tbPilha);
        }

        private void btMaior_Click(object sender, EventArgs e)
        {
            p.Maior(tbPilha);
        }

        private void btMenor_Click(object sender, EventArgs e)
        {
            p.Menor(tbPilha);
        }

        private void btInverte_Click(object sender, EventArgs e)
        {
            p.Inverte(tbPilha);
        }
    }
}
