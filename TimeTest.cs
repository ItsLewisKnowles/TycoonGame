using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeTest : MonoBehaviour {
    /* <--
    public Text timeText;

    public Text moneyText;

    private float time = 0f;
    private int money = 0;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        time += Time.deltaTime;
        timeText.text = Mathf.Round(time).ToString();
        if (time >= 5f)
        {
            money += 50;
            moneyText.text = "Money: " + money.ToString();
            time = 0f;
            timeText.text = Mathf.Round(time).ToString();
        }  
            //time.ToString();
	}

    /*
    Value per second variable

    if tagged object (boat) is in scene

    add money to variable

    */
}
