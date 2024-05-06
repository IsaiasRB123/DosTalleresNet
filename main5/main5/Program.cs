using System;

class Program
{
    static void Main(string[] args)
    {
        // Solicitar al usuario que ingrese su nombre
        Console.Write("Por favor, ingresa tu nombre: ");
        string nombre = Console.ReadLine();

        // Mostrar cada letra separada por un espacio
        Console.WriteLine("Tu nombre separado por espacios:");
        foreach (char letra in nombre)
        {
            Console.Write(letra + " ");
        }
    }
}

