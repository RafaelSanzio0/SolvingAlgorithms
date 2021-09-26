using System;
using System.Collections.Generic;
using System.Text;

/*
Leia 6 valores.Em seguida, mostre quantos destes valores digitados foram positivos. Na próxima linha, deve-se mostrar a média de todos os valores positivos digitados, com um dígito após o ponto decimal.

Entrada
A entrada contém 6 números que podem ser valores inteiros ou de ponto flutuante. Pelo menos um destes números será positivo.

Saída
O primeiro valor de saída é a quantidade de valores positivos. A próxima linha deve mostrar a média dos valores positivos digitados.


namespace URI
{
    class _1064_positivos_e_media
    {
        static void Main(string [] args)
        {
            var contadorPositivo = 0;
            decimal sum_numbers = 0;

            for (int i = 0; i < 6; i++)
            {
                var numbers = Convert.ToDecimal(Console.ReadLine());

                if (numbers > 0)
                {
                    contadorPositivo++;
                    sum_numbers += numbers;
                }
            }

            Console.WriteLine("{0} valores positivos", contadorPositivo);
            Console.WriteLine("{0:f1}", (sum_numbers/contadorPositivo));

        }
    }
}
*/
