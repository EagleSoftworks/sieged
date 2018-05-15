using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

public class Player : MonoBehaviour {

    private PlayerControl control;
    private UnitCollection all_units;    // unused currently
    private UnitManagement manage_units; // unused
    private Guid uuid;

    [Range(0, 1023)] private int facing;
    private Vector3 position;

    public Player (Vector3 position, int facing) {
        this.uuid = Guid.NewGuid();
        this.position = position;
        this.facing = facing;

        this.all_units = new UnitCollection();
        this.manage_units = new UnitManagement();
        this.control = new Player.PlayerControl();
    }

    public void Update () {
        this.position += this.control.getMoveInputs();
    }

    public class PlayerControl : MonoBehaviour {

      [Range(0, 10)] public float moveSpeed;

  //private:
      //float facing;
      //Vector3 moving;

    	public void Start () {
        this.moveSpeed = 5;
        //this.facing = 0;
        //this.moving = new Vector3.zero;
    	}

      public Vector3 getMoveInputs () {
          // reset player direction
          Vector3 moving = Vector3.zero;

          if (Input.GetButton("up"))
          {
              moving += Vector3.up;
          }
          if (Input.GetButton("down"))
          {
              moving += Vector3.down;
          }
          if (Input.GetButton("left"))
          {
              moving += Vector3.left;
          }
          if (Input.GetButton("right"))
          {
              moving += Vector3.right;
          }

          // return player direction and speed
          return (moving.normalized / 10) * moveSpeed;
      }

/*
      public void Update () {
          this.player.transform.position += this.getMoveInputs();
      }
*/
    }

}