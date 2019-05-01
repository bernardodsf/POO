using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_04
{
    class Vetor2D
    {
        protected Double x;
        protected Double y;

        //defaut
        public Vetor2D()
        {
            x = 0.0;
            y = 0.0;
        }

        public Vetor2D(Double _x, Double _y)
        {
            x = _x;
            y = _y;
        }

        //getters e setters
        public Double getX()
        {
            return x;
        }
        public Double getY()
        {
            return y;
        }

        public void setX(Double _x)
        {
            x = _x;
        }
        public void setY(Double _y)
        {
            y = _y;
        }
    }
}
