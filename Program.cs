using BenchmarkDotNet.Running;
using DotNetPerformanceComparison.Benchmarks;

Console.WriteLine("Hello, World!");

BenchmarkRunner.Run<StringAllocationBenchmarks>();