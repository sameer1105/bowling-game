using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bowling_game
{
    public class StrikeFrame : IFrame
    {
        protected List<int> throws;
        protected int startingIndex;

        public StrikeFrame(List<int> throws)
        {
            this.throws = throws;
            startingIndex = throws.Count;
            throws.Add(10);
        }

        public int Score()
        {
            return throws[startingIndex] + throws[startingIndex + 1] + throws[startingIndex + 2]; ;
        }
    }
}
