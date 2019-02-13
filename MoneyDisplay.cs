using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MoneyDisplay : MonoBehaviour
{

    public static int money = 0;
    // This is a public variable for money, this is so I can edit the values when coding other scripts if need be.
    public Text MoneyText;
    // This is a public text variable, this is so that I can edit a text box to display the money.
    
    // This is a public text variable, this is so that I can assign a text box to be edited with a value.
    public Text timeText;
    public Text timeText2;
    public Text timeText3;
    public Text timeText4;
    public Text timeText5;
    public Text timeText6;
    public Text timeText7;
       
    // This is a public text variable, this is so that I can assign a text box to be edited with a value.
    public Text boatCount;
    public Text boatCount2;
    public Text boatCount3;
    public Text boatCount4;
    
    // Same as the boat counters, but this is for the buildings and can be assigned a text box to be edited.
    public Text buildingCount1;
    public Text buildingCount2;
    public Text buildingCount3;
    

    // This is a public static, this is so that I can use this variable in other scripts and add onto the value.
    public static int boats = 0;
    public static int boats2 = 0;
    public static int boats3 = 0;
    public static int boats4 = 0;

    // This is a public static, this is so that I can use this variable in other scripts and add onto the value.
    public static int buildings1 = 0;
    public static int buildings2 = 0;
    public static int buildings3 = 0;
    
    // This is a private variable, this is for the timer sequence that is bellow.
    private float time = 0f;    
    private float time2 = 0f;
    private float time3 = 0f;
    private float time4 = 0f;
    private float time5 = 0f;
    private float time6 = 0f;
    private float time7 = 0f;
    




    private void Awake()
    {
        // Money will always be set to this value apon entering the scene.
        money = 600;
        // This will set all the values for the boats and buildings counters to 0,
        // this prevents the player from getting money when reentering the scene from the previous game.
        boats = 0;
        boats2 = 0;
        boats3 = 0;
        boats4 = 0;
        buildings1 = 0;
        buildings2 = 0;
        buildings3 = 0;

    }
    private void Update()
    {
        // This is the line of code that changes the text box to display the money.
        MoneyText.text = "Money: " + money;

        // This is the line of code that changes the text box to display the amount of boats brought.
        boatCount.text = "Boats: " + boats;        
        boatCount2.text = "Boats: " + boats2;
        boatCount3.text = "Boats: " + boats3;
        boatCount4.text = "Boats: " + boats4;

        // This is the line of code that changes the text box to display the amount of buildings brought.
        buildingCount1.text = "Buildings: " + buildings1;
        buildingCount2.text = "Buildings: " + buildings2;
        buildingCount3.text = "Buildings: " + buildings3;

        // In this section, I have created a series of code that will allow the player to get income
        // depending on the ammount of boats that are brought. 
        if (boats >= 1) // This will activate if there is 1 boat present
        {
            time += Time.deltaTime; // These lines of code will create a timer that will add money
            timeText.text = Mathf.Round(time).ToString(); // every certain ammount of seconds.
            if (time >= 5f) // This will activate when the timer hits 5 seconds.
            {
                money += 10; // this will add 10 to the variable money.
                MoneyText.text = "Money: " + money.ToString(); // This will update the money text box.
                time = 0f; // This will set the timer back to 0 so that It can restart the timer.
                timeText.text = Mathf.Round(time).ToString();

                if (boats >= 2) // This will activate if there are 2 boats present.
                {
                    money += 10; // this will add 10 to the variable money.
                    MoneyText.text = "Money: " + money.ToString(); // This will update the money text box.
                    time = 0f; // This will set the timer back to 0 so that It can restart the timer.
                    timeText.text = Mathf.Round(time).ToString();

                    if (boats >= 3) // This will activate if there are 3 boats present.
                    {
                        money += 10; // this will add 10 to the variable money.
                        MoneyText.text = "Money: " + money.ToString(); // This will update the money text box.
                        time = 0f; // This will set the timer back to 0 so that It can restart the timer.
                        timeText.text = Mathf.Round(time).ToString();

                        if (boats >= 4) // This will activate if there are 4 boats present.
                        {
                            money += 10; // this will add 10 to the variable money.
                            MoneyText.text = "Money: " + money.ToString(); // This will update the money text box.
                            time = 0f; // This will set the timer back to 0 so that It can restart the timer.
                            timeText.text = Mathf.Round(time).ToString();

                            if (boats >= 5) // This will activate if there are 5 boats present.
                            {
                                money += 10; // this will add 10 to the variable money.
                                MoneyText.text = "Money: " + money.ToString(); // This will update the money text box.
                                time = 0f; // This will set the timer back to 0 so that It can restart the timer.
                                timeText.text = Mathf.Round(time).ToString();

                                if (boats >= 6) // This will activate if there are 6 boats present.
                                {
                                    money += 10; // this will add 10 to the variable money.
                                    MoneyText.text = "Money: " + money.ToString(); // This will update the money text box.
                                    time = 0f; // This will set the timer back to 0 so that It can restart the timer.
                                    timeText.text = Mathf.Round(time).ToString();

                                    if (boats >= 7) // This will activate if there are 7 boats present.
                                    {
                                        money += 10; // this will add 10 to the variable money.
                                        MoneyText.text = "Money: " + money.ToString(); // This will update the money text box.
                                        time = 0f; // This will set the timer back to 0 so that It can restart the timer.
                                        timeText.text = Mathf.Round(time).ToString();

                                        if (boats >= 8) // This will activate if there are 8 boats present.
                                        {
                                            money += 10; // this will add 10 to the variable money.
                                            MoneyText.text = "Money: " + money.ToString(); // This will update the money text box.
                                            time = 0f; // This will set the timer back to 0 so that It can restart the timer.
                                            timeText.text = Mathf.Round(time).ToString();

                                            if (boats >= 9) // This will activate if there are 9 boats present.
                                            {
                                                money += 10; // this will add 10 to the variable money.
                                                MoneyText.text = "Money: " + money.ToString(); // This will update the money text box.
                                                time = 0f; // This will set the timer back to 0 so that It can restart the timer.
                                                timeText.text = Mathf.Round(time).ToString();

                                                if (boats >= 10) // This will activate if there are 10 boats present.
                                                {
                                                    money += 10; // this will add 10 to the variable money.
                                                    MoneyText.text = "Money: " + money.ToString(); // This will update the money text box.
                                                    time = 0f; // This will set the timer back to 0 so that It can restart the timer.
                                                    timeText.text = Mathf.Round(time).ToString();

                                                    if (boats >= 11) // This will activate if there are 11 boats present.
                                                    {
                                                        money += 10; // this will add 10 to the variable money.
                                                        MoneyText.text = "Money: " + money.ToString(); // This will update the money text box.
                                                        time = 0f; // This will set the timer back to 0 so that It can restart the timer.
                                                        timeText.text = Mathf.Round(time).ToString();

                                                        if (boats >= 12) // This will activate if there are 12 boats present.
                                                        {
                                                            money += 10; // this will add 10 to the variable money.
                                                            MoneyText.text = "Money: " + money.ToString(); // This will update the money text box.
                                                            time = 0f; // This will set the timer back to 0 so that It can restart the timer.
                                                            timeText.text = Mathf.Round(time).ToString();
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        if (boats2 >= 1) // This will activate if there is 1 boat present
        {
            time2 += Time.deltaTime; // These lines of code will create a timer that will add money
            timeText2.text = Mathf.Round(time2).ToString(); // every certain ammount of seconds.

            if (time2 >= 5f) // This will activate when the timer hits 5 seconds.
        {
            money += 50; // this will add 50 to the variable money.
            MoneyText.text = "Money: " + money.ToString(); // This will update the money text box.
            time2 = 0f; // This will set the timer back to 0 so that It can restart the timer.
            timeText2.text = Mathf.Round(time2).ToString();

            if (boats2 >= 2) // This will activate if there are 2 boats present.
            {
                money += 50; // this will add 50 to the variable money.
                MoneyText.text = "Money: " + money.ToString(); // This will update the money text box.
                time2 = 0f; // This will set the timer back to 0 so that It can restart the timer.
                timeText2.text = Mathf.Round(time2).ToString();

                if (boats2 >= 3) // This will activate if there are 3 boats present.
                {
                    money += 50; // this will add 50 to the variable money.
                    MoneyText.text = "Money: " + money.ToString(); // This will update the money text box.
                    time2 = 0f; // This will set the timer back to 0 so that It can restart the timer.
                    timeText2.text = Mathf.Round(time2).ToString();

                    if (boats2 >= 4) // This will activate if there are 4 boats present.
                    {
                        money += 50; // this will add 50 to the variable money.
                        MoneyText.text = "Money: " + money.ToString(); // This will update the money text box.
                        time2 = 0f; // This will set the timer back to 0 so that It can restart the timer.
                        timeText2.text = Mathf.Round(time2).ToString();

                        if (boats2 >= 5) // This will activate if there are 5 boats present.
                        {
                            money += 50; // this will add 50 to the variable money.
                            MoneyText.text = "Money: " + money.ToString(); // This will update the money text box.
                            time2 = 0f; // This will set the timer back to 0 so that It can restart the timer.
                            timeText2.text = Mathf.Round(time2).ToString();

                            if (boats2 >= 6) // This will activate if there are 6 boats present.
                            {
                                money += 50; // this will add 50 to the variable money.
                                MoneyText.text = "Money: " + money.ToString(); // This will update the money text box.
                                time2 = 0f; // This will set the timer back to 0 so that It can restart the timer.
                                timeText2.text = Mathf.Round(time2).ToString();

                                if (boats2 >= 7) // This will activate if there are 7 boats present.
                                {
                                    money += 50; // this will add 50 to the variable money.
                                    MoneyText.text = "Money: " + money.ToString(); // This will update the money text box.
                                    time2 = 0f; // This will set the timer back to 0 so that It can restart the timer.
                                    timeText2.text = Mathf.Round(time2).ToString();

                                    if (boats2 >= 8) // This will activate if there are 8 boats present.
                                    {
                                        money += 50; // this will add 50 to the variable money.
                                        MoneyText.text = "Money: " + money.ToString(); // This will update the money text box.
                                        time2 = 0f; // This will set the timer back to 0 so that It can restart the timer.
                                        timeText2.text = Mathf.Round(time2).ToString();

                                        if (boats2 >= 9) // This will activate if there are 9 boats present.
                                        {
                                            money += 50; // this will add 50 to the variable money.
                                            MoneyText.text = "Money: " + money.ToString(); // This will update the money text box.
                                            time2 = 0f; // This will set the timer back to 0 so that It can restart the timer.
                                            timeText2.text = Mathf.Round(time2).ToString();

                                            if (boats2 >= 10) // This will activate if there are 10 boats present.
                                            {
                                                money += 50; // this will add 50 to the variable money.
                                                MoneyText.text = "Money: " + money.ToString(); // This will update the money text box.
                                                time2 = 0f; // This will set the timer back to 0 so that It can restart the timer.
                                                timeText2.text = Mathf.Round(time2).ToString();

                                                if (boats2 >= 11) // This will activate if there are 11 boats present.
                                                {
                                                    money += 50; // this will add 50 to the variable money.
                                                    MoneyText.text = "Money: " + money.ToString(); // This will update the money text box.
                                                    time2 = 0f; // This will set the timer back to 0 so that It can restart the timer.
                                                    timeText2.text = Mathf.Round(time2).ToString();

                                                    if (boats2 >= 12) // This will activate if there are 12 boats present.
                                                    {
                                                        money += 50; // this will add 50 to the variable money.
                                                        MoneyText.text = "Money: " + money.ToString(); // This will update the money text box.
                                                        time2 = 0f; // This will set the timer back to 0 so that It can restart the timer.
                                                        timeText2.text = Mathf.Round(time2).ToString();
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
    }
        // Money and time for the third upgrade
        if (boats3 >= 1) // This will activate if there is 1 boat present
        {
            time3 += Time.deltaTime; // These lines of code will create a timer that will add money
            timeText3.text = Mathf.Round(time3).ToString(); // every certain ammount of seconds.

            if (time3 >= 5f) // This will activate when the timer hits 5 seconds.
            {
                money += 100; // this will add 100 to the variable money.
                MoneyText.text = "Money: " + money.ToString(); // This will update the money text box.
                time3 = 0f; // This will set the timer back to 0 so that It can restart the timer.
                timeText3.text = Mathf.Round(time3).ToString();

                if (boats3 >= 2) // This will activate if there are 2 boats present.
                {
                    money += 100; // this will add 100 to the variable money.
                    MoneyText.text = "Money: " + money.ToString(); // This will update the money text box.
                    time3 = 0f; // This will set the timer back to 0 so that It can restart the timer.
                    timeText3.text = Mathf.Round(time3).ToString();

                    if (boats3 >= 3) // This will activate if there are 3 boats present.
                    {
                        money += 100; // this will add 100 to the variable money.
                        MoneyText.text = "Money: " + money.ToString(); // This will update the money text box.
                        time3 = 0f; // This will set the timer back to 0 so that It can restart the timer.
                        timeText3.text = Mathf.Round(time3).ToString();

                        if (boats3 >= 4) // This will activate if there are 4 boats present.
                        {
                            money += 100; // this will add 100 to the variable money.
                            MoneyText.text = "Money: " + money.ToString(); // This will update the money text box.
                            time3 = 0f; // This will set the timer back to 0 so that It can restart the timer.
                            timeText3.text = Mathf.Round(time3).ToString();

                            if (boats3 >= 5) // This will activate if there are 5 boats present.
                            {
                                money += 100; // this will add 100 to the variable money.
                                MoneyText.text = "Money: " + money.ToString(); // This will update the money text box.
                                time3 = 0f; // This will set the timer back to 0 so that It can restart the timer.
                                timeText3.text = Mathf.Round(time3).ToString();

                                if (boats3 >= 6) // This will activate if there are 6 boats present.
                                {
                                    money += 100; // this will add 100 to the variable money.
                                    MoneyText.text = "Money: " + money.ToString(); // This will update the money text box.
                                    time3 = 0f; // This will set the timer back to 0 so that It can restart the timer.
                                    timeText3.text = Mathf.Round(time3).ToString();

                                    if (boats3 >= 7) // This will activate if there are 7 boats present.
                                    {
                                        money += 100; // this will add 100 to the variable money.
                                        MoneyText.text = "Money: " + money.ToString(); // This will update the money text box.
                                        time3 = 0f; // This will set the timer back to 0 so that It can restart the timer.
                                        timeText3.text = Mathf.Round(time3).ToString();

                                        if (boats3 >= 8) // This will activate if there are 8 boats present.
                                        {
                                            money += 100; // this will add 100 to the variable money.
                                            MoneyText.text = "Money: " + money.ToString(); // This will update the money text box.
                                            time3 = 0f; // This will set the timer back to 0 so that It can restart the timer.
                                            timeText3.text = Mathf.Round(time3).ToString();

                                            if (boats3 >= 9) // This will activate if there are 9 boats present.
                                            {
                                                money += 100; // this will add 100 to the variable money.
                                                MoneyText.text = "Money: " + money.ToString(); // This will update the money text box.
                                                time3 = 0f; // This will set the timer back to 0 so that It can restart the timer.
                                                timeText3.text = Mathf.Round(time3).ToString();

                                                if (boats3 >= 10) // This will activate if there are 10 boats present.
                                                {
                                                    money += 100; // this will add 100 to the variable money.
                                                    MoneyText.text = "Money: " + money.ToString(); // This will update the money text box.
                                                    time3 = 0f; // This will set the timer back to 0 so that It can restart the timer.
                                                    timeText3.text = Mathf.Round(time3).ToString();

                                                    if (boats3 >= 11) // This will activate if there are 11 boats present.
                                                    {
                                                        money += 100; // this will add 100 to the variable money.
                                                        MoneyText.text = "Money: " + money.ToString(); // This will update the money text box.
                                                        time3 = 0f; // This will set the timer back to 0 so that It can restart the timer.
                                                        timeText3.text = Mathf.Round(time3).ToString();

                                                        if (boats3 >= 12) // This will activate if there are 12 boats present.
                                                        {
                                                            money += 100; // this will add 100 to the variable money.
                                                            MoneyText.text = "Money: " + money.ToString(); // This will update the money text box.
                                                            time3 = 0f; // This will set the timer back to 0 so that It can restart the timer.
                                                            timeText3.text = Mathf.Round(time3).ToString();
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
        // Money and upgrade for the forth upgrade
        if (boats4 >= 1) // This will activate if there is 1 boat present
        {
            time4 += Time.deltaTime; // These lines of code will create a timer that will add money
            timeText4.text = Mathf.Round(time4).ToString(); // every certain ammount of seconds.

            if (time4 >= 5f) // This will activate when the timer hits 5 seconds.
            {
                money += 300; // this will add 300 to the variable money.
                MoneyText.text = "Money: " + money.ToString(); // This will update the money text box.
                time4 = 0f; // This will set the timer back to 0 so that It can restart the timer.
                timeText4.text = Mathf.Round(time4).ToString();

                if (boats4 >= 2) // This will activate if there are 2 boats present.
                {
                    money += 300; // this will add 300 to the variable money.
                    MoneyText.text = "Money: " + money.ToString(); // This will update the money text box.
                    time4 = 0f; // This will set the timer back to 0 so that It can restart the timer.
                    timeText4.text = Mathf.Round(time4).ToString();

                    if (boats4 >= 3) // This will activate if there are 3 boats present.
                    {
                        money += 300; // this will add 300 to the variable money.
                        MoneyText.text = "Money: " + money.ToString(); // This will update the money text box.
                        time4 = 0f; // This will set the timer back to 0 so that It can restart the timer.
                        timeText4.text = Mathf.Round(time4).ToString();

                        if (boats4 >= 4) // This will activate if there are 4 boats present.
                        {
                            money += 300; // this will add 300 to the variable money.
                            MoneyText.text = "Money: " + money.ToString(); // This will update the money text box.
                            time4 = 0f; // This will set the timer back to 0 so that It can restart the timer.
                            timeText4.text = Mathf.Round(time4).ToString();

                            if (boats4 >= 5) // This will activate if there are 5 boats present.
                            {
                                money += 300; // this will add 300 to the variable money.
                                MoneyText.text = "Money: " + money.ToString(); // This will update the money text box.
                                time4 = 0f; // This will set the timer back to 0 so that It can restart the timer.
                                timeText4.text = Mathf.Round(time4).ToString();

                                if (boats4 >= 6) // This will activate if there are 6 boats present.
                                {
                                    money += 300; // this will add 300 to the variable money.
                                    MoneyText.text = "Money: " + money.ToString(); // This will update the money text box.
                                    time4 = 0f; // This will set the timer back to 0 so that It can restart the timer.
                                    timeText4.text = Mathf.Round(time4).ToString();

                                    if (boats4 >= 7) // This will activate if there are 7 boats present.
                                    {
                                        money += 300; // this will add 300 to the variable money.
                                        MoneyText.text = "Money: " + money.ToString(); // This will update the money text box.
                                        time4 = 0f; // This will set the timer back to 0 so that It can restart the timer.
                                        timeText4.text = Mathf.Round(time4).ToString();

                                        if (boats4 >= 8) // This will activate if there are 8 boats present.
                                        {
                                            money += 300; // this will add 300 to the variable money.
                                            MoneyText.text = "Money: " + money.ToString(); // This will update the money text box.
                                            time4 = 0f; // This will set the timer back to 0 so that It can restart the timer.
                                            timeText4.text = Mathf.Round(time4).ToString();

                                            if (boats4 >= 9) // This will activate if there are 9 boats present.
                                            {
                                                money += 300; // this will add 300 to the variable money.
                                                MoneyText.text = "Money: " + money.ToString(); // This will update the money text box.
                                                time4 = 0f; // This will set the timer back to 0 so that It can restart the timer.
                                                timeText4.text = Mathf.Round(time4).ToString();

                                                if (boats4 >= 10) // This will activate if there are 10 boats present.
                                                {
                                                    money += 300; // this will add 300 to the variable money.
                                                    MoneyText.text = "Money: " + money.ToString(); // This will update the money text box.
                                                    time4 = 0f; // This will set the timer back to 0 so that It can restart the timer.
                                                    timeText4.text = Mathf.Round(time4).ToString();

                                                    if (boats4 >= 11) // This will activate if there are 11 boats present.
                                                    {
                                                        money += 300; // this will add 300 to the variable money.
                                                        MoneyText.text = "Money: " + money.ToString(); // This will update the money text box.
                                                        time4 = 0f; // This will set the timer back to 0 so that It can restart the timer.
                                                        timeText4.text = Mathf.Round(time4).ToString();

                                                        if (boats4 >= 12) // This will activate if there are 12 boats present.
                                                        {
                                                            money += 300; // this will add 300 to the variable money.
                                                            MoneyText.text = "Money: " + money.ToString(); // This will update the money text box.
                                                            time4 = 0f; // This will set the timer back to 0 so that It can restart the timer.
                                                            timeText4.text = Mathf.Round(time4).ToString();
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        if (buildings1 >= 1) // This will activate if there is 1 building present
        {
            time5 += Time.deltaTime; // These lines of code will create a timer that will add money
            timeText5.text = Mathf.Round(time5).ToString(); // every certain ammount of seconds.
            if (time5 >= 5f) // This will activate when the timer hits 5 seconds.
            {
                money += 400; // this will add 400 to the variable money.
                MoneyText.text = "Money: " + money.ToString(); // This will update the money text box.
                time5 = 0f; // This will set the timer back to 0 so that It can restart the timer.
                timeText5.text = Mathf.Round(time5).ToString();
                if (buildings1 >= 2) // This will activate when the timer hits 5 seconds.
                {
                    money += 400; // this will add 400 to the variable money.
                    MoneyText.text = "Money: " + money.ToString(); // This will update the money text box.
                    time5 = 0f; // This will set the timer back to 0 so that It can restart the timer.
                    timeText5.text = Mathf.Round(time5).ToString();
                    if (buildings1 >= 3) // This will activate when the timer hits 5 seconds.
                    {
                        money += 400; // this will add 400 to the variable money.
                        MoneyText.text = "Money: " + money.ToString(); // This will update the money text box.
                        time5 = 0f; // This will set the timer back to 0 so that It can restart the timer.
                        timeText5.text = Mathf.Round(time5).ToString();
                        if (buildings1 >= 4) // This will activate when the timer hits 5 seconds.
                        {
                            money += 400; // this will add 400 to the variable money.
                            MoneyText.text = "Money: " + money.ToString(); // This will update the money text box.
                            time5 = 0f; // This will set the timer back to 0 so that It can restart the timer.
                            timeText5.text = Mathf.Round(time5).ToString();
                        }
                    }
                }
            }
        }

        if (buildings2 >= 1) // This will activate if there is 1 building present
        {
            time6 += Time.deltaTime; // These lines of code will create a timer that will add money
            timeText6.text = Mathf.Round(time6).ToString(); // every certain ammount of seconds.
            if (time6 >= 5f) // This will activate when the timer hits 5 seconds.
            {
                money += 800; // this will add 800 to the variable money.
                MoneyText.text = "Money: " + money.ToString(); // This will update the money text box.
                time6 = 0f; // This will set the timer back to 0 so that It can restart the timer.
                timeText6.text = Mathf.Round(time6).ToString();
                if (buildings2 >= 2) // This will activate when the timer hits 5 seconds.
                {
                    money += 800; // this will add 800 to the variable money.
                    MoneyText.text = "Money: " + money.ToString(); // This will update the money text box.
                    time6 = 0f; // This will set the timer back to 0 so that It can restart the timer.
                    timeText6.text = Mathf.Round(time6).ToString();
                    if (buildings2 >= 3) // This will activate when the timer hits 5 seconds.
                    {
                        money += 800; // this will add 800 to the variable money.
                        MoneyText.text = "Money: " + money.ToString(); // This will update the money text box.
                        time6 = 0f; // This will set the timer back to 0 so that It can restart the timer.
                        timeText6.text = Mathf.Round(time6).ToString();
                        if (buildings2 >= 4) // This will activate when the timer hits 5 seconds.
                        {
                            money += 800; // this will add 800 to the variable money.
                            MoneyText.text = "Money: " + money.ToString(); // This will update the money text box.
                            time6 = 0f; // This will set the timer back to 0 so that It can restart the timer.
                            timeText6.text = Mathf.Round(time6).ToString();
                        }
                    }
                }
            }
        }

        if (buildings3 >= 1) // This will activate if there is 1 building present
        {
            time7 += Time.deltaTime; // These lines of code will create a timer that will add money
            timeText7.text = Mathf.Round(time7).ToString(); // every certain ammount of seconds.
            if (time7 >= 5f) // This will activate when the timer hits 5 seconds.
            {
                money += 1200; // this will add 1200 to the variable money.
                MoneyText.text = "Money: " + money.ToString(); // This will update the money text box.
                time7 = 0f; // This will set the timer back to 0 so that It can restart the timer.
                timeText7.text = Mathf.Round(time7).ToString();
                if (buildings3 >= 2) // This will activate when the timer hits 5 seconds.
                {
                    money += 1200; // this will add 1200 to the variable money.
                    MoneyText.text = "Money: " + money.ToString(); // This will update the money text box.
                    time7 = 0f; // This will set the timer back to 0 so that It can restart the timer.
                    timeText7.text = Mathf.Round(time7).ToString();
                    if (buildings3 >= 3) // This will activate when the timer hits 5 seconds.
                    {
                        money += 1200; // this will add 1200 to the variable money.
                        MoneyText.text = "Money: " + money.ToString(); // This will update the money text box.
                        time7 = 0f; // This will set the timer back to 0 so that It can restart the timer.
                        timeText7.text = Mathf.Round(time7).ToString();
                        if (buildings3 >= 4) // This will activate when the timer hits 5 seconds.
                        {
                            money += 1200; // this will add 1200 to the variable money.
                            MoneyText.text = "Money: " + money.ToString(); // This will update the money text box.
                            time7 = 0f; // This will set the timer back to 0 so that It can restart the timer.
                            timeText7.text = Mathf.Round(time7).ToString();
                        }
                    }
                }
            }
        }
    }
                /*
                if (Input.GetKeyDown(KeyCode.Space))
                {
                    money++;
                }
                */
} 

