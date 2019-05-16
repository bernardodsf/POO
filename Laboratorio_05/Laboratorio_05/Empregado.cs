using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_05
{
    class Empregado
    {
        protected String nome;       
        protected String CPF;
        protected String endereco;

        public Empregado()
        {
            nome = "";            
            CPF = "";
            endereco = "";
        }

        public Empregado(String _nome, String _CPF, String _endereco)
        {
            nome = _nome;            
            CPF = _CPF;
            endereco = _endereco;
        }

        public String getNome()
        {
            return nome;
        }        
        public String getCPF()
        {
            return CPF;
        }
        public String getEndereco()
        {
            return endereco;
        }

        public void setNome(String _nome)
        {
            nome = _nome;
        }        
        public void setCPF(String _CPF)
        {
            CPF = _CPF;
        }
        public void setEndereco(String _endereco)
        {
            endereco = _endereco;
        }

        public virtual double salarioLiq()
        {
            return 0.0;
        }
    }
}
