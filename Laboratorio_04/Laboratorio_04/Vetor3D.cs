using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_04
{
    class Vetor3D : Vetor2D
    {
        private Double z;
        
        //default
        public Vetor3D() : base()
        {
            z = 0.0;
        }

        public Vetor3D(Double _x, Double _y, Double _z) : base(_x, _y)
        {
            z = _z;
        }

        //getter e setter
        public Double getZ()
        {
            return z;
        }

        public void setZ(Double _z)
        {
            z = _z;
        }

        //produto vetorial
        public Vetor3D prod_vet(Vetor3D v2)
        {
            Vetor3D v3 = new Vetor3D();

            v3.x = (y * v2.z) - (z * v2.y);
            v3.y = (z * v2.x) - (x * v2.z);
            v3.z = (x * v2.y) - (y * v2.x);

            return v3;
        }

        //módulos
        public double mod_vet(Vetor3D vet)
        {
            double mod_vet = 0.0;

            mod_vet = Math.Sqrt(Math.Pow((vet.x), 2) + Math.Pow((vet.y), 2) + Math.Pow((vet.z), 2));

            return mod_vet;
        }
    }
}
