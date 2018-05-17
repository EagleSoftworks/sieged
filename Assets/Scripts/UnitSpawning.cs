using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnitSpawning : MonoBehaviour
{

    // sub-objects should not care about owners
    public Transform holder;

    // this object is never initialised
    public Transform[] prefab; // ????
    public Transform[] troopPoints; // ????

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
                Instantiate(prefab[6], transform.position, Quaternion.identity, holder);
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
                Instantiate(prefab[0], transform.position, Quaternion.identity, holder);
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
}
