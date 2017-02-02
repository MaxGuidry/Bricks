using UnityEngine;
using System.Collections;

public class BallMovement : MonoBehaviour {
    private Vector3 velocity;
    // Use this for initialization
    void Start () {
        velocity.z = 0;
        velocity.y = .05f;
        velocity.x = Random.Range(-.05f,.05f );
    }
	
	// Update is called once per frame
	void Update () {
        transform.position += velocity;
	}
    void OnTriggerStay(Collider c)
    {
        if (c.tag == "Platform")
            velocity.y *= -1;
        if (c.tag == "Brick")
            velocity.y *= -1;
    }
}
