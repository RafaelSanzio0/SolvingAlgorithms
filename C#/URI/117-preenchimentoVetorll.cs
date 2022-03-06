using System;

/*
Faça um programa que leia um valor T e preencha um vetor N[1000] com a sequência de valores de 0 até T-1 repetidas vezes, conforme exemplo abaixo. Imprima o vetor N.

Entrada
A entrada contém um valor inteiro T (2 ≤ T ≤ 50).

Saída
Para cada posição do vetor, escreva "N[i] = x", onde i é a posição do vetor e x é o valor armazenado naquela posição.
*/


namespace URI
{
    public class _117_preenchimentoVetorll
    {
        public static void Main(string[] agrs)
        {
            int[] N = new int[10];
            int T = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < N.Length; i++)
            {
                N[i] = i % T;
                Console.WriteLine("N[{0}] = {1}", i, N[i]);
            }
        }
    }
}
