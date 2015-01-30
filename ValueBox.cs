using UnityEngine;
using System.Collections;
using System;

public class ValueBox : MonoBehaviour {
	float timer=0;
    //-------------------------Date
    public static int Year=57, Month=6, Day=3;
    //-------------------------Mages
    public static int mAmount = 2000;
    public static double mModifier = 1.3f, mCost = mCost * 5 * Math.Sqrt(mAmount)*mModifier;
    //-------------------------Gold
    public static int Gold=123456;
    public static int MagesGold = 0;
    //-------------------------Mana
    public static int Mana=0;
    public static int MagesMana = 0;

    public static VerbianDate vd = new VerbianDate(Year,Month,Day);
    public static Mages m = new Mages((int)mCost, mAmount, (int)mModifier,MagesGold,MagesMana);

    public static HUDController hc = new HUDController(vd,m,Gold,Mana);

	void Update()
	{

        timer += Time.deltaTime;
        if (timer > 1)
        {
            hc.Date.Day += 1;
            timer = 0;
        }

        if (mAmount < 0) {mAmount = 0; }
		if (Mana < 0) Mana = 0;
		if (Gold < 0) Gold = 0;
        if (hc.Date.Day == 21) { hc.Date.Month++; hc.Date.Day = 1; }
        if (hc.Date.Month == 21) { hc.Date.Year++; hc.Date.Month = 1; }

		

	}


}
