using AutoMapper;
using ConsoleApp.ViewModel;

namespace ConsoleApp.Automapper
{
    public class TeamProfile : Profile
    {
        public TeamProfile()
        {
            CreateMap<Domain.Models.Player, Player>();
            CreateMap<Domain.Models.LeagueName, LeagueName>();
            CreateMap<Domain.Models.League, League>();
            CreateMap<Domain.Models.HistoricalPlayers, HistoricalPlayers>();
            CreateMap<Domain.Models.TeamIdentificator, TeamIdentificator>();
            CreateMap<Domain.Models.TeamIdentificator, TeamIdentificator>();
            CreateMap<Domain.Models.Team, Team>();
        }
    }
}
