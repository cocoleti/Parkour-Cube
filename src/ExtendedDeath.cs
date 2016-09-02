using UnityEngine;

public class ExtendedDeath : MonoBehaviour
{
    public GameObject EndSpawn;
    public Movement Player;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.name == "Player")
        {
            Respawn();
        }

    }

    public void Respawn()
    {
        Player.transform.position = EndSpawn.transform.position;

    }
}