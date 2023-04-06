using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bowling_game
{
    public class BonusRoll : Frame
    {
        public BonusRoll(List<int> throws, int firstThrow) : base(throws)
        {
            throws.Add(firstThrow);
        }

        public override int Score()
        {
            return 0;
        }
    }
}
