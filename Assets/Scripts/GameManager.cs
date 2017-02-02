using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour
{

    public GameObject ball;
    public GameObject brick;
    
    private Vector3 positionForBricks;

    // Use this for initialization
    void Start()
    {
        positionForBricks = brick.transform.position;
        MakeBricks();
    }

    // Update is called once per frame
    void Update()
    {

    }

    void MakeBricks()
    {
        positionForBricks = new Vector3(-8f, 4, 0);
        for (int i = 1; i < 28; i++)
        {

            // brick.transform.position = positionForBricks.position;
            Instantiate(brick, positionForBricks, Quaternion.identity);
            if (i % 9 == 0)
            {
                positionForBricks += new Vector3(0f, -1.5f, 0);
                positionForBricks.x = -8f;
            }
            else
                positionForBricks += new Vector3(2f, 0f, 0f);

        }
    }

}
