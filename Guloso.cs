using System;
using System.Collections.Generic;
using System.Linq;

public class Guloso
{
    public static void Executar(List<int> numbers)
    {
        var result = guloso(numbers);

        string resultString = string.Join(", ", result);

        Console.WriteLine($"Elementos repetidos: {resultString}");
    }

    private static List<int> guloso(List<int> numbers)
    {
        List<int> repetidos = new List<int>();

        if (numbers.Count <= 1) return repetidos;

        numbers.Sort();
        var par = numbers.Where(n => n % 2 == 0).ToList();
        var impar = numbers.Where(n => n % 2 != 0).ToList();

        for (int i = 0; i < numbers.Count - 1; i++)
        {
            if (numbers[i] % 2 == 0)
            {
                par.Remove(numbers[i]);
                if (par.Contains(numbers[i]) && !repetidos.Contains(numbers[i]))
                {
                    repetidos.Add(numbers[i]);
                }
            }
            else
            {
                impar.Remove(numbers[i]);
                if (impar.Contains(numbers[i]) && !repetidos.Contains(numbers[i]))
                {
                    repetidos.Add(numbers[i]);
                }
            }
        }

        return repetidos;
    }
}
