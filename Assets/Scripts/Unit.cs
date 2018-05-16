using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Unit : MonoBehaviour {

    int hp;
    int damage;
    int popCost;
    int goldCost;
    string level;
    string type;
    Sprite unitSprite;

    public Unit(Sprite unitSprite, string type, string level, int goldCost, int popCost, int hp, int damage)
    {
        this.unitSprite = unitSprite;
        this.type = type;
        this.level = level;
        this.goldCost = goldCost;
        this.popCost = popCost;
        this.hp = hp;
        this.damage = damage;
    }
 
}

