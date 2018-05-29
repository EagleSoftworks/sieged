using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArmyLayout : MonoBehaviour {

    private List<GameObject> armyUnits = new List<GameObject>();
    private int peasantIndex, hopliteIndex, swordsmanIndex;

    private Dictionary<int, GameObject> armyPositions = new Dictionary<int, GameObject>();
    private int positionIndex;

    private float playerColliderDistance;
    private float peasantRowDistance;
    private float hopliteRowDistance;
    private float swordsmanRowDistance;          
    
    private Transform player;
    private Transform army;
    private Transform lastSpawn;
    


	// Use this for initialization
	void Start () {
        player = transform.parent.parent.Find("PlayerObject").transform;
        playerColliderDistance = player.GetComponentInChildren<Player>().GetComponent<CircleCollider2D>().radius * 2;
        peasantRowDistance = UnitManagement.GetUnit("peasant").GetComponent<CircleCollider2D>().radius * 2;
        hopliteRowDistance = UnitManagement.GetUnit("hoplite").GetComponent<CircleCollider2D>().radius * 2;
        swordsmanRowDistance = UnitManagement.GetUnit("swordsman").GetComponent<CircleCollider2D>().radius * 2;
        positionIndex = 0;

    
    }
	
	// Update is called once per frame
	void Update () {
        CalculateUnitPOS();		
	}

    public void AddUnit(GameObject unit)
    {
        switch (unit.name)
        {
            case "peasant":
                armyUnits.Insert(peasantIndex++, unit);
                GameObject spawn = NextPosition();              
                unit.GetComponent<UnitMovement>().SetTarget(spawn.transform);
                armyPositions.Add(positionIndex++, spawn);                
                break;
            case "hoplite":
                armyUnits.Insert(++hopliteIndex, unit);
                break;
            case "swordsman":
                armyUnits.Insert(++swordsmanIndex, unit);
                break;
            default:
                break;

        }
    }

    public GameObject NextPosition()
    {     
        GameObject spawn = new GameObject("spawn");
        spawn.transform.position = new Vector2(player.transform.position.x + 
                                               peasantRowDistance + playerColliderDistance,  
                                               player.transform.position.y);
        spawn.transform.parent = player.GetComponentInChildren<ArmyLayout>().transform;
        return spawn;                         
    }

    public void CalculateUnitPOS()
    {
       
    }


}
