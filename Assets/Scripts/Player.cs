using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

public class Player : MonoBehaviour {

    public string playerName;

    private UnitCollection all_units;    // unused currently
    private UnitManagement manage_units; // unused
    private Guid uuid;
    private GameObject player;

    [Range(0, 1023)] private int facing;
    private Vector3 position;

    [Range(0, 10)] public float moveSpeed;

    public Player (Vector3 position, int facing) {
        this.uuid = Guid.NewGuid();
        this.position = position;
        this.facing = facing;

        this.all_units = new UnitCollection();
        this.manage_units = new UnitManagement();
    }

    public void Start()
    {
        // Test Programmatically creating a player object
        //player = new GameObject("Player");
        //player.AddComponent<Transform>(); // use to give random spawn
        //player.AddComponent<CircleCollider2D>();
        //player.AddComponent<Player>(); //circular
    }

    public void Update () {
        this.transform.position += getMoveInputs();
    }

    public Vector3 getMoveInputs()
    {
        // reset player direction
        Vector3 moving = Vector3.zero;

        if (Input.GetButton("up"))
        {
            Debug.Log("up");
            moving += Vector3.up;
        }
        if (Input.GetButton("down"))
        {
            Debug.Log("down");
            moving += Vector3.down;
        }
        if (Input.GetButton("left"))
        {
            Debug.Log("left");
            moving += Vector3.left;
        }
        if (Input.GetButton("right"))
        {
            Debug.Log("right");
            moving += Vector3.right;
        }

        // return player direction and speed
        return (moving.normalized / 10) * moveSpeed;
    }
}
//Emmett Sux