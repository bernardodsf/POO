using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laboratorio_04
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Vetor3D v1 = new Vetor3D();
        Vetor3D v2 = new Vetor3D();
        Vetor3D v3 = new Vetor3D();

        private void btProd_Vet_Click(object sender, EventArgs e)
        {
            v1 = new Vetor3D(Convert.ToDouble(tbV1x.Text), Convert.ToDouble(tbV1y.Text), Convert.ToDouble(tbV1z.Text));
            v2 = new Vetor3D(Convert.ToDouble(tbV2x.Text), Convert.ToDouble(tbV2y.Text), Convert.ToDouble(tbV2z.Text));

            //Produto Vetorial
            v3 = v1.prod_vet(v2);

            tbV3x.Text = Convert.ToString(v3.getX());
            tbV3y.Text = Convert.ToString(v3.getY());
            tbV3z.Text = Convert.ToString(v3.getZ());
        }

        private void btMod_Click(object sender, EventArgs e)
        {
            double mod_v1 = 0.0;
            double mod_v2 = 0.0;
            double mod_v3 = 0.0;
            
            //Módulos
            mod_v1 = v1.mod_vet(v1);
            mod_v2 = v2.mod_vet(v2);
            mod_v3 = v3.mod_vet(v3);

            tbModV1.Text = Convert.ToString(Math.Round(mod_v1, 3));
            tbModV2.Text = Convert.ToString(Math.Round(mod_v2, 3));
            tbModV3.Text = Convert.ToString(Math.Round(mod_v3, 3));
        }
    }
}
