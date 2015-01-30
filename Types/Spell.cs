using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets.Scripts.Types
{
    class Spell
    {
        public int Level { get; set; }
        public string Type { get; set; }
        public int Dmg { get; set; }

        public Spell(int level, string type, int dmg)
        {
            this.Level = level;
            this.Type = type;
            this.Dmg = dmg;
        }

        public int DealDmg()
        {
            int x = Dmg * Level;
            return x;
        }
    }
}
