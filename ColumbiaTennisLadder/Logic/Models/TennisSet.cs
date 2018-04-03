using System.Collections.Generic;

namespace ColumbiaTennisLadder.Logic.Models
{
    public  class TennisSet
    {
        public int DefenderGames { get; set; }
        public int ChallengerGames { get; set; }
        public IEnumerable<TennisGame> games { get; set; }
    }
}