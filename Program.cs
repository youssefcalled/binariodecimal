using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio
{
    class Program
    {
        public static double nDecimal(string binario)
        {
            int j = 0, numeroconvertido = 0;
            string a = string.Empty;
            double ndecimal = 0.0;
            for (int l = binario.Length - 1; l >= 0; l--)
            {

                a = Convert.ToString(binario[l]);
                numeroconvertido = Convert.ToInt32(a);
                ndecimal = ndecimal + (numeroconvertido * (Math.Pow(2, j)));
                j++;

            }
            return ndecimal;
        }
            static void Main(string[] args)
        {
            
            string num = "0111001";
            Console.WriteLine("Binário: {0} \nDecimal: {1}", num, nDecimal(num));

            Console.ReadKey();
        }
    }
}
