namespace DotNetPerformanceComparison.Benchmarks;

[MemoryDiagnoser]
public class StringAllocationBenchmarks
{
    private readonly string SampleText = "BenchmarkDotNet is powerful!";

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

    [Benchmark]
    public string StringConcatOption3()
    {
        StringBuilder sb = new();
        sb.Append("Benchmark");
        sb.Append("DotNet");
        sb.Append(SampleText);
        return sb.ToString();
    }

    /// <summary>
    /// Compares two strings using string.Compare method.
    /// </summary>
    /// <returns></returns>
    [Benchmark]
    public string StringCompareOption1()
    {
        return string.Compare("Benchmark", "DotNet") == 0 ? SampleText : "Not Equal";
    }

    /// <summary>
    /// Compares two strings using string.Equals method.
    /// </summary>
    /// <returns></returns>
    [Benchmark]
    public string StringCompareOption2()
    {
        return "Benchmark".Equals("DotNet") ? SampleText : "Not Equal";
    }

    /// <summary>
    /// Compares two strings using string.Contains method.
    /// </summary>
    /// <returns></returns>
    [Benchmark]
    public string StringCompareOption3()
    {
        return "Benchmark".Contains("DotNet") ? SampleText : "Not Equal";
    }

    /// <summary>
    /// Sets a string value using an empty string literal. 
    /// </summary>
    [Benchmark]
    public void StringSetValueOption1()
    {
        string value = string.Empty;
        value = "BenchmarkDotNet is powerful!";
    }

    /// <summary>
    /// Sets a string value using an empty string literal.
    /// </summary>
    [Benchmark]
    public void StringSetValueOption2()
    {
        string value = "";
        value = "BenchmarkDotNet is powerful!";
    }
}
