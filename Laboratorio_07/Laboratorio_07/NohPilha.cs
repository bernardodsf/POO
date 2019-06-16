using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_07
{
    class NohPilha
    {
        private int info;
        private NohPilha next;

        public NohPilha()
        {
            info = 0;
            next = null;
        }

        public NohPilha(int _info)
        {
            info = _info;
            next = null;
        }

        public NohPilha(int _info, NohPilha _next)
        {
            info = _info;
            next = _next;
        }

        public int getInfo()
        {
            return info;
        }
        public NohPilha getNext()
        {
            return next;
        }

        public void setInfo(int _info)
        {
            info = _info;
        }
        public void setNext(NohPilha _next)
        {
            next = _next;
        }
    }
}
