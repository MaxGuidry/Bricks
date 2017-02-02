using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour
{

    public GameObject ball;
    public GameObject brick;
    private GameObject[] bricks;
    private Transform positionForBricks;

    // Use this for initialization
    void Start()
    {
        positionForBricks = brick.transform;
        MakeBricks();
    }

    // Update is called once per frame
    void Update()
    {

    }

    void MakeBricks()
    {
        positionForBricks.position = new Vector3(-8f, 2, 0);
        for (int i = 0; i < 10; i++)
        {
            Transform newPosition = brick.transform;

            newPosition.position += positionForBricks.position;
            brick.transform.position = positionForBricks.position;
            Instantiate(brick,positionForBricks.position,Quaternion.identity);
          
            positionForBricks.position += new Vector3(2f, 0f, 0f);
        }
    }

}
