using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

/* Master Unit Manager */

public class UnitManagement : MonoBehaviour {
    
    private static Dictionary<string, GameObject> units = new Dictionary<string, GameObject>();

    public void Awake()
    {
        LoadUnits();
    }

    public static GameObject GetUnit(string unitName)
    {
        return units.ContainsKey(unitName) ? units[unitName] : null;            
    }

    void LoadUnits()
    {
        var unitBundle = AssetBundle.LoadFromFile(Path.Combine(Application.streamingAssetsPath, "units"));

        if (unitBundle == null)
        {
            Debug.Log("Failed to load asset bundle");
            return;
        }

        var peasant = unitBundle.LoadAsset<GameObject>("Peasant");
        peasant.transform.localScale = new Vector3(5f, 5f, 0);

        var hoplite = unitBundle.LoadAsset<GameObject>("Hoplite");
        hoplite.transform.localScale = new Vector3(7f, 7f, 0);           

        var swordsman = unitBundle.LoadAsset<GameObject>("Swordsman");
        swordsman.transform.localScale = new Vector3(7f, 7f, 0);

        units.Add("peasant", Instantiate(peasant));
        units.Add("hoplite", Instantiate(hoplite));
        units.Add("swordsman", Instantiate(swordsman));

        unitBundle.Unload(false);
    }


}