using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets.Scripts.Types
{
    class Mana
    {
        public int Amount { get; set; }
        public int MPS { get; set; }

        public Mana(int amount, int mps)
        {
            this.Amount = amount;
            this.MPS = mps;
        }
    }
}
