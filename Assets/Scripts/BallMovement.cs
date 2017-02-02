using UnityEngine;
using System.Collections;

public class BallMovement : MonoBehaviour
{
    private Vector3 velocity;
    // Use this for initialization
    void Start()
    {
        velocity.z = 0;
        velocity.y = .05f;
        velocity.x = Random.Range(-.05f, .05f);
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(Time.deltaTime);
        transform.position += velocity;
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Platform")
        {
            velocity = new Vector3((this.transform.position.x - other.transform.position.x) * Time.deltaTime, velocity.y, 0);
            velocity.y *= -1;
        }
        else if (other.tag == "Brick")
        {
            velocity.y *= -1;
            Destroy(other.gameObject);
        }
        if (other.tag == "LRWall")
            velocity.x *= -1;
        if (other.tag == "TBWall")
            velocity.y *= -1;
    }
    void OnCollisionEnter(Collider other)
    {
        
    }

}
