using AutoMapper;
using ConsoleApp.ViewModel;

namespace ConsoleApp.Automapper
{
    public class TeamProfile : Profile
    {
        public TeamProfile()
        {
            CreateMap<Domain.Models.Player, Player>()
                .ForMember(x => x.CallerName, opt => opt.MapFrom(src => src.Nickname));

            CreateMap<Domain.Models.LeagueName, LeagueName>()
                .ForMember(x => x.ShortDeclaredName, opt => opt.MapFrom(src => src.DeclaredName.Substring(0, 3).ToUpper()));

            CreateMap<Domain.Models.League, League>();
            CreateMap<Domain.Models.HistoricalPlayers, HistoricalPlayers>();
            CreateMap<Domain.Models.TeamIdentificator, TeamIdentificator>();
            CreateMap<Domain.Models.TeamIdentificator, TeamIdentificator>();
            CreateMap<Domain.Models.Team, Team>();
        }
    }
}
