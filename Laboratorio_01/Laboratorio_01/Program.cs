using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Vetor2D vet1 = new Vetor2D(10.0, 5.0);
            Vetor2D vet2 = new Vetor2D(4.0, -2.0);

            Console.WriteLine("Produto escalar entre os 2 vetores: " + vet1.produtoEscalar(vet2));

            Console.WriteLine("Modulo do vetor 1: " + vet1.moduloVetor());
            Console.WriteLine("Modulo do vetor 2: " + vet2.moduloVetor());

            Console.WriteLine("Angulo entre os vetores: " + vet1.anguloVetor(vet2) + " graus");

            Vetor2D vetprojecao = new Vetor2D();
            vetprojecao = vet1.projecaoVetor(vet2);
            Console.WriteLine("Projecao do vetor 1 no vetor 2: (" + vetprojecao.getX() + ", " + vetprojecao.getY() + ")");
            vetprojecao = vet2.projecaoVetor(vet1);
            Console.WriteLine("Projecao do vetor 2 no vetor 1: (" + vetprojecao.getX() + ", " + vetprojecao.getY() + ")");

            Console.ReadLine();
        }
    }
}
