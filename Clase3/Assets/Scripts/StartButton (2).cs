using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using Runner;

public class StartButton : MonoBehaviour {

	// Use this for initialization
	void Start () {
		GetComponent<Button> ().onClick.AddListener (() => goChooser ());
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void goChooser(){
		SceneManager.LoadScene (Global.PLAYER_SELECT);
	}
}
