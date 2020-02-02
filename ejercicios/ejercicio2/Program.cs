using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio2
{
    class Program
    {
        /*
         Realizar una aplicación que permita administrar una lista de contacto, en este podemos agregar, listar, editar y eliminar contactos, 
         la cantidad de contactos maximos es 15.
             */
        static void Main(string[] args)
        {
            string[][] contactos = new string[15][];
            for (int i = 0; i < 15; i++)
            {
                contactos[i] = new string[2];
            }
            inicio:
            int opcion;
            menu();

            if (int.TryParse(Console.ReadLine(),out opcion))
            {
                switch (opcion)
                {
                    case 1:
                        if (string.IsNullOrEmpty(contactos[14][0]))
                        {
                            Console.WriteLine("Ingrese el nombre contacto");
                            string nombre = Console.ReadLine();
                            Console.WriteLine("Ingrese el numero del contacto");
                            string telefono = Console.ReadLine();
                            for (int i = 0; i < contactos.Length; i++)
                            {
                                if (string.IsNullOrEmpty(contactos[i][0]))
                                {
                                    contactos[i][0] = nombre;
                                    contactos[i][1] = telefono;
                                    break;
                                }
                            }
                            Console.WriteLine("Se ha agregado con exito\n presione cualquier tecla para continuar");
                            Console.ReadKey();
                            goto inicio;
                        }
                        break;
                    case 2:
                        mostrar_listado(contactos);
                        Console.ReadKey();
                        break;
                    case 3:
                        inicio_update:
                        mostrar_listado(contactos);
                        Console.WriteLine("Elija el numero del contacto a modificar");
                        int contacto;
                        if (int.TryParse(Console.ReadLine(),out contacto))
                        {
                            Console.WriteLine("Introduzca el nombre del contacto");
                            string nombre = Console.ReadLine();
                            Console.WriteLine("Introduzca el telefono del contacto");
                            string telefono = Console.ReadLine();

                            contactos[contacto - 1][0] = nombre;
                            contactos[contacto - 1][1] = telefono;
                            Console.WriteLine("Se ha modificado con exito \n Presione cualquier tecla para continuar");
                            Console.ReadKey();
                            goto inicio;
                        }
                        else
                        {
                            Console.WriteLine("Debe introducir el numero del contacto");
                            Console.ReadKey();
                            goto inicio_update;
                        }
                    case 4:
                        mostrar_listado(contactos);
                        Console.WriteLine("Elija el numero del contacto a eliminar");
                        int contacto_eliminar;
                        if (int.TryParse(Console.ReadLine(), out contacto_eliminar))
                        { 
                            contactos[contacto_eliminar - 1][0] = string.Empty;
                            contactos[contacto_eliminar - 1][1] = string.Empty;
                            Console.WriteLine("Se ha eliminado con exito \n Presione cualquier tecla para continuar");
                            Console.ReadKey();
                            goto inicio;
                        }
                        else
                        {
                            Console.WriteLine("Debe introducir el numero del contacto");
                            Console.ReadKey();
                            goto inicio_update;
                        }
                    case 5:
                        
                        break;
                    default:
                        Console.WriteLine("La opcion elegida no esta contemplada");
                        Console.ReadKey();
                        goto inicio;
                }
            }
            else
            {
                Console.WriteLine("Debe seleccionar una de las opciones especificadas\n Presione cualquier tecla para continuar");
                Console.ReadKey();
                goto inicio;
            }
        }
        static void mostrar_listado(string[][] contactos) {
            Console.Clear();
            Console.WriteLine("Lista de contactos");
            Console.WriteLine("Nombre \t Telefono ");
            for (int i = 0; i < contactos.Length; i++)
            {
                if (!string.IsNullOrEmpty(contactos[i][0]))
                {
                    Console.WriteLine((i + 1) + "- " + contactos[i][0] + "\t" + contactos[i][1]);
                }
            }
        }
        static void menu() {
            Console.Clear();
            Console.WriteLine("Bienvenido\n usted posee las siguientes opciones:");
            Console.WriteLine("1-Agregar contactos");
            Console.WriteLine("2-Mostrar contactos");
            Console.WriteLine("3-Editar contacto");
            Console.WriteLine("4-Eliminar contacto");
            Console.WriteLine("5-Salir");
        }
    }
}
