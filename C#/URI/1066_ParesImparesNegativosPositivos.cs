using System;
using System.Collections.Generic;
using System.Text;

/*
 
Leia 5 valores Inteiros. A seguir mostre quantos valores digitados foram pares, quantos valores digitados foram ímpares, quantos valores digitados foram positivos e quantos valores digitados foram negativos.

Entrada
O arquivo de entrada contém 5 valores inteiros quaisquer.

Saída
Imprima a mensagem conforme o exemplo fornecido, uma mensagem por linha, não esquecendo o final de linha após cada uma.



namespace URI
{
    class _1066_ParesImparesNegativosPositivos
    {
        static void Main(string[] args)
        {
            int contadorPositivo = 0, contadorNegativo = 0, contadorPar = 0, contadorImpar = 0;
        
            for (int i = 0; i < 5; i++)
            {
                var numbers = Convert.ToInt32(Console.ReadLine());

                if (numbers > 0)
                {
                    contadorPositivo++;
                }
                else if(numbers != 0)
                {
                    contadorNegativo++;
                }

                if (numbers % 2 == 0)
                {
                    contadorPar++;
                }
                else
                {
                    contadorImpar++;
                }
            }

            Console.WriteLine("{0} valor(es) par(es)", contadorPar);
            Console.WriteLine("{0} valor(es) impar(es)", contadorImpar);
            Console.WriteLine("{0} valor(es) positivo(s)", contadorPositivo);
            Console.WriteLine("{0} valor(es) negativo(s)", contadorNegativo);
        }
    }
}

 */
