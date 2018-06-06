using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Play : MonoBehaviour {

    public Button play;
    public string next;
    public GameObject isNull;
    public GameObject isActive;

	// Use this for initialization
	void Start () {
        play.onClick.AddListener(move);
	}

    void move () {
        isNull.SetActive(false);
        isActive.SetActive(true);
        SceneManager.LoadScene(next);
    }
}
