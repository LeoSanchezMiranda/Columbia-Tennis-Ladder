using ColumbiaTennisLadder.Logic.Models.Enums;

namespace ColumbiaTennisLadder.Logic.Models
{
    public class MatchPlayer : Player{
        public MatchPlayerType type { get; set; }
    }
}