using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BoatBehavour : MonoBehaviour {

    public GameObject BoatPrefab;
    private GameObject Boat;
    private int Value;
    private int Income;

    


    void Awake()
    {
        Value = 400;
        Income = 10;
    }

    private bool CanPlaceBoat()
    {
        return Boat == null;
    }

    void OnMouseUp()
    {
        if (CanPlaceBoat())
        {
            Boat = (GameObject)
                Instantiate(BoatPrefab, transform.position, Quaternion.identity);
            MoneyDisplay.money -= Value;


        }
    }
}
