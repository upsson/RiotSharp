using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RiotSharp
{
    public class ChampionKDA
    {
        public ChampionKDA()
        {
            Id = 0;
            Name = string.Empty;
            Imagen = string.Empty;
            MaxNumDeaths = 0;
            TotalDeathsPerSession = 0;
            MaxChampionsKilled = 0;
            TotalAssists = 0;
            totalChampionKills = 0;
            totalDoubleKills = 0;
            totalGoldEarned = "";
            totalMinionKills = 0;
            totalPentaKills = 0;
            totalQuadraKills = 0;
            totalSessionsLost = 0;
            totalSessionsPlayed = 0;
            totalSessionsWon = 0;
            totalTripleKills = 0;
            totalTurretsKilled = 0;
            KDA = "";

        }
        #region Properties
        public int Id { get; set; }
        public string Name { get; set; }
        public string Imagen { get; set; }
        public int MaxNumDeaths { get; set; }
        public int TotalDeathsPerSession { get; set; }
        public int MaxChampionsKilled { get; set; }
        public int TotalAssists { get; set; }
        public int totalChampionKills { get; set; }
        public int totalDoubleKills { get; set; }
        public string totalGoldEarned { get; set; }
        public int totalMinionKills { get; set; }
        public int totalPentaKills { get; set; }
        public int totalQuadraKills { get; set; }
        public int totalSessionsLost { get; set; }
        public int totalSessionsPlayed { get; set; }
        public int totalSessionsWon { get; set; }
        public int totalTripleKills { get; set; }
        public int totalTurretsKilled { get; set; }
        public string KDA { get; set; }
        #endregion
    }
}
