using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoatSpawning : MonoBehaviour
{
    // These here are the variables that will spawn the boat in at the assigned object.
    public Transform boatSpawnPos;
    public Transform boatUPSpawnPos;
    public Transform boatUP2SpawnPos;
    public Transform boatUP3SpawnPos;
    // These are the variables where I can assign the different boats to their corresponding
    // upgrade level.
    public GameObject boat;
    public GameObject boatUP;
    public GameObject boatUP2;
    public GameObject boatUP3;




    // A type of class that can be assigned to a button which will spawn in the boat 
    // when the player has enough money.
    public void Spawn () 
    {
        
            if (MoneyDisplay.money >= BoatMoney.boatCost) // Checks to see if the player has enough money.
        {
                // Will spawn in the certain game object to the assigned location.
                GameObject tmp = (GameObject)Instantiate(boat, boatSpawnPos.position, Quaternion.Euler(Vector3.zero));
                // Subtracts money that is corresponding to the value of the boat
                MoneyDisplay.money -= BoatMoney.boatCost;
                // Adds a value to the counters to apply money a second.
                MoneyDisplay.boats += 1;
            
            }
    }
    // A type of class that can be assigned to a button which will spawn in the boat 
    // when the player has enough money.
    public void SpawnUpgrade()
    {

        if (MoneyDisplay.money >= BoatMoney.boatCost2) // Checks to see if the player has enough money.
        {
            // Will spawn in the certain game object to the assigned location.
            GameObject tmp = (GameObject)Instantiate(boatUP, boatUPSpawnPos.position, Quaternion.Euler(Vector3.zero));
            // Subtracts money that is corresponding to the value of the boat
            MoneyDisplay.money -= BoatMoney.boatCost2;
            // Adds and subtracts a value to the counters to apply money a second.
            MoneyDisplay.boats2 += 1;
            MoneyDisplay.boats -= 1;
            
        }
    }
    // A type of class that can be assigned to a button which will spawn in the boat 
    // when the player has enough money.
    public void SpawnUpgrade2()
    {

        if (MoneyDisplay.money >= BoatMoney.boatCost3) // Checks to see if the player has enough money.
        {
            // Will spawn in the certain game object to the assigned location.
            GameObject tmp = (GameObject)Instantiate(boatUP2, boatUP2SpawnPos.position, Quaternion.Euler(Vector3.zero));
            // Subtracts money that is corresponding to the value of the boat 
            MoneyDisplay.money -= BoatMoney.boatCost3;
            // Adds and subtracts a value to the counters to apply money a second.
            MoneyDisplay.boats3 += 1;
            MoneyDisplay.boats2 -= 1;
            
        }
    }
    // A type of class that can be assigned to a button which will spawn in the boat 
    // when the player has enough money.
    public void SpawnUpgrade3()
    {

        if (MoneyDisplay.money >= BoatMoney.boatCost4) // Checks to see if the player has enough money.
        {
            // Will spawn in the certain game object to the assigned location.
            GameObject tmp = (GameObject)Instantiate(boatUP3, boatUP3SpawnPos.position, Quaternion.Euler(Vector3.zero));
            // Subtracts money that is corresponding to the value of the boat
            MoneyDisplay.money -= BoatMoney.boatCost4;
            // Adds and subtracts a value to the counters to apply money a second.
            MoneyDisplay.boats4 += 1;
            MoneyDisplay.boats3 -= 1;
            


        }
    }
}

