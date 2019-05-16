using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_05
{
    class CLT : Empregado
    {
        private Double sBrutoCLT;

        public CLT() : base()
        {
            sBrutoCLT = 0.0;
        }

        public CLT(String _nome, String _CPF, String _endereco, Double _sBrutoCLT)
            : base(_nome, _CPF, _endereco)
        {
            sBrutoCLT = _sBrutoCLT;
        }

        public Double getSalario()
        {
            return sBrutoCLT;
        }

        public void setSalario(Double _sBrutoCLT)
        {
            sBrutoCLT = _sBrutoCLT;
        }

        public override double salarioLiq()
        {
            if (sBrutoCLT <= 5000)
                return sBrutoCLT * 0.85;
            else
                return sBrutoCLT * 0.725;
        }
    }
}
