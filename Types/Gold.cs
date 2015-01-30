using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets.Scripts.Types
{
    class Gold
    {
        public int Amount { get; set; }
        public int GPS { get; set; }

        public Gold(int amount, int gps)
        {
            this.Amount = amount;
            this.GPS = gps;
        }
    }
}
