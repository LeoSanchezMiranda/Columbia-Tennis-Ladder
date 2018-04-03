using ColumbiaTennisLadder.Logic.Models;
using ColumbiaTennisLadder.Logic.Models.Enums;
using NUnit.Framework;

namespace ColumbiaTennisLadder.Tests.ModelsTests
{
    public class ScoreModelTests : TestBase
    {
        private Score sut;

        protected override void Arrange()
        {
            base.Arrange();
            sut = new Score();
        }

        public class WhenIncreasingTheScoreForServer : ScoreModelTests
        {
            protected override void Act()
            {
                base.Act();
                sut.AddPointToServer();
            }

            public class AndScoreIsLove : WhenIncreasingTheScoreForServer {
                protected override void Arrange()
                {
                    base.Arrange();
                    sut.ServerScore = ScorePoint.Love;
                }

                [Test]
                public void ScoreShouldBeFifteen() {
                    Act();
                    Assert.AreEqual(ScorePoint.Fifteen, sut.ServerScore);
                }
            }

        }
    }
}
