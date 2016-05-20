using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using System.Collections.Generic;


public class playerController : MonoBehaviour {

    // Use this for initialization
    [SerializeField]
    public float speed;
    public float jumpSpeed;
    [HideInInspector]
    private Animator paint;
    private Rigidbody2D hero;
    string color;
    int life;
    List<string> colors;
    
    void Start () {
        hero = GetComponent<Rigidbody2D>();
        paint = GetComponent<Animator>();
        //para qempieceal aza, creamos una lista
        color = "green";
        colors = new List<string>();
        colors.Add("green");
        colors.Add("blue");
        colors.Add("yellow");
        colors.Add("pink");
        //paint.Play();
        life = GameObject.FindGameObjectsWithTag("lifes").Length;
    }
	
	// Update is called once per frame
	void Update () {
        colores();
        controles();
        
	}

    void colores()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            color = "blue";
            paint.Play(color);
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            color = "green";
            paint.Play(color);
        }
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            color = "pink";
            paint.Play(color);
        }
        if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            color = "yellow";
            paint.Play(color);
        }
    }

    void controles()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            hero.velocity = new Vector2(speed * -1, hero.velocity.y);
            transform.localScale = new Vector3(-1,1,1);
            
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            hero.velocity = new Vector2(speed , hero.velocity.y);
            transform.localScale = new Vector3(1, 1, 1);
        }

        if (Input.GetKey(KeyCode.Space))
        {
            hero.velocity = new Vector2(hero.velocity.x, jumpSpeed);
        }
         
        
    }
    void OnTriggerEnter2D(Collider2D coll)
    {
        if (coll.gameObject.tag == color)
        {
            
        }
        else {
            life--;
            GameObject.FindGameObjectWithTag("lifes").SetActive(false);
            
        }
        if (life == 0)
        {
            SceneManager.LoadScene(2);
        }

    }
}
