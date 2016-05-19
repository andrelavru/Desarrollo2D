using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SetScene : MonoBehaviour {

    // Use this for initialization

    public int escena;
	void Start () {
	    GetComponent<Button>().onClick.AddListener(()=>goScene());
	}

    void goScene()
    {
        SceneManager.LoadScene(escena);
    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
