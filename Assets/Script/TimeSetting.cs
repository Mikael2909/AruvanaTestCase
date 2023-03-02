using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeSetting : MonoBehaviour
{
    [SerializeField] public Text text; 
    [SerializeField] public InputField inputFieldhour;
    [SerializeField] public InputField inputFieldminute;
    [SerializeField] public InputField inputFieldsecond;
    private string textValuehour,textValueminute,textValuesecond;
    public Dropdown dropdown;
    int index;
    int jam,hour;
    //[SerializeField] public InputField input;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        

        textValuehour = inputFieldhour.text;
        textValueminute = inputFieldminute.text;
        textValuesecond = inputFieldsecond.text;
        if (Input.GetKeyUp(KeyCode.Return))
        {
            CheckKondisi();
          
            Debug.Log(dropdown.options[2]);
            // Debug.Log("time: " + textValuehour + ":" + textValueminute + ":" + textValuesecond);
            text.text =textValuehour+ ":"+ textValueminute + ": " + textValuesecond;
            inputFieldhour.Select();
            inputFieldhour.text = "";
            inputFieldminute.Select();
            inputFieldminute.text = "";
            inputFieldsecond.Select();
            inputFieldsecond.text = "";
        }
        
    }
    void CheckKondisi()
    {
        string nilaiPilihan = dropdown.options[dropdown.value].text;
        if (textValuehour == "24" )
        {
            textValuehour = "00";
        }
        if (textValuesecond == "59")
        {
            textValuesecond = "00";
        }
        if (textValueminute == "59")
        {
            textValueminute = "00";
        }
        if (nilaiPilihan == "PM" && textValuehour != "12") 
        {
            int waktupm = int.Parse(textValuehour);
            waktupm += 12;
            string jamText = waktupm.ToString();
            textValuehour = jamText;
        } else if(nilaiPilihan =="AM" && textValuehour == "12")
        {
            int waktuam = int.Parse(textValuehour);
            waktuam = 0;
            string jamTextAm = waktuam.ToString("00");
            textValuehour = jamTextAm;
        }
       
    }
  
  

}
