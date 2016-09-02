using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadLevel : MonoBehaviour {

    private int b;

    void Start()
    {
         b = SceneManager.GetActiveScene().buildIndex;
    }

void OnTriggerEnter2D (Collider2D other)
    {
        if (other.name == "Player")
            SceneManager.LoadScene(b + 1);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
            SceneManager.LoadScene(b);
    }


}