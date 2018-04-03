using System.Collections.Generic;

namespace ColumbiaTennisLadder.Logic.Models
{
    public class TennisMatch
    {
        public int MatchId { get; set; }
        public IEnumerable<MatchPlayer> Players { get; set; }
        public IEnumerable<TennisSet> Sets { get; set; }
    }
}