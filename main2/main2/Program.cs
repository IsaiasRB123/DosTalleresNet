using System;

class Usuario
{
    public string Nombre { get; set; }
    public int Edad { get; set; }

    public Usuario(string nombre, int edad)
    {
        Nombre = nombre;
        Edad = edad;
    }
}

class Cita
{
    public string Nombre { get; set; }
    public DateTime Fecha { get; set; }

    public Cita(string nombre, DateTime fecha)
    {
        Nombre = nombre;
        Fecha = fecha;
    }
}

class Program
{
    static void Main(string[] args)
    {
        
        Usuario[] usuarios = new Usuario[] {
            new Usuario("Juan", 30),
            new Usuario("María", 25),
            new Usuario("Carlos", 40)
        };

       
        Cita[] citas = new Cita[] {
            new Cita("Cita 1", new DateTime(2024, 5, 10)),
            new Cita("Cita 2", new DateTime(2024, 5, 15)),
            new Cita("Cita 3", new DateTime(2024, 5, 20))
        };

        
        Console.WriteLine("Usuarios:");
        foreach (var usuario in usuarios)
        {
            Console.WriteLine($"Nombre: {usuario.Nombre}, Edad: {usuario.Edad}");
        }

        
        Console.WriteLine("\nCitas:");
        foreach (var cita in citas)
        {
            Console.WriteLine($"Nombre: {cita.Nombre}, Fecha: {cita.Fecha}");
        }
    }
}

