using UnityEngine;
using System.Collections;

public class Mages
{
    public int Power { get; set; }
    public int Amount { get; set; }
    public int Modifier { get; set; }
    public int inGold { get; set; }
    public int inMana { get; set; }
    public int inWar { get; set; }
    public int Idle { get; set; }

    public Mages(int power, int amount, int modifier, int gold, int mana, int war)
    {
        this.Power = power;
        this.Amount = amount;
        this.Modifier = modifier;
        this.inGold = gold;
        this.inMana = mana;
        this.inWar = war;
        this.Idle = amount;
    }


    /*Cost of mages*/
    float an(int n)
    {
        return (Mathf.Sqrt(n) * Modifier);
    }
    float Sn(int n, int k)
    {
        return ((an(n) + an(k)) * 0.5f * (k - n + 1));
    }
    public float PriceNewMages(int n)
    {
        return Sn(Amount + 1, Amount + n);
    }
    public int MaxNewMages()
    {
        int max = 0;
        while (PriceNewMages(max + 1) < ValueBox.gold.Amount)
        {
            max++;
        }
        return max;
    }

    /*Amount calculations*/
    public double CountIdleMages()
    {
        Idle = Amount - inGold - inMana - inWar;
        return Idle;
    }

    public void Update()
    {
        if (Amount < 0) Amount = 0;
        CountIdleMages();
    }

}
