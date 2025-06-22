using BenchmarkDotNet.Attributes;

namespace DotNetPerformanceComparison.Benchmarks;

[MemoryDiagnoser]
public class StringAllocationBenchmarks
{
    private const string SampleText = "BenchmarkDotNet is powerful!";

    [Benchmark]
    public string StringConcatOption1()
    {
        return "Benchmark" + "DotNet" + SampleText;
    }

    [Benchmark]
    public string StringConcatOption2()
    {
        return $"Benchmark DotNet {SampleText}";
    }
}
