using UnityEngine;
using System.Collections;

public class followCamera : MonoBehaviour {

    public float dx;
    public float dy;
    void Start () {
	
	}
	
	void Update () {
        if (hero.instance.alive)
        {
            float posX = hero.instance.transform.position.x - dx;
            float posY = hero.instance.transform.position.y - dy;
            transform.position = new Vector3(posX, posY, transform.position.z);
        }
        
	}
}
