# StringAllocationBenchmarks

This benchmark suite evaluates different string allocation and comparison techniques in C# using [BenchmarkDotNet](https://benchmarkdotnet.org/). It is designed for .NET 9 and demonstrates various approaches to string concatenation, comparison, and assignment.

## Benchmarked Methods

### String Concatenation
- **StringConcatOption1**: Concatenates strings using the `+` operator.
- **StringConcatOption2**: Concatenates strings using string interpolation (`$""`).
- **StringConcatOption3**: Concatenates strings using a `StringBuilder`.

### String Comparison
- **StringCompareOption1**: Compares two strings using `string.Compare`.
- **StringCompareOption2**: Compares two strings using `string.Equals`.
- **StringCompareOption3**: Checks if one string contains another using `string.Contains`.

### String Assignment
- **StringSetValueOption1**: Assigns a string value using `string.Empty`.
- **StringSetValueOption2**: Assigns a string value using an empty string literal (`""`).

## Prerequisites

- [.NET 9 SDK](https://dotnet.microsoft.com/download/dotnet/9.0)
- [BenchmarkDotNet](https://benchmarkdotnet.org/) NuGet package

## How to Run

1. Restore NuGet packages:
2. Build the solution:
3. Run the benchmarks:
> Ensure the `StringAllocationBenchmarks` class is included in your benchmark runner.

## Output

BenchmarkDotNet will generate a summary table showing the performance and memory usage of each method.

## References

- [BenchmarkDotNet Documentation](https://benchmarkdotnet.org/articles/overview.html)
- [C# String Handling](https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/strings/)

---

*This benchmark is intended for educational and comparative purposes to highlight the performance characteristics of different string operations in modern C#.*
