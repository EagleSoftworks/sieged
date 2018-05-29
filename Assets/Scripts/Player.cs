using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

public class Player : MonoBehaviour {

    private UnitCollection all_units;    // unused currently
    private UnitManagement manage_units; // unused
    private UnitSpawning spawn;
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
        spawn = GetComponentInChildren<UnitSpawning>();
    }

    public void Update () {
        
    }

    private void FixedUpdate()
    {
        float vertical = Input.GetAxis("Vertical");
        float horizontal = Input.GetAxis("Horizontal");

        //assign vertical input as a vector 2 value
        Vector2 movement = new Vector2(horizontal, vertical);

        GetComponent<Rigidbody2D>().AddForce(movement, ForceMode2D.Impulse);
    }



}