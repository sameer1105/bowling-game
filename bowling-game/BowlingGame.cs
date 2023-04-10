using System.Runtime.Versioning;

namespace bowling_game
{
    public class BowlingGame
    {
        public List<Frame> frames;
        public List<int> throws;
        public int frameCount;
        /// <summary>
        /// frame represent the 10 frames that we have
        /// throws represent the total throws in the game - Maximum of 21 throws are possible
        /// </summary>
        public BowlingGame()
        {
            frames = new List<Frame>();
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
            frameCount++;
        }

        /// <summary>
        /// A spare frame where the sum of first and second throw is equal to 10
        /// </summary>
        /// <param name="firstThrow"></param>
        /// <param name="secondThrow"></param>
        public void Spare(int firstThrow, int secondThrow)
        {
            frames.Add(new SpareFrame(throws, firstThrow, secondThrow));
            frameCount++;
        }

        /// <summary>
        /// A strike frame where all 10 pins rolled in 1 throw
        /// </summary>
        public void Strike()
        {
            frames.Add(new StrikeFrame(throws));
            frameCount++;
        }

        /// <summary>
        /// This method is only for the last frame as there can be one or two extra throws  
        /// </summary>
        /// <param name="firstThrow"></param>
        public void Bonus(int firstThrow)
        {
            frames.Add(new BonusRoll(throws, firstThrow, frameCount));
         
        }

        public int Score()
        {
            int total = 0;
            foreach(Frame frame in frames)
            {
                total += frame.Score();
            }
            return total;
        }
    }
}