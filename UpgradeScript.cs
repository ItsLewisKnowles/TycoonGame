using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpgradeScript : MonoBehaviour
{
    public Transform boatUPSpawnPos;
    
    public GameObject boatUP;
    // Use this for initialization
    void Start ()
    {
        /*
        if (MoneyDisplay.money >= 1000)
            {
            Destroy(Boat, .5f);
            }
        */
	}

    public void SpawnUpgrade()
    {

        if (MoneyDisplay.money >= BoatMoney.boatCost2)
        {
            GameObject tmp = (GameObject)Instantiate(boatUP, boatUPSpawnPos.position, Quaternion.Euler(Vector3.zero));
            MoneyDisplay.money -= BoatMoney.boatCost2;
            MoneyDisplay.boats += 1;
            //Destroy(BoatSpawning.boat, .5f);
            //MoneyDisplay.money += BoatMoney.boatIncome;


        }
    }





    // Update is called once per frame
    void Update ()
    {
		
	}
}
