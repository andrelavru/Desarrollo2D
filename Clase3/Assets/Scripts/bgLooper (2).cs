using UnityEngine;
using System.Collections;

public class bgLooper : MonoBehaviour {

	// Use this for initialization
	Material mat;
	Vector2 ofset;
	public float speed;
	void Start () {
		mat = GetComponent<Renderer> ().material;
		ofset = mat.GetTextureOffset ("_MainText");
	}
	
	// Update is called once per frame
	void Update () {
		ofset.x += speed * Time.deltaTime;
		mat.SetTextureOffset ("_MainText", ofset);
		
	}
}
