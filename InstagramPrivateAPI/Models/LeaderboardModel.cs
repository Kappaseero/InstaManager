using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstagramPrivateAPI.Models
{
    internal class LeaderboardModel
    {
        internal LeaderboardModel(SortedList<int, LeaderboardPersonModel> sortedList)
        {
            LeaderboardList = sortedList;
        }
        public SortedList<int, LeaderboardPersonModel> LeaderboardList { get; set; }
    }
}
