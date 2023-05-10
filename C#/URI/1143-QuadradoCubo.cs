using System;
using System.Collections.Generic;
using System.Text;
using static System.Math;

/*
 * Escreva um programa que leia um valor inteiro N (1 < N < 1000).
 * Este N é a quantidade
 * de linhas de saída que serão apresentadas na execução do programa.
 */

namespace URI
{
    class _1143_QuadradoCubo
    {
        static void Main(string[] args)
        {
            int caseTests = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= caseTests; i++)
            {
                Console.WriteLine("{0} {1} {2}",i,Pow(i,2),Pow(i,3));
            }
        }
    }
}
