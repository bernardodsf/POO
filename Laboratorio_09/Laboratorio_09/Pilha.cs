using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_09
{
    class Pilha : Lista<int>
    {
        public Pilha() : base()
        { }

        public override void insertFim(int _data)
        {
            base.insertFim(_data);
        }

        public override void Pop(int _data)
        {
            base.Pop(fim.getData());
        }

        public override void imprimirDE()
        {
            base.imprimirDE();
        }
    }
}
