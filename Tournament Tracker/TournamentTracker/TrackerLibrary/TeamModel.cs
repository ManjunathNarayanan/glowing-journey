using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    public class TeamModel
    {
        /// <summary>
        /// List of Persons who are playing for this team
        /// </summary>
        public List<PersonModel> TeamMembers { get; set;}

        /// <summary>
        /// Represents the Name of the team
        /// </summary>
        public string TeamName { get; set; }
        
        /// <summary>
        /// Constructor for TeamModel
        /// </summary>
        public TeamModel()
        {
            TeamMembers = new List<PersonModel>();
        } 
    }
}
