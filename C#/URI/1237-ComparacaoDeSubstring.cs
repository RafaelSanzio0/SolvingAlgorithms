/*
 * 
 * Encontre a maior substring comum entre as duas strings informadas. 
 * A substring pode ser qualquer parte da string, inclusive ela toda. Se não houver subseqüência comum, a saída deve ser “0”. A comparação é case sensitive ('x' != 'X').

Entrada
A entrada contém vários casos de teste. Cada caso de teste é compo
sto por duas linhas, cada uma contendo uma string. Ambas strings de en
trada contém entre 1 e 50 caracteres ('A'-'Z','a'-'z' ou espaço ' '), inclusive, ou no mínimo uma letra ('A'-'Z','a'-'z').

Saída
O tamanho da maior subsequência comum entre as duas Strings.
*/
using System;

namespace URI
{
    internal class _1237_ComparacaoDeSubstring
    {
        public static void Main(string[] args)
        {
            string s1, s2;

            while ((s1 = Console.ReadLine()) != null && (s2 = Console.ReadLine()) != null)
            {
                int result = LCSLength(s1, s2);
                Console.WriteLine(result);
            }
        }

        public static int LCSLength(string s1, string s2) // algoritmo LCS
        {
            int m = s1.Length;
            int n = s2.Length;
            
            int[,] dp = new int[m + 1, n + 1];

            for (int i = 1; i <= m; i++)
            {
                for (int j = 1; j <= n; j++)
                {
                    if (s1[i - 1] == s2[j - 1])
                    {
                        dp[i, j] = dp[i - 1, j - 1] + 1;
                    }
                    else
                    {
                        dp[i, j] = Math.Max(dp[i - 1, j], dp[i, j - 1]);
                    }
                }
            }

            return dp[m, n];
        }
    }
}
