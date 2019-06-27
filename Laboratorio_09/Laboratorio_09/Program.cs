using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_09
{
    class Program
    {
        static void Main(string[] args)
        {
            bool continueLoop = true;
            do
            {
                try
                {
                    int auxMenu = 1, auxMenu2 = 0;
                    Lista<int> lista = new Lista<int>();
                    Fila fila = new Fila();
                    Pilha pilha = new Pilha();

                    while (auxMenu != 0)
                    {
                        Console.Clear();
                        Console.WriteLine("MENU:");
                        Console.WriteLine("[1] Criar uma lista de inteiros");
                        Console.WriteLine("[2] Criar uma fila de inteiros");
                        Console.WriteLine("[3] Criar uma pilha de inteiros");
                        Console.WriteLine("[4] SAIR");
                        auxMenu2 = Convert.ToInt32(Console.ReadLine());

                        switch (auxMenu2)
                        {
                            case 1:
                                Console.Clear();
                                Console.WriteLine("LISTA DE INTEIROS!\n");
                                while (auxMenu != 0)
                                {
                                    Console.Clear();
                                    Console.WriteLine("[1] Inserir um numero no início");
                                    Console.WriteLine("[2] Inserir um numero no fim");
                                    Console.WriteLine("[3] Remover um numero");
                                    Console.WriteLine("[4] SAIR");
                                    auxMenu2 = Convert.ToInt32(Console.ReadLine());

                                    switch (auxMenu2)
                                    {
                                        case 1:
                                            Console.WriteLine("Digite o numero a ser inserido: ");
                                            lista.insertInicio(Convert.ToInt32(Console.ReadLine()));
                                            break;
                                        case 2:
                                            Console.WriteLine("Digite o numero a ser inserido: ");
                                            lista.insertFim(Convert.ToInt32(Console.ReadLine()));
                                            break;
                                        case 3:
                                            Console.WriteLine("Escolha o numero que será removido: ");
                                            lista.imprimirED();
                                            lista.Pop(Convert.ToInt32(Console.ReadLine()));
                                            Console.WriteLine("Numero removido!");
                                            Console.ReadLine();
                                            break;
                                        case 4:
                                            auxMenu = 0;
                                            break;
                                        default:
                                            Console.WriteLine("Selecione uma opção válida!");
                                            break;
                                    }
                                }
                                auxMenu = 1;
                                auxMenu2 = 0;
                                break;

                            case 2:
                                Console.Clear();
                                Console.WriteLine("FILA DE INTEIROS\n");
                                while (auxMenu != 0)
                                {
                                    Console.Clear();
                                    Console.WriteLine("[1] Inserir um numero");
                                    Console.WriteLine("[2] Remover um numero");
                                    Console.WriteLine("[3] SAIR");
                                    auxMenu2 = Convert.ToInt32(Console.ReadLine());

                                    switch (auxMenu2)
                                    {
                                        case 1:
                                            Console.WriteLine("Digite o numero a ser inserido: ");
                                            fila.insertFim(Convert.ToInt32(Console.ReadLine()));
                                            break;
                                        case 2:
                                            Console.WriteLine("Removendo o primeiro numero inserido.");
                                            fila.Pop(0);
                                            Console.WriteLine("Numero removido!");
                                            Console.ReadLine();
                                            break;
                                        case 3:
                                            auxMenu = 0;
                                            break;
                                        default:
                                            Console.WriteLine("Selecione uma opção válida!");
                                            break;
                                    }
                                }
                                auxMenu = 1;
                                auxMenu2 = 0;
                                break;

                            case 3:
                                Console.Clear();
                                Console.WriteLine("PILHA DE INTEIROS\n");
                                while (auxMenu != 0)
                                {
                                    Console.Clear();
                                    Console.WriteLine("[1] Inserir um numero");
                                    Console.WriteLine("[2] Remover um numero");
                                    Console.WriteLine("[3] SAIR");
                                    auxMenu2 = Convert.ToInt32(Console.ReadLine());

                                    switch (auxMenu2)
                                    {
                                        case 1:
                                            Console.WriteLine("Digite o numero a ser inserido: ");
                                            pilha.insertFim(Convert.ToInt32(Console.ReadLine()));
                                            break;
                                        case 2:
                                            Console.WriteLine("Removendo o ultimo numero inserido.");
                                            pilha.Pop(0);
                                            Console.WriteLine("Numero removido!");
                                            Console.ReadLine();
                                            break;
                                        case 3:
                                            auxMenu = 0;
                                            break;
                                        default:
                                            Console.WriteLine("Selecione uma opção válida!");
                                            break;
                                    }
                                }
                                auxMenu = 1;
                                auxMenu2 = 0;
                                break;

                            case 4:
                                Console.WriteLine("SAIR!\n");
                                Console.WriteLine("Lista: ");
                                lista.imprimirED();
                                Console.WriteLine("\n\nFila: ");
                                fila.imprimirED();
                                Console.WriteLine("\n\nPilha: ");
                                pilha.imprimirDE();
                                Console.Read();
                                continueLoop = false;
                                break;

                            default:
                                Console.WriteLine("Selecione uma opção válida!");
                                break;
                        }
                    }
                }
                catch (FormatException) { }
            } while (continueLoop);
        }
    }
}
