using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour {

    public Sprite[]  boats = new Sprite[5];
    private SpriteRenderer spRend;

    int i = 0;

    void Start()
    {
        spRend = GetComponent<SpriteRenderer>();
    }

    void Update ()
    {
        if(Input.GetKeyDown(KeyCode.F) && i < boats.Length)
        {
            spRend.sprite = boats[i++];
        }
    }
}
