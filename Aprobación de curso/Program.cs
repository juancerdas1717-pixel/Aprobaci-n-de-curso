using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aprobación_de_curso
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Ingrese una nota del 0 al 100: ");
            string entrada = Console.ReadLine();
            double nota = Convert.ToDouble(entrada);

            if (nota < 0 || nota>100)
            {
                Console.WriteLine("!ERROR! La nota ingresada no esta en la escala de 0 a 100");

            }
            else if (nota >= 70)
            {
                Console.WriteLine("El estudiante ha aprobado");

            }
            else
            {
                Console.WriteLine("El estudiante ha reprobado");
            }
        }
    }
}
 