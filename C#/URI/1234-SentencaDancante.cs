
/*Uma sentença é chamada de dançante se sua primeira letra for maiúscula e cada letra subsequente for o oposto da letra anterior. Espaços devem ser ignorados ao determinar o case
 * (minúsculo/maiúsculo) de uma letra. Por exemplo, "A b Cd" é uma sentença dançante porque a primeira letra ('A') é maiúscula, a próxima letra ('b') é minúscula,
 * a próxima letra ('C') é maiúscula, e a próxima letra ('d') é minúscula.

Entrada
A entrada contém vários casos de teste. Cada caso de teste é composto por uma linha que contém uma sentença, que é uma string que contém entre 1 e 50 caracteres ('A'-'Z','a'-'z' ou espaço ' '), 
inclusive, ou no mínimo uma letra ('A'-'Z','a'-'z').

Saída
Transforme a sentença de entrada em uma sentença dançante (conforme o exemplo abaixo) trocando as letras para minúscula ou maiúscula onde for necessário. Todos os espaços da sentença original deverão ser preservados, 
ou seja, " sentence " deverá ser convertido para " SeNtEnCe ".
*/

using System;

namespace URI
{
    internal class _1234_SentencaDancante
    {
        static void Main()
        {
            string input;

            while (!string.IsNullOrEmpty(input = Console.ReadLine()))
            {
                bool isUpper = true;

                foreach (char c in input)
                {
                    if (char.IsLetter(c))
                    {
                        if (isUpper)
                        {
                            Console.Write(char.ToUpper(c));
                        }
                        else
                        { 
                            Console.Write(char.ToLower(c));
                        }

                        isUpper = !isUpper;
                    }
                    else
                    {
                        Console.Write(c);
                    }
                }
                Console.WriteLine();
            }
        }
    }
}