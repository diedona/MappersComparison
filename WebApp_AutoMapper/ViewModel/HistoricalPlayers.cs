﻿namespace WebApp_AutoMapper.ViewModel
{
    public class HistoricalPlayers
    {
        public int YearSeries { get; set; }
        public IEnumerable<Player> Players { get; set; }
    }
}
