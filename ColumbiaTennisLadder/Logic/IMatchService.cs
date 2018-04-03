using ColumbiaTennisLadder.Logic.Models;
using System.Collections.Generic;

namespace ColumbiaTennisLadder.Logic
{
    public interface IMatchService
    {
        IEnumerable<TennisMatch> GetAllMatches();
        IEnumerable<TennisMatch> GetPlayerMatches(int playerId);
        TennisMatch GetMatch(int matchId);
        void UpsertMatch(TennisMatch match);
    }
}
