using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstaManagerLibrary.Models
{
    public abstract class LeaderboardBase
    {
        public abstract List<LeaderboardPersonModel>? Leaderboard { get; set; }

        public abstract bool Save();
        public abstract bool Load();
        public abstract bool Delete();
    }
}
