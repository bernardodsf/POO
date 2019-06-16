using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_07
{
    class Pilha
    {
        private NohPilha topo;

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

        public void Push(int _info)
        {
            if (isEmpty())
                topo = new NohPilha(_info);
            else
            {
                NohPilha novoNoh = new NohPilha(_info, topo);
                topo = novoNoh;
            }
        }

        public void Pop(System.Windows.Forms.RichTextBox tbPop)
        {
            try
            {
                int valor = topo.getInfo();
                topo = topo.getNext();
                tbPop.Text = Convert.ToString(valor);
            }
            catch (NullReferenceException)
            {
                System.Windows.Forms.MessageBox.Show("Pilha vazia!!", "ERRO");
            }
        }

        public void Print(System.Windows.Forms.RichTextBox tbPilha)
        {
            tbPilha.Clear();
            if (isEmpty())
            {
                System.Windows.Forms.MessageBox.Show("Pilha vazia!!", "ERRO");
            }
            else
            {
                NohPilha n = topo;
                while (n != null)
                {
                    tbPilha.AppendText(Convert.ToString(n.getInfo()) + "\n");
                    n = n.getNext();
                }
            }
        }

        public void Maior(System.Windows.Forms.RichTextBox tbPilha)
        {
            if (isEmpty())
            {
                System.Windows.Forms.MessageBox.Show("Pilha vazia!!", "ERRO");
            }
            else
            {
                NohPilha n = topo;
                int maior = topo.getInfo();
                while (n != null)
                {
                    if (maior < n.getInfo())
                    {
                        maior = n.getInfo();
                    }
                    n = n.getNext();
                }
                tbPilha.Text = Convert.ToString(maior);
            }
        }

        public void Menor(System.Windows.Forms.RichTextBox tbPilha)
        {
            if (isEmpty())
            {
                System.Windows.Forms.MessageBox.Show("Pilha vazia!!", "ERRO");
            }
            else
            {
                NohPilha n = topo;
                int menor = topo.getInfo();
                while (n != null)
                {
                    if (menor > n.getInfo())
                    {
                        menor = n.getInfo();
                    }
                    n = n.getNext();
                }
                tbPilha.Text = Convert.ToString(menor);
            }
        }

        public void Inverte(System.Windows.Forms.RichTextBox tbPilha)
        {
            if (isEmpty())
            {
                System.Windows.Forms.MessageBox.Show("Pilha vazia!!", "ERRO");
            }
            else
            {
                List<int> dados = new List<int>();
                NohPilha n = topo;
                while (n != null)
                {
                    dados.Add(n.getInfo());
                    n = n.getNext();
                    Pop_inv();
                }
                for (int i = 0; i < dados.Count; i++)
                {
                    Push_inv(dados[i]);
                }
                Print(tbPilha);
            }
        }
        public void Push_inv(int insertItem)
        {
            if (isEmpty())           
                topo = new NohPilha(insertItem);
            else
            {
                NohPilha n = new NohPilha(insertItem, topo);
                topo = n;
            }
        }
        public int Pop_inv()
        {
            if (isEmpty())
            {
                Console.WriteLine("Pilha vazia!");
                return 0;
            }
            else
            {
                int valor = topo.getInfo();
                topo = topo.getNext();
                return valor;
            }
        }

        public int tamanho()
        {
            NohPilha n = topo;
            int i = 0;
            while (n != null)
            {
                i++;
                n = n.getNext();
            }
            return i;
        }
    }
}
