using UnityEngine;

public class Platform : MonoBehaviour {

    private int platformSpeed = 10;
    public GameObject Switch1;
    public GameObject Switch2;

	void OnTriggerStay2D(Collider2D other)
    {
        if (other.name == "Switch1")
            MoveRight();
        else if (other.name == "Switch2")
            MoveLeft();

    }




    public void MoveLeft()
    {
        GetComponent<Rigidbody2D>().velocity = new Vector2(-platformSpeed, 0);
    }

    public void MoveRight()
    {
        GetComponent<Rigidbody2D>().velocity = new Vector2(platformSpeed, 0);
    }

}


