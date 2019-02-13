using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildingSpawning : MonoBehaviour
{
    // These here are the variables that will spawn the building in at the assigned object.
    public Transform buildingSpawnPos;
    public Transform buildingSpawnPos2;
    public Transform buildingSpawnPos3;

    // These are the variables where I can assign the different boats to their corresponding
    // upgrade level.
    public GameObject building;
    public GameObject building2;
    public GameObject building3;

    // A type of class that can be assigned to a button which will spawn in the building 
    // when the player has enough money.
    public void Spawn()
    {
        if (MoneyDisplay.money >= BuildingMoney.buildingCost1) // Checks to see if the player has enough money.
        {
            // Will spawn in the certain game object to the assigned location.
            GameObject tmp = (GameObject)Instantiate(building, buildingSpawnPos.position, Quaternion.Euler(Vector3.zero));

            MoneyDisplay.money -= BuildingMoney.buildingCost1;

            MoneyDisplay.buildings1 += 1;

            //MoneyDisplay.money += BoatMoney.boatIncome;
        }
    }

    public void Spawn2()
    {
        if (MoneyDisplay.money >= BuildingMoney.buildingCost2) // Checks to see if the player has enough money.
        {
            // Will spawn in the certain game object to the assigned location.
            GameObject tmp = (GameObject)Instantiate(building2, buildingSpawnPos2.position, Quaternion.Euler(Vector3.zero));
            // Subtracts money that is corresponding to the value of the building
            MoneyDisplay.money -= BuildingMoney.buildingCost2;
            // Adds a value to the counters to apply money a second.
            MoneyDisplay.buildings2 += 1;
            MoneyDisplay.buildings1 -= 1;
            
        }
    }

    public void Spawn3()
    {
        if (MoneyDisplay.money >= BuildingMoney.buildingCost2) // Checks to see if the player has enough money.
        {
            // Will spawn in the certain game object to the assigned location.
            GameObject tmp = (GameObject)Instantiate(building3, buildingSpawnPos3.position, Quaternion.Euler(Vector3.zero));
            // Subtracts money that is corresponding to the value of the bilding
            MoneyDisplay.money -= BuildingMoney.buildingCost3;
            // Adds a value to the counters to apply money a second.
            MoneyDisplay.buildings3 += 1;
            MoneyDisplay.buildings2 -= 1;
           
        }
    }
}
