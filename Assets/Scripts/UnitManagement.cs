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
        peasant.name = "peasant";
        peasant.transform.localScale = new Vector3(5f, 5f, 0);

        var hoplite = unitBundle.LoadAsset<GameObject>("Hoplite");
        hoplite.name = "hoplite";
        hoplite.transform.localScale = new Vector3(7f, 7f, 0);           

        var swordsman = unitBundle.LoadAsset<GameObject>("Swordsman");
        swordsman.name = "swordsman";
        swordsman.transform.localScale = new Vector3(7f, 7f, 0);

        units.Add("peasant", peasant);
        units.Add("hoplite", hoplite);
        units.Add("swordsman", swordsman);

        unitBundle.Unload(false);
    }


}