using System;

class Program
{
    static void Main(string[] args)
    {
 
        Console.WriteLine("Ingrese las observaciones:");
        string observaciones = Console.ReadLine();

        observaciones = observaciones.Replace("@", "x").Replace("|", "x").Replace("&", "x");

        observaciones = observaciones.Replace("?", "").Replace("¿", "");

     
        observaciones = "init " + observaciones + " end";


        observaciones = observaciones.ToUpper();

       
        Console.WriteLine(observaciones);
    }
}
