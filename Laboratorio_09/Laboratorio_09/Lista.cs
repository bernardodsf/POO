using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_09
{
    class Lista<TAD> : Object
    {
        protected NohLista<TAD> inicio;
        protected NohLista<TAD> fim;

        public Lista()
        {
            inicio = null;
            fim = null;
        }

        public bool isEmpty()
        {
            if (inicio == null && fim == null)
                return true;
            else
                return false;
        }

        public virtual void insertInicio(TAD _data)
        {
            NohLista<TAD> novoNoh = new NohLista<TAD>(_data);
            if (isEmpty())
            {
                inicio = novoNoh;
                fim = novoNoh;
            }
            else
            {
                inicio.setPrev(novoNoh);
                novoNoh.setNext(inicio);
                inicio = novoNoh;
            }
        }

        public virtual void insertFim(TAD _data)
        {
            NohLista<TAD> novoNoh = new NohLista<TAD>(_data);
            if (isEmpty())
            {
                inicio = novoNoh;
                fim = novoNoh;
            }
            else
            {
                fim.setNext(novoNoh);
                novoNoh.setPrev(fim);
                fim = novoNoh;
            }
        }

        public virtual void Pop(TAD _data)
        {
            NohLista<TAD> elemento = encontraNoh(_data);
            if (elemento == inicio)
            {
                inicio = inicio.getNext();
                inicio.setPrev(null);
            }
            else if (elemento == fim)
            {
                fim = fim.getPrev();
                fim.setNext(null);
            }
            else
            {
                elemento.getNext().setPrev(elemento.getPrev());
                elemento.getPrev().setNext(elemento.getNext());
            }
        }

        public NohLista<TAD> encontraNoh(TAD _data)
        {
            NohLista<TAD> elemento = inicio;
            while (!elemento.getData().Equals(_data))
            {
                if (elemento.getData().Equals(_data)) break;
                elemento = elemento.getNext();
            }
            return elemento;
        }

        public virtual void imprimirED()
        {
            NohLista<TAD> novoNoh = inicio;
            while (novoNoh != null)
            {
                Console.Write(novoNoh.getData() + " ");
                novoNoh = novoNoh.getNext();
            }
        }

        public virtual void imprimirDE()
        {
            NohLista<TAD> novoNoh = fim;
            while (novoNoh != null)
            {
                Console.Write(novoNoh.getData() + " ");
                novoNoh = novoNoh.getPrev();
            }
        }
    }
}
