using UnityEngine;
//using UnityEngine.EventSystems;
using System.Collections;
using UnityEngine.UI;

public class UpdateHUD_Text : MonoBehaviour
{
    public string upText;
    public string value;
    public string downText;
    Text text;

    public enum category
    {
        Date, Gold, Mana, Mages
    }
    public category box;

    void Start()
    {
        text = GetComponent<Text>();
    }
    void LateUpdate()
    {
        ValueBox.
        
        if (box == category.Gold) this.value = ValueBox.hc.Gold.ToString();
        else if (box == category.Mana) this.value = ValueBox.Mana.ToString();
        else if (box == category.Mages) this.value = ValueBox.hc.Mages.ToString();
        else if (box == category.Date) this.value = ValueBox.hc.Date.ToString();
    
        text.text = upText + '\n' + value + '\n' + downText;
    }


        //{
        //    string date = ValueBox.GameStartDate.Day.ToString() + ' ' + ValueBox.GameStartDate.Month.ToString() + ' ' + ValueBox.GameStartDate.Year.ToString();
        //    text.text = upText + '\n' + date + '\n' + downText;
        //}
	
}
