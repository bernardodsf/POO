using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_03
{
    class Aluno
    {
        private string nome;
        private string nro_matricula;
        private string periodo;
        Materia[] listamateria = new Materia[20];

        int i = 0;
        int cont = 0;

        public Aluno()
        {
            nome = " ";
            nro_matricula = " ";
            periodo = " ";
        }

        public String getNome()
        {
            return nome;
        }
        public void setNome(String _nome)
        {
            nome = _nome;
        }

        public String getMatricula()
        {
            return nro_matricula;
        }
        public void setMatricula(String _nro)
        {
            nro_matricula = _nro;
        }

        public String getPeriodo()
        {
            return periodo;
        }
        public void setPeriodo(String _periodo)
        {
            periodo = _periodo;
        }

        public void setMaterias(Materia mat)
        {

            listamateria[i] = new Materia();
            listamateria[i].setNome(mat.getNome());
            listamateria[i].setCod(mat.getCod());
            i++;
            cont++;
        }

        public String getMaterias(int k)
        {
            if (k < cont)
            {
                return listamateria[k].getNome();
            }
            else
            {
                return "fim";
            }
        }
    }
}