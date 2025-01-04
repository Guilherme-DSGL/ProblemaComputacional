using System;
using System.Collections.Generic;

public class ForcaBruta
{
    public static void Executar(List<int> numbers)
    {
        var result = forcaBruta(numbers);

        string resultString = string.Join(", ", result);

        Console.WriteLine($"Elementos repetidos: {resultString}");

    }

    private static List<int> forcaBruta(List<int> numbers)
    {
        List<int> repeated = new List<int>();

        if (numbers.Count <= 1) return repeated;

        for (int i = 0; i < numbers.Count; i++)
        {
            for (int j = i + 1; j < numbers.Count; j++)
            {
                if (numbers[i] == numbers[j] && !repeated.Contains(numbers[i]))
                {
                    repeated.Add(numbers[i]);
                }
            }
        }

        return repeated;
    }
}