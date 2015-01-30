using UnityEngine;
using System.Collections;

using System.Collections.Generic;
using System.Linq;
using System.Text;
using System;
using UnityEngine.UI;



public class ValueBox : MonoBehaviour {

    ////////////////////////////////////////////////////////////////////////////
    ///////////////////////////////// New Game /////////////////////////////////
    ////////////////////////////////////////////////////////////////////////////

    static int Year = 57, Month = 6, Day = 13;

    static int startGold = 100000;
    static int startGPS = 20;

    static int startMana = 0;
    static int startMPS = 20;

    static int startMages = 2000;
    static int startMagesCostModifier = 100;
    
    public static float UpdateTime = 0.5f;


    ////////////////////////////////////////////////////////////////////////////
    ///////////////////////////////// Info /////////////////////////////////////
    ////////////////////////////////////////////////////////////////////////////

    public static DateTime GameFirstStartDate;
    public static DateTime GameStartDate;

    ////////////////////////////////////////////////////////////////////////////
    //////////////////////////////// Game Data /////////////////////////////////
    ////////////////////////////////////////////////////////////////////////////

    public static VerbianDate date = new VerbianDate(Year, Month, Day);
    public static Mages mages = new Mages(startMages, startMagesCostModifier, 0, 0, 0);
    public static Gold gold = new Gold(startGold, startGPS);
    public static Mana mana = new Mana(startMana, startMPS);
    //public static Spells spells;
    //public static Cities cities;
    //public static Upgrades upgrades;
    //public static Constructions constructions;
    //public static Emperor emperor;

    ////////////////////////////////////////////////////////////////////////////
    //////////////////////////////// References ////////////////////////////////
    ////////////////////////////////////////////////////////////////////////////

    public static Slider sliderMagesRecruit,
                         sliderMagesGold,
                         sliderMagesMana,
                         sliderMagesWar;

    

	public enum Element{
		Wind, Fire, Water, Stone, Metal
	}



    float timer = 0;
	void Update()
	{
        gold.Update();
        mana.Update();
        mages.Update();

		timer += Time.deltaTime;
        if (timer > UpdateTime) 
		{
            gold.Gather();
            mana.Gather();
			timer = 0;
		}
	}

    
    
    void Awake()
    {
        sliderMagesRecruit = GameObject.FindGameObjectWithTag("SliderMagesRecruit").GetComponent<Slider>();
        sliderMagesGold = GameObject.FindGameObjectWithTag("SliderMagesToGold").GetComponent<Slider>();
        sliderMagesMana = GameObject.FindGameObjectWithTag("SliderMagesToMana").GetComponent<Slider>();
        sliderMagesWar = GameObject.FindGameObjectWithTag("SliderMagesToWar").GetComponent<Slider>();
    }
    
    
    

}
