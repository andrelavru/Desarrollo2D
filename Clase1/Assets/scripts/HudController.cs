using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class HudController : MonoBehaviour {

	// Use this for initialization
	public int life;
	public Text txtScore;
	public Text txtLife;
	int score;
	Button buttonPause;
	void Start () {
		score = 0;
		txtScore.text = "Score: " + score;
		txtLife.text = "Life: " + life;
		buttonPause = GameObject.Find ("Pause").GetComponent<Button> ();
		buttonPause.onClick.AddListener (() => controlPause());
	}

	void controlPause()
	{
		if (Time.timeScale == 1) {
			Time.timeScale = 0;
		} else if (Time.timeScale == 0) 
		{
			Time.timeScale = 1;
		}

	}

	public void updateScore()
	{
		score += 1;
		txtScore.text = "Score: " + score;
	}

	public void updateLife()
	{
		life += 1;
		txtLife.text = "Life: " + life;
		
	}

	public void reduceLife ()
	{
		life -= 1;
		txtLife.text = "Life: " + life;
		if (life == 0) {
			PlayerPrefs.SetInt ("score", score);
			SceneManager.LoadScene (3);
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
