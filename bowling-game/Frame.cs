using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bowling_game
{
    /// <summary>
    /// Created an abstract class as wanted to have Score method to be implemented by each sub-class separately
    /// </summary>
    public abstract class Frame
    {
        protected List<int> throws;
        protected int startingIndex;
        public Frame(List<int> throws)
        {
            this.throws = throws;
            startingIndex = throws.Count;

        }
        public abstract int Score();
    }
}
