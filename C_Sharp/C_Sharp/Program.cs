using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("En cada ronda del juego del cachipún, los dos competidores deben elegir entre jugar tijera, papel o piedra. " +
                "Las reglas para decidir quién gana la ronda son: tijera le gana a papel, papel le gana a piedra, piedra le gana a tijera, y " +
                "todas las demás combinaciones son empates. El ganador del juego es el primero que gane tres rondas. " +
                "Escriba un programa que pregunte a cada jugador cuál es su jugada, muestre cuál es el marcador después de cada ronda, y " +
                "termine cuando uno de ellos haya ganado tres rondas. " +
                "Los jugadores deben indicar su jugada escribiendo: tijera, papel o piedra.\n");

            //Declaramos las variables contador
            int contador1 = 0, contador2 = 0;

            //Bucle que repetirá el proceso mientras se produzca una excepción
            while(true)
            {
                //Bloque para el manejo de excepciones
                try
                {
                    //Declaramos la variable que guarda el mensaje de la ronda
                    string mensaje;

                    //Declaramos las variables de ingreso de jugadas
                    string jugador1, jugador2;

                    //Bucle que repetirá el proceso mientras J1 no realice un ingreso correcto
                    while (true)
                    {
                        //Solicitamos a J1 que ingrese su elección
                        Console.WriteLine("J1 elija entre piedra, papel o tijera: ");
                        jugador1 = Console.ReadLine();

                        //Si J1 realiza un ingreso diferente al solicitado se le indica por pantalla
                        if (jugador1 != "piedra" && jugador1 != "papel" && jugador1 != "tijera")
                        {
                            Console.WriteLine("Sólo puede ingresar piedra, papel o tijera");
                        }

                        //Caso contrario se rompe el bucle
                        else
                        {
                            break;
                        }
                    }

                    //Bucle que repetirá el proceso mientras J2 no realice un ingreso correcto
                    while (true)
                    {
                        //Solicitamos a J2 que ingrese su elección
                        Console.WriteLine("J2 elija entre piedra, papel o tijera: ");
                        jugador2 = Console.ReadLine();

                        //Si J2 realiza un ingreso diferente al solicitado se le indica por pantalla
                        if (jugador2 != "piedra" && jugador2 != "papel" && jugador2 != "tijera")
                        {
                            Console.WriteLine("Sólo puede ingresar piedra, papel o tijera");
                        }

                        //Caso contrario se rompe el bucle
                        else
                        {
                            break;
                        }
                    }

                    //Si el ingreso de ambos jugadores es igual se considera empate
                    if (jugador1 == jugador2)
                    {
                        mensaje = "Empate";
                    }

                    //Si J1 elije piedra y J2 tijera o J1 elije papel y J2 piedra o J1 elije tijera y J2 papel el ganador de la ronda es J1
                    else if ((jugador1 == "piedra" && jugador2 == "tijera") || (jugador1 == "papel" && jugador2 == "piedra") || (jugador1 == "tijera" && jugador2 == "papel"))
                    {
                        mensaje = "J1 gana ronda";
                        contador1 += 1; //Se aumenta en uno el contador de J1
                    }
                    //Caso contrario el ganador de la ronda es J2
                    else
                    {
                        mensaje = "J2 gana ronda";
                        contador2 += 1; //se aumenta en uno el contador de J2
                    }

                    //Mostramos el mensaje del ganador de la ronda y el marcador general
                    Console.WriteLine(mensaje);
                    Console.WriteLine("Marcador: " + contador1 + " - " + contador2);

                    //Si el contador de J1 es mayor al contador de J2 y el contador de J1 es mayor o igual a 3
                    //El ganador es el jugador uno y se rompe el bucle
                    if (contador1 > contador2 && contador1 >= 3)
                    {
                        Console.WriteLine("J1 gana el juego");
                        Console.ReadKey();
                        break;
                    }
                    //Si el contador de J2 es mayor al contador de J1 y el contador de J2 es mayor o igual a 3
                    //El ganador es el jugador uno y se rompe el bucle
                    else if (contador2 > contador1 && contador2 >=3)
                    {
                        Console.WriteLine("J2 gana el juego");
                        Console.ReadKey();
                        break;
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("\nHa ocurrido un error, intente nuevamente.");
                }
            }
        }
    }
}
