using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bowling_game
{
    public class OpenFrame : IFrame
    {
        protected List<int> throws;
        protected int startingIndex;

        public OpenFrame(List<int> throws, int firstThrow, int secondThrow)
        {
            this.throws = throws;
            startingIndex = throws.Count;
            throws.Add(firstThrow);
            throws.Add(secondThrow);
        }

        public int Score()
        {
            return throws[startingIndex] + throws[startingIndex+1];
        }
    }
}
