using ColumbiaTennisLadder.Logic.Models.Enums;
using System;

namespace ColumbiaTennisLadder.Logic.Models
{
    public class Challenge {

        public Challenge() {
            Disposition = ChallengeDisposition.Pending;
        }

        public int ChallengeId { get; set; }
        public ChallengeDisposition Disposition { get; set; }
        public DateTime ChallengeIssuedDate { get; set; }
        public DateTime? ChallengeLastUpdate { get; set; }
        public MatchPlayer Challenger { get; set; }
        public MatchPlayer Defendant { get; set; }
        public Player LatestUpdatedBy { get; set; }
    }
}