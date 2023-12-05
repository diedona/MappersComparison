using Bogus;
using Domain.Models;

namespace Domain
{
    public class FakerRepository
    {
        private readonly Faker<Team> _fakerTeam;

        public const int NUMBER_OF_TEAMS = 10000;
        public const int SEED = 155039;

        public FakerRepository()
        {
            var identificator = new Faker<TeamIdentificator>()
                .RuleFor(p => p.Serial, f => f.Random.Uuid().ToString())
                .RuleFor(p => p.Name, f => f.Name.FirstName())
                .UseSeed(SEED);

            var player = new Faker<Player>()
                .RuleFor(p => p.Name, f => f.Name.FullName())
                .RuleFor(p => p.Nickname, f => f.Name.LastName())
                .RuleFor(p => p.DateOfBirth, f => f.Date.PastDateOnly(19))
                .RuleFor(p => p.Id, f => f.Random.Int(1))
                .UseSeed(SEED);

            var historicalPlayer = new Faker<HistoricalPlayers>()
                .RuleFor(p => p.YearSeries, f => f.Random.Int(2002, 2025))
                .RuleFor(p => p.Players, player.GenerateBetween(3, 5))
                .UseSeed(SEED);

            var leagueName = new Faker<LeagueName>()
                .RuleFor(p => p.DeclaredName, f => f.Name.FullName())
                .RuleFor(p => p.HistoricalName, f => f.Name.FullName())
                .UseSeed(SEED);

            var league = new Faker<League>()
                .RuleFor(p => p.Id, f => f.Random.Int(1))
                .RuleFor(p => p.Name, f => leagueName.Generate())
                .UseSeed(SEED);

            _fakerTeam = new Faker<Team>()
                .RuleFor(p => p.Id, f => f.Random.Guid())
                .RuleFor(p => p.Identificator, identificator.Generate())
                .RuleFor(p => p.CurrentPlayers, player.Generate(22))
                .RuleFor(p => p.HistoricalPlayers, historicalPlayer.GenerateBetween(1, 3))
                .RuleFor(p => p.League, league.Generate())
                .UseSeed(SEED);
        }

        public ICollection<Team> GetTeams()
        {
            return _fakerTeam.Generate(NUMBER_OF_TEAMS);
        }
    }
}
