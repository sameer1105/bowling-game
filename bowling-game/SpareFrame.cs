using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bowling_game
{
    public class SpareFrame : Frame
    {
        public SpareFrame(List<int> throws, int firstThrow, int secondThrow) : base(throws)
        {
            throws.Add(firstThrow);
            throws.Add(secondThrow);
        }

        public override int Score()
        {
            return throws[startingIndex] + throws[startingIndex + 1] + throws[startingIndex + 2];
        }
    }
}
