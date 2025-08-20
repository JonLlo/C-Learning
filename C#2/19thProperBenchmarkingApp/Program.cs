using System.Text;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;

//RUNTHIS: dotnet run -c Release 


//benchmarking like this is better than using DateTime.Now: because its less noisy.
//It starts and stops a timner instead of using the outside date.time.
namespace ProperBenchmarking;

public class Program
{
    public static void Main(string[] args)
    {
        var summary = BenchmarkRunner.Run<StringAppendBenchmarks>();
    }
}

[MemoryDiagnoser]
public class StringAppendBenchmarks
{
    private int iterations = 1_000;

    [Benchmark]
    public void SlowTool()
    {
        string name = "";
        for (int i = 0; i < iterations; i++)
        {
            name += i;
        }
    }

    [Benchmark]
    public void QuickTool()
    {
        var sb = new StringBuilder();
        for (int i = 0; i < iterations; i++)
        {
            sb.Append(i);
        }
    }
}
