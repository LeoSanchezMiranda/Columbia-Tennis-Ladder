using ColumbiaTennisLadder.Logic.Models;

namespace ColumbiaTennisLadder.Logic
{
    public interface IChallengeService
    {
        Challenge CreateChallenge(MatchPlayer challenger, MatchPlayer defendant);
        Challenge AcceptChallenge(MatchPlayer defendant, int challengeId);
        Challenge RefuseChallenge(MatchPlayer defendant, int challengeId, string reason);
        Challenge CancelChallenge(Player cancellingMember, int challengeId, string reason);
    }
}
