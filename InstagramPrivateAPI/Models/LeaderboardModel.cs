using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstaManagerLibrary.Models
{
    public class LeaderboardModel : LeaderboardBase
    {
        public LeaderboardModel(InstaMain instaMain)
        {
            InstaMain = instaMain;
        }
        public override List<LeaderboardPersonModel>? Leaderboard { get; set; }
        private InstaMain InstaMain { get; }

        /// <summary>
        /// Saves the leaderboard data to the local database table.
        /// </summary>
        /// <returns>True if successful.</returns>
        public override bool Save()
        {
            bool success = false;
            if (success)
            {
                return true;
            }
            else
                return false;
        }

        /// <summary>
        /// Creates a leaderboard from the local database table.
        /// </summary>
        /// <returns>True if successful.</returns>
        public override bool Load()
        {
            if (Leaderboard != null)
            {
                return true;
            }
            else
                return false;
        }

        /// <summary>
        /// Empties the leaderboard table from the local database.
        /// </summary>
        /// <returns>True if successful.</returns>
        public override bool Delete()
        {
            bool success = false;
            if (success)
            {
                return true;
            }
            else
                return false;
        }

    }
}
