namespace bowling_game
{
    public class BowlingGame
    {
        public List<IFrame> frames;
        public List<int> throws;

        /// <summary>
        /// frame represent the 10 frames that we have
        /// throws represent the total throws in the game - Maximum of 21 throws are possible
        /// </summary>
        public BowlingGame()
        {
            frames = new List<IFrame>();
            throws = new List<int>();
        }

        /// <summary>
        /// An Open frame where the sum of first and second throw is less than 10
        /// </summary>
        /// <param name="firstThrow"></param>
        /// <param name="secondThrow"></param>
        public void Open(int firstThrow, int secondThrow)
        {
            frames.Add(new OpenFrame(throws,firstThrow, secondThrow));
        }

        /// <summary>
        /// A spare frame where the sum of first and second throw is equal to 10
        /// </summary>
        /// <param name="firstThrow"></param>
        /// <param name="secondThrow"></param>
        public void Spare(int firstThrow, int secondThrow)
        {
            frames.Add(new SpareFrame(throws, firstThrow, secondThrow));
        }

        /// <summary>
        /// A strike frame where all 10 pins rolled in 1 throw
        /// </summary>
        public void Strike()
        {
            frames.Add(new StrikeFrame(throws));
        }

        /// <summary>
        /// This method is only for the last frame as there can be one or two extra throws  
        /// </summary>
        /// <param name="firstThrow"></param>
        public void Bonus(int firstThrow)
        {
            frames.Add(new BonusRoll(throws, firstThrow));
        }

        public int Score()
        {
            int total = 0;
            foreach(IFrame frame in frames)
            {
                total += frame.Score();
            }
            return total;
        }
    }
}