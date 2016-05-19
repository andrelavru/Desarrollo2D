using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class spawner : MonoBehaviour {

	// Use this for initialization
	public GameObject[] elements;
	List<GameObject> enemys;
	float elapsed;
	void Start () {		
		enemys = new List<GameObject> ();
		createEnemy ();
	}

	void createEnemy(){
		for(int i = 0; i < elements.Length*3;i++)
		{
			int index = Random.Range(0, elements.Length);
			GameObject element = Instantiate (elements [index], transform.position, transform.rotation)as GameObject;
			enemys.Add (element);
			element.SetActive (false);
		}
	}
	
	// Update is called once per frame
	void Update () {
		elapsed += Time.deltaTime;
		if (elapsed >= 1) {
			elapsed = 0;
			generateElement ();
		}
	}

	void generateElement(){

		int index = Random.Range (0, enemys.Count);
		while (true) {
			if (!enemys [index].activeInHierarchy) {
				enemys [index].SetActive (true);
				enemys [index].transform.position = new Vector3 (transform.position.x, Random.Range (-5f, 5f), 0);
				break;
			} else {
				index = Random.Range (0, enemys.Count);
			}
		}

	}


}
