
using System;
using System.Collections.Generic;
using System.Text;

/*
 * Este programa deve ler uma variável inteira X inúmeras vezes
 * (deve parar quando o valor no arquivo de entrada for igual a zero).
 * Para cada valor lido imprima a sequência de 1 até X,
 * com um espaço entre cada número e seu sucessor.
 */

namespace URI
{
    class _1146_SequenciasCrecentes
    {

        static void Main(string[] args)
        {
            int x = Convert.ToInt32(Console.ReadLine());
            StringBuilder stringBuilder = new StringBuilder();

            while (x != 0)
            {
                for (int i = 1; i <= x; i++)
                {
                    stringBuilder.AppendFormat("{0} ", i);
                }
                Console.Write(stringBuilder);
                Console.Write("\n");

                x = Convert.ToInt32(Console.ReadLine());
            }
        }
    }
}

