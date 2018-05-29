using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnitMovement : MonoBehaviour {

    public Transform target;
    private float speed = 10;
    
    void Start()
    {
        //target = transform.parent.parent.gameObject.GetComponentInChildren<Player>().gameObject.transform;
    }
    
    // every frame
    void FixedUpdate()
    {
        float step = speed * Time.deltaTime;          
        transform.position = Vector3.MoveTowards(transform.position, target.position, step);
    }

    public void SetTarget(Transform target)
    {
        this.target = target;
    }
}
