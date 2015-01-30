using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Upgrades
{
    public Upgrade ManaUpgrade { get; set; }
    public Upgrade MageUpgrade { get; set; }
    public Upgrade EmperorUpgrade { get; set; }

    public Upgrades(Upgrade manaUpgrade, Upgrade mageUpgrade, Upgrade emperorUpgrade)
    {
        this.ManaUpgrade = manaUpgrade;
        this.MageUpgrade = mageUpgrade;
        this.EmperorUpgrade = emperorUpgrade;
    }
}

