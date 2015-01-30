using UnityEngine;
using System.Collections;

public class Mages
{

	public int Cost { get; private set;}
	public int Amount { get; set;}
	public int Modifier { get; private set;}
    public int Gold { get; set; }
    public int Mana { get; set; }
    public int War { get; set; }
    public int Idle { get; set; }

	public Mages(int cost,int amount,int modifier,int gold,int mana, int war)
	{
		this.Cost = cost;
		this.Amount = amount;
		this.Modifier = modifier;
        this.Gold = gold;
        this.Mana = mana;
        this.War = war;
        this.Idle = amount;

	}

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
    int MaxNewMages()
    {
        int max = 0;
        while (PriceNewMages(max + 1) < ValueBox.Gold)
        {
            max++;
        }
        return max;
    }


    public double CountIdleMages()
    {
        Idle = Amount - Gold - Mana - War;
        return Idle;
    }
}