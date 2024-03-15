using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class HelloWorld : MonoBehaviour
{
    int number =0;
    public TextMeshProUGUI text;
    string numberString;
    public void OnClick()
    {
        number = number+23;
        numberString=number.ToString();
        text.text=numberString;
    }
}


