using System;
using System.Collections.Generic;
using System.Text;

/*
 * Faça um programa que leia 5 valores inteiros.
 * Conte quantos destes valores digitados são pares e mostre esta informação.
*/


namespace URI
{
    class _1065_ParesEntreCinco
    {
        static void Main(string[] args)
        {
            int value = 0, qtd = 0;

            for(int i=0; i < 5; i++)
            {
                value = Convert.ToInt32(Console.ReadLine());

                if (value % 2 == 0)
                {
                    qtd += 1;
                }

            }
            Console.WriteLine("{0} valores pares", qtd);
        }
    }
}
