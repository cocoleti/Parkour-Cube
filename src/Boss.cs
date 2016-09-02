using UnityEngine;

public class Boss : MonoBehaviour {

    public int bossspeed;
    public int bossheight;

    void OnTriggerStay2D(Collider2D other)
    {
        if (other.name == "Lefty")
        MoveLeft();
        else if (other.name == "Righty")
        MoveRight();
       else if (other.name == "Jump") 
        Jump();
    }

    public void MoveLeft()
    {
        GetComponent<Rigidbody2D>().velocity = new Vector2(-bossspeed, 0);
    }

    public void MoveRight()
    {
        GetComponent<Rigidbody2D>().velocity = new Vector2(bossspeed, 0);
    }

    public void Jump()
    {
        GetComponent<Rigidbody2D>().velocity = new Vector2 (GetComponent<Rigidbody2D>().velocity.x, bossheight);
    }

}
