using System.Collections;
using System.Collections.Generic;
using System.Guid;
using UnityEngine;

public class Player : MonoBehaviour {

private:
  PlayerControl control;
  UnitCollection all_units;
  UnitManagement manage_units;
  Guid uuid;

  public Player () {
      this.uuid = Guid.NewGuid();
      this.all_units = new UnitCache();
      this.manage_units = new UnitManagement();
  }

  public class PlayerControl : MonoBehaviour {

    [Range(0, 10)] public float moveSpeed;

  //private:
      //float facing;
      //Vector3 moving;

    	public void Start () {
        moveSpeed = 5;
        //this.facing = 0;
        //this.moving = new Vector3.zero;
    	}

      private Vector3 getMoveInputs ()
      {
          // reset player direction
          const Vector3 moving = Vector3.zero;

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

    	// Update is called once per frame
    	public void Update () {
          player.transform.position += this.getMoveInputs();
      }
  }

}