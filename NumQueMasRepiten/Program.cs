using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static List<int> NumerosMasRepetidos(List<int> numeros)
    {
        Dictionary<int, int> contador = new Dictionary<int, int>();

        // Contar la frecuencia de cada número
        foreach (int num in numeros)
        {
            if (contador.ContainsKey(num))
                contador[num]++;
            else
                contador[num] = 1;
        }

        // Encontrar la frecuencia máxima
        int maxRepeticiones = contador.Values.Max();

        // Obtener los números que se repiten con mayor frecuencia
        List<int> numerosMasRepetidos = contador.Where(pair => pair.Value == maxRepeticiones)
                                                .Select(pair => pair.Key)
                                                .ToList();
        return numerosMasRepetidos;
    }

    static void Main()
    {
        // Generar un array de números aleatorios
        Random random = new Random();
        List<int> numeros = Enumerable.Range(1, 100)
                                      .Select(i => random.Next(1, 11)) // Números aleatorios entre 1 y 10
                                      .ToList();

        Console.WriteLine("Array original:");
        Console.WriteLine(string.Join(" ", numeros));

        // Encontrar los números que más se repiten
        List<int> numerosRepetidos = NumerosMasRepetidos(numeros);

        Console.WriteLine("Números que más se repiten:");
        foreach (int num in numerosRepetidos)
        {
            Console.Write(num + " ");
        }
    }
}
