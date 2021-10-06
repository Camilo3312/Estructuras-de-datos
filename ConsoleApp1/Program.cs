

using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Programa
    {
        public static void Main(string[] args)
        {
            TiposDatos tiposdatos = new TiposDatos();

            var a = true;

            while (a == true)
            {
                Console.WriteLine("");
                Console.WriteLine("Estructuras de datos");
                Console.WriteLine("(1) Array");
                Console.WriteLine("(2) Matriz");
                Console.WriteLine("(3) Diccionario");
                Console.WriteLine("(4) Colecciones");
                Console.WriteLine("(5) Salir");
                Console.WriteLine("Ingrese una opcion");        

                int opcion = Convert.ToInt32(Console.ReadLine());

                if (opcion == 1)
                {
                    // Array unidimencional
                    Console.WriteLine("Vecotres");

                    Console.WriteLine("");
                    Console.WriteLine("====================");
                    Console.WriteLine("Array unidimencional");
                    Console.WriteLine("====================");
                    Console.WriteLine("");

                    // agregar 
                    for(var i = 0; i < tiposdatos.array.Length; i++){
                        Console.WriteLine("Ingrese un dato");
                        var dato = Console.ReadLine();
                        tiposdatos.array[i] = Convert.ToInt32(dato);
                    }

                    Console.WriteLine("");
                    foreach (var i in tiposdatos.array)
                    {
                        Console.WriteLine(i);
                    }
                }

                else if (opcion == 2)
                {
                    // Array bidimencional

                    Console.WriteLine("");
                    Console.WriteLine("====================");
                    Console.WriteLine("Array bidimencional");
                    Console.WriteLine("====================");
                    Console.WriteLine("");

                    // tiposdatos.array2D[0, 2] = 23423;

                    for (int fila = 0; fila < 3; fila++)
                    {
                        for (int col = 0; col < 3; col++)
                        {
                            Console.WriteLine("Ingresa un numero: ");
                            tiposdatos.array2D[fila, col] = Convert.ToInt32(Console.ReadLine());
                        }
                    }
                  
                    for (int fila = 0; fila < 3; fila++)
                    {
                        for (int col = 0; col < 3; col++)
                        {
                            Console.Write(" " + tiposdatos.array2D[fila, col]);
                        }
                        Console.WriteLine();
                    }
                }

                else if (opcion == 3)
                {
                    Console.WriteLine("");
                    Console.WriteLine("====================");
                    Console.WriteLine("Diccionario");
                    Console.WriteLine("====================");
                    Console.WriteLine("");

                    //Diccionario
                    tiposdatos.myDictionary.Add("John Doe", 23);
                    tiposdatos.myDictionary.Add("Mariana", 24);
                    tiposdatos.myDictionary.Add("David", 27);

                    Console.WriteLine(tiposdatos.myDictionary["John Doe"]);

                    foreach (var i in tiposdatos.myDictionary)
                    {
                        Console.WriteLine(i);
                    }
                }

                else if (opcion == 4)
                {
                    Console.WriteLine("");
                    Console.WriteLine("====================");
                    Console.WriteLine("Coleccion");
                    Console.WriteLine("====================");
                    Console.WriteLine("");

                    //Coleccion
                    Console.WriteLine("Ingrese la cantidad de datos que desea ingresar");
                    int cantidad = Convert.ToInt32(Console.ReadLine());
                    for (var i = 0; i < cantidad; i++)
                    {
                        Console.WriteLine("Ingrese un dato");
                        var dato = Console.ReadLine();
                        tiposdatos.miColeccion.Add(dato);
                    }

                    Console.WriteLine("");
                    for (var i = 0; i < tiposdatos.miColeccion.Count; i++)
                    {                     
                        Console.WriteLine(tiposdatos.miColeccion[i]);
                    }
                }

                else if (opcion == 5)
                {
                    a = false;
                }
            }
        }
    }
}
























