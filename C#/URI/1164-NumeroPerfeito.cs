using System;
using System.Collections.Generic;
using System.Text;

/*

Na matemática, um número perfeito é um número inteiro para o qual a soma de todos os seus divisores positivos próprios (excluindo ele mesmo)
é igual ao próprio número. Por exemplo o número 6 é perfeito, pois 1+2+3 é igual a 6. Sua tarefa é escrever um programa que imprima se um determinado número é perfeito ou não.

Entrada
A entrada contém vários casos de teste. A primeira linha da entrada contém um inteiro N (1 ≤ N ≤ 20), indicando o número de casos de teste da entrada.
Cada uma das N linhas seguintes contém um valor inteiro X (1 ≤ X ≤ 108), que pode ser ou não, um número perfeito.

Saída
Para cada caso de teste de entrada, imprima a mensagem “X eh perfeito” ou “X nao eh perfeito”, de acordo com a especificação fornecida.



namespace URI
{
    class _1164_NumeroPerfeito
    {
        public static void Main(string[] args)
        {
            var caseTest = Convert.ToInt32(Console.ReadLine());
            var soma = 0;

            for (int i = 0; i < caseTest; i++)
            {
                var input = Convert.ToInt32(Console.ReadLine());

                for (int j = 1; j < input+1; j++)
                {
                    var resto = input % j;

                    if (resto == 0 && j != input)
                    {
                        soma += j;
                    }
                }

                if (soma == input)
                {
                    Console.WriteLine("{0} eh perfeito", input);
                }
                else
                {
                    Console.WriteLine("{0} nao eh perfeito", input);
                }

                soma = 0;
            }
        }
    }
}
 */