
using System;

namespace Dominio_DDD_Email_ValueObjects
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("-----------------------------------------------------");
            Console.WriteLine("Trabajo Practico de Laboratorio de Software");
            Console.WriteLine("Proyecto Hotel: Prueba Unitaria Capa Dominio ValueObjects Email");
            Console.WriteLine();
            Console.WriteLine("Profesor: Daniel Alejandro Fernandez");
            Console.WriteLine("Alumnos: Julia Avalos");
            Console.WriteLine("         Leonardo Caceres");
            Console.WriteLine("         Eduardo Arizza");
            Console.WriteLine("         Gonzalo Arizza");
            Console.WriteLine("         Omar Bazar");
            Console.WriteLine("-----------------------------------------------------");
            Console.WriteLine();

            // Ejemplo de uso de la clase Email:
            try
            {
                string emailString = "ejemplo@dominio.com";
                Email email = new Email(emailString);
                Console.WriteLine($"El email '{email.Valor()}' es válido.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }

            Console.WriteLine("Presione cualquier tecla para salir.");
            Console.ReadKey();
        }
    }
}
