using System;
using System.Collections.Generic;
using System.Text;


/*
Faça um programa que leia um vetor A[100]. No final, mostre todas as posições do vetor que armazenam um valor menor ou igual a 10 e o valor armazenado em cada uma das posições.

Entrada
A entrada contém 100 valores, podendo ser inteiros, reais, positivos ou negativos.

Saída
Para cada valor do vetor menor ou igual a 10, escreva "A[i] = x", onde i é a posição do vetor e x é o valor armazenado na posição, com uma casa após o ponto decimal.

namespace URI
{
    class _1174_SelecaoEmVetor1
    {
        public static void Main(string[] args)
        {
            double[] A = new double[100];

            for (int i = 0; i < A.Length; i++)
            {
                var numberRandom = GetRandomNumber(-10, 40);
                A[i] = numberRandom;

                if(A[i] <= 10)
                {
                    Console.WriteLine("A[{0}] = {1}", i, Convert.ToString(numberRandom).Replace(",","."));
                }
            }
        }

        public static double GetRandomNumber(double minimum, double maximum)
        {
            Random random = new Random();
            return Math.Round(random.NextDouble() * (maximum - minimum) + minimum,1);
        }
    }
}

*/