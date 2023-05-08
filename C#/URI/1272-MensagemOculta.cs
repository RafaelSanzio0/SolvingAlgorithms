using System;
using System.Linq;
using System.Text;

namespace URI
{
    internal class _1272_MensagemOculta
    {
        public static void Main(string[] args)
        {
            var testCase = int.Parse(Console.ReadLine());

            for (int i = 0; i < testCase; i++)
            {
                var input = Console.ReadLine().Split(' ');
                var bytes = new byte[input.Length];
                byte[] newInput = bytes; 

                for (int k = 0; k < input.Length; k++) //complete
                {
                    bytes = Encoding.ASCII.GetBytes(input[k]); // pega o C em byte

                    if (bytes[0] != ' ')
                    {
                        var a = newInput.Append(bytes[0]);
                        Console.WriteLine(a);

                    }
                }

            }
        }
    }
}