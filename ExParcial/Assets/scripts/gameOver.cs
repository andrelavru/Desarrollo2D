using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class gameOver : MonoBehaviour {

    // Use this for initialization
    public Text score;
	void Start () {
        score.text = "score: " + PlayerPrefs.GetInt("Score");
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
