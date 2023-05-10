using System;
using System.Collections.Generic;
using System.Text;


/*

Faça um algoritmo para ler um valor A e um valor N. Imprimir a soma de A + i para cada i com os valores (0 <= i <= N-1). Enquanto N for negativo ou ZERO, um novo N(apenas N) deve ser lido.

Entrada
A entrada contém somente valores inteiros, podendo ser positivos ou negativos. Todos os valores estão na mesma linha.

Saída
A saída contém apenas um valor inteiro.
 */


namespace URI
{
    class _1149_SomandoInteirosConsecutivos
    {
        public static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');
            int a = int.Parse(input[0]);
            int n = int.Parse(input[1]);
            int prox = 2;
            var soma = 0;

            while(n <= 0)
            {
                n = int.Parse(input[prox]);
                prox++;
            }

            for (int i = 0; i <= n-1; i++)
            {
                soma += (a + i);
            }

            Console.WriteLine(soma);
        }
    }
}
