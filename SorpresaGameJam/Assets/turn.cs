using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class turn : MonoBehaviour {

    public bool face = false;

    public Sprite top;
    public Sprite bot;

    public void Turn()
    {
        face = !face;
        if(face)
        {
            GameObject.Find("RoomSprite").GetComponent<SpriteRenderer>().sprite = top;
        }
        else
        {
            GameObject.Find("RoomSprite").GetComponent<SpriteRenderer>().sprite = bot;
        }
    }
}
