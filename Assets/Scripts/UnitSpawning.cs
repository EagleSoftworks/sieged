using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

public class UnitSpawning : MonoBehaviour
{

    // sub-objects should not care about owners
    public Transform holder;
    public Transform grid;

    // this object is never initialised
    public Transform[] prefab; // ????
    public List<Transform> troops;
    public List<Transform> troopPoints; // ????

    public GameObject trackingPoint;

    private float lastAngle = 0f;
    private Vector3 newTroopOffset;
    private Vector3 newTroopPos;

    void Start()
    {
        
    }
    // each frame
    void Update()
    {
        bool shift_held = Input.GetKey(KeyCode.LeftShift);

        // shift modifier
        if (shift_held)
        {
            if (Input.GetButtonDown(KeyCode.T.ToString()))
            {

                Transform troop = Instantiate(prefab[6], transform.position, Quaternion.identity, holder);
                troops.Add(troop);
            }   

            if (Input.GetButtonDown(KeyCode.Y.ToString()))
            {
                Instantiate(prefab[7], transform.position, Quaternion.identity, holder);
            }

            if (Input.GetButtonDown(KeyCode.U.ToString()))
            {
                Instantiate(prefab[8], transform.position, Quaternion.identity, holder);
            }

            if (Input.GetButtonDown(KeyCode.I.ToString()))
            {
                Instantiate(prefab[9], transform.position, Quaternion.identity, holder);
            }

            if (Input.GetButtonDown(KeyCode.O.ToString()))
            {
                Instantiate(prefab[10], transform.position, Quaternion.identity, holder);
            }

            if (Input.GetButtonDown(KeyCode.P.ToString()))
            {
                Instantiate(prefab[11], transform.position, Quaternion.identity, holder);
            }

        }
        else // keys alone
        {
            if (Input.GetButtonDown(KeyCode.T.ToString()))
            {
                GameObject point = Instantiate(trackingPoint, nexttroopPos(), Quaternion.identity, grid);
                troopPoints.Insert(0, point.transform);

                Transform troop = Instantiate(prefab[0], transform.position, Quaternion.identity, holder);
                troops.Add(troop);
                
                
            }

            if (Input.GetButtonDown(KeyCode.Y.ToString()))
            {
                Instantiate(prefab[1], transform.position, Quaternion.identity, holder);
            }

            if (Input.GetButtonDown(KeyCode.U.ToString()))
            {
                Instantiate(prefab[2], transform.position, Quaternion.identity, holder);
            }   

            if (Input.GetButtonDown(KeyCode.I.ToString()))
            {
                Instantiate(prefab[3], transform.position, Quaternion.identity, holder);
            }

            if (Input.GetButtonDown(KeyCode.O.ToString()))
            {
                Instantiate(prefab[4], transform.position, Quaternion.identity, holder);
            }

            if (Input.GetButtonDown(KeyCode.P.ToString()))
            {
                Instantiate(prefab[5], transform.position, Quaternion.identity, holder);
            }
        }
    }

    Vector3 nexttroopPos()
    {
        if (troops.Count > 59)
        {
            newTroopOffset = new Vector3((Mathf.Cos(Convert.ToSingle(lastAngle * Math.PI / 180))), (Mathf.Sin(Convert.ToSingle(lastAngle * Math.PI / 180))), 0f);
            newTroopOffset = newTroopOffset.normalized * (25f);
            newTroopPos = newTroopOffset + this.transform.position;
            lastAngle += 12;
            return newTroopPos;
        }
        else if (troops.Count > 35)
        {
            newTroopOffset = new Vector3((Mathf.Cos(Convert.ToSingle(lastAngle * Math.PI / 180))), (Mathf.Sin(Convert.ToSingle(lastAngle * Math.PI / 180))), 0f);
            newTroopOffset = newTroopOffset.normalized * (20f);
            newTroopPos = newTroopOffset + this.transform.position;
            lastAngle += 15;
            return newTroopPos;
        }
        else if (troops.Count > 17)
        {
            newTroopOffset = new Vector3((Mathf.Cos(Convert.ToSingle(lastAngle * Math.PI / 180))), (Mathf.Sin(Convert.ToSingle(lastAngle * Math.PI / 180))), 0f);
            newTroopOffset = newTroopOffset.normalized * (15f);
            newTroopPos = newTroopOffset + this.transform.position;
            lastAngle += 20;
            return newTroopPos;
        }
        else if (troops.Count > 5)
        {
            newTroopOffset = new Vector3((Mathf.Cos(Convert.ToSingle(lastAngle * Math.PI / 180))), (Mathf.Sin(Convert.ToSingle(lastAngle * Math.PI / 180))), 0f);
            newTroopOffset = newTroopOffset.normalized * (10f);
            newTroopPos = newTroopOffset + this.transform.position;
            lastAngle += 30;
            return newTroopPos;
        }
        else
        {
            newTroopOffset = new Vector3((Mathf.Cos(Convert.ToSingle(lastAngle * Math.PI / 180))), (Mathf.Sin(Convert.ToSingle(lastAngle * Math.PI / 180))), 0f);
            newTroopOffset = newTroopOffset.normalized * (5f);
            newTroopPos = newTroopOffset + this.transform.position;
            lastAngle += 60;
            return newTroopPos;
        }
    }
}
