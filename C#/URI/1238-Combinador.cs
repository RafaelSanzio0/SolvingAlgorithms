using System;
using System.Text;

/*
 * Implemente um programa denominado combinador, que recebe duas strings e deve combiná-las, alternando as letras de cada string, começando com a
 * primeira letra da primeira string, seguido pela primeira letra da segunda string, em seguida pela segunda letra da primeira string, e
 * assim sucessivamente. As letras restantes da cadeia mais longa devem ser adicionadas ao fim da string resultante e retornada.

Entrada
A entrada contém vários casos de teste. A primeira linha contém um inteiro N que indica a quantidade de casos de teste que vem a 
seguir. Cada caso de teste é composto por uma linha que contém duas cadeias de caracteres, cada cadeia de caracteres contém entre 1 e 50 caracteres inclusive.

Saída
Combine as duas cadeias de caracteres da entrada como mostrado no exemplo abaixo e exiba a cadeia resultante.
*/

namespace URI
{
    internal class _1238_Combinador
    {
        public static void Main(string[] args)
        {
            var testCase = int.Parse(Console.ReadLine());

            for (int i = 0; i < testCase; i++)
            {
                string[] input = Console.ReadLine().Split(' ');
                var n1 = input[0];
                var n2 = input[1];
                var n3 = new StringBuilder();
                var times = Math.Max(n1.Length, n2.Length);

                for (int j = 0; j <= times; j++)
                {
                    if (j < n1.Length)
                    {
                        n3.Append(n1[j]);
                    }

                    if (j < n2.Length)
                    {
                        n3.Append(n2[j]);
                    }

                }
                Console.WriteLine(n3);
            }
        }
    }
}
