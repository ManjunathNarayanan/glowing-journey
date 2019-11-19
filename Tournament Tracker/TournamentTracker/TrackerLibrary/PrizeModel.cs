using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    public class PrizeModel
    {
        /// <summary>
        /// Represnts the Place number or Rank of the Prize
        /// </summary>
        public int PlaceNumber { get; set; }

        /// <summary>
        /// Represents the Name for the place for which this prize is created
        /// </summary>
        public string PlaceName { get; set; }
        
        /// <summary>
        /// Represents the Prize Amount 
        /// </summary>
        public decimal PrizeAmount { get; set; }
        
        /// <summary>
        /// Represents the Percentage of Tournament income that shall be awarded for the given place.
        /// This is considered in place for Prize Amount
        /// </summary>
        public double PrizePercentage { get; set; }
    }
}
