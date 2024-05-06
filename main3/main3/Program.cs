using System;

class ConversorDolar
{
    private double precioDolarAnterior;
    private double precioDolarActual;

    public ConversorDolar(double precioAnterior, double precioActual)
    {
        precioDolarAnterior = precioAnterior;
        precioDolarActual = precioActual;
    }

    public double ConvertirDolarAPeso(double cantidadDolares)
    {
      
        double tasaCambio = 3500;
        return cantidadDolares * tasaCambio;
    }

    public void ImprimirVariacion()
    {
        double variacion = ((precioDolarActual - precioDolarAnterior) / precioDolarAnterior) * 100;
        Console.WriteLine($"Variación del precio del dólar: {variacion}%");
    }
}

class Program
{
    static void Main(string[] args)
    {
        double precioAnterior = 3200; 
        double precioActual = 3500;

 
        ConversorDolar conversor = new ConversorDolar(precioAnterior, precioActual);


        double cantidadPesos = conversor.ConvertirDolarAPeso(100);
        Console.WriteLine($"100 dólares equivalen a {cantidadPesos} pesos colombianos");


        conversor.ImprimirVariacion();
    }
}

