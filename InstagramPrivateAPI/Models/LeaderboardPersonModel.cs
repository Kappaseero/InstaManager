using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstaManagerLibrary.Models
{
    public class LeaderboardPersonModel
    {
        public LeaderboardPersonModel(string name)
        {
            Name = name;
            Score = 0;
        }
        public int Score { get; set; }
        public string Name { get; set; }
    }
}
