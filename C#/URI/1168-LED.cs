using System;
using System.Text;

/*
 * João quer montar um painel de leds contendo diversos números. Ele não possui muitos leds, e não tem certeza se conseguirá montar o número 
 * desejado. Considerando a configuração dos leds dos números abaixo, faça um algoritmo que ajude João a descobrir a quantidade de leds necessário para montar o valor.

Obs.: Para programadores de Javascript, recomenda-se o uso de "input.trim().split('\n')" para evitar erros conhecidos.
*/

namespace URI
{
    internal class _1168_LED
    {
        public static void Main(string[] args)
        {
            var testCase = int.Parse(Console.ReadLine());
            var leds = 0;
         
            for (int i = 0; i < testCase; i++)
            {
                var input = Console.ReadLine();
                var bytes = Encoding.ASCII.GetBytes(input);

                for (int j = 0; j < bytes.Length; j++)
                {
                    if (bytes[j] == '0')
                    {
                        leds += 6;
                    }
                    if (bytes[j] == '1')
                    {
                        leds += 2;
                    }
                    if (bytes[j] == '2')
                    {
                        leds += 5;
                    }
                    if (bytes[j] == '3')
                    {
                        leds += 5;
                    }
                    if (bytes[j] == '4')
                    {
                        leds += 4;
                    }
                    if (bytes[j] == '5')
                    {
                        leds += 5;
                    }
                    if (bytes[j] == '6')
                    {
                        leds += 6;
                    }
                    if (bytes[j] == '7')
                    {
                        leds += 3;
                    }
                    if (bytes[j] == '8')
                    {
                        leds += 7;
                    }
                    if (bytes[j] == '9')
                    {
                        leds += 6;
                    }
                }
                Console.WriteLine("{0} leds", leds);
                leds= 0;
            }
        }
    }
}
