using Domain.Models;
using Riok.Mapperly.Abstractions;

namespace ConsoleApp.Mapperly
{
    [Mapper]
    public static partial class TeamMapper
    {
        public static partial ViewModel.Team MapTeam(Team team);
        public static partial ICollection<ViewModel.Team> MapTeams(ICollection<Team> teams);
    }
}
