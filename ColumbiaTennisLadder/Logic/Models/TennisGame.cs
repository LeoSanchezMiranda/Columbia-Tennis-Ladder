using System.Collections.Generic;

namespace ColumbiaTennisLadder.Logic.Models
{
    public class TennisGame
    {
        public MatchPlayer ServingPlayer { get; set; }
        public List<Score> Scores { get; set; }
    }
}