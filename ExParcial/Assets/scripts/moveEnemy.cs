using UnityEngine;
using System.Collections;

public class moveEnemy : MonoBehaviour {

    // Use this for initialization
    public float speed;
	void Start () {
	   
	}
	
	// Update is called once per frame
	void Update () {
        if (gameObject.activeInHierarchy)
        {
            Vector3 position = transform.position;
            position.y += speed * Time.deltaTime;
            transform.position = position;
        }
        if (gameObject.transform.position.y <= -5)
        {
            gameObject.SetActive(false);
        }
        else
        {
            gameObject.SetActive(true);
        }
	}
}
