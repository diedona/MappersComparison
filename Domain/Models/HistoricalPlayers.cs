namespace Domain.Models
{
    public class HistoricalPlayers
    {
        public int YearSeries { get; set; }
        public IEnumerable<Player> Players { get; set; }
    }
}
