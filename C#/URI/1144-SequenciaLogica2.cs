using System;
using System.Collections.Generic;
using System.Text;

/*
 * Escreva um programa que leia dois valores X e Y. A seguir,
 * mostre uma sequência de 1 até Y, passando para a próxima linha a cada X números.
 */

namespace URI
{
    class _1144_SequenciaLogica2
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(" ");
            int x = int.Parse(input[0]);
            int y = int.Parse(input[1]);
            int contaLinha = 0;

            for (int i = 1; i <= y; i++)
            {
                Console.Write("{0} ", i);
                contaLinha += 1;
                if(contaLinha == x)
                {
                    Console.Write("\n");
                    contaLinha = 0;
                }
            }
        }
    }
}
