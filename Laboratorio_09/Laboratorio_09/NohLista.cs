using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_09
{
    class NohLista<TAD> : Object
    {
        private NohLista<TAD> prev;
        private TAD data;
        private NohLista<TAD> next;

        public NohLista()
        {
            prev = null;
            next = null;
        }

        public NohLista(TAD _data)
        {
            prev = null;
            data = _data;
            next = null;
        }

        public NohLista<TAD> getPrev()
        {
            return prev;
        }
        public TAD getData()
        {
            return data;
        }
        public NohLista<TAD> getNext()
        {
            return next;
        }

        public void setPrev(NohLista<TAD> _prev)
        {
            prev = _prev;
        }
        public void setData(TAD _data)
        {
            data = _data;
        }
        public void setNext(NohLista<TAD> _next)
        {
            next = _next;
        }
    }
}
