using UnityEngine;
using System.Collections;

public class hero : MonoBehaviour {

    
    /// /////////////SALTO/////////////
    /// </summary>
    Rigidbody2D body;
    public LayerMask whatIsGround;
    public Transform groundPos;
    public float radius;
    public float jumpPower;
   // public float speed;
    bool doubleJump;
    bool onGround;
    Animator anim;
    //safe point
    public bool alive;

    public static hero instance;

    void Awake()
    {
        instance = this;
    }
   
    /// ///////////////////////////////
    
	void Start () {
        body = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        alive = true;
	}

	
	// Update is called once per frame
	void Update () {
        /////safe point
        if (transform.position.y < -Camera.main.orthographicSize && alive)
        {
            gameObject.SetActive(false);
            alive = false;
            transform.position = setPointController.instance.transform.position;
        }
       
        ///////////////SALTO///////////////////////
            onGround = Physics2D.OverlapCircle(groundPos.position, radius, whatIsGround);
        

        if (Input.GetKeyDown(KeyCode.Space)) 
        {
            //anim.Play("stand");
            if (onGround)
            {
                doubleJump = false;
                body.velocity = new Vector2(body.velocity.x, jumpPower);
            }
            else
            {
                if (!doubleJump)
                {
                    doubleJump = true;
                    body.velocity = new Vector2(body.velocity.x, jumpPower);
                }
            }
        }
        /////////////////////////////////////////
        float forceX = 0;
        if (Input.GetKey(KeyCode.A))
        {
            forceX = -2f;
           // body.velocity = new Vector2(speed*-1, body.velocity.y);
            body.transform.localScale = new Vector3(-1,1,1);
            
        }

        if (Input.GetKey(KeyCode.D))
        {
            forceX = 2f;
            //body.velocity = new Vector2(speed, body.velocity.y);
            body.transform.localScale = new Vector3(1, 1, 1);
        }

        /////animaciones
        if (forceX != 0)
        {
            anim.Play("hero");
        }
        else {
            anim.Play("stand");
        }
        ////////////////

        body.velocity = new Vector2(forceX, body.velocity.y);
    }

    void reinicio()
    {
        alive = true;
        gameObject.SetActive(true);
    }
}
