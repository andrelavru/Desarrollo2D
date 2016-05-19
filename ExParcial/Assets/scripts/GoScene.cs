using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GoScene : MonoBehaviour {

    // Use this for initialization
    Button jugar;
    public int escena;
	void Start () {
        jugar = GetComponent<Button>();
        jugar.onClick.AddListener(()=>goGame());
	}

    void goGame()
    {
        SceneManager.LoadScene(escena);
    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
