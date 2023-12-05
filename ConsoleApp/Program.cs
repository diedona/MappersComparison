using BenchmarkDotNet.Running;
using ConsoleApp;

var summary = BenchmarkRunner.Run<MappingBenchMark>();