using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jumper : MonoBehaviour
{
    //jump location
    const float minX = -5;
    const float maxX = 5;
    const float minY = -2.5f;
    const float maxY = 2.5f;

    //timer support
    const float TotalJumpDelaySeconds = 1;
    float elapsedJumpDelaySeconds = 0;
    // Update is called once per frame
    void Update()
    {
        //update timer and check if it's done
        elapsedJumpDelaySeconds = elapsedJumpDelaySeconds + Time.deltaTime;

        if (elapsedJumpDelaySeconds >= TotalJumpDelaySeconds)
        {
            Debug.Log("nice");
            elapsedJumpDelaySeconds = 0;
            transform.position = new Vector3(Random.Range(minX, maxX), Random.Range(minY, maxY), 0);
        }
    }
}
