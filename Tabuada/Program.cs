using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tabuada
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;

            Console.Write("Digite a tabuada que deseja consultar: ");
            numero = Convert.ToInt32(Console.ReadLine());

            int resultado;
            int i;
            
            for (i = 0; i <= 10; i++)
            {
                resultado = i * numero;
                Console.WriteLine(i + "x" + numero + "=" + resultado);
            }

            Console.ReadLine();
        }
    }
}
