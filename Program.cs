using System.Diagnostics;


class Program
{
    public static void Main(string[] args)
    {
        List<int> numbers = CreateInstanceProblem();

        
        AlgorithmTester("Divisão e Conquista", () => DivisaoConquista.Executar(numbers));
        AlgorithmTester("Guloso", () => Guloso.Executar(numbers));
        AlgorithmTester("Força bruta", () => ForcaBruta.Executar(numbers));
    }

    private static void AlgorithmTester(string nomeAlgoritmo, Action callBack)
    {
        Console.WriteLine($"Algoritmo: {nomeAlgoritmo}");
     

        var stopwatch = new Stopwatch();
        stopwatch.Start();
        var initMemory = GC.GetTotalMemory(true);

        callBack();

        var endMemory = GC.GetTotalMemory(true);

        stopwatch.Stop();

        var tempoExecucao = stopwatch.ElapsedMilliseconds;
        var consumoMemoria = (endMemory - initMemory); // Memória em KB

        Console.WriteLine($"Tempo de execução: {tempoExecucao}ms");
        Console.WriteLine($"Consumo de memória: {consumoMemoria} KB");
    }

    private static List<int> CreateInstanceProblem()
    {
        List<int> numbers = new List<int>();
        for (int i = 0; i <= 100000; i++)
        {
            numbers.Add(i);
        }
        return numbers;
    }

}
