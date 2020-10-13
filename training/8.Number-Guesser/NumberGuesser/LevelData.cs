using System;
using System.Collections.Generic;
using System.Text;

namespace NumberGuesser
{
    class LevelData
    {
        public int StartRange { get; set; }
        public int EndRange { get; set; }
        public int Target{ get; set; }
        public int MaximumTries { get; set; }

        

        public LevelData(int startRange, int endRange, int target, int maximumTries)
        {
            this.StartRange = startRange;
            this.EndRange = endRange;
            this.Target = target;
            this.MaximumTries = maximumTries;
        }
    }
}
