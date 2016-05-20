using UnityEngine;
using System.Collections;

public class bulletSpawner : MonoBehaviour {

    // Use this for initialization
    float elapsed;
    public GameObject bullet;
    public Transform startPos;
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        elapsed += Time.deltaTime;
        if (Input.GetKey(KeyCode.Q))
        {
            if(elapsed >= 0.3f)
            {
                Instantiate(bullet, startPos.position, transform.rotation);
                elapsed = 0;
            }
            
        }
	}
}
