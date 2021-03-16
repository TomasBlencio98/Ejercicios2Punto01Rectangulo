using Ejercicios2Punto01Rectangulo.BL;
using System;

namespace Ejercicios2Punto01Rectangulo.Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangulo rectangulo = new Rectangulo();
            Console.WriteLine("A continuacion favor de ingresar " +
                "los datos del Rectangulo");
            Console.Write("Ingrese uno de los lados del rectangulo:  ");
            if (double.TryParse(Console.ReadLine(), out var ladoUno))
            {
                Console.Write("Ingrese el segundo de los lados del rectangulo:  ");
                if (double.TryParse(Console.ReadLine(), out var ladoDos))
                {
                    if (ladoUno>ladoDos)
                    {
                        rectangulo.LadoMayor = ladoUno;
                        rectangulo.LadoMenor = ladoDos;
                        Console.WriteLine($"Rectangulo de lado mayor {ladoUno}; lado menor {ladoDos}");
                        Console.WriteLine($"La superficie del Rectangulo es {rectangulo.GetSuperficie()}");
                        Console.WriteLine($"El perimetro del Rectangulo es {rectangulo.GetPerimetro()}");
                    }
                    else
                    {
                        rectangulo.LadoMayor = ladoDos;
                        rectangulo.LadoMenor = ladoUno;
                        Console.WriteLine($"Rectangulo de lado mayor {ladoDos}; lado menor {ladoUno}");
                        Console.WriteLine($"La superficie del Rectangulo es {rectangulo.GetSuperficie()}");
                        Console.WriteLine($"El perimetro del Rectangulo es {rectangulo.GetPerimetro()}");
                    }
                }
                else
                {
                    Console.WriteLine("Valor/formato del lado ingresado no valido. ");
                }
            }else
            {
                Console.WriteLine("Valor/formato del lado ingresado no valido. ");
            }

            Console.ReadLine();

        }
    }
}
