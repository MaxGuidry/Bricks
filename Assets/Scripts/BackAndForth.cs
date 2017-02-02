using UnityEngine;
using System.Collections;

public class BackAndForth : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey(KeyCode.RightArrow))
            this.transform.position += new Vector3(.1f, 0f, 0f);
        if (Input.GetKey(KeyCode.LeftArrow))
            this.transform.position += new Vector3(-.1f, 0f, 0f);
    }
    void OnTriggerEnter(Collider c)
    {
        if (Input.GetKey(KeyCode.RightArrow))
            this.transform.position += new Vector3(-.1f, 0f, 0f);
        if (Input.GetKey(KeyCode.LeftArrow))
            this.transform.position += new Vector3(.1f, 0f, 0f);
    }
    void OnCollisionStay()
    {
        if (Input.GetKey(KeyCode.RightArrow))
            this.transform.position += new Vector3(-.1f, 0f, 0f);
        if (Input.GetKey(KeyCode.LeftArrow))
            this.transform.position += new Vector3(.1f, 0f, 0f);
    }
}
