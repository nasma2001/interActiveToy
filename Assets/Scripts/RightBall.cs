using System.Collections;
using System.Collections.Generic;
using UnityEditor.SceneManagement;
using UnityEngine;

public class RightBall : MonoBehaviour
{
    float deltaZ;
    float time;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            deltaZ = Mathf.Abs(Mathf.Sin(time * 1.5f));
            transform.rotation = Quaternion.Euler(0, 0, deltaZ * -25);
            time = Time.time + 1.5f;
        }
        else if (Input.GetKeyUp(KeyCode.Space))
        {
            transform.rotation = Quaternion.Euler(0, 0, 0);

        }
    }
    public void startingRightBall(float leftBallTime)
    {
        time = leftBallTime + 0.5f * 2f;
    }
}
