using System;

class Program
{
    static void Main(string[] args)
    {
        
        int n = 10;

        
        double[] numeros = new double[n];

        
        Random random = new Random();
        for (int i = 0; i < n; i++)
        {
            numeros[i] = random.NextDouble() * 100; 
        }

       
        Console.WriteLine("Array en desorden:");
        ImprimirArray(numeros);


        OrdenarAscendente(numeros);

    
        Console.WriteLine("\nArray ordenado ascendente:");
        ImprimirArray(numeros);
    }

    static void ImprimirArray(double[] array)
    {
        foreach (var numero in array)
        {
            Console.WriteLine(numero);
        }
    }

    static void OrdenarAscendente(double[] array)
    {
        for (int i = 0; i < array.Length - 1; i++)
        {
            for (int j = i + 1; j < array.Length; j++)
            {
                if (array[i] > array[j])
                {
                    
                    double temp = array[i];
                    array[i] = array[j];
                    array[j] = temp;
                }
            }
        }
    }
}

