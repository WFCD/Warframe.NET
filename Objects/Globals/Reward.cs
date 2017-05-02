using System.Collections.Generic;

namespace WarframeNET
{
    public class Reward
    {
        public List<string> Items { get; set; }

        public object[] CountedItems { get; set; }

        public int Credits { get; set; }
    }
}