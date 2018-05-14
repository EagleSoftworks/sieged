using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerControl : MonoBehaviour {

    public Transform player;
    
    private Vector3 playerHeading;

    [Range(5, 10)] public float moveSpeed;

	// Use this for initialization
	void Start () {
		
	}
	
    // Determine move direction
    Vector3 GetHeading ()
    {
        // reset player direction
        playerHeading = Vector3.zero;

        if (Input.GetButton("up"))
        {
            playerHeading += Vector3.up;
        }
        if (Input.GetButton("down"))
        {
            playerHeading += Vector3.down;
        }
        if (Input.GetButton("left"))
        {
            playerHeading += Vector3.left;
        }
        if (Input.GetButton("right"))
        {
            playerHeading += Vector3.right;
        }

        // return player direction and speed
        return (playerHeading.normalized / 10) * moveSpeed;
    }

	// Update is called once per frame
	void Update () {

        player.transform.position += GetHeading();
    }
}
