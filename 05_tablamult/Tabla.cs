// crear en la terminal dotnet new console
using System;
using System.Numerics;
using Microsoft.VisualBasic;

namespace _05_tablamult
{ //poner el mismo nombre que en el RootNamespace 
    internal class Tabla
    {
        static void Main(string[] args)
        {
            int numero = 0;
            bool entero = false;
            do
            {
                Console.Write("Introduce un número: ");

                try
                {
                    numero = int.Parse(Console.ReadLine());

                    //si el nº es mayor o igual que 0 y entero imprimimos la tabla
                    if (numero >= 0)
                    {
                        entero = true;
                    }
                    else //sino el bucle se repetirá hasta que sea entero y mayor o igual que 0
                    {
                        Console.WriteLine("El número no es válido");

                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("El número no es válido");
                }

            } while (!entero);

            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine($"{i} x {numero} = {i * numero}");
            }



        }
    }
}