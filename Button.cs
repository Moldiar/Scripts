using UnityEngine;
using UnityEngine.EventSystems;
using System.Collections;

public class Button : MonoBehaviour, IPointerClickHandler, IPointerUpHandler, IPointerDownHandler, IPointerEnterHandler, IPointerExitHandler
{
	public action Effect;
	public enum action	{
		Menu, 
		Recruit, ManaPlant, GoldMine, UpgradeMana, UpgradePower, UpgradeEmperor, UpgradeSpell, Attack, Retreat, Protect,
		MusicOnOff, SoundsOnOff}
	//public bool StopSound;
	public float power;

//--------------------------------------------------------------------------------------//



//--------------------------------------------------------------------------------------//
	/*Kliknięcie myszą*/
	public void OnPointerDown(PointerEventData data)
	{
		//if (StopSound) Source.Stop ();

		switch (Effect) 
		{
		case action.Menu:
			Speaker.Play (Speaker.SoundMenuClick);
			break;
		case action.Recruit:
			Speaker.Play (Speaker.SoundMenuFanfare);
			ValueBox.m.Amount += (ValueBox.hc.Gold/100);
            ValueBox.hc.Gold %= 100;
			break;
		case action.ManaPlant:
			Speaker.Play (Speaker.SoundManaClick);
			ValueBox.Mana += (int)power;
			break;
		case action.GoldMine:
			Speaker.Play (Speaker.SoundGoldGathered);
            ValueBox.Gold += (int)power;
			break;
		case action.UpgradeMana:
			Speaker.Play (Speaker.SoundManaGathered);
			ValueBox.Mana = 0;
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
			ValueBox.Gold += (ValueBox.Mana * 100);
			ValueBox.Mana = 0;
            ValueBox.mAmount -= (int)power;
			break;
		case action.Retreat:
			Speaker.Play (Speaker.SoundSqueeze);

			break;
		case action.Protect:
			Speaker.Play (Speaker.SoundSpellFireballHit);
            ValueBox.mAmount -= (int)power;
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
	
	public void OnPointerClick(PointerEventData data)
	{
		
	}
	
	public void OnPointerEnter(PointerEventData data)
	{
		Speaker.Play (Speaker.SoundMenuHover);

	}
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
}
