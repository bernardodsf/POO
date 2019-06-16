using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_08
{
    class Program
    {
        static void Main(string[] args)
        {
            Pilha<char> pStr = new Pilha<char>();
            char[] expr;
            String str;
            int n = 1;

            while (n != 0)
            {
                Console.Clear();
                Console.WriteLine("Digite a expressão a ser avaliada: ");
                str = Console.ReadLine();
                expr = str.ToCharArray();

                for (int i = 0; i < expr.Length; i++)
                {
                    if (expr[i] == '{' || expr[i] == '[' || expr[i] == '(')
                        pStr.Push(expr[i]);
                    if (pStr.isEmpty())
                    {
                        if (expr[i] == '}' || expr[i] == ']' || expr[i] == ')')
                        {
                            pStr.Push(expr[i]);
                            break;
                        }
                    }
                    if (!pStr.isEmpty())
                    {
                        if (expr[i] == '}' || expr[i] == ']' || expr[i] == ')')
                            pStr.Pop();
                    }
                }

                if (pStr.isEmpty())
                    Console.WriteLine("\nExpressão válida!!");
                else
                    Console.WriteLine("\nExpressão inválida!!");

                try
                {
                    Console.WriteLine("Para sair, digite 0");
                    Console.WriteLine("\nPara continuar, digite uma nova expressão");
                    n = Convert.ToInt32(Console.ReadLine());
                }
                catch (FormatException)
                {
                    Console.WriteLine("Valor digitado inválido");
                    Console.Read();
                }
            }
        }
    }
}
