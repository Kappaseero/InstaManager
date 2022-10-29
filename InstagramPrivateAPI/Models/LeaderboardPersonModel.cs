using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstagramPrivateAPI.Models
{
    internal class LeaderboardPersonModel
    {
        internal LeaderboardPersonModel(string name)
        {
            Name = name;
            Score = 0;
        }
        public int Score { get; set; }
        public string Name { get; set; }
    }
}
