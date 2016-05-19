using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SetDificultad : MonoBehaviour {

    // Use this for initialization
    private Button bronce, plata, oro;
    string dificultad;
	void Start () {
        bronce = GameObject.Find("btnBronce").GetComponent<Button>();
        plata = GameObject.Find("btnPlata").GetComponent<Button>();
        oro = GameObject.Find("btnOro").GetComponent<Button>();

        bronce.onClick.AddListener(()=>chooseBronce());
        plata.onClick.AddListener(() => choosePlata());
        oro.onClick.AddListener(() => chooseOro());


    }

    void chooseBronce()
    {
        dificultad = "bronce";
        goGame();
    }

    void choosePlata()
    {
        dificultad = "plata";
        goGame();
    }

    void chooseOro()
    {
        dificultad = "oro";
        goGame();
    }

    void goGame()
    {
        PlayerPrefs.SetString("metal", dificultad);
    }
    // Update is called once per frame
    void Update () {
	
	}
}
