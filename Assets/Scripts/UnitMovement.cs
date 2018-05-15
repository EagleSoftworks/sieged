using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnitMovement : MonoBehaviour {

    public Transform target;
    private float speed = 5;
    /*
            // one time at object init
            void Start () {
                //target = FindObjectOfType<PlayerControl>().transform; // this appears to be a metaprogramming hack
            }

    */
    // every frame
    void Update()
    {
        float step = speed * Time.deltaTime;
        Debug.Log(target.transform.position);
        transform.position = Vector3.MoveTowards(transform.position, target.position, step);
    }
}
