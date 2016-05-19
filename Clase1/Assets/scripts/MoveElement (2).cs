using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class MoveElement : MonoBehaviour {

	// Use this for initialization
	public float speed;
	Vector3 limit;
	void Start () {
		limit = GameObject.Find ("Limit").transform.position;
	}
	
	// Update is called once per frame
	void Update () {
		if (gameObject.activeInHierarchy) {
			Vector3 position = transform.position;
			position.x -= speed*Time.deltaTime;
			transform.position = position;
			if(limit.x>transform.position.x){
				gameObject.SetActive(false);
			}
		}
	}
}
