using System;
using System.Collections.Generic;
using System.Text;

/*
 * Leia 2 valores inteiros X e Y. A seguir,
 * calcule e mostre a soma dos números impares entre eles.
 

namespace URI
{
    class _1071_SomaDosImparesEntreNumeros
    {

        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
            int sum_imp = 0;

            
            if(x < y) // -5(x)-4 -3 -2 -1 0 1 2 3 4 5 6(y)
            {
                for(int i = x+1; i < y; i++)
                {
                    if(i % 2 != 0)
                    {
                        sum_imp += i;
                    }
                 
                }
            }
            else
            {
                for (int i = y+1; i < x; i++)  //15(x) 14 13 12(y)
                {
                    if (i % 2 != 0)
                    {
                        sum_imp += i;
                    }
                }
            }
            Console.WriteLine(sum_imp);
        }
    }
}
*/

