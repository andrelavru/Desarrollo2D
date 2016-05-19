using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using Runner;

public class PlayerChooser : MonoBehaviour {

	// Use this for initialization
	private Button yellow, green, blue, pink;
	string player;

	void Start () {
		yellow = GameObject.Find ("Yellow").GetComponent<Button> ();
		green = GameObject.Find ("Green").GetComponent<Button> ();
		blue = GameObject.Find ("Blue").GetComponent<Button> ();
		pink = GameObject.Find ("Pink").GetComponent<Button> ();

		yellow.onClick.AddListener (() => chooseYellow ());
		green.onClick.AddListener (() => chooseGreen ());
		blue.onClick.AddListener (() => chooseBlue ());
		pink.onClick.AddListener (() => choosePink ());
	}

	void chooseYellow()
	{
		player = "yellow";
		goGame ();
	}

	void chooseGreen()
	{
		player = "green";
		goGame ();
	}

	void chooseBlue()
	{
		player = "blue";
		goGame ();
	}

	void choosePink()
	{
		player = "pink";
		goGame ();
	}

	void goGame()
	{
		PlayerPrefs.SetString ("color", player);
		SceneManager.LoadScene (Global.GAME);
	}
	// Update is called once per frame
	void Update () {
	
	}
}
