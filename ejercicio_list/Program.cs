using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_list
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Gato> gato = new List<Gato>();
            string nombre, color, leer="";
            int id=0, opcion=0, cantidad;

            while (opcion !=6)
            {
                Console.WriteLine("--Menu--");
                Console.WriteLine("1.- Agregar");
                Console.WriteLine("2.- Agregar por bloque");
                Console.WriteLine("3.- Eliminar");
                Console.WriteLine("4.- Imprimir");
                Console.WriteLine("5.- Limpiar lista");
                Console.WriteLine("6.- Salir");
                Console.Write("Elige una opcion ");
                leer = Console.ReadLine();
                opcion = Convert.ToInt32(leer);

                switch (opcion)
                {
                    case 1:
                        Console.WriteLine("ingrese el id del gato:");
                        leer = Console.ReadLine();
                        id = Convert.ToInt32(leer);
                        Console.WriteLine("ingrese el nombre del gato:");
                        nombre = Console.ReadLine();
                        Console.WriteLine("color del gato");
                        color = Console.ReadLine();
                        gato.Add(new Gato() {
                            Id = id,
                            Nombre = nombre,
                            Color = color
                        });
                        break;

                    case 2:
                        Console.WriteLine("Ingresa la cantidad de gatos a agregar");
                        leer = Console.ReadLine();
                        cantidad = Convert.ToInt32(leer);
                        agregarBloque(cantidad,gato);
                        break;

                    case 3:
                        Console.WriteLine("Ingresa el id del gato a eliminar:");
                        id = Convert.ToInt32(Console.ReadLine());
                        eliminar(id,gato);
                        break;

                    case 4:
                        imprimir(gato);
                        break;

                    case 5:
                        gato.Clear();
                        Console.WriteLine("Se a vaciado la lista!");
                        break;

                    case 6:
                        Console.WriteLine("Saliendo del programa");
                        Console.ReadKey();
                        break;

                    default:
                        Console.WriteLine("La opcion no esta en el menu");
                        break;
                }
            }
        }

        public static void imprimir(List<Gato> lista)
        {
            Console.WriteLine("Datos de los gatos");
            foreach (var gato in lista)
            {
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("Id: "+gato.Id);
                Console.WriteLine("Nombre: "+gato.Nombre);
                Console.WriteLine("Color: "+gato.Color);
                Console.WriteLine("-------------------------");
                Console.ForegroundColor = ConsoleColor.Black;
            }

        }

        public static void agregarBloque(int cantidad, List<Gato> lista) {

            string nombre, color;

            for (int i = 0; i<=cantidad; i++)
            {
                Console.WriteLine("Ingresa el nombre del gato: ");
                nombre = Console.ReadLine();
                Console.WriteLine("Ingresa el color del gato:");
                color = Console.ReadLine();

                lista.Add(new Gato() {
                    Id = i + 345,
                    Nombre = nombre,
                    Color = color
                });
            }
        }

        public static void eliminar(int id, List<Gato> lista) {

            var elemento = lista.FirstOrDefault(g => g.Id == id);
            if (elemento!=null)
            {
                lista.Remove(elemento);
                Console.WriteLine("El gato a sido eliminado");
            }
            else
            {
                Console.WriteLine("El gato no existe en la lista");
            }
        }
    }
}
