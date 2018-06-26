namespace BowlingGameKata
{
    public class BowlingGame
    {
        private int _score;

        public int Score()
        {
            return _score;
        }

        public void Roll(int pins)
        {
            _score += pins;
        }
    }
}
