using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using static System.Math;

/*
 * Leia 3 valores de ponto flutuante e efetue o cálculo das raízes da equação de Bhaskara.
 * Se não for possível calcular as raízes, mostre a mensagem correspondente
 * “Impossivel calcular”,
 * caso haja uma divisão por 0 ou raiz de numero negativo.
 */

namespace URI
{
    class _1036_Bhaskara
    {

        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(" ");
            double a = double.Parse(input[0],new CultureInfo("en-US")),
                   b = double.Parse(input[1],new CultureInfo("en-US")),
                   c = double.Parse(input[2],new CultureInfo("en-US"));

            double delta = ((b * b) - (4 * a * c));


            if (delta >= 0 && a != 0)
            {
                double r1 = ((-b + Sqrt(delta)) / 2 * a);
                double r2 = ((-b - Sqrt(delta)) / 2 * a);
                Console.WriteLine("R1 = "+ Round(r1,6));
                Console.WriteLine("R2 = " + Round(r2,6));

            }
            else
            {
                Console.WriteLine("Impossivel calcular");
            }

        }

    }
}

    
