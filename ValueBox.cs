using UnityEngine;
using System.Collections;

using System.Collections.Generic;
using System.Linq;
using System.Text;
using System;
using UnityEngine.UI;



public class ValueBox : MonoBehaviour {
	
    public static DateTime GameStartDate;
	//public static int 	Gold=10000, 
		//					Mana=666, 
			//				Mages=2000, MagesInGoldMine=0, MagesInManaCrystal=0, MagesAtWar=0, MagesIdle;

    //-------------------------Date
    
    public static int Year = 57, Month = 6, Day = 3;
    //-------------------------Mages
    public static int mAmount = 2000;
    public static double mModifier = 100f, mCost = Math.Sqrt(mAmount) * mModifier;
    public static int atWar = 0;
    //-------------------------Gold
    public static int Gold = 100000;
    public static int MagesGold = 0;
    //-------------------------Mana
    public static int Mana = 0;
    public static int MagesMana = 0;
    public static VerbianDate vd = new VerbianDate(Year, Month, Day);
    public static HUDController hc = new HUDController(vd, m.Amount, Gold, Mana);

    public static VerbianDate date;
    public static Mages mages = new Mages((int)mCost, mAmount, (int)mModifier, MagesGold, MagesMana, atWar);
    public static Gold gold;
    public static Mana mana;
    public static Spells spells;
    public static Cities cities;
    public static Upgreades upgreades;


	//lista cech imperatora
	//KlasaZaklęcie: lvl, dmg, żywioł, cooldown, boolFlipable
	//Klasa Miasto: mages, owned, armyPower, elementProtection, goldmines

    public static Slider sliderMagesRecruit,
                         sliderMagesGold,
                         sliderMagesMana,
                         sliderMagesWar;

    public float    GoldPerSecondPerMage = 20.0f,
                    ManaPerSecondPerMage = 20.0f;

	public enum Element{
		Wind, Fire, Water, Stone, Metal
	}

    float timer = 0;


	void Update()
	{
        if (m.Amount < 0) m.Amount = 0;
		if (Mana < 0) Mana = 0;
		if (Gold < 0) Gold = 0;

		timer += Time.deltaTime;
		if (timer > 0.5) 
		{
            Gold += (int)(m.Gold * GoldPerSecondPerMage * timer);
            Mana += (int)(m.Mana * ManaPerSecondPerMage * timer);
			timer = 0;
		}

        CountIdleMages();
	}

    
    
    void Awake()
    {
        

        sliderMagesRecruit = GameObject.FindGameObjectWithTag("SliderMagesRecruit").GetComponent<Slider>();
        sliderMagesGold = GameObject.FindGameObjectWithTag("SliderMagesToGold").GetComponent<Slider>();
        sliderMagesMana = GameObject.FindGameObjectWithTag("SliderMagesToMana").GetComponent<Slider>();
        sliderMagesWar = GameObject.FindGameObjectWithTag("SliderMagesToWar").GetComponent<Slider>();
    }
    
    
    

}
