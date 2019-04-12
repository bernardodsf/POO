using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_02
{
    class Tempo
    {
        private int hora;
        private int min;
        private int seg;
                
        public Tempo()
        {
            hora = 0;
            min = 0;
            seg = 0;
        }
                
        public void setHora(int _hora)
        {
            hora = _hora;
        }

        public int getHora()
        {
            return hora;
        }

        public void setMin(int _min)
        {
            min = _min;
        }

        public int getMin()
        {
            return min;
        }

        public void setSeg(int _seg)
        {
            seg = _seg;
        }
        
        public int getSeg()
        {
            return seg;
        }
        
        public void print()
        {
            Console.WriteLine("Horario:" + hora + ":" + min + ":" + seg);
        }

        public Tempo somar(Tempo t)
        {
            Tempo n = new Tempo();

            n.hora = hora + t.hora;
            n.min = min + t.min;
            n.seg = seg + t.seg;

            if (n.seg > 60)
            {
                n.seg = n.seg - 60;
                n.min++;
            }
            if (n.min > 60)
            {
                n.min = n.min - 60;
                n.hora++;
            }

            return (n);
        }

        public Tempo subtrair(Tempo t)
        {
            Tempo n = new Tempo();

            n.hora = hora - t.hora;
            n.min = min - t.min;
            n.seg = seg - t.seg;

            if (n.seg < 0)
            {
                n.seg = n.seg + 60;
                n.min--;
            }
            if (n.min < 0)
            {
                n.min = n.min + 60;
                n.hora--;
            }

            return (n);
        }
    }
}
