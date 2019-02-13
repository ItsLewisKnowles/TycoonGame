using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    public void Finish()
    {
        if (PlayerPrefs.GetInt("Money") < MoneyDisplay.money)
        {
            PlayerPrefs.SetInt("Money", MoneyDisplay.money);
        }
        
    }
}
