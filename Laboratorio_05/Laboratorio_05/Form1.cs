using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laboratorio_05
{
    public partial class Form1 : Form
    {               
        CLT clt = new CLT();
        Horista horista = new Horista();         

        public Form1()
        {
            InitializeComponent();
        }

        private void rbCLT_CheckedChanged(object sender, EventArgs e)
        {
            if (rbCLT.Checked == true)
            {
                label4.Enabled = true;
                tbSBruto.Enabled = true;
            }
            if (rbCLT.Checked == false)
            {
                label4.Enabled = false;
                tbSBruto.Enabled = false;
                tbSBruto.Clear();
            }
        }

        private void rbHorista_CheckedChanged(object sender, EventArgs e)
        {
            if (rbHorista.Checked == true)
            {
                label5.Enabled = true;
                tbNHoras.Enabled = true;
                label6.Enabled = true;
                tbPHora.Enabled = true;
            }
            if (rbHorista.Checked == false)
            {
                label5.Enabled = false;
                tbNHoras.Enabled = false;
                label6.Enabled = false;
                tbPHora.Enabled = false;
                tbNHoras.Clear();
                tbPHora.Clear();
            }            
        }

        private void btRelatorio_Click(object sender, EventArgs e)
        {
            if (rbCLT.Checked == true)
            {
                clt.setNome(tbNome.Text);
                clt.setCPF(tbCPF.Text);
                clt.setEndereco(tbEndereco.Text);
                clt.setSalario(Convert.ToDouble(tbSBruto.Text));

                tbNome.Clear();
                tbCPF.Clear();
                tbEndereco.Clear();
                tbSBruto.Clear();

                tbRelatorio.Text = "Nome: " + clt.getNome() + Environment.NewLine + "CPF: " + clt.getCPF()
                    + Environment.NewLine + "Endereço: " + clt.getEndereco() + Environment.NewLine +
                    "Salário Bruto: " + clt.getSalario() + Environment.NewLine + "Salário Líquido: "
                    + clt.salarioLiq();
            }
            if (rbHorista.Checked == true)
            {
                horista.setNome(tbNome.Text);
                horista.setCPF(tbCPF.Text);
                horista.setEndereco(tbEndereco.Text);
                horista.setnHoras(Convert.ToDouble(tbNHoras.Text));
                horista.setprecoH(Convert.ToDouble(tbPHora.Text));

                tbNome.Clear();
                tbCPF.Clear();
                tbEndereco.Clear();
                tbNHoras.Clear();
                tbPHora.Clear();

                tbRelatorio.Text = "Nome: " + horista.getNome() + Environment.NewLine + "CPF: " +
                    horista.getCPF() + Environment.NewLine + "Endereço: " + horista.getEndereco() +
                    Environment.NewLine + "Número de horas: " + horista.getnHoras() + Environment.NewLine 
                    + "Preço da hora: " + horista.getprecoH() + Environment.NewLine + "Salário Líquido: " 
                    + horista.salarioLiq();
            }
            if (rbCLT.Checked == false & rbHorista.Checked == false)
            {
                MessageBox.Show("Escolha um opção(CLT ou Horista) e preencha todos os campos!");
            }                
        }              
    }
}
