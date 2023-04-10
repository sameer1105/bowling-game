using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bowling_game
{
    public class BonusRoll : IFrame
    {
        protected List<int> throws;
        protected int startingIndex;

        public BonusRoll(List<int> throws, int firstThrow)
        {
            this.throws = throws;
            startingIndex = throws.Count;
            throws.Add(firstThrow);
        }

        public int Score()
        {
            return 0;
        }
    }
}
