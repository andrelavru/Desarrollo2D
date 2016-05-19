using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;


public class playerController : MonoBehaviour {

    // Use this for initialization
    [SerializeField]
    public float speed;
    [HideInInspector]
    private Animator paint;
    private Rigidbody2D hero;
    int life;
    
    void Start () {
        hero = GetComponent<Rigidbody2D>();
        paint = GetComponent<Animator>();
        
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
            paint.Play("blue");
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            paint.Play("green");
        }
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            paint.Play("pink");
        }
        if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            paint.Play("yellow");
        }
    }

    void controles()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            hero.velocity = new Vector2(speed * -1, 0);
            transform.localScale = new Vector3(-1,1,1);
            
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            hero.velocity = new Vector2(speed , 0);
            transform.localScale = new Vector3(1, 1, 1);
        }

        if (Input.GetKey(KeyCode.Space))
        {
            hero.velocity = new Vector2(0, 0);
        }
        if (!Input.GetKey(KeyCode.LeftArrow)&&!Input.GetKey(KeyCode.RightArrow))
        {
            hero.velocity = new Vector2(0, 0);
        }
        
    }
    void OnColisionEnter2D(Collision2D coll)
    {        
        life = GameObject.FindGameObjectsWithTag("lifes").Length;
        life--;
        GameObject.FindGameObjectWithTag("lifes").SetActive(false);
        if (life == 0)
        {
            SceneManager.LoadScene(2);
        }

    }
}
