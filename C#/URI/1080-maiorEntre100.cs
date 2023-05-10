using System;
using System.Collections.Generic;
using System.Text;

/*
 * Leia 100 valores inteiros. Apresente então o maior valor
 * lido e a posição dentre os 100 valores lidos.
 */

namespace URI
{
    class _1080_maiorEntre100
    {
        static void Main(string[] args)
        {
            int[] array = new int[100];
            int maior = array[0];
            int posMaior = 0;

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = Convert.ToInt32(Console.ReadLine());
            }

            for (int i = 0; i < array.Length; i++)
            {
                int atual = array[i];
                if(atual > maior)
                {
                    maior = atual;
                    posMaior = i+1;
                }
            }
            Console.WriteLine(maior);
            Console.WriteLine(posMaior);
        }
    }
}

