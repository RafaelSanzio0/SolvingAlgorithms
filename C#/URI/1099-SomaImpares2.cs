using System;
/*
 * Leia 2 valores inteiros X e Y. A seguir, ( com a qtd de N casos)
 * calcule e mostre a soma dos números impares entre eles.
 * ##COMPILATION ERROR URI
 */

namespace URI
{
    class SomaImpares2
    {
        static void Main(string[] args)
        {
            int caseTests = Convert.ToInt32(Console.ReadLine());
            int[] vetorImp = new int[caseTests];

            for (int i = 0; i < caseTests; i++)
            {
                string[] input = Console.ReadLine().Split(" ");
                int x = int.Parse(input[0]), y = int.Parse(input[1]);
                int sumImp = 0;

                if (x < y)
                {
                    for (int j = x + 1; j < y; j++)
                    {
                        if (j % 2 != 0)
                        {
                            sumImp += j;
                        }
                    }
                }
                else
                {
                    for (int j = y + 1; j < x; j++)
                    {
                        if (j % 2 != 0)
                        {
                            sumImp += j;
                        }
                    }
                }
                vetorImp[i] = sumImp;
            }

            for (int i = 0; i < caseTests; i++)
            {
                Console.WriteLine(vetorImp[i]);
            }
        }
    }
}


