using Domain.Models;
using Riok.Mapperly.Abstractions;

namespace ConsoleApp.Mapperly
{
    [Mapper]
    [UseStaticMapper(typeof(LeagueNameMapper))]
    public static partial class TeamMapper
    {
        public static partial ViewModel.Team MapTeam(Team team);
        public static partial ICollection<ViewModel.Team> MapTeams(ICollection<Team> teams);
    }

    [Mapper]
    public static partial class LeagueNameMapper
    {
        private static partial ViewModel.LeagueName PrivateMapLeagueName(LeagueName leagueName);

        public static ViewModel.LeagueName MapLeagueName(LeagueName leagueName)
        {
            var viewmodel = PrivateMapLeagueName(leagueName);
            viewmodel.ShortDeclaredName = viewmodel.DeclaredName[..3].ToUpper();
            return viewmodel;
        }
    }
}
