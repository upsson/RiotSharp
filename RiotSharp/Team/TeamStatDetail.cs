﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace RiotSharp
{
    /// <summary>
    /// Team stats (Team API).
    /// </summary>
    public class TeamStatDetail
    {
        internal TeamStatDetail() { }

        /// <summary>
        /// Number of games played on average.
        /// </summary>
        [JsonProperty("averageGamesPlayed")]
        public int AverageGamesPlayed { get; set; }

        /// <summary>
        /// Full id of the team.
        /// </summary>
        [JsonProperty("fullId")]
        public string FullId { get; set; }

        /// <summary>
        /// Number of losses.
        /// </summary>
        [JsonProperty("losses")]
        public int Losses { get; set; }

        /// <summary>
        /// Type of team stat.
        /// </summary>
        [JsonProperty("teamStatType")]
        public string TeamStatType { get; set; }

        /// <summary>
        /// Number of wins.
        /// </summary>
        [JsonProperty("wins")]
        public int Wins { get; set; }
    }
}
