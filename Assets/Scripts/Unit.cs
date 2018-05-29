using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Unit : MonoBehaviour {

    public int hp;
    public int damage;
    public int popCost;
    public int goldCost;
    int level;
    int experience;
    public string type;
    
    private void Start()
    {
        level = 1;
        experience = 0;
    }

    public void XPGain(int xp)
    {
        experience += xp;
    }
 
 
}

