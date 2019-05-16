using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_05
{
    class Horista : Empregado
    {
        private Double nHoras;
        private Double precoH;

        public Horista() : base()
        {
            nHoras = 0.0;
            precoH = 0.0;
        }

        public Horista(String _nome, String _CPF, String _endereco, Double _nHoras, Double _precoH)
            : base(_nome, _CPF, _endereco)
        {
            nHoras = _nHoras;
            precoH = _precoH;
        }

        public Double getprecoH()
        {
            return precoH;
        }
        public Double getnHoras()
        {
            return nHoras;
        }

        public void setprecoH(Double _precoH)
        {
            precoH = _precoH;
        }
        public void setnHoras(Double _nHoras)
        {
            nHoras = _nHoras;
        }

        public override double salarioLiq()
        {
            return (nHoras * precoH) * 0.85;
        }
    }
}
