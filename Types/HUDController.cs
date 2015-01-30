using System;
using UnityEngine;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class HUDController
{
    public VerbianDate Date { get; set; }
    public Mages Mages { get; set; }
    public int Gold { get; set; }
    public int Mana { get; set; }

    public HUDController(VerbianDate date, Mages mages, int gold, int mana)
    {
        this.Date = date;
        this.Mages = mages;
        this.Gold = gold;
        this.Mana = mana;
    }
}
