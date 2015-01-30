using UnityEngine;
//using UnityEngine.EventSystems;
using System.Collections;
using UnityEngine.UI;

public class UpdateHUD_Text : MonoBehaviour
{
    public string upText;
    public int value;
    public string downText;
    Text text;

    public enum category
    {
        Date, Gold, Mana, Mages, IdleMages
    }
    public category box;

    void Start()
    {
        text = GetComponent<Text>();
    }
    void LateUpdate()
    {
        //if (box == category.Gold) this.value = string.Format("{0:# ###}" ,ValueBox.gold.Amount);
        //else if (box == category.Mana) this.value = ValueBox.mana.Amount.ToString("#,#");
        //else if (box == category.Mages) this.value = ValueBox.mages.Amount.ToString("#,#");
        //else if (box == category.Date) this.value = ValueBox.date.ToString();
        //else if (box == category.IdleMages) this.value = ValueBox.mages.Idle.ToString("#,#");




        if (box != category.Date)
        {
            if (box == category.Gold) value = ValueBox.gold.Amount;
            else if (box == category.Mana) value = ValueBox.mana.Amount;
            else if (box == category.Mages) value = ValueBox.mages.Amount;
            else if (box == category.IdleMages) value = ValueBox.mages.Idle;

            string liczba = "0";
            if (value > 0)
            {
                liczba = value.ToString("#,#");
                liczba = liczba.Replace(',', ' ');
            }
            text.text = upText + '\n' + liczba + '\n' + downText;

        }
        else
        {
            //string date = ValueBox.GameStartDate.Day.ToString() + ' ' + ValueBox.GameStartDate.Month.ToString() + ' ' + ValueBox.GameStartDate.Year.ToString();
            text.text = upText + '\n' + ValueBox.date.ToString() + '\n' + downText;
        }

//        text.text = upText + '\n' + value + '\n' + downText;
    }


        //{
        //    string date = ValueBox.GameStartDate.Day.ToString() + ' ' + ValueBox.GameStartDate.Month.ToString() + ' ' + ValueBox.GameStartDate.Year.ToString();
        //    text.text = upText + '\n' + date + '\n' + downText;
        //}
	
}
