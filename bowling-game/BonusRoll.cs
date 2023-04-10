using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bowling_game
{
    public class BonusRoll : Frame
    {
        private readonly int frameCount;

        public BonusRoll(List<int> throws, int firstThrow, int frameCount) : base(throws)
        {
            throws.Add(firstThrow);
            this.frameCount = frameCount;
        }

        public override int Score()
        {
            if(frameCount != 10)
            {
                return throws[startingIndex];
            }
            return 0;
        }
    }
}
