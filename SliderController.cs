using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Text;

public class SliderController : MonoBehaviour {
    public enum slide 
    {
        Recruit, ToGold, ToMana, ToWar
    }
    public slide SliderDestiny;

    Slider slid;
    InputField textField;
    float lastValue;
    public Text GoldenTextField;

	void Start () {
        slid = GetComponent<Slider>();
        textField = GetComponentInChildren<InputField>();
        slid.value = 0f;
	}
	
	// Update is called once per frame
	void Update () {
        switch (SliderDestiny)
        {
            case slide.Recruit:
                //slid.maxValue = (float)(int)(ValueBox.Gold / 100);
                //slid.maxValue = Sn((int)ValueBox.Mages, (int)ValueBox.Mages+10);
                slid.maxValue = (float)MaxNewMages();

                string liczba = PriceNewMages((int)slid.value).ToString("#,#");
                liczba = liczba.Replace(',', ' ');
                if (slid.value == 0)
                    liczba = "0";

                GoldenTextField.text = "You gonna pay: " + liczba + " gold";
                break;

            case slide.ToGold:
                
                slid.maxValue = (float)(int)(ValueBox.MagesIdle + ValueBox.MagesInGoldMine);
                ValueBox.MagesInGoldMine = (int)slid.value;
                
                break;

            case slide.ToMana:
                
                slid.maxValue = (float)(int)(ValueBox.MagesIdle + ValueBox.MagesInManaCrystal);
                ValueBox.MagesInManaCrystal = (int)slid.value;

                break;

            case slide.ToWar:
                
                slid.maxValue = (float)(int)(ValueBox.MagesIdle + ValueBox.MagesAtWar);
                ValueBox.MagesAtWar = (int)slid.value;

                break;
        }









        if (lastValue != slid.value)
            textField.text = slid.value.ToString();
        else
            slid.value = int.Parse(textField.text);

        if (int.Parse(textField.text) > slid.maxValue)
            textField.text = slid.maxValue.ToString();

        lastValue = slid.value;
	}

 
}
