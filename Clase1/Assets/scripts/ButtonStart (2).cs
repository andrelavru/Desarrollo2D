using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ButtonStart : MonoBehaviour {

    // Use this for initialization
    public int scene;
	void Start () {
		Button button = GetComponent<Button> ();
		button.onClick.AddListener (()=>goGame());
	}

	void goGame(){
		SceneManager.LoadScene (scene);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
