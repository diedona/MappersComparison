using BenchmarkDotNet.Running;
using ConsoleApp;

var summary = BenchmarkRunner.Run<MappingBenchMark>();
//var teams = new FakerRepository().GetTeams();
//var teamsViewModel = TeamMapper.MapTeams(teams);
//Console.WriteLine("ok");