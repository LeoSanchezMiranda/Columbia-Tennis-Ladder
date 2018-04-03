using ColumbiaTennisLadder.Logic.Models;
using System.Collections.Generic;

namespace ColumbiaTennisLadder.Logic
{
    public interface IMembers
    {
        IEnumerable<Player> GetAllPlayers();
        Member GetMember(int memberId);
    }
}
