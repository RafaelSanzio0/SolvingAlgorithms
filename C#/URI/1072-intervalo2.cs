using System;
using System.Collections.Generic;
using System.Text;

/*
Leia um valor inteiro N. Este valor será a quantidade de valores inteiros X que serão lidos em seguida.
Mostre quantos destes valores X estão dentro do intervalo [10,20] e quantos estão fora do intervalo, mostrando essas informações.

Entrada
A primeira linha da entrada contém um valor inteiro N (N < 10000), que indica o número de casos de teste.
Cada caso de teste a seguir é um valor inteiro X (-107 < X <107).
 

Saída
Para cada caso, imprima quantos números estão dentro (in) e quantos valores estão fora (out) do intervalo.
 */

namespace URI
{
    class _1072_intervalo2
    {
        static void Main(string[] args)
        {
            var caseTests = Convert.ToInt32(Console.ReadLine());
            int numbersIn = 0, numbersOut = 0;
           
            for (int i = 0; i < caseTests; i++)
            {
                var x = Convert.ToInt32(Console.ReadLine());

                if (x >= 10 && x <= 20)
                {
                    numbersIn++;
                }
                else
                {
                    numbersOut++;
                }
            }

            Console.WriteLine("{0} in", numbersIn);
            Console.WriteLine("{0} out", numbersOut);
        }
    }
}

