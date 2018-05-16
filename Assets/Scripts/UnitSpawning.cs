using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnitSpawning : MonoBehaviour
{
    public GameObject[] troops; // Troop Array
    public List<Transform> troopPlacement;
    public List<Vector3> spawnVectors = new List<Vector3>()
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
    private Transform nextPosition;

    public Vector3 NextSpawnVector()
    {
        if (spawnVectorIndex >= spawnVectors.Count)
        {
            spawnVectorIndex = 0;
        }
        return spawnVectors[spawnVectorIndex++].normalized;
    }

    void Start()
    {
        nextPosition.position = Vector3.right;      
    }
    // each frame
    void Update()
    {
        bool shift_held = Input.GetKey(KeyCode.LeftShift);

        // shift modifier
        if (shift_held)
        {
            if (Input.GetButtonDown(KeyCode.T.ToString()))
            {
                Instantiate(troops[6], new Vector3(2.0F, 0, 0), Quaternion.identity);
            }

            if (Input.GetButtonDown(KeyCode.Y.ToString()))
            {
                Instantiate(troops[7], new Vector3(2.0F, 0, 0), Quaternion.identity);
            }

            if (Input.GetButtonDown(KeyCode.U.ToString()))
            {
                Instantiate(troops[8], new Vector3(2.0F, 0, 0), Quaternion.identity);
            }

            if (Input.GetButtonDown(KeyCode.I.ToString()))
            {
                Instantiate(troops[9], new Vector3(2.0F, 0, 0), Quaternion.identity);
            }

            if (Input.GetButtonDown(KeyCode.O.ToString()))
            {
                Instantiate(troops[10], new Vector3(2.0F, 0, 0), Quaternion.identity);
            }

            if (Input.GetButtonDown(KeyCode.P.ToString()))
            {
                Instantiate(troops[11], new Vector3(2.0F, 0, 0), Quaternion.identity);
            }

        }
        else // keys alone
        {
            if (Input.GetButtonDown(KeyCode.T.ToString()))
            {                
                GameObject swordsman = Instantiate(troops[0], transform.position, transform.rotation);
                swordsman.transform.parent = transform.parent;
                swordsman.transform.position += NextSpawnVector();                 
                
            }

            if (Input.GetButtonDown(KeyCode.Y.ToString()))
            {
                Instantiate(troops[1], new Vector3(2.0F, 0, 0), Quaternion.identity);
            }

            if (Input.GetButtonDown(KeyCode.U.ToString()))
            {
                Instantiate(troops[2], new Vector3(2.0F, 0, 0), Quaternion.identity);
            }

            if (Input.GetButtonDown(KeyCode.I.ToString()))
            {
                Instantiate(troops[3], new Vector3(2.0F, 0, 0), Quaternion.identity);
            }

            if (Input.GetButtonDown(KeyCode.O.ToString()))
            {
                Instantiate(troops[4], new Vector3(2.0F, 0, 0), Quaternion.identity);
            }

            if (Input.GetButtonDown(KeyCode.P.ToString()))
            {
                Instantiate(troops[5], new Vector3(2.0F, 0, 0), Quaternion.identity);
            }
        }
    }
}
