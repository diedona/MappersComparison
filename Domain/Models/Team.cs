namespace Domain.Models
{
    public class Team
    {
        public Guid Id { get; set; }
        public TeamIdentificator Identificator { get; set; }
        public IEnumerable<HistoricalPlayers> HistoricalPlayers { get; set; }
        public IEnumerable<Player> CurrentPlayers { get; set; }
        public League League { get; set; }
    }
}
