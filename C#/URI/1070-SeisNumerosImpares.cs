using System;
using System.Collections.Generic;
using System.Text;

/*
Leia um valor inteiro X. Em seguida apresente os 6 valores ímpares consecutivos a partir de X, um valor por linha, inclusive o X ser for o caso.

Entrada
A entrada será um valor inteiro positivo.

Saída
A saída será uma sequência de seis números ímpares.
*/

namespace URI
{
    class _1070_SeisNumerosImpares
    {
        static void Main(string[] args)
        {
            var x = Convert.ToInt32(Console.ReadLine());
            var contador = 0;

            while (contador < 6)
            {
                if (x % 2 != 0)
                {
                    contador++;
                    Console.WriteLine("{0}", x);
                }

                x += 1;
            }

        }
    }
}

