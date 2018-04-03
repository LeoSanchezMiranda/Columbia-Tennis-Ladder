using ColumbiaTennisLadder.Logic.Models.Enums;

namespace ColumbiaTennisLadder.Logic.Models
{
    public class Score
    {
        public Score() {
            ServerScore = ScorePoint.Love;
            ReceiverScore = ScorePoint.Love;
        }

        public ScorePoint ServerScore { get; set; }
        public ScorePoint ReceiverScore { get; set; }

        public void AddPointToServer() {
            var newScore = GetNewScore(ServerScore, ReceiverScore);

            ServerScore = newScore;

            if (newScore == ScorePoint.Deuce) {
                ReceiverScore = ScorePoint.Deuce;
            }

            if (newScore == ScorePoint.Advantage) {
                ReceiverScore = ScorePoint.Disadvantage;
            }

        }

        public void AddPointToReceiver() {
            var newScore = GetNewScore(ReceiverScore, ServerScore);

            ReceiverScore = newScore;

            if (newScore == ScorePoint.Deuce)
            {
                ServerScore = ScorePoint.Deuce;
            }

            if (newScore == ScorePoint.Advantage)
            {
                ServerScore = ScorePoint.Disadvantage;
            }
        }

        private ScorePoint GetNewScore(ScorePoint scoreIncreasing, ScorePoint otherScore) {
            if (scoreIncreasing == ScorePoint.Game || scoreIncreasing == ScorePoint.Game)
            {
                return ScorePoint.Game;
            }

            if (scoreIncreasing > ScorePoint.Thirty)
            {
                if (scoreIncreasing == ScorePoint.Deuce)
                {
                    return ScorePoint.Advantage;
                }

                if (otherScore < scoreIncreasing)
                {
                    return ScorePoint.Game;
                }                

                return ScorePoint.Deuce;
            }            

            return scoreIncreasing + 1;
        }


    }
}