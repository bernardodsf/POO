using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_08
{
    class Pilha<TAD> : Object
    {
        private NohPilha<TAD> topo;

        public Pilha()
        {
            topo = null;
        }

        public bool isEmpty()
        {
            if (topo == null)
                return true;
            else
                return false;
        }

        public void Push(TAD insertItem)
        {
            if (isEmpty())            
                topo = new NohPilha<TAD>(insertItem);
            else
            {
                NohPilha<TAD> n = new NohPilha<TAD>(insertItem, topo);
                topo = n; //n pode ser substituido por this
            }
        }

        public TAD Pop()
        {
            if (isEmpty())
            {
                Console.WriteLine("Pilha vazia!");
                throw new Exception();
            }
            else
            {
                TAD valor = topo.getData();
                topo = topo.getNextNoh();
                return valor;
            }
        }

        public void Print()
        {
            if (isEmpty())
                Console.WriteLine("Pilha vazia!");
            else
            {
                NohPilha<TAD> n = topo;
                while (n != null)
                {
                    Console.WriteLine("\n " + n.getData());
                    n = n.getNextNoh();
                }
            }
        }

        public TAD getTopo()
        {
            return topo.getData();
        }
    }
}
