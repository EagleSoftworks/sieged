using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/* unit control and movement */

public class UnitManagement /* : MonoBehaviour ? */ {

    public class UnitMovement : MonoBehaviour {

      public:
        Transform target;
        float speed;
        // one time at object init
        void Start () {
            target = FindObjectOfType<PlayerControl>().transform; // this appears to be a metaprogramming hack
        }

        // every frame
        void Update () {
            float step = speed * Time.deltaTime;
            Debug.Log(target.transform.position);
            transform.position = Vector3.MoveTowards(transform.position, target.position, step);
        }
    }

    public class UnitSpawning : MonoBehaviour {

        // sub-objects should not care about owners
        // public Transform player; // ??

        // this object is never initialised
        public Transform[] prefab; // ????

        void Start () { }
        // each frame
        void Update () {
            bool shift_held = Input.GetKey(KeyCode.LeftShift);

            // shift modifier
            if (shift_held)
            {
                if (Input.GetButtonDown(KeyCode.T.ToString()))
                {
                    Instantiate(prefab[6], new Vector3(2.0F, 0, 0), Quaternion.identity);
                }

                if (Input.GetButtonDown(KeyCode.Y.ToString()))
                {
                    Instantiate(prefab[7], new Vector3(2.0F, 0, 0), Quaternion.identity);
                }

                if (Input.GetButtonDown(KeyCode.U.ToString()))
                {
                    Instantiate(prefab[8], new Vector3(2.0F, 0, 0), Quaternion.identity);
                }

                if (Input.GetButtonDown(KeyCode.I.ToString()))
                {
                    Instantiate(prefab[9], new Vector3(2.0F, 0, 0), Quaternion.identity);
                }

                if (Input.GetButtonDown(KeyCode.O.ToString()))
                {
                    Instantiate(prefab[10], new Vector3(2.0F, 0, 0), Quaternion.identity);
                }

                if (Input.GetButtonDown(KeyCode.P.ToString()))
                {
                    Instantiate(prefab[11], new Vector3(2.0F, 0, 0), Quaternion.identity);
                }

            }
            else // keys alone
            {
                if (Input.GetButtonDown(KeyCode.T.ToString()))
                {
                    Instantiate(prefab[0], new Vector3(2.0F, 0, 0), Quaternion.identity);
                }

                if (Input.GetButtonDown(KeyCode.Y.ToString()))
                {
                    Instantiate(prefab[1], new Vector3(2.0F, 0, 0), Quaternion.identity);
                }

                if (Input.GetButtonDown(KeyCode.U.ToString()))
                {
                    Instantiate(prefab[2], new Vector3(2.0F, 0, 0), Quaternion.identity);
                }

                if (Input.GetButtonDown(KeyCode.I.ToString()))
                {
                    Instantiate(prefab[3], new Vector3(2.0F, 0, 0), Quaternion.identity);
                }

                if (Input.GetButtonDown(KeyCode.O.ToString()))
                {
                    Instantiate(prefab[4], new Vector3(2.0F, 0, 0), Quaternion.identity);
                }

                if (Input.GetButtonDown(KeyCode.P.ToString()))
                {
                    Instantiate(prefab[5], new Vector3(2.0F, 0, 0), Quaternion.identity);
                }
            }
        }
    }
}