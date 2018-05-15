using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Unit : MonoBehaviour {

    public int hp;
    public int damage;
    public int popCost;
    public int goldCost;
    public string level;
    public string type;

    public Unit(string type, string level, int goldCost, int popCost, int hp, int damage)
    {
        this.type = type;
        this.level = level;
        this.goldCost = goldCost;
        this.popCost = popCost;
        this.hp = hp;
        this.damage = damage;
    }
 
}

