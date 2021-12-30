using System;
using System.Collections.Generic;
using System.Text;
using static System.Math;

/*

Maria acabou de iniciar seu curso de graduação na faculdade de medicina e precisa de sua ajuda para organizar os experimentos de um laboratório o qual ela é responsável. Ela quer saber no final do ano, quantas cobaias foram utilizadas no laboratório e o percentual de cada tipo de cobaia utilizada.

Este laboratório em especial utiliza três tipos de cobaias: sapos, ratos e coelhos. Para obter estas informações, ela sabe exatamente o número de experimentos que foram realizados, o tipo de cobaia utilizada e a quantidade de cobaias utilizadas em cada experimento.

Entrada
A primeira linha de entrada contém um valor inteiro N que indica os vários casos de teste que vem a seguir. Cada caso de teste contém um inteiro Quantia (1 ≤ Quantia ≤ 15) que representa a quantidade de cobaias utilizadas e um caractere Tipo ('C', 'R' ou 'S'), indicando o tipo de cobaia (R:Rato S:Sapo C:Coelho).

Saída
Apresente o total de cobaias utilizadas, o total de cada tipo de cobaia utilizada e o percentual de cada uma em relação ao total de cobaias utilizadas, sendo que o percentual deve ser apresentado com dois dígitos após o ponto.




namespace URI
{
    class _1094_Experiencia
    {
        static void Main(string[] args)
        {
            var caseTest = Convert.ToInt32(Console.ReadLine());
            var totalCobais = 0; var totalCoelhos = 0; var totalRatos = 0; var totalSapos = 0;
            var porcentagemCoelhos = 0.0; var porcentagemRatos = 0.0; var porcentagemSapos = 0.0;

            for (int i = 0; i < caseTest; i++)
            {
                var input = Convert.ToString(Console.ReadLine());
                var value = Convert.ToInt32(input.Split(' ')[0]);
                var type = input.Split(' ')[1];

                totalCobais += value;

                if (type.ToUpper().Equals("C"))
                {
                    porcentagemCoelhos = totalCoelhos += value;
                }
                else if (type.ToUpper().Equals("R"))
                {
                    porcentagemRatos = totalRatos += value;
                }
                else if (type.ToUpper().Equals("S"))
                {
                    porcentagemSapos = totalSapos += value;
                }
                else
                {
                    Console.WriteLine("Operacao invalida");
                }

            }

            Console.WriteLine("Total: {0} cobaias", totalCobais);
            Console.WriteLine("Total de coelhos: {0}", totalCoelhos);
            Console.WriteLine("Total de ratos: {0}", totalRatos);
            Console.WriteLine("Total de sapos: {0}", totalSapos);
            Console.WriteLine("Percentual de coelhos: {0} %", FomartaSaida(porcentagemCoelhos, totalCobais));
            Console.WriteLine("Percentual de ratos: {0} %", FomartaSaida(porcentagemRatos, totalCobais));
            Console.WriteLine("Percentual de sapos: {0} %", FomartaSaida(porcentagemSapos, totalCobais));

        }
        public static double GetPorcentagem(double a, int b)
        {
            return (a /= b) * 100;
        }

        public static string FomartaSaida(double a, int b)
        {
            return GetPorcentagem(a, b).ToString("N2").Replace(",", ".");
        }
    }
}

*/