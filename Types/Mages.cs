using UnityEngine;
using System.Collections;

public class Mages
{

	public int Cost { get; private set;}
	public int Amount { get; set;}
	public int Modifier { get; private set;}
    public int Gold { get; set; }
    public int Mana { get; set; }

	public Mages(int cost,int amount,int modifier,int gold,int mana)
	{
		this.Cost = cost;
		this.Amount = amount;
		this.Modifier = modifier;
        this.Gold = gold;
        this.Mana = mana;
	}

}