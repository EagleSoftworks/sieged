using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Transition : MonoBehaviour {

    public GameObject saved;
    public InputField userInput;
    public Text playerName;

	// Use this for initialization
	void Start () {
        playerName.text = userInput.text;
	}
	
	// Update is called once per frame
	void Update () {
        PlayerPrefs.SetString("Name", userInput.text); 
        playerName.text = PlayerPrefs.GetString("Name");
        DontDestroyOnLoad(saved);
	}
}
