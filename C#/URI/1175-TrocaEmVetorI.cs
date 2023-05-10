using System;
using System.Collections.Generic;
using System.Text;

/*
Faça um programa que leia um vetor N[20]. Troque a seguir, o primeiro elemento com o último, o segundo elemento com o penúltimo, etc., até trocar o 10º com o 11º. Mostre o vetor modificado.

Entrada
A entrada contém 20 valores inteiros, positivos ou negativos.

Saída
Para cada posição do vetor N, escreva "N[i] = Y", onde i é a posição do vetor e Y é o valor armazenado naquela posição.
 */

namespace URI
{
    class _1175_TrocaEmVetorI
    {
        static void Main(string[] args)
        {
            int[] N = new int[20];
            int last = 19;

            for (int i = 0; i < 20; i++)
            {
                int input = Convert.ToInt32(Console.ReadLine());
                N[i] = input;
            }

            for (int i = 0; i < 20; i++)
            {
                if(last >= 10)
                {
                    int temp = N[i];
                    N[i] = N[last];
                    N[last] = temp;
                    last -= 1;
                }
                else
                {
                    Console.WriteLine("N[{0}] = {1}", i, N[i]);
                    continue;
                }
                Console.WriteLine("N[{0}] = {1}", i, N[i]);
            }
        }
    }
}
