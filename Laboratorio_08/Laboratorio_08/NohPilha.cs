using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_08
{
    class NohPilha<TAD> : Object
    {
        private TAD data;
        private NohPilha<TAD> nextNoh;

        public NohPilha()
        {
            nextNoh = null;
        }

        public NohPilha(TAD _data)
        {
            data = _data;
            nextNoh = null;
        }

        public NohPilha(TAD _data, NohPilha<TAD> _nextNoh)
        {
            data = _data;
            nextNoh = _nextNoh;
        }

        public TAD getData()
        {
            return data;
        }
        public NohPilha<TAD> getNextNoh()
        {
            return nextNoh;
        }

        public void setData(TAD _data)
        {
            data = _data;
        }       
        public void setNextNoh(NohPilha<TAD> _nextNoh)
        {
            nextNoh = _nextNoh;
        }
    }
}
