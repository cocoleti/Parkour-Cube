using UnityEngine;

public class BossEnd : MonoBehaviour
{
    public GameObject Door;
    public GameObject Floor;
    public GameObject Right;
    public GameObject Left;
    public GameObject Jump;
    public GameObject End;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.name == "Player")
        Destroy(Door);
        Destroy(Floor);
        Destroy(Right);
        Destroy(Left);
        Destroy(Jump);
        Destroy(End);
    }

    
}