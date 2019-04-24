using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_03
{
    class Materia
    {
        private String nome;
        private String codigo_materia;

        public Materia()
        {
            nome = " ";
            codigo_materia = " ";
        }

        public Materia(String _nome, String _codigo_materia)
        {
            nome = _nome;
            codigo_materia = _codigo_materia;
        }

        public void setNome(String _nome)
        {
            nome = _nome;

        }
        public String getNome()
        {
            return nome;
        }

        public void setCod(String _cod)
        {
            codigo_materia = _cod;

        }
        public String getCod()
        {
            return codigo_materia;
        }
    }
}