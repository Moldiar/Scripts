using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

    public class Mana
    {
        public int Amount { get; set; }
        public int MPS { get; set; }

        public Mana(int amount, int mps)
        {
            this.Amount = amount;
            this.MPS = mps;
        }

        public void Update()
        {
            if (Amount < 0) Amount = 0;
        }
        public void Gather()
        {
            Amount += (int)(MPS * ValueBox.mages.inMana * ValueBox.UpdateTime);
        }
    }
