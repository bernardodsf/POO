using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_02
{
    class Estacionamento
    {       
        private string placa;
        private string marca;
        Tempo entrada = new Tempo();
        Tempo saida = new Tempo();
                
        public void setDados(Tempo e, Tempo s)
        {
            entrada.setHora(e.getHora());
            entrada.setMin(e.getMin());
            entrada.setSeg(e.getSeg());
            
            saida.setHora(s.getHora());
            saida.setMin(s.getMin());
            saida.setSeg(s.getSeg());
            
            Console.Write("Placa: ");
            placa = Console.ReadLine();

            Console.Write("Marca: ");
            marca = Console.ReadLine();

        }

        public void imprimir_dados()
        {
            Console.WriteLine("\nDados do Carro.");

            Console.WriteLine("\nPlaca: " + placa + " \nMarca: " + marca);

            Console.WriteLine("Entrada.");
            entrada.print();

            Console.WriteLine("Saida.");
            saida.print();
        }

        public void valor()
        {
            Tempo t = new Tempo();
            t = saida.subtrair(entrada);

            Console.WriteLine("\nValor a ser pago:" + 7 * (t.getHora() + 1) + "R$");
        }
    }
}
