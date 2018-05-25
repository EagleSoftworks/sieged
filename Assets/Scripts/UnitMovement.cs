using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

public class UnitMovement : MonoBehaviour {

    public Transform target;
    public float speed = 5;

    private List<Transform> targetGrid = new List<Transform>();
    public int index;

    // one time at object init
    void Start () {
        this.transform.parent = transform;
        
        Transform player = this.transform.parent.parent;

        UnitSpawning spawnScript = player.GetComponentInChildren<UnitSpawning>();
        index = spawnScript.troops.IndexOf(transform);

        targetGrid = spawnScript.troopPoints;
        target = targetGrid[index].transform;
    }


    // every frame
    void Update()
    {
        float step = speed * Time.deltaTime;
        Debug.Log(target.transform.position);
        transform.position = Vector3.MoveTowards(transform.position, target.position, step);
    }
}
