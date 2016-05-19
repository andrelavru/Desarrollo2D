using UnityEngine;
using System.Collections;

public class bgScaler : MonoBehaviour {

	// Use this for initialization
	//Renderer render;
	float height, width;
	void Start () {
		//render = GetComponent<Renderer> ();
		height = Camera.main.orthographicSize * 2f;
		width = height * Screen.width / Screen.height;
		transform.localScale = new Vector3 (width, height, 0);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
