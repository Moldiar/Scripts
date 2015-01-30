using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets.Scripts.Types
{
    class Spells
    {
        public Spell Fireball { get; set; }
        public Spell FireballRain { get; set; }
        public Spell Earthquake { get; set; }
        public Spell Thunder { get; set; }

        public Spells(Spell fireball, Spell fireballRain, Spell earthquake, Spell thunder)
        {
            this.Fireball = fireball;
            this.FireballRain = fireballRain;
            this.Earthquake = earthquake;
            this.Thunder = thunder;
        }
    }
}
