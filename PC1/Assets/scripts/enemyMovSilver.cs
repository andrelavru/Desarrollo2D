using UnityEngine;
using System.Collections;

public class enemyMovSilver : MonoBehaviour {

    // Use this for initialization
    public float speed;
    void Start () {
    }
	
	// Update is called once per frame
	void Update () {
            if (gameObject.activeInHierarchy)
            {
                Vector3 position = transform.position;
                position.x -= speed * Time.deltaTime;
                transform.position = position;                
            }
    }
}
