using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace multiplicar_dos_numero
{
    class Program
    {
        static void Main(string[] args)
        {
            int valor1 = 50, valor2 = 51, resultado;
            Console.WriteLine("vamos a multiplicar 50x51");
            resultado = valor1 * valor2;
            Console.WriteLine("el resultado de la multiplicacion es: "+resultado);
            Console.ReadKey();
        }
    }
}
