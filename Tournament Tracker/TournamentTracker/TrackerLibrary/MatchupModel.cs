using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    public class MatchupModel
    {
        /// <summary>
        /// Represents the list of Matchup Entries (Teams that participated in this matchup) 
        /// </summary>
        public List<MatchupEntryModel> Entries { get; set; }

        /// <summary>
        /// Represents the Winning Team in this Matchup
        /// </summary>
        public TeamModel Winner { get; set; }
        
        /// <summary>
        /// Represents the round in which this matchup happened
        /// </summary>
        public int MatchupRound { get; set; }
        
        /// <summary>
        /// Constructor for MatchupModel
        /// </summary>
        public MatchupModel()
        {
            Entries = new List<MatchupEntryModel>();
        }
    }
}