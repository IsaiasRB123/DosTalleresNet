using System;
using System.Collections.Generic;

class Venta
{
    public string Codigo { get; set; }
    public string Nombre { get; set; }
    public double Precio { get; set; }
    public int Cantidad { get; set; }

    public Venta(string codigo, string nombre, double precio, int cantidad)
    {
        Codigo = codigo;
        Nombre = nombre;
        Precio = precio;
        Cantidad = cantidad;
    }

    public double CalcularValorPagar()
    {
        if (Precio <= 0 || Cantidad <= 0)
        {
            throw new ArgumentException("El precio y la cantidad deben ser mayores que 0.");
        }

        double valorBruto = Precio * Cantidad;

        if (Cantidad > 10)
        {
            valorBruto *= 0.9; // Aplicar descuento del 10% si la cantidad es > 10
        }

        double valorIVA = valorBruto * 0.19; // Calcular el valor del IVA (19%)

        return valorBruto + valorIVA;
    }
}

class Program
{
    static List<string> documentos = new List<string>();
    static List<string> nombres = new List<string>();
    static List<int> inasistencias = new List<int>();

    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("--------------------MENÚ---------------------");
            Console.WriteLine("1. Registrar inasistencias");
            Console.WriteLine("2. Listar todas las inasistencias");
            Console.WriteLine("3. Listar los aprendices con inasistencias superiores a 3");
            Console.WriteLine("4. Consultar el total de inasistencias por aprendiz");
            Console.WriteLine("5. Valor a pagar");
            Console.WriteLine("6. Número de suerte");
            Console.WriteLine("7. Salir");
            Console.WriteLine("----------------Digite la opción---------------");

            int opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    RegistrarInasistencias();
                    break;
                case 2:
                    ListarTodasInasistencias();
                    break;
                case 3:
                    ListarInasistenciasMayores();
                    break;
                case 4:
                    ConsultarTotalInasistencias();
                    break;
                case 5:
                    CalcularValorPagar();
                    break;
                case 6:
                    GenerarNumeroSuerte();
                    break;
                case 7:
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Opción no válida. Por favor, seleccione otra opción.");
                    break;
            }
        }
    }

    static void RegistrarInasistencias()
    {
        Console.WriteLine("Digite el documento del aprendiz:");
        string documento = Console.ReadLine();

        if (documentos.Contains(documento))
        {
            Console.WriteLine("Digite la cantidad de inasistencias:");
            int inasistencia = int.Parse(Console.ReadLine());
            if (inasistencia < 1 || inasistencia > 100)
            {
                Console.WriteLine("La cantidad de inasistencias debe estar entre 1 y 100.");
                return;
            }
            int index = documentos.IndexOf(documento);
            inasistencias[index] = inasistencia;
            Console.WriteLine("Inasistencias actualizadas.");
        }
        else
        {
            Console.WriteLine("Digite el nombre completo del aprendiz:");
            string nombre = Console.ReadLine();
            Console.WriteLine("Digite la cantidad de inasistencias:");
            int inasistencia = int.Parse(Console.ReadLine());
            if (inasistencia < 1 || inasistencia > 100)
            {
                Console.WriteLine("La cantidad de inasistencias debe estar entre 1 y 100.");
                return;
            }
            documentos.Add(documento);
            nombres.Add(nombre);
            inasistencias.Add(inasistencia);
            Console.WriteLine("Inasistencias registradas.");
        }
    }

    static void ListarTodasInasistencias()
    {
        Console.WriteLine("-----------Lista de todas las inasistencias------------");
        for (int i = 0; i < documentos.Count; i++)
        {
            Console.WriteLine($"Estudiante Registrado #{i + 1}:");
            Console.WriteLine($"Documento: {documentos[i]}");
            Console.WriteLine($"Nombre: {nombres[i]}");
            Console.WriteLine($"Inasistencias: {inasistencias[i]}\n");
        }
    }

    static void ListarInasistenciasMayores()
    {
        Console.WriteLine("--------Lista de inasistencias mayores a 3---------");
        for (int i = 0; i < documentos.Count; i++)
        {
            if (inasistencias[i] > 3)
            {
                Console.WriteLine($"Documento: {documentos[i]}");
                Console.WriteLine($"Nombre: {nombres[i]}");
                Console.WriteLine($"Inasistencias: {inasistencias[i]}\n");
            }
        }
    }

    static void ConsultarTotalInasistencias()
    {
        Console.WriteLine("Digite el documento del aprendiz:");
        string documento = Console.ReadLine();
        if (documentos.Contains(documento))
        {
            int index = documentos.IndexOf(documento);
            Console.WriteLine($"Total de inasistencias para el aprendiz {nombres[index]}: {inasistencias[index]}");
        }
        else
        {
            Console.WriteLine("El documento no está registrado.");
        }
    }

    static void CalcularValorPagar()
    {
        Console.WriteLine("Ingrese el código del producto:");
        string codigo = Console.ReadLine();
        Console.WriteLine("Ingrese el nombre del producto:");
        string nombre = Console.ReadLine();
        Console.WriteLine("Ingrese el precio del producto:");
        double precio = double.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese la cantidad del producto:");
        int cantidad = int.Parse(Console.ReadLine());

        try
        {
            Venta venta = new Venta(codigo, nombre, precio, cantidad);
            double valorPagar = venta.CalcularValorPagar();
            Console.WriteLine($"El valor a pagar es: ${valorPagar.ToString("0.00")}");
        }
        catch (Exception e)
        {
            Console.WriteLine($"Error: {e.Message}");
        }
    }

    static void GenerarNumeroSuerte()
    {
        Random random = new Random();
        int numeroSuerte = random.Next(1000);
        string numeroSuerteStr = numeroSuerte.ToString().PadLeft(3, '0');
        Console.WriteLine($"Tu número de la suerte es: {numeroSuerteStr}");
    }
}
