using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bowling_game
{
    public class StrikeFrame : Frame
    {
        public StrikeFrame(List<int> throws) : base(throws)
        {
            throws.Add(10);
        }

        public override int Score()
        {
            return throws[startingIndex] + throws[startingIndex + 1] + throws[startingIndex + 2]; ;
        }
    }
}
