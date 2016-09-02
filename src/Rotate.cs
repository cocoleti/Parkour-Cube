using UnityEngine;

public class Rotate : MonoBehaviour {

	void Update () {
        rotate();
	}
	
    void rotate()
    {
        transform.Rotate(Vector3.forward * 3);
    }
}
