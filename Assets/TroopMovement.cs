using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TroopMovement : MonoBehaviour {
    public Transform target;
    public float speed;
    // Use this for initialization
    void Start () {
        target = FindObjectOfType<PlayerControl>().transform;
	}
	
	// Update is called once per frame
	void Update () {
        float step = speed * Time.deltaTime;
        Debug.Log(target.transform.position);
        transform.position = Vector3.MoveTowards(transform.position, target.position, step);
    }
}
