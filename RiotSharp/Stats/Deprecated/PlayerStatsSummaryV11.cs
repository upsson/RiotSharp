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
    /// Stats summary of a player (Stats API).
    /// </summary>
    [Obsolete("The stats api v1.1 is deprecated, please use PlayerStatsSummary instead.")]
    public class PlayerStatsSummaryV11
    {
        internal PlayerStatsSummaryV11() { }

        /// <summary>
        /// List of aggregated stats.
        /// </summary>
        [JsonProperty("aggregatedStats")]
        public List<AggregatedStatV11> AggregatedStats { get; set; }

        /// <summary>
        /// Number of losses for this queue type. Returned for ranked queue types only.
        /// </summary>
        [JsonProperty("losses")]
        public int Losses { get; set; }

        /// <summary>
        /// Date stats were last modified specified as epoch milliseconds.
        /// </summary>
        [JsonProperty("modifyDate")]
        [JsonConverter(typeof(DateTimeConverter))]
        public DateTime ModifyDate { get; set; }

        /// <summary>
        /// Human readable string representing date stats were last modified.
        /// </summary>
        [JsonProperty("modifyDateStr")]
        public string ModifyDateString { get; set; }

        /// <summary>
        /// Player stats summary type.
        /// </summary>
        [JsonProperty("playerStatSummaryType")]
        [JsonConverter(typeof(PlayerStatsSummaryTypeConverter))]
        public PlayerStatsSummaryType PlayerStatSummaryType { get; set; }

        /// <summary>
        /// Number of wins for this queue type.
        /// </summary>
        [JsonProperty("wins")]
        public int Wins { get; set; }
    }
}
