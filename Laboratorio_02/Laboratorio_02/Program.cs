using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_02
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            
            Tempo t1 = new Tempo();
            Tempo t2 = new Tempo();
            
            Estacionamento[] carro = new Estacionamento[5];
            
            while (i < 5)
            {
                carro[i] = new Estacionamento();
                Console.WriteLine("Carro " + (i + 1) + ":");

                Console.WriteLine("\nInsira horario de entrada.");

                Console.Write("Insira horas: ");
                t1.setHora(int.Parse(Console.ReadLine()));

                Console.Write("Insira minutos: ");
                t1.setMin(int.Parse(Console.ReadLine()));

                Console.Write("Insira segundos: ");
                t1.setSeg((int.Parse(Console.ReadLine())));

                t1.print();

                Console.WriteLine("\nInsira horario de saida.");

                Console.Write("Insira horas: ");
                t2.setHora(int.Parse(Console.ReadLine()));

                Console.Write("Insira minutos: ");
                t2.setMin(int.Parse(Console.ReadLine()));

                Console.Write("Insira segundos: ");
                t2.setSeg((int.Parse(Console.ReadLine())));

                t2.print();

                carro[i].setDados(t1, t2);

                i++;

                Console.Clear();
            }
            for (i = 0; i < 5; i++)
            {
                carro[i].imprimir_dados();
                carro[i].valor();
            }

            Console.Read();
        }
    }
}
