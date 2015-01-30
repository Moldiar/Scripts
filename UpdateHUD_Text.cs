using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class UpdateHUD_Text : MonoBehaviour
{
	public string upText;
	public string value;
	public string downText;
	Text text;

	public enum category{
		Date, Gold, Mana, Mages} 
	public category box;

	void Start () 
	{
		text = GetComponent <Text>();
	}
	void LateUpdate () 
	{
		if (box == category.Gold) this.value = ValueBox.Gold.ToString();
        else if (box == category.Mana) this.value = ValueBox.hc.Mana.ToString();
        else if (box == category.Mages) this.value = ValueBox.hc.Mages.Amount.ToString();
        else if (box == category.Date) this.value = ValueBox.hc.Date.ToString();

		text.text = upText + '\n' + value + '\n' + downText;
	}
}
