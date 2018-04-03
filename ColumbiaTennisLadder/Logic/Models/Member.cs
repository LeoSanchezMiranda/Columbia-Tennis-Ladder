using System;

namespace ColumbiaTennisLadder.Logic.Models
{
    public class Member : Player {
        public string PhoneNumber { get; set; }
        public string NickName { get; set; }
        public string AvatarUrl { get; set; }
        public string Message { get; set; }
        public DateTime? Birthday { get; set; }
        public int MatchesWon { get; set; }
        public int MatchesLost { get; set; }
        public string Website { get; set; }
    }
}