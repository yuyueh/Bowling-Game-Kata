namespace BowlingGameKata
{
    public class BowlingGame
    {
        private int _score = 0;

        public BowlingGame()
        {
        }

        public void Roll(int pins)
        {
            _score += pins;
        }

        public int Score()
        {
            return _score;
        }
    }
}