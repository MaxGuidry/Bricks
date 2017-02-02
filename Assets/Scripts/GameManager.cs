using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {

    public GameObject ball;
    public GameObject brick;
    private GameObject[] bricks;
    private Transform positionForBricks;
    
    // Use this for initialization
	void Start () {
        positionForBricks.position = new Vector3(-8f, 2, 0);
        for (int i =0;i<10;i++)
        {
            brick.transform.position = positionForBricks.position;
            //bricks[i] = brick;
            //bricks[i] = Instantiate(brick);
            brick = Instantiate(brick) as GameObject;
            positionForBricks.position += new Vector3(2, 0, 0);
        }
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    
}
