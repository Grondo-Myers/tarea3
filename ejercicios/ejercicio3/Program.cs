using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio3
{
    class Program
    {
        static int oportunidades = 10;
        static Random random = new Random();
        /*
        Realiza una aplicación que genere un número random del 1-100 y que luego el usuario deba adivinar cuál es número que se generó,
        el mismo solo tendrá 10 oportunidades para adivinar al agotar las 10 oportunidades debe mostrarse cuál era el número y preguntarle 
        si quiere volver a jugar si quiere seguir se debe generar un nuevo número random de no querer seguir jugando debe finalizar la aplicación.

        La aplicación debe de darle pista al usuario según qué tan cerca este si está a menos o a 5 números debe decirle que está muy caliente, si
        está a 10 o menos número que está caliente si está a 20 o menos números que se está acercando si está a 30 o menos que esta frio si esta 50 o 
        menos que está muy frio.
    
        Ejemplo si el número random es 40 y el usuario ingresa 35 está muy caliente y si ingresa 45 también está muy caliente porque en ambos casos 
        está a 5 números del resultado correcto. 
        */
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenido, adivina el numero ramdon, tienes 10 oportunidades para hacerlo, buena suerte!");
            int num_aleatorio=random.Next(1,100);
            do
            {
                Console.WriteLine("Intentos restantes: "+oportunidades);
                Console.WriteLine("Introduzca un numero");
                int num = int.Parse(Console.ReadLine());
                if (num == num_aleatorio)
                {
                    Console.WriteLine("Felicidades, Ganaste");
                    Console.ReadKey();
                    break;
                }
                else if (validar_estado(num,num_aleatorio,5))
                {
                    estado("Muy caliente");
                }
                else if (validar_estado(num, num_aleatorio, 10)) {
                    estado("Caliente");
                }
                else if (validar_estado(num, num_aleatorio, 20)) {
                    estado("Te estas acercando");
                }
                else if (validar_estado(num, num_aleatorio, 30))
                {
                    estado("Frio");
                }
                else if (validar_estado(num, num_aleatorio, 50))
                {
                    estado("muy frio");
                }
                else
                {
                    estado("muy frio");
                }

                oportunidades--;
            } while (oportunidades!=0);
            if (oportunidades==0)
            {
                Console.Clear();
                Console.WriteLine("Has perdido, lo siento");
                Console.WriteLine("Presione cualquier tecla para continuar");
            }
            Console.ReadKey();
        }
        static void estado(string estado) {
            Console.Clear();
            Console.WriteLine("Fallaste, pero estas "+estado);
        }
        static bool validar_estado(int numero_user,int numero_aleatorio,int cant) {
            for (int i = 1; i <= cant; i++)
            {
                if (numero_user+i==numero_aleatorio || numero_user-i==numero_aleatorio)
                {
                    return true;
                }
            }
            return false;
        }

    }
}
