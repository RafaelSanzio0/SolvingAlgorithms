using System;
using System.Collections.Generic;
using System.Text;
/*
 * Escreva um programa que repita a leitura de uma senha até que ela seja válida.
 * Para cada leitura de senha incorreta informada, escrever a mensagem
 * "Senha Invalida". Quando a senha for informada corretamente deve ser
 * impressa a mensagem "Acesso Permitido" e o algoritmo encerrado. 
 * Considere que a senha correta é o valor 2002. 
 */

namespace URI
{
    class _1114_SenhaFixa
    {
        static void Main(string[] args)
        {
            int senhaValida = 2002;
            int tentativaSenha = Convert.ToInt32(Console.ReadLine());

            if(tentativaSenha == senhaValida)
            {
                Console.WriteLine("Acesso Permitido");
            }else if(tentativaSenha != senhaValida){
                Console.WriteLine("Senha Invalida");

                while (tentativaSenha != senhaValida)
                {
                    tentativaSenha = Convert.ToInt32(Console.ReadLine());

                    if (tentativaSenha == senhaValida)
                    {
                        Console.WriteLine("Acesso Permitido");
                    }
                    else if (tentativaSenha != senhaValida)
                    {
                        Console.WriteLine("Senha Invalida");
                    }
                }
            }
        }
    }
}

