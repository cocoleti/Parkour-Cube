using UnityEngine;

public class Death : MonoBehaviour {

    public GameObject Spawn;
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
        Player.transform.position = Spawn.transform.position;
    }
                                    }
