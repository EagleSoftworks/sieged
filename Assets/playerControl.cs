using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerControl : MonoBehaviour {

    public Transform player;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        if (Input.GetButton("up"))
        {
            player.transform.position = new Vector2(player.transform.position.x, player.transform.position.y + 0.1f);
        }
        if (Input.GetButton("down"))
        {
            player.transform.position = new Vector2(player.transform.position.x, player.transform.position.y - 0.1f);
        }
        if (Input.GetButton("left"))
        {
            player.transform.position = new Vector2(player.transform.position.x - 0.1f, player.transform.position.y);
        }
        if (Input.GetButton("right"))
        {
            player.transform.position = new Vector2(player.transform.position.x + 0.1f, player.transform.position.y);
        }
    }
}
