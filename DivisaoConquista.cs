using System;
using System.Collections.Generic;

public class DivisaoConquista
{
    public static void Executar(List<int> numbers)
    {
        var result = divisaoConquista(numbers);

        string resultString = string.Join(", ", result);

        Console.WriteLine($"Elementos repetidos: {resultString}");
    }

    private static List<int> divisaoConquista(List<int> numbers)
    {
        List<int> repetidos = new List<int>();

        if (numbers.Count <= 1) return repetidos;

        int mid = numbers.Count / 2;

        var left = numbers.GetRange(0, mid);
        var right = numbers.GetRange(mid, numbers.Count - mid);

        var leftRepetidos = divisaoConquista(left);
        var rightRepetidos = divisaoConquista(right);

        repetidos.AddRange(leftRepetidos);
        repetidos.AddRange(rightRepetidos);

        HashSet<int> tableLeft = new HashSet<int>(left);
        foreach (var numberRight in right)
        {
            if (tableLeft.Contains(numberRight) && !repetidos.Contains(numberRight))
            {
                repetidos.Add(numberRight);
            }
        }

        return repetidos;
    }
}
