using UnityEngine;
using System.Collections;

public class bulletMov : MonoBehaviour {

    // Use this for initialization
    Rigidbody2D bala;
    float speed;
	void Start () {
        bala = GetComponent<Rigidbody2D>();
        Invoke("kill", 5f);
        //////////voltenadola para q funcione en ambos sentidos
        speed = 2f * hero.instance.transform.localScale.x;
        bala.angularVelocity = 2;
        
	}

    void kill()
    {
        Destroy(gameObject);
    }
	
	// Update is called once per frame
	void Update () {
        bala.velocity = new Vector2(speed, bala.velocity.y);
	}
}
