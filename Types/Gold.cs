using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

    public class Gold
    {
        public int Amount { get; set; }
        public int GPS { get; set; }

        public Gold(int amount, int gps)
        {
            this.Amount = amount;
            this.GPS = gps;
        }

        public void Update()
        {
            if (Amount < 0) Amount = 0;
        }
        public void Gather()
        {
            Amount += (int)(GPS * ValueBox.mages.inGold * ValueBox.UpdateTime);
        }
    }
