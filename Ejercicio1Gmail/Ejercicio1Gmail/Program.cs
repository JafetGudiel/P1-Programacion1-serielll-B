using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1Gmail
{
    internal class Program
    {
        static void Main(string[] args)
        {
                Console.Write("Por favor ingresa tu correo electrónico: ");
                string correoIngresado = Console.ReadLine();

                string correoFinal = CorreoModificado(correoIngresado);

                Console.WriteLine($"El correo electrónico generado es: {correoFinal}");
                Console.ReadLine();
            }

            public static string CorreoModificado(string correoIngresado)
            {
                if (correoIngresado.EndsWith("@miumg.edu.gt"))
                {
                    return correoIngresado;
                }
                else
                {
                    string[] partesCorreo = correoIngresado.Split('@');
                    if (partesCorreo.Length == 2)
                    {
                        return $"{partesCorreo[0]}@miumg.edu.gt";
                    }
                    else
                    {
                        return "Correo electrónico no válido";
                    }
                }
            }
        }


    }


