using UnityEngine;
using System.Collections;

public class SoundList : MonoBehaviour
{

	AudioSource Source;
	void Start () 
	{
		Source = GetComponent<AudioSource> ();
	}

	public AudioClip 	
		SoundMenuClick,
		SoundMenuHover,
		SoundMenuFanfare,
		SoundManaClick,
		SoundGoldGathered,
	 	SoundManaGathered,
		SoundManaUpgrade,
	 	SoundSpell_UPGRADE,
		SoundSpellFireballHit,
		SoundSpellFireballCast,
		SoundSpellBigFireball,
		SoundSpellThunder,
		SoundSpellEarthquake,
		SoundLoreNext,
		SoundLoreClose,
		SoundSlap,
		SoundWhip,
		SoundGoldCoinFlip,
		SoundSqueeze;

	public void Play(AudioClip Clip)
	{
		float Volume = Random.Range(0.6f, 1.0f);
		Source.PlayOneShot (Clip, Volume);
	}
}
