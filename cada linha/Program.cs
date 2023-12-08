using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cada_linha {
    class Program {
        static void Main(string[] args) {

            int n, i, j, maior;

            Console.Write("Qual a ordem da matriz? ");
            n = int.Parse(Console.ReadLine());

            int[,] matriz = new int[n, n];

            for (i = 0; i < n; i++) {
                for (j = 0; j < n; j++) {
                    Console.Write("Elemento [" + i + "," + j + "]: ");
                    matriz[i, j] = int.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine("MAIOR ELEMENTO DE CADA LINHA:");
            for (i = 0; i < n; i++) {
                maior = 0;
                for (j = 0; j < n; j++) {
                    if (matriz[i, j] > maior) {
                        maior = matriz[i, j];
                    }
                }
                Console.WriteLine(maior);
            }
        }
    }
}
