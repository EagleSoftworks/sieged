using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnitSpawning : MonoBehaviour
{
    private ArmyLayout armyLayout;
    private List<Vector3> spawnVectors = new List<Vector3>()
    {
        Vector3.right,
        Vector3.right + Vector3.up,
        Vector3.up,
        Vector3.up + Vector3.left,
        Vector3.left,
        Vector3.left + Vector3.down,
        Vector3.down,
        Vector3.down + Vector3.right
    };

    private int spawnVectorIndex = 0;
    private Transform player;

    void Start()
    {
        armyLayout = GetComponent<ArmyLayout>();
        player = transform.parent.gameObject.GetComponentInChildren<Player>().transform;
    }         

    // each frame
    void Update()
    {
        HandleInput();
    }

    private GameObject SpawnUnit(string unitName)
    {
        GameObject unit = Instantiate(UnitManagement.GetUnit(unitName),
                                                   player.position,
                                                   transform.rotation);
        unit.transform.parent = transform;
        unit.transform.position += NextSpawnVector();

        return unit;
    }

    public Vector3 NextSpawnVector()
    {
        short spawnOffsetModifier = 4;

        if (spawnVectorIndex >= spawnVectors.Count)
        {
            spawnVectorIndex = 0;
        }
        return spawnVectors[spawnVectorIndex++].normalized * spawnOffsetModifier;
    }

    private void HandleInput()
    {
        if (Input.GetButtonDown("Swordsman"))
        {
            GameObject unit = SpawnUnit("swordsman");
            unit.name = "swordsman";
            armyLayout.AddUnit(unit);
        }      
            
        if (Input.GetButtonDown("Hoplite"))
        {
            GameObject unit = SpawnUnit("hoplite");
            unit.name = "hoplite";
            armyLayout.AddUnit(unit);
        }

        if (Input.GetButtonDown("Peasant"))
        {
            GameObject unit =  SpawnUnit("peasant");
            unit.name = "peasant";
            armyLayout.AddUnit(unit);
        }           
    }
}
