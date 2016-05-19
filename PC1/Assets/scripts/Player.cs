using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

    // Use this for initialization
    Rigidbody2D hero;
    private float scaleX;
	void Start () {
        scaleX = transform.localScale.x;
        hero = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            hero.velocity = new Vector2(-2f, hero.velocity.y);
            transform.localScale = new Vector3(-scaleX, transform.localScale.y, transform.localScale.z);
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            hero.velocity = new Vector2(2f, hero.velocity.y);
            transform.localScale = new Vector3(scaleX, transform.localScale.y, transform.localScale.z);
        }

        if (!Input.anyKey)
        {
            hero.velocity = new Vector2(0, hero.velocity.y);
            
        }
    }
}
