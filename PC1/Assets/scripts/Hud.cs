using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Hud : MonoBehaviour {

    // Use this for initialization
    public int vidas;
    public Text txtVidas;
	void Start () {
        txtVidas.text = "Vidas: " + vidas;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
