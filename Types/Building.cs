using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Building
{
    public int Cost { get; set; }
    public int Level { get; set; }
    public int Value { get; set; }

    public Building(int cost,int level,int value)
    {
        this.Cost = cost;
        this.Level = level;
        this.Value = value;
    }
}

