 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicios
{
    class Program
    {
        static void Main(string[] args)
        {
            ejercicio1();
        }
        /*Debe realizar aplicación que permita administrar el listado de la compra de alimentos, solo 10 alimentos por listado, 
         * en el mismo podemos agregar alimentos pero cada alimento pertenece a una de estas categorías: frutas, vegetales o lácteos, 
         * de manera que antes de agregar un alimento al listado debemos saber a cuál categoría pertenece.

        También el sistema permite listar la lista de compra de las siguientes maneras, el sistema nos permite elegir entre listar solo las 
        frutas, solo los vegetales, solo los lácteos o todos los alimentos.

        Podemos editar los alimentos de las diferentes listas de compra, para editar algún alimento primero debemos seleccionar 
        de cual lista es que modificaremos el alimento.

        Finalmente podemos borrar los alimentos de las diferentes listas de compra, para borrar algún alimento primero debemos seleccionar 
        de cual lista es que borraremos el alimento.*/
        static void menu() {
            Console.Clear();
            Console.WriteLine("Selecione la opcion deseada \n" +
                                   "[1]-FRUTAS    \n" +
                                   "[2]-VEGETALES \n" +
                                   "[3]-LACTEOS   \n" +
                                   "[4]-SALIR     \n");
        }
        static void listado(string listado)
        {
            Console.Clear();
            Console.WriteLine("Listado de "+listado+" \n" +
                                "''OPCIONES'' \n" +
                                "[1]-AÑADIR   \n" +
                                "[2]-MOSTRAR  \n" +
                                "[3]-EDITAR   \n" +
                                "[4]-ELIMINAR \n" +
                                "[5]-CERRAR");
        }
        static void mostrar_items_existetes(string listado,string[] items) {
            Console.Clear();
            Console.WriteLine("LISTADO DE "+listado+" AÑADIDADAS");
            for (int i = 0; i < items.Length; i++)
            {

                string elemento = items[i];
                Console.WriteLine((i + 1) + "-" + elemento);

            }
        }
        static void agregar(string[] items,string listado ) {
            if (string.IsNullOrEmpty(items[9]))
            {
                Console.WriteLine("Ingrese la "+listado+" que desea añadir");
                string Fruta = Console.ReadLine();
                for (int i = 0; i < items.Length; i++)
                {

                    string elemento = items[i];

                    if (string.IsNullOrEmpty(elemento))
                    {
                        items[i] = Fruta;
                        break;
                    }
                }
                Console.WriteLine("Se ha añadido con exito.\n Presione cualquier tecla para continuar");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("CAMPOS LLENOS!");
                Console.ReadKey();
            }
        }
       static void ejercicio1() {
            string[] Frutas = new string[10];
            string[] Vegetales = new string[10];
            string[] Lacteos = new string[10];
            Console.WriteLine("Bienvenido a su listado :)\n" +
                              "Precione cualquier letra para continuar...");
            Console.ReadKey();
            while (true)
            { 
                bool C = true;
                int MenuP;
                menu();
                MenuP = Convert.ToInt32(Console.ReadLine());

                while (true)
                {
                    switch (MenuP)
                    {
                        case 1:
                            int FRUTAS;
                            listado("FRUTAS");
                            FRUTAS = Convert.ToInt32(Console.ReadLine());

                            switch (FRUTAS)
                            {

                                case 1:
                                    agregar(Frutas, "fruta");
                                    break;
                                case 2:
                                    mostrar_items_existetes("FRUTAS",Frutas);
                                    Console.ReadKey();
                                    break;
                                case 3:
                                    mostrar_items_existetes("FRUTAS", Frutas);
                                    Console.WriteLine("Coloque el numero de la fruta a modificar");
                                    int fruta_modificar = int.Parse(Console.ReadLine());
                                    Console.WriteLine("Ingrese la fruta cambiada");
                                    string new_fruta = Console.ReadLine();
                                    if (fruta_modificar<11 && fruta_modificar>=1)
                                    {
                                        Frutas[fruta_modificar-1] = new_fruta;
                                    }
                                    else
                                    {
                                        Console.WriteLine("El numero introduccido no corresponde con el listado de frutas");
                                        mostrar_items_existetes("FRUTAS", Frutas);
                                    }
                                    break;
                                case 4:
                                    mostrar_items_existetes("FRUTAS",Frutas);
                                    Console.WriteLine("Coloque el numero de la fruta a eliminar");
                                    int fruta_eliminar = int.Parse(Console.ReadLine());
                                    if (fruta_eliminar < 11 && fruta_eliminar >= 1)
                                    {
                                        Frutas[fruta_eliminar-1]=string.Empty;
                                    }
                                    else
                                    {
                                        Console.WriteLine("El numero introduccido no corresponde con el listado de frutas");
                                        mostrar_items_existetes("FRUTAS", Frutas);
                                    }
                                    break;
                                case 5:
                                    goto SALIR1;
                                default:
                                    break;
                            }

                            break;
                        case 2:
                            int VEGETALES;
                            listado("VEGETALES");
                            VEGETALES = Convert.ToInt32(Console.ReadLine());
                            switch (VEGETALES)
                            {
                                case 1:
                                    agregar(Vegetales, "vegetales");
                                    break;

                                case 2:
                                    mostrar_items_existetes("VEGETALES", Vegetales);
                                    Console.ReadKey();
                                    break;
                                case 3:
                                    mostrar_items_existetes("VEGETAL", Vegetales);
                                    Console.WriteLine("Coloque el numero de la vegetal a modificar");
                                    int vegetal_modificar = int.Parse(Console.ReadLine());
                                    Console.WriteLine("Ingrese el vegetal cambiado");
                                    string new_vegetal = Console.ReadLine();
                                    if (vegetal_modificar < 11 && vegetal_modificar >= 1)
                                    {
                                        Vegetales[vegetal_modificar - 1] = new_vegetal;
                                    }
                                    else
                                    {
                                        Console.WriteLine("El numero introduccido no corresponde con el listado de vegetales");
                                        mostrar_items_existetes("VEGETALES", Vegetales);
                                    }
                                    break;
                                case 4:
                                    mostrar_items_existetes("VEGETALES", Vegetales);
                                    Console.WriteLine("Coloque el numero de la vegetal a eliminar");
                                    int vegetal_eliminar = int.Parse(Console.ReadLine());
                                    if (vegetal_eliminar < 11 && vegetal_eliminar >= 1)
                                    {
                                        Vegetales[vegetal_eliminar - 1] = string.Empty;
                                    }
                                    else
                                    {
                                        Console.WriteLine("El numero introduccido no corresponde con el listado de vegetales");
                                        mostrar_items_existetes("FRUTAS", Vegetales);
                                    }
                                    break;
                                case 5:
                                    goto SALIR1;
                                    break;
                                default:
                                    break;
                            }

                            break;
                        case 3:
                            int LACTEOS;
                            listado("LACTEOS");
                            LACTEOS = Convert.ToInt32(Console.ReadLine());
                            switch (LACTEOS)
                            {
                                case 1:
                                    agregar(Lacteos, "lacteo");
                                    break;
                                case 2:
                                    mostrar_items_existetes("LACTEOS", Lacteos);
                                    Console.ReadKey();
                                    break;
                                case 3:
                                    mostrar_items_existetes("LACTEOS", Lacteos);
                                    Console.WriteLine("Coloque el numero del lacteo a modificar");
                                    int lacteo_modificar = int.Parse(Console.ReadLine());
                                    Console.WriteLine("Ingrese el lacteo cambiado");
                                    string new_lacteo = Console.ReadLine();
                                    if (lacteo_modificar < 11 && lacteo_modificar >= 1)
                                    {
                                        Lacteos[lacteo_modificar - 1] = new_lacteo;
                                    }
                                    else
                                    {
                                        Console.WriteLine("El numero introduccido no corresponde con el listado de lacteos");
                                        mostrar_items_existetes("LACTEOS", Lacteos);
                                    }
                                    break;
                                case 4:
                                    mostrar_items_existetes("LACTEOS", Lacteos);
                                    Console.WriteLine("Coloque el numero del lacteo a eliminar");
                                    int lacteo_eliminar = int.Parse(Console.ReadLine());
                                    if (lacteo_eliminar < 11 && lacteo_eliminar >= 1)
                                    {
                                        Lacteos[lacteo_eliminar - 1] = string.Empty;
                                    }
                                    else
                                    {
                                        Console.WriteLine("El numero introduccido no corresponde con el listado de lacteos");
                                        mostrar_items_existetes("LACTEOS", Lacteos);
                                    }
                                    break;
                                case 5:
                                    goto SALIR1;
                                    break;
                                default:
                                    break;
                            }

                            break;
                        case 4:
                            goto SALIR;
                        default:
                            Console.WriteLine("OPCION ERRONEA!!\nINTENTE NUEVAMENTE");
                            break;
                    }
                    //Console.ReadKey();
                }
                SALIR1: Console.Clear();
            }
            SALIR: Console.Clear();
            Console.WriteLine("ADIOS! REGRESA PRONTO :(");
            Console.ReadKey();
        }

    }
}
