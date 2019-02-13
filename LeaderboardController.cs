using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LeaderboardController : MonoBehaviour
{
    public Text highScoreText;
    public Text yourScoreText;
    private int highScore;

	// Use this for initialization
	void Start ()
    {
        highScore = PlayerPrefs.GetInt("Money", 0);
        highScoreText.text = "Money: " + highScore;
        yourScoreText.text = "Money: " + MoneyDisplay.money;
	}
	
	
}
