using UnityEngine;

public class Movement : MonoBehaviour {

    public float movespeed;
    public float jumpheight;
   
    public Transform groundcheck;
    public float gcheckradius;
    public LayerMask whatisground;
    private bool grounded;
    private bool doublejump;


    //Physics based
    void FixedUpdate () {
        grounded = Physics2D.OverlapCircle(groundcheck.position, gcheckradius, whatisground);
    }

    public void Jump()
    {
        GetComponent<Rigidbody2D>().velocity = new Vector2(GetComponent<Rigidbody2D>().velocity.x, jumpheight);
    }

    void Update()
    {

        if (grounded) 
            doublejump = false;

        if (Input.GetKeyDown(KeyCode.Escape))
            Application.Quit();

        if (Input.GetKeyDown(KeyCode.Space) && grounded )
        {
            Jump();
        }

        if (Input.GetKeyDown(KeyCode.Space) && !doublejump && !grounded)
        {
            Jump();
            doublejump = true;
        }
            //GetKey is for holding down while getkeydown is once
            if (Input.GetKey(KeyCode.D))
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(movespeed,  GetComponent<Rigidbody2D>().velocity.y);
        }

        if (Input.GetKey(KeyCode.A))
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(-movespeed, GetComponent<Rigidbody2D>().velocity.y);
        }                                                   //-movespeed is left because of coordinates or a graph

        if (Input.GetKeyUp(KeyCode.A))
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(0, GetComponent<Rigidbody2D>().velocity.y);        }

     if (Input.GetKeyUp(KeyCode.D))
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(0, GetComponent<Rigidbody2D>().velocity.y);
        }
     


        if (Input.GetKey(KeyCode.RightArrow))
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(movespeed, GetComponent<Rigidbody2D>().velocity.y);
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(-movespeed, GetComponent<Rigidbody2D>().velocity.y);
        }                                                   //-movespeed is left because of coordinates or a graph

        if (Input.GetKeyUp(KeyCode.LeftArrow))
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(0, GetComponent<Rigidbody2D>().velocity.y);
        }

        if (Input.GetKeyUp(KeyCode.RightArrow))
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(0, GetComponent<Rigidbody2D>().velocity.y);
        }

    }   
}
