using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_01
{
    class Vetor2D
    {
        //atributos
        private double X;
        private double Y;


        //construtor default
        public Vetor2D()
        {
            X = 0.0;
            Y = 0.0;
        }


        //construtor variável
        public Vetor2D(double _X, double _Y) 
        {
            X = _X;
            Y = _Y;
        }


        //getters e setters
        public double getX()
        {
            return X;
        }

        public void setX(double _X)
        {
            X = _X;
        }

        public double getY()
        {
            return Y;
        }

        public void setY(double _Y)
        {
            Y = _Y;
        }


        //produto escalar entre os 2 vetores
        public double produtoEscalar(Vetor2D vetor)
        {
            return (X * vetor.getX() + Y * vetor.getY());
        }


        //módulo do vetor
        public double moduloVetor()
        {
            return Math.Sqrt(Math.Pow(X, 2.0) + Math.Pow(Y, 2.0));
        }


        //angulo entre dois vetores
        public double anguloVetor(Vetor2D vetor)
        {
            double ang;
            ang = (produtoEscalar(vetor) / (moduloVetor() * vetor.moduloVetor()));
            return (Math.Acos(ang) * 180 / Math.PI);
        }


        //projeção vetor A em B
        public Vetor2D projecaoVetor(Vetor2D vetor)
        {
            double aux;
            Vetor2D vetorProjecao = new Vetor2D();
            aux = (produtoEscalar(vetor) / produtoEscalar(this));
            vetorProjecao.setX(getX() * aux);
            vetorProjecao.setY(getY() * aux);
            return vetorProjecao;
        }

    }
}
