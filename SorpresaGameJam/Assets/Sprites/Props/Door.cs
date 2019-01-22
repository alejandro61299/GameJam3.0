using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Door : MonoBehaviour {

    public SpriteRenderer room;
    public Sprite new_room;
    public Text room_name;

	void Start () {

	}

    private void OnMouseDown()
    {
        room.sprite = new_room;
        room_name.text = new_room.name;
    }
}
