using UnityEngine;
using UnityEngine.EventSystems;
using System.Collections;
using UnityEngine.UI;

public class Button : MonoBehaviour, IPointerClickHandler, IPointerUpHandler, IPointerDownHandler, IPointerEnterHandler, IPointerExitHandler
{
	public action Effect;
	public enum action	{
		Menu, 
		Recruit, ManaPlant, GoldMine, UpgradeMana, UpgradePower, UpgradeEmperor, UpgradeSpell, Attack, Retreat, Protect,
		MusicOnOff, SoundsOnOff,
        BattlefieldAll, BattlefieldIdle, ManaPlantAll, ManaPlantIdle, GoldMineAll, GoldMineIdle, RecruitMax
    }
	//public bool StopSound;
	public float power;

//---------------------------------------------------------------------------------------//

	/*Przycisnięcie myszy*/
	public void OnPointerDown(PointerEventData data)
	{
		//if (StopSound) Source.Stop ();

		switch (Effect) 
		{
		case action.Menu:
			Speaker.Play (Speaker.SoundMenuClick);
			break;

		case action.Recruit:
            Source.Stop();
            if (ValueBox.sliderMagesRecruit.value > 0)
			    Speaker.Play (Speaker.SoundMenuFanfare);
            else
                Speaker.Play(Speaker.SoundSpellFireballHit);

            ValueBox.mages.Amount += (int)(ValueBox.sliderMagesRecruit.value);
            ValueBox.gold.Amount -= (int)(ValueBox.mages.PriceNewMages((int)ValueBox.sliderMagesRecruit.value));
			break;
        case action.RecruitMax:
            Source.Stop();
            if (ValueBox.sliderMagesRecruit.maxValue > 0)
                Speaker.Play(Speaker.SoundMenuFanfare);
            else
                Speaker.Play(Speaker.SoundSpellFireballHit);

            ValueBox.mages.Amount += (int)(ValueBox.sliderMagesRecruit.maxValue);
            ValueBox.gold.Amount -= (int)(ValueBox.mages.PriceNewMages((int)ValueBox.sliderMagesRecruit.maxValue));
            break;

        case action.GoldMineIdle:
            Speaker.Play(Speaker.SoundGoldGathered);
            ValueBox.sliderMagesGold.value = ValueBox.sliderMagesGold.maxValue;
            break;
        case action.GoldMineAll:
            Speaker.Play(Speaker.SoundGoldGathered);
            ResetIdleMages();
            ValueBox.sliderMagesGold.value = ValueBox.sliderMagesGold.maxValue = (float)ValueBox.mages.Amount;
            break;

        case action.ManaPlantIdle:
            Speaker.Play(Speaker.SoundManaClick);
            ValueBox.sliderMagesMana.value = ValueBox.sliderMagesMana.maxValue;
            break;
		case action.ManaPlantAll:
			Speaker.Play (Speaker.SoundManaClick);
            ResetIdleMages();
            ValueBox.sliderMagesMana.value = ValueBox.sliderMagesMana.maxValue = (float)ValueBox.mages.Amount;
			break;

        case action.BattlefieldIdle:
            Speaker.Play(Speaker.SoundGoldGathered);
            ValueBox.sliderMagesWar.value = ValueBox.sliderMagesWar.maxValue;
            break;
        case action.BattlefieldAll:
            Speaker.Play(Speaker.SoundGoldGathered);
            ResetIdleMages();
            ValueBox.sliderMagesWar.value = ValueBox.sliderMagesWar.maxValue = (float)ValueBox.mages.Amount;
            break;


		case action.UpgradeMana:
			Speaker.Play (Speaker.SoundManaGathered);
			ValueBox.mana.Amount = 0;
			break;

		case action.UpgradePower:
			Speaker.Play (Speaker.SoundManaUpgrade);
			break;

		case action.UpgradeEmperor:
			Speaker.Play (Speaker.SoundLoreClose);
			break;

		case action.UpgradeSpell:
			Speaker.Play (Speaker.SoundSpell_UPGRADE);
			break;

		case action.Attack:
			Speaker.Play (Speaker.SoundWhip);
			ValueBox.gold.Amount += (ValueBox.mana.Amount * 100);
			ValueBox.mana.Amount = 0;
            ValueBox.mages.Amount -= (int)power;
			break;

		case action.Retreat:
			Speaker.Play (Speaker.SoundSqueeze);
			break;

		case action.Protect:
			Speaker.Play (Speaker.SoundSpellFireballHit);
            ValueBox.mages.Amount -= (int)power;
			break;
		
		case action.MusicOnOff:
			MusicSource.mute = !MusicSource.mute;
			break;

		case action.SoundsOnOff:
			Source.mute = !Source.mute;
			break;
		}
	}

	/*Puszczenie przycisku*/
	public void OnPointerUp(PointerEventData data)
	{

	}

	/*Standardowe kliknięcie*/
	public void OnPointerClick(PointerEventData data)
	{
		
	}

	/*Najechanie myszą*/
	public void OnPointerEnter(PointerEventData data)
	{
		Speaker.Play (Speaker.SoundMenuHover);

	}

	/*Zjechanie myszą z obiektu*/
	public void OnPointerExit(PointerEventData data)
	{

	}

//---------------------------------------------------------------------------------------//	
	
	
	/*Set up Speaker & Values*/
	AudioSource Source;
	AudioSource MusicSource;
	GameObject AudioSpeaker;
	SoundList Speaker;
	//ValueBox Values;
	
	void Start () {
		AudioSpeaker = GameObject.FindGameObjectWithTag("MainSpeaker");
		Source = AudioSpeaker.GetComponent<AudioSource> ();
		Speaker = AudioSpeaker.GetComponent<SoundList> ();
		MusicSource = GameObject.FindGameObjectWithTag("MusicSpeaker").GetComponent<AudioSource>();

		//Values = GameObject.FindGameObjectWithTag("CodeCube").GetComponent<ValueBox>();
	}


    /////////////////////////////FUNCTIONS//////////////////////////////////////////////////////////////////FUNCTIONS/////////////////////////////////////
    /////////////////////////////FUNCTIONS//////////////////////////////////////////////////////////////////FUNCTIONS/////////////////////////////////////
    /////////////////////////////FUNCTIONS//////////////////////////////////////////////////////////////////FUNCTIONS/////////////////////////////////////

    void ResetIdleMages()
    {
        ValueBox.sliderMagesGold.value = ValueBox.sliderMagesMana.value = ValueBox.sliderMagesWar.value = 0f;
        ValueBox.mages.inGold = ValueBox.mages.inMana = ValueBox.mages.inWar = 0;
        ValueBox.mages.Update();
    }
}
