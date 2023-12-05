using AutoMapper;
using BenchmarkDotNet.Attributes;
using Domain;

namespace ConsoleApp
{
    [MemoryDiagnoser]
    public class MappingBenchMark
    {
        private IMapper _autoMapper;
        private ICollection<Domain.Models.Team> _teams;

        [GlobalSetup]
        public void Setup()
        {
            _teams = new FakerRepository().GetTeams();
            _autoMapper = GetAutoMapper();
        }

        private IMapper GetAutoMapper()
        {
            var config = new MapperConfiguration(cfg => {
                cfg.AddMaps(typeof(Program).Assembly);
            });

            return config.CreateMapper();
        }

        [Benchmark]
        public ICollection<ViewModel.Team> AutoMapper() 
        {
            return _autoMapper.Map<ICollection<ViewModel.Team>>(_teams);
        }

        [Benchmark]
        public ICollection<ViewModel.Team> Mapperly()
        {
            return [];
        }
    }
}
