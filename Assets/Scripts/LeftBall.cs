using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeftBall : MonoBehaviour
{
    public float deltaZ;
    public static bool startRightBall = false;
    public RightBall rightBall;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            deltaZ = Mathf.Abs(Mathf.Sin(Time.time * 1.5f));
            transform.rotation = Quaternion.Euler(0, 0, deltaZ * 25);

            if (!startRightBall && (deltaZ * 25) > 24)
            {
                startRightBall = true;
                rightBall.startingRightBall(Time.time * 1.5f);
            }
        }
         else if (Input.GetKeyUp(KeyCode.Space))
        {
            transform.rotation = Quaternion.Euler(0, 0, 0);

        }

    }
}
