using UnityEngine;
using UnityEngine.SceneManagement;

public class Restart : MonoBehaviour
{
    private int b;

    void Start()
    {
        b = SceneManager.GetActiveScene().buildIndex;
    }


    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.name == "Player")
            SceneManager.LoadScene("Level 1");
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
            SceneManager.LoadScene(b);
    }


}