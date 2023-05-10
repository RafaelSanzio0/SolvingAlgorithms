using System;
using System.Collections.Generic;
using System.Text;

/*
Escreva um programa que leia um valor inteiro N. Este N é a quantidade de linhas de saída que serão apresentadas na execução do programa.

Entrada
O arquivo de entrada contém um número inteiro positivo N.

Saída
Imprima a saída conforme o exemplo fornecido.
*/

namespace URI
{
    class _1142_PUM
    {
        static void Main(string[] args)
        {
            var testCase = Convert.ToInt32(Console.ReadLine());
            int a = 1;
            int b = 2;
            int c = 3;

            for (int i = 0; i < testCase; i++)
            {
                Console.WriteLine("{0} {1} {2} PUM", a, b, c);
                a += 4;
                b += 4;
                c += 4;
            }
        }
    }
}
