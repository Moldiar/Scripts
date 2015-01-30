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
    public Text GoldenMaxTextField;

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
                slid.maxValue = (float)ValueBox.mages.MaxNewMages();

                string price = ValueBox.mages.PriceNewMages((int)slid.value).ToString("#,#");
                price = price.Replace(',', ' ');
                if (slid.value == 0) price = "0";
                GoldenTextField.text = "You gonna pay: " + price + " gold";

                string maxPrice = ValueBox.mages.PriceNewMages((int)slid.maxValue).ToString("#,#");
                maxPrice = maxPrice.Replace(',', ' ');
                if (slid.maxValue == 0) maxPrice = "0";
                string maxMages = slid.maxValue.ToString("#,#");
                maxMages = maxMages.Replace(',', ' ');
                if (slid.maxValue == 0) maxMages = "0";
                GoldenMaxTextField.text = maxPrice + " gold for " + maxMages + " new mages";

                break;

            case slide.ToGold:
                
                slid.maxValue = (float)(int)(ValueBox.mages.Idle + ValueBox.mages.inGold);
                ValueBox.mages.inGold = (int)slid.value;
                
                break;

            case slide.ToMana:

                slid.maxValue = (float)(int)(ValueBox.mages.Idle + ValueBox.mages.inMana);
                ValueBox.mages.inMana = (int)slid.value;

                break;

            case slide.ToWar:
                
                slid.maxValue = (float)(int)(ValueBox.mages.Idle + ValueBox.mages.inWar);
                ValueBox.mages.inWar = (int)slid.value;

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
