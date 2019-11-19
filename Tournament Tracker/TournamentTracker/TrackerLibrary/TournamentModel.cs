using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    public class TournamentModel
    {
        /// <summary>
        /// Represents Name of the Tournament
        /// </summary>
        public string TournamentName { get; set; }

        /// <summary>
        /// Represents the Entry Fee for the Tournament
        /// </summary>
        public decimal EntryFee { get; set; }
        
        /// <summary>
        /// Contains the List of Teams that have registered for this tournament.
        /// </summary>
        public List<TeamModel> EnteredTeams { get; set; }
        
        /// <summary>
        /// Contains the List of Prizes 
        /// </summary>
        public List<PrizeModel> Prizes { get; set; }
        
        /// <summary>
        /// Contains the List of Matchups each representing a round
        /// </summary>
        public List<List<MatchupModel>> Rounds { get; set; }
        
        /// <summary>
        /// Constructor for Tournament Model
        /// </summary>
        public TournamentModel()
        {
            EnteredTeams = new List<TeamModel>();
            Prizes = new List<PrizeModel>();
            Rounds = new List<List<MatchupModel>>();
        }
    }
}
