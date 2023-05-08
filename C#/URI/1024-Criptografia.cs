using System;
using System.Linq;
using System.Text;

/*
 * Solicitaram para que você construisse um programa simples de criptografia. Este programa deve possibilitar enviar mensagens codificadas sem que alguém consiga lê-las.
 * O processo é muito simples. São feitas três passadas em todo o texto.

Na primeira passada, somente caracteres que sejam letras minúsculas e maiúsculas devem ser deslocadas 3 posições para a direita, segundo a tabela ASCII:
letra 'a' deve virar letra 'd', letra 'y' deve virar caractere '|' e assim sucessivamente. Na segunda passada, a linha deverá ser invertida. Na terceira e última passada,
todo e qualquer caractere a partir da metade em diante (truncada) devem ser deslocados uma posição para a esquerda na tabela ASCII. Neste caso, 'b' vira 'a' e 'a' vira '`'.

Por exemplo, se a entrada for “Texto #3”, o primeiro processamento sobre esta entrada deverá produzir “Wh{wr #3”. O resultado do segundo processamento inverte 
os caracteres e produz “3# rw{hW”. Por último, com o deslocamento dos caracteres da metade em diante, o resultado final deve ser “3# rvzgV”.


namespace URI
{
    internal class _1024_Criptografia
    {
        public static void Main(string[] args)
        {
            var testCase = int.Parse(Console.ReadLine());

            for (int i = 0; i < testCase; i++)
            {
                var input = Console.ReadLine();
                Console.WriteLine("********TEXTO DESCRIPTOGRAFADO: " + input);
                byte[] asciiBytes = Encoding.ASCII.GetBytes(input);
                byte[] newInput = new byte[asciiBytes.Length];

                // desloca maisculos e minusculos para 3 posições da ASCII
                for (int j = 0; j < asciiBytes.Length; j++)
                {
                    if (char.IsUpper((char)asciiBytes[j]) || char.IsLower((char)asciiBytes[j]))
                    {
                        asciiBytes[j] += 3;
                    }
                }

                // inverte todo o array
                Array.Reverse(asciiBytes);

                // obtem os elementos da metade pra frente do array e desloca uma casa a esquerda
                var half = asciiBytes.Skip(asciiBytes.Length/2).ToArray();
                for (int k = 0; k < half.Length; k++)
                {
                    half[k] -= 1;
                }

                //obtem a primeira metade do array que ja foi invertido
                var firstHalf = asciiBytes.Take(asciiBytes.Length / 2).ToArray();

                // preenche a nova saida com a primeira metade do array invertido
                for (int l = 0; l < firstHalf.Length; l++)
                {
                    newInput[l] += asciiBytes[l];
                }

                // preenche a nova saida da metade pra frente do array com as casas deslocas a esquerda
                var isCousin = asciiBytes.Length % 2 == 0 ? (half.Length * 2) : (half.Length * 2) - 1;
                for (int m = newInput.Length / 2 ; m < isCousin; m++)
                {
                    newInput[m] += half[m - newInput.Length / 2];
                }
                Console.WriteLine("******TEXTO CRIPTOGRAFADO: " + Encoding.Default.GetString(newInput));
            }
        }
    }
}
*/